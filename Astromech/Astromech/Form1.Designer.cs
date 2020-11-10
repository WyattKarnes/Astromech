using System;

namespace Astromech
{
    partial class Astromech1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Astromech1));
            this.TmrSpeaking = new System.Windows.Forms.Timer(this.components);
            this.droidNameInput = new System.Windows.Forms.TextBox();
            this.droidNameLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.timeToWaitLabel = new System.Windows.Forms.Label();
            this.timeToWaitSelector = new System.Windows.Forms.NumericUpDown();
            this.useWakeWordChkBox = new System.Windows.Forms.CheckBox();
            this.keybindsButton = new System.Windows.Forms.Button();
            this.versionLabel = new System.Windows.Forms.Label();
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
            this.droidNameInput.Location = new System.Drawing.Point(362, 184);
            this.droidNameInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.droidNameInput.Name = "droidNameInput";
            this.droidNameInput.Size = new System.Drawing.Size(76, 20);
            this.droidNameInput.TabIndex = 3;
            this.droidNameInput.Text = "R 2";
            // 
            // droidNameLabel
            // 
            this.droidNameLabel.AutoSize = true;
            this.droidNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.droidNameLabel.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.droidNameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.droidNameLabel.Location = new System.Drawing.Point(206, 91);
            this.droidNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.droidNameLabel.Name = "droidNameLabel";
            this.droidNameLabel.Size = new System.Drawing.Size(407, 87);
            this.droidNameLabel.TabIndex = 4;
            this.droidNameLabel.Text = "Please enter your Droid\'s name.\r\n Letters, numbers, and spaces only.\r\n No hyphens" +
    " or other symbols.";
            this.droidNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(369, 206);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(56, 19);
            this.acceptButton.TabIndex = 5;
            this.acceptButton.Text = "Start";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(369, 230);
            this.quitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(56, 19);
            this.quitButton.TabIndex = 6;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // timeToWaitLabel
            // 
            this.timeToWaitLabel.AutoSize = true;
            this.timeToWaitLabel.ForeColor = System.Drawing.Color.Yellow;
            this.timeToWaitLabel.Location = new System.Drawing.Point(7, 61);
            this.timeToWaitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeToWaitLabel.Name = "timeToWaitLabel";
            this.timeToWaitLabel.Size = new System.Drawing.Size(385, 13);
            this.timeToWaitLabel.TabIndex = 8;
            this.timeToWaitLabel.Text = "This is the wait time before the wake word (droid name) will need to be repeated." +
    "";
            // 
            // timeToWaitSelector
            // 
            this.timeToWaitSelector.Location = new System.Drawing.Point(9, 77);
            this.timeToWaitSelector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timeToWaitSelector.Name = "timeToWaitSelector";
            this.timeToWaitSelector.Size = new System.Drawing.Size(90, 20);
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
            this.useWakeWordChkBox.Location = new System.Drawing.Point(9, 31);
            this.useWakeWordChkBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.useWakeWordChkBox.Name = "useWakeWordChkBox";
            this.useWakeWordChkBox.Size = new System.Drawing.Size(106, 17);
            this.useWakeWordChkBox.TabIndex = 10;
            this.useWakeWordChkBox.Text = "Use Wake Word";
            this.useWakeWordChkBox.UseVisualStyleBackColor = true;
            this.useWakeWordChkBox.CheckedChanged += new System.EventHandler(this.useWakeWordChkBox_CheckedChanged);
            // 
            // keybindsButton
            // 
            this.keybindsButton.Location = new System.Drawing.Point(9, 404);
            this.keybindsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.keybindsButton.Name = "keybindsButton";
            this.keybindsButton.Size = new System.Drawing.Size(115, 37);
            this.keybindsButton.TabIndex = 11;
            this.keybindsButton.Text = "Edit Keybinds";
            this.keybindsButton.UseVisualStyleBackColor = true;
            this.keybindsButton.Click += new System.EventHandler(this.keybindsButton_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(757, 429);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(28, 13);
            this.versionLabel.TabIndex = 12;
            this.versionLabel.Text = "v2.0";
            // 
            // Astromech1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.keybindsButton);
            this.Controls.Add(this.useWakeWordChkBox);
            this.Controls.Add(this.timeToWaitSelector);
            this.Controls.Add(this.timeToWaitLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.droidNameLabel);
            this.Controls.Add(this.droidNameInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Astromech1";
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
        private System.Windows.Forms.Button keybindsButton;
        private System.Windows.Forms.Label versionLabel;
    }
}

