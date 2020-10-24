using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Media;
using System.IO;

/// <summary>
/// This code was created by Wyatt Karnes. Currently, the code is NOT open source.
/// </summary>
namespace Astromech
{
    public partial class Astromech : Form
    {
        #region SpeechRecognition
        //listens for commands
        private SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();

        private SoundPlayer astromechOn = new SoundPlayer(Properties.Resources.happybeep1);
        private SoundPlayer astromechOff = new SoundPlayer(Properties.Resources.offbeep1);

        //listens for wake word
        private SpeechRecognitionEngine startListening = new SpeechRecognitionEngine();


        //keeps track of seconds before a timeout
        private int timeOut = 0;

        string[] commands;
        #endregion

        #region UserVariables
        private string droidName;
        private int timeToWait;
        private bool useWakeWord;
        #endregion

        public Astromech()
        {
            InitializeComponent();
        }

        private void Astromech_Load(object sender, EventArgs e)
        {
            TmrSpeaking.Stop();
            astromechOn.LoadAsync();
            astromechOff.LoadAsync();

            //Load last used droid name, time to wait, and wake word bool
            if(Properties.Settings.Default != null)
            {
                droidNameInput.Text = Properties.Settings.Default.Droid_Name;
                timeToWaitSelector.Value = Properties.Settings.Default.Wait_Time;
                useWakeWordChkBox.Checked = Properties.Settings.Default.Use_Wake_Word;
            }

            droidName = droidNameInput.Text;
            timeToWait = (int)timeToWaitSelector.Value;
            useWakeWord = useWakeWordChkBox.Checked;
        }

        //Listening for the wake word. Might not be enabled, depending on user choice.
        private void startListening_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //when speech is recognized, store what was recognized into a string
            string speech = e.Result.Text;

            //if the wake word is heard, stop listening for wake words, 
            if (speech.Equals(droidName))
            {
                
                astromechOn.Play();
                startListening.RecognizeAsyncCancel();
                recognizer.RecognizeAsync(RecognizeMode.Multiple);
                timeOut = 0;
                TmrSpeaking.Start();
            }
        }

        //When speech is detected, set the time out timer to zero.
        //This is so a wake word doesn't have to be repeated if your speech isn't actually understood.
        private void recognizer_SpeechDetected(object sender, SpeechDetectedEventArgs e)
        {
            timeOut = 0;
        }

        //Determines what was heard and then acts accordingly
        private void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //stop the timer
            TmrSpeaking.Stop();

            //handle input
            PerformCommand(e.Result.Text);

            //reset sleep timer and start counting again
            timeOut = 0;

