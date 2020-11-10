using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astromech
{
    public partial class Keybinds : Form
    {

        public Keyboard.DirectXKeyStrokes enginePowerKey;
        public Keyboard.DirectXKeyStrokes weaponPowerKey;
        public Keyboard.DirectXKeyStrokes shieldPowerKey;
        public Keyboard.DirectXKeyStrokes balancePowerKey;
        public Keyboard.DirectXKeyStrokes counterKey;
        public Keyboard.DirectXKeyStrokes forwardShieldKey;
        public Keyboard.DirectXKeyStrokes rearShieldKey;
        public Keyboard.DirectXKeyStrokes balanceShieldKey;
        public Keyboard.DirectXKeyStrokes cycleTargetsKey;
        public Keyboard.DirectXKeyStrokes targetAttackerKey;
        public Keyboard.DirectXKeyStrokes targetAlliesKey;
        public Keyboard.DirectXKeyStrokes targetHostilesKey;
        public Keyboard.DirectXKeyStrokes targetSystemsKey;
        public Keyboard.DirectXKeyStrokes targetAIKey;
        public Keyboard.DirectXKeyStrokes targetsFollowerKey;
        public Keyboard.DirectXKeyStrokes targetMissilesKey;
        public Keyboard.DirectXKeyStrokes pingKey;
        public Keyboard.DirectXKeyStrokes acknowledgeKey;
        public Keyboard.DirectXKeyStrokes modKey;

        //used to notify the user they forgot to save
        private bool changesMade = false;

        public Keybinds()
        {
            InitializeComponent();
        }

        //when we load the keybinds screen, load correct keys from settings and put them in the dropdowns
        private void Keybinds_Load(object sender, EventArgs e)
        {
            //get options for the combo boxes
            LoadComboBoxes();
        }

        //can be called externally, so that we don't have to open a keybind window to get these.
        public void SetKeybindDataFromFile()
        {
            enginePowerKey = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.enginePowerKey, false);
            weaponPowerKey = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.weaponPowerKey, false);
            shieldPowerKey = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.shieldPowerKey, false);
            balancePowerKey = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.balancePowerKey, false);
            counterKey = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.counterKey, false);
            forwardShieldKey = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.fShieldKey, false);
            rearShieldKey = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.rShieldKey, false);
            balanceShieldKey = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.bShieldKey, false);
            cycleTargetsKey = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.cycleKey, false);
            targetAttackerKey = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.attackerKey, false);
            targetAlliesKey = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.alliesKey, false);
            targetHostilesKey = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.hostilesKey, false);
            targetSystemsKey = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.systemsKey, false);
            targetAIKey = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.AIKey, false);
            targetsFollowerKey = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.followerKey, false);
            targetMissilesKey = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.missileKey, false);
            pingKey = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.pingKey, false);
            acknowledgeKey = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.ackKey, false);
            modKey = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.modKey, false);
        }

        private void SaveKeybinds()
        {
            

            //set keybind data
            enginePowerKey = (Keyboard.DirectXKeyStrokes)enginePowerKeybind.SelectedItem;
            weaponPowerKey = (Keyboard.DirectXKeyStrokes)weaponPowerKeybind.SelectedItem;
            shieldPowerKey = (Keyboard.DirectXKeyStrokes)shieldPowerKeybind.SelectedItem;
            balancePowerKey = (Keyboard.DirectXKeyStrokes)balancePowerKeybind.SelectedItem;
            counterKey = (Keyboard.DirectXKeyStrokes)countermeasureKeybind.SelectedItem;
            forwardShieldKey = (Keyboard.DirectXKeyStrokes)forwardShieldKeybind.SelectedItem;
            rearShieldKey = (Keyboard.DirectXKeyStrokes)rearShieldKeybind.SelectedItem;
            balanceShieldKey = (Keyboard.DirectXKeyStrokes)balanceShieldKeybind.SelectedItem;
            cycleTargetsKey = (Keyboard.DirectXKeyStrokes)cycleKeybind.SelectedItem;
            targetAttackerKey = (Keyboard.DirectXKeyStrokes)targetAttackerKeybind.SelectedItem;
            targetAlliesKey = (Keyboard.DirectXKeyStrokes)targetAlliesKeybind.SelectedItem;
            targetHostilesKey = (Keyboard.DirectXKeyStrokes)targetHostilesKeybind.SelectedItem;
            targetSystemsKey = (Keyboard.DirectXKeyStrokes)targetSystemsKeybind.SelectedItem;
            targetAIKey = (Keyboard.DirectXKeyStrokes)targetAIKeybind.SelectedItem;
            targetsFollowerKey = (Keyboard.DirectXKeyStrokes)targetsFollowerKeybind.SelectedItem;
            targetMissilesKey = (Keyboard.DirectXKeyStrokes)targetMissilesKeybind.SelectedItem;
            pingKey = (Keyboard.DirectXKeyStrokes)pingKeybind.SelectedItem;
            acknowledgeKey = (Keyboard.DirectXKeyStrokes)acknowledgeKeybind.SelectedItem;
            modKey = (Keyboard.DirectXKeyStrokes)modKeyKeybind.SelectedItem;

            //save to application settings file
            Properties.Settings.Default.enginePowerKey = enginePowerKey.ToString();
            Properties.Settings.Default.weaponPowerKey = weaponPowerKey.ToString();
            Properties.Settings.Default.shieldPowerKey = shieldPowerKey.ToString();
            Properties.Settings.Default.balancePowerKey = balancePowerKey.ToString();
            Properties.Settings.Default.counterKey = counterKey.ToString();
            Properties.Settings.Default.fShieldKey = forwardShieldKey.ToString();
            Properties.Settings.Default.rShieldKey = rearShieldKey.ToString();
            Properties.Settings.Default.bShieldKey = balanceShieldKey.ToString();
            
            Properties.Settings.Default.cycleKey = cycleTargetsKey.ToString();
            Properties.Settings.Default.attackerKey = targetAttackerKey.ToString();
            Properties.Settings.Default.alliesKey = targetAlliesKey.ToString();
            Properties.Settings.Default.hostilesKey = targetHostilesKey.ToString();
            Properties.Settings.Default.systemsKey = targetSystemsKey.ToString();
            Properties.Settings.Default.AIKey = targetAIKey.ToString();
            Properties.Settings.Default.followerKey = targetsFollowerKey.ToString();
            Properties.Settings.Default.missileKey = targetMissilesKey.ToString();
            Properties.Settings.Default.pingKey = pingKey.ToString();
            Properties.Settings.Default.ackKey = acknowledgeKey.ToString();
            Properties.Settings.Default.modKey = modKey.ToString();
            Properties.Settings.Default.Save();

            changesMade = false;
            MessageBox.Show("Keybinds saved.");
        }

        private void LoadComboBoxes()
        {
            //set the data source of the combo boxes to Key Stroke options.
            enginePowerKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            weaponPowerKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            shieldPowerKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            balancePowerKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            countermeasureKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            forwardShieldKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            rearShieldKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            balanceShieldKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            cycleKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            targetAttackerKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            targetAlliesKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            targetHostilesKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            targetSystemsKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            targetAIKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            targetsFollowerKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            targetMissilesKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            pingKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            acknowledgeKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));
            modKeyKeybind.DataSource = Enum.GetValues(typeof(Keyboard.DirectXKeyStrokes));

            //set the default selected items to whatever was saved in user settings.
            enginePowerKeybind.SelectedItem = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.enginePowerKey, false);
            weaponPowerKeybind.SelectedItem = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.weaponPowerKey, false);
            shieldPowerKeybind.SelectedItem = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.shieldPowerKey, false);
            balancePowerKeybind.SelectedItem = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.balancePowerKey, false);
            countermeasureKeybind.SelectedItem = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.counterKey, false);
            forwardShieldKeybind.SelectedItem = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.fShieldKey, false);
            rearShieldKeybind.SelectedItem = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.rShieldKey, false);        
            balanceShieldKeybind.SelectedItem = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.bShieldKey, false);
            cycleKeybind.SelectedItem = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.cycleKey, false);
            targetAttackerKeybind.SelectedItem = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.attackerKey, false);
            targetAlliesKeybind.SelectedItem = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.alliesKey, false);
            targetHostilesKeybind.SelectedItem = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.hostilesKey, false);
            targetSystemsKeybind.SelectedItem = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.systemsKey, false);
            targetAIKeybind.SelectedItem = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.AIKey, false);
            targetsFollowerKeybind.SelectedItem = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.followerKey, false);
            targetMissilesKeybind.SelectedItem = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.missileKey, false);
            pingKeybind.SelectedItem = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.pingKey, false);
            acknowledgeKeybind.SelectedItem = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.ackKey, false);
            modKeyKeybind.SelectedItem = (Keyboard.DirectXKeyStrokes)Enum.Parse(typeof(Keyboard.DirectXKeyStrokes), Properties.Settings.Default.modKey, false);
        }

        private void keybindSaveBtn_Click(object sender, EventArgs e)
        {
            SaveKeybinds();
        }

        private void defaultsButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset the keybinds?", "Reset to Default", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {

                Properties.Settings.Default.enginePowerKey = "DIK_1";
                Properties.Settings.Default.weaponPowerKey = "DIK_2";
                Properties.Settings.Default.shieldPowerKey = "DIK_3";
                Properties.Settings.Default.balancePowerKey = "DIK_4";
                Properties.Settings.Default.counterKey = "DIK_R";
                Properties.Settings.Default.fShieldKey = "DIK_9";
                Properties.Settings.Default.rShieldKey = "DIK_0";
                Properties.Settings.Default.bShieldKey = "DIK_MINUS";
                Properties.Settings.Default.cycleKey = "DIK_F";
                Properties.Settings.Default.attackerKey = "DIK_G";
                Properties.Settings.Default.alliesKey = "DIK_F6";
                Properties.Settings.Default.hostilesKey = "DIK_F10";
                Properties.Settings.Default.systemsKey = "DIK_F12";
                Properties.Settings.Default.AIKey = "DIK_F11";
                Properties.Settings.Default.followerKey = "DIK_F7";
                Properties.Settings.Default.missileKey = "DIK_F3";
                Properties.Settings.Default.pingKey = "DIK_H";
                Properties.Settings.Default.ackKey = "DIK_B";
                Properties.Settings.Default.modKey = "DIK_LCONTROL";

                LoadComboBoxes();
                SaveKeybinds();
            } 
        }

        private void Keybinds_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changesMade)
            {
                DialogResult result = MessageBox.Show("You have unsaved changes. Would you like to keep them?", "Unsaved Changes", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes)
                {
                    SaveKeybinds();
                }
            } 
        }

        private void AnyKeybind_SelectionChangeCommitted(object sender, EventArgs e)
        {
            changesMade = true;
        }
        
    }
}
