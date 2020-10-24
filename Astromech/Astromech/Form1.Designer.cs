using System;

namespace Astromech
{
    partial class Astromech
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Astromech));
            this.TmrSpeaking = new System.Windows.Forms.Timer(this.components);
            this.droidNameInput = new System.Windows.Forms.TextBox();
            this.droidNameLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.timeToWaitLabel = new System.Windows.Forms.Label();
            this.timeToWaitSelector = new System.Windows.Forms.NumericUpDown();
            this.useWakeWordChkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.timeToWaitSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // TmrSpeaking
            // 
            this.TmrSpeaking.Enabled = true;
            this.TmrSpeaking.Interval = 1000;
            this.TmrSpeaking.Tick += new System.EventHandler(this.TmrSpeaking_Tick);
            // 
            // droidNameInput
            // 
            this.droidNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.droidNameInput.Location = new System.Drawing.Point(483, 226);
            this.droidNameInput.Name = "droidNameInput";
            this.droidNameInput.Size = new System.Drawing.Size(100, 22);
            this.droidNameInput.TabIndex = 3;
            this.droidNameInput.Text = "R 2";
            // 
            // droidNameLabel
            // 
            this.droidNameLabel.AutoSize = true;
            this.droidNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.droidNameLabel.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.droidNameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.droidNameLabel.Location = new System.Drawing.Point(275, 112);
            this.droidNameLabel.Name = "droidNameLabel";
            this.droidNameLabel.Size = new System.Drawing.Size(507, 111);
            this.droidNameLabel.TabIndex = 4;
            this.droidNameLabel.Text = "Please enter your Droid\'s name.\r\n Letters, numbers, and spaces only.\r\n No hyphens" +
    " or other symbols.";
            this.droidNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(492, 254);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 5;
            this.acceptButton.Text = "Start";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(492, 283);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 6;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // timeToWaitLabel
            // 
            this.timeToWaitLabel.AutoSize = true;
            this.timeToWaitLabel.ForeColor = System.Drawing.Color.Yellow;
            this.timeToWaitLabel.Location = new System.Drawing.Point(9, 75);
            this.timeToWaitLabel.Name = "timeToWaitLabel";
            this.timeToWaitLabel.Size = new System.Drawing.Size(514, 17);
            this.timeToWaitLabel.TabIndex = 8;
            this.timeToWaitLabel.Text = "This is the wait time before the wake word (droid name) will need to be repeated." +
    "";
            // 
            // timeToWaitSelector
            // 
            this.timeToWaitSelector.Location = new System.Drawing.Point(12, 95);
            this.timeToWaitSelector.Name = "timeToWaitSelector";
            this.timeToWaitSelector.Size = new System.Drawing.Size(120, 22);
            this.timeToWaitSelector.TabIndex = 9;
            this.timeToWaitSelector.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // useWakeWordChkBox
            // 
            this.useWakeWordChkBox.AutoSize = true;
            this.useWakeWordChkBox.Checked = true;
            this.useWakeWordChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useWakeWordChkBox.ForeColor = System.Drawing.Color.Yellow;
            this.useWakeWordChkBox.Location = new System.Drawing.Point(12, 38);
            this.useWakeWordChkBox.Name = "useWakeWordChkBox";
            this.useWakeWordChkBox.Size = new System.Drawing.Size(133, 21);
            this.useWakeWordChkBox.TabIndex = 10;
            this.useWakeWordChkBox.Text = "Use Wake Word";
            this.useWakeWordChkBox.UseVisualStyleBackColor = true;
            this.useWakeWordChkBox.CheckedChanged += new System.EventHandler(this.useWakeWordChkBox_CheckedChanged);
            // 
            // Astromech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.useWakeWordChkBox);
            this.Controls.Add(this.timeToWaitSelector);
            this.Controls.Add(this.timeToWaitLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.droidNameLabel);
            this.Controls.Add(this.droidNameInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Astromech";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astromech";
            this.Load += new System.EventHandler(this.Astromech_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timeToWaitSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TmrSpeaking;
        private System.Windows.Forms.TextBox droidNameInput;
        private System.Windows.Forms.Label droidNameLabel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label timeToWaitLabel;
        private System.Windows.Forms.NumericUpDown timeToWaitSelector;
        private System.Windows.Forms.CheckBox useWakeWordChkBox;
    }
}