            if (useWakeWord)
            {
                TmrSpeaking.Start();
            }
        }

        //There is a timer active in the form. It ticks once per second when wake word is in use.
        //When ten seconds have passed with no recognizeable speech, we reset to the beginning.
        private void TmrSpeaking_Tick(object sender, EventArgs e)
        {
            timeOut++;

            if (timeOut == timeToWait)
            {
                //stop listening for major commands
                recognizer.RecognizeAsyncCancel();

                //listen for wake word
                astromechOff.Play();
                startListening.RecognizeAsync(RecognizeMode.Multiple);

                //stop timer
                TmrSpeaking.Stop();

                //reset recTimeOut
                timeOut = 0;
            }
        }

        //save settings and launch speech recognition
        private void acceptButton_Click(object sender, EventArgs e)
        {           
            droidName = droidNameInput.Text;
            timeToWait = (int)timeToWaitSelector.Value;
            useWakeWord = useWakeWordChkBox.Checked;

            //save settings
            Properties.Settings.Default.Droid_Name = droidName;
            Properties.Settings.Default.Wait_Time = timeToWait;
            Properties.Settings.Default.Use_Wake_Word = useWakeWord;
            Properties.Settings.Default.Save();

            useWakeWordChkBox.AutoCheck = false; //disable the check box

            commands = File.ReadAllLines(@"Commands.txt");


            recognizer.SetInputToDefaultAudioDevice();
            recognizer.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(commands))));
            recognizer.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(recognizer_SpeechDetected);
            recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);

            if (useWakeWord) //if using wake word then use timer. Otherwise, no. 
            {
                startListening.SetInputToDefaultAudioDevice();
                startListening.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(droidName))));
                startListening.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(startListening_SpeechRecognized);
                startListening.RecognizeAsync(RecognizeMode.Multiple);
            }
            else
            {
                recognizer.RecognizeAsync(RecognizeMode.Multiple);
            }

            acceptButton.Visible = false;
        }

        //close program
        private void quitButton_Click(object sender, EventArgs e)
        {
            //save settings
            Properties.Settings.Default.Droid_Name = droidName;
            Properties.Settings.Default.Wait_Time = timeToWait;
            Properties.Settings.Default.Use_Wake_Word = useWakeWord;
            Properties.Settings.Default.Save();

            this.Close();
        }

        //change whether or not we are using a wake word. Probably redundant.
        private void useWakeWordChkBox_CheckedChanged(object sender, EventArgs e)
        {
            useWakeWord = useWakeWordChkBox.Checked;
        }

        //determines what was said and acts
        private void PerformCommand(string speech)
        {


            //counter measures
            if (speech == commands[0] || speech == commands[1])
            {
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_R, false, Keyboard.InputType.Keyboard);
                Thread.Sleep(7);
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_R, true, Keyboard.InputType.Keyboard);
                return;
            }

            //weapon power
            if (speech == commands[2] || speech == commands[3])
            {
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_LCONTROL, false, Keyboard.InputType.Keyboard);
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_2, false, Keyboard.InputType.Keyboard);

                Thread.Sleep(7);
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_LCONTROL, true, Keyboard.InputType.Keyboard);
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_2, true, Keyboard.InputType.Keyboard);
                return;
            }

            //engine power
            if (speech == commands[4] || speech == commands[5])
            {
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_LCONTROL, false, Keyboard.InputType.Keyboard);
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_1, false, Keyboard.InputType.Keyboard);

                Thread.Sleep(7);
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_LCONTROL, true, Keyboard.InputType.Keyboard);
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_1, true, Keyboard.InputType.Keyboard);
                return;
            }

            //shield power
            if (speech == commands[6] || speech == commands[7])
            {
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_LCONTROL, false, Keyboard.InputType.Keyboard);
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_3, false, Keyboard.InputType.Keyboard);

                Thread.Sleep(7);
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_LCONTROL, true, Keyboard.InputType.Keyboard);
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_3, true, Keyboard.InputType.Keyboard);
                return;
            }

            //balance power
            if (speech == commands[8] || speech == commands[9])
            {
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_4, false, Keyboard.InputType.Keyboard);

                Thread.Sleep(7);

                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_4, true, Keyboard.InputType.Keyboard);
                return;
            }

            //forward deflectors, emergency power to engines
            if (speech == commands[10] || speech == commands[11] || speech == commands[12] || speech == commands[13])
            {
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_9, false, Keyboard.InputType.Keyboard);
                Thread.Sleep(7);
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_9, true, Keyboard.InputType.Keyboard);
                return;
            }

            //rear deflectors, emergency power to weapons
            if (speech == commands[14] || speech == commands[15] || speech == commands[16] || speech == commands[17])
            {
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_0, false, Keyboard.InputType.Keyboard);
                Thread.Sleep(7);
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_0, true, Keyboard.InputType.Keyboard);
                return;
            }

            //balance deflectors, balance emergency power
            if (speech == commands[18] || speech == commands[19] || speech == commands[20] || speech == commands[21])
            {
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_MINUS, false, Keyboard.InputType.Keyboard);
                Thread.Sleep(7);
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_MINUS, true, Keyboard.InputType.Keyboard);
                return;
            }

            //lock onto attacker
            if (speech == commands[22] || speech == commands[23])
            {
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_G, false, Keyboard.InputType.Keyboard);
                Thread.Sleep(7);
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_G, true, Keyboard.InputType.Keyboard);
                return;
            }

            //cycle targets
            if (speech == commands[24] || speech == commands[25])
            {
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_F, false, Keyboard.InputType.Keyboard);
                Thread.Sleep(7);
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_F, true, Keyboard.InputType.Keyboard);
                return;
            }

            //target friendlies
            if (speech == commands[26] || speech == commands[27])
            {
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_F6, false, Keyboard.InputType.Keyboard);
                Thread.Sleep(7);
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_F6, true, Keyboard.InputType.Keyboard);
                return;
            }

            //target hostiles
            if (speech == commands[28] || speech == commands[29])
            {
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_F10, false, Keyboard.InputType.Keyboard);
                Thread.Sleep(7);
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_F10, true, Keyboard.InputType.Keyboard);
                return;
            }

            //target capital ship systems
            if (speech == commands[30] || speech == commands[31])
            {
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_F12, false, Keyboard.InputType.Keyboard);
                Thread.Sleep(7);
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_F12, true, Keyboard.InputType.Keyboard);
                return;
            }

            //target AI
            if (speech == commands[32] || speech == commands[33])
            {
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_F11, false, Keyboard.InputType.Keyboard);
                Thread.Sleep(7);
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_F11, true, Keyboard.InputType.Keyboard);
                return;
            }

            //target the target's follower
            if (speech == commands[34] || speech == commands[35])
            {
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_F7, false, Keyboard.InputType.Keyboard);
                Thread.Sleep(7);
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_F7, true, Keyboard.InputType.Keyboard);
                return;
            }

            //target missiles
            if (speech == commands[36] || speech == commands[37])
            {
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_F3, false, Keyboard.InputType.Keyboard);
                Thread.Sleep(7);
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_F3, true, Keyboard.InputType.Keyboard);
                return;
            }

            //ping target
            if (speech == commands[38] || speech == commands[39])
            {
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_H, false, Keyboard.InputType.Keyboard);
                Thread.Sleep(7);
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_H, true, Keyboard.InputType.Keyboard);
                return;
            }

            //acknowledge
            if (speech == commands[40] || speech == commands[41])
            {
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_B, false, Keyboard.InputType.Keyboard);
                Thread.Sleep(7);
                Keyboard.SendKey(Keyboard.DirectXKeyStrokes.DIK_B, true, Keyboard.InputType.Keyboard);
                return;
            }

        }

      
    }

}
