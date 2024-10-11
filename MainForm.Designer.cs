namespace mscom
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.portBox = new System.Windows.Forms.GroupBox();
            this.handshakeComboBox = new System.Windows.Forms.ComboBox();
            this.portButton = new System.Windows.Forms.Button();
            this.handshakeLabel = new System.Windows.Forms.Label();
            this.portPictureBox = new System.Windows.Forms.PictureBox();
            this.stopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.stopBitsLabel = new System.Windows.Forms.Label();
            this.parityComboBox = new System.Windows.Forms.ComboBox();
            this.parityLabel = new System.Windows.Forms.Label();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.dataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.dataBitsLabel = new System.Windows.Forms.Label();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.displaySettingGroupBox = new System.Windows.Forms.GroupBox();
            this.base64CheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.timeStampCheckBox = new System.Windows.Forms.CheckBox();
            this.displaySentCheckBox = new System.Windows.Forms.CheckBox();
            this.showHexCheckbox = new System.Windows.Forms.CheckBox();
            this.sendGroupBox = new System.Windows.Forms.GroupBox();
            this.suffixComboBox = new System.Windows.Forms.ComboBox();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.fileButton = new System.Windows.Forms.Button();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.intevalTextBox = new System.Windows.Forms.TextBox();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.loopCheckBox = new System.Windows.Forms.CheckBox();
            this.sendHexCheckBox = new System.Windows.Forms.CheckBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.SendTextBox = new System.Windows.Forms.TextBox();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.dispalyGroupBox = new System.Windows.Forms.GroupBox();
            this.sendPanel = new System.Windows.Forms.Panel();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.portStatusLabel = new System.Windows.Forms.Label();
            this.portStatuspictureBox = new System.Windows.Forms.PictureBox();
            this.statusResetButton = new System.Windows.Forms.Button();
            this.sentTextBox = new System.Windows.Forms.TextBox();
            this.sendCountLabel = new System.Windows.Forms.Label();
            this.receiveTextBox = new System.Windows.Forms.TextBox();
            this.recvCountLabel = new System.Windows.Forms.Label();
            this.suffixLabel = new System.Windows.Forms.Label();
            this.clearDisplayButton = new System.Windows.Forms.Button();
            this.portBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portPictureBox)).BeginInit();
            this.displaySettingGroupBox.SuspendLayout();
            this.sendGroupBox.SuspendLayout();
            this.displayPanel.SuspendLayout();
            this.dispalyGroupBox.SuspendLayout();
            this.sendPanel.SuspendLayout();
            this.inputGroupBox.SuspendLayout();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portStatuspictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // portBox
            // 
            resources.ApplyResources(this.portBox, "portBox");
            this.portBox.Controls.Add(this.handshakeComboBox);
            this.portBox.Controls.Add(this.portButton);
            this.portBox.Controls.Add(this.handshakeLabel);
            this.portBox.Controls.Add(this.portPictureBox);
            this.portBox.Controls.Add(this.stopBitsComboBox);
            this.portBox.Controls.Add(this.stopBitsLabel);
            this.portBox.Controls.Add(this.parityComboBox);
            this.portBox.Controls.Add(this.parityLabel);
            this.portBox.Controls.Add(this.baudRateComboBox);
            this.portBox.Controls.Add(this.baudRateLabel);
            this.portBox.Controls.Add(this.dataBitsComboBox);
            this.portBox.Controls.Add(this.dataBitsLabel);
            this.portBox.Controls.Add(this.portComboBox);
            this.portBox.Controls.Add(this.portLabel);
            this.portBox.Name = "portBox";
            this.portBox.TabStop = false;
            // 
            // handshakeComboBox
            // 
            this.handshakeComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.handshakeComboBox, "handshakeComboBox");
            this.handshakeComboBox.Name = "handshakeComboBox";
            // 
            // portButton
            // 
            resources.ApplyResources(this.portButton, "portButton");
            this.portButton.Name = "portButton";
            this.portButton.UseVisualStyleBackColor = true;
            this.portButton.Click += new System.EventHandler(this.portButton_Click);
            // 
            // handshakeLabel
            // 
            resources.ApplyResources(this.handshakeLabel, "handshakeLabel");
            this.handshakeLabel.Name = "handshakeLabel";
            // 
            // portPictureBox
            // 
            this.portPictureBox.Image = global::mscom.Properties.Resources.circle_red;
            resources.ApplyResources(this.portPictureBox, "portPictureBox");
            this.portPictureBox.Name = "portPictureBox";
            this.portPictureBox.TabStop = false;
            // 
            // stopBitsComboBox
            // 
            this.stopBitsComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.stopBitsComboBox, "stopBitsComboBox");
            this.stopBitsComboBox.Name = "stopBitsComboBox";
            // 
            // stopBitsLabel
            // 
            resources.ApplyResources(this.stopBitsLabel, "stopBitsLabel");
            this.stopBitsLabel.Name = "stopBitsLabel";
            // 
            // parityComboBox
            // 
            this.parityComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.parityComboBox, "parityComboBox");
            this.parityComboBox.Name = "parityComboBox";
            // 
            // parityLabel
            // 
            resources.ApplyResources(this.parityLabel, "parityLabel");
            this.parityLabel.Name = "parityLabel";
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.baudRateComboBox, "baudRateComboBox");
            this.baudRateComboBox.Name = "baudRateComboBox";
            // 
            // baudRateLabel
            // 
            resources.ApplyResources(this.baudRateLabel, "baudRateLabel");
            this.baudRateLabel.Name = "baudRateLabel";
            // 
            // dataBitsComboBox
            // 
            this.dataBitsComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.dataBitsComboBox, "dataBitsComboBox");
            this.dataBitsComboBox.Name = "dataBitsComboBox";
            // 
            // dataBitsLabel
            // 
            resources.ApplyResources(this.dataBitsLabel, "dataBitsLabel");
            this.dataBitsLabel.Name = "dataBitsLabel";
            // 
            // portComboBox
            // 
            this.portComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.portComboBox, "portComboBox");
            this.portComboBox.Name = "portComboBox";
            // 
            // portLabel
            // 
            resources.ApplyResources(this.portLabel, "portLabel");
            this.portLabel.Name = "portLabel";
            // 
            // displayTextBox
            // 
            this.displayTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            resources.ApplyResources(this.displayTextBox, "displayTextBox");
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            // 
            // displaySettingGroupBox
            // 
            this.displaySettingGroupBox.Controls.Add(this.clearDisplayButton);
            this.displaySettingGroupBox.Controls.Add(this.base64CheckBox);
            this.displaySettingGroupBox.Controls.Add(this.saveButton);
            this.displaySettingGroupBox.Controls.Add(this.timeStampCheckBox);
            this.displaySettingGroupBox.Controls.Add(this.displaySentCheckBox);
            this.displaySettingGroupBox.Controls.Add(this.showHexCheckbox);
            resources.ApplyResources(this.displaySettingGroupBox, "displaySettingGroupBox");
            this.displaySettingGroupBox.Name = "displaySettingGroupBox";
            this.displaySettingGroupBox.TabStop = false;
            // 
            // base64CheckBox
            // 
            resources.ApplyResources(this.base64CheckBox, "base64CheckBox");
            this.base64CheckBox.Name = "base64CheckBox";
            this.base64CheckBox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // timeStampCheckBox
            // 
            resources.ApplyResources(this.timeStampCheckBox, "timeStampCheckBox");
            this.timeStampCheckBox.Name = "timeStampCheckBox";
            this.timeStampCheckBox.UseVisualStyleBackColor = true;
            // 
            // displaySentCheckBox
            // 
            resources.ApplyResources(this.displaySentCheckBox, "displaySentCheckBox");
            this.displaySentCheckBox.Name = "displaySentCheckBox";
            this.displaySentCheckBox.UseVisualStyleBackColor = true;
            // 
            // showHexCheckbox
            // 
            resources.ApplyResources(this.showHexCheckbox, "showHexCheckbox");
            this.showHexCheckbox.Name = "showHexCheckbox";
            this.showHexCheckbox.UseVisualStyleBackColor = true;
            // 
            // sendGroupBox
            // 
            resources.ApplyResources(this.sendGroupBox, "sendGroupBox");
            this.sendGroupBox.Controls.Add(this.suffixLabel);
            this.sendGroupBox.Controls.Add(this.suffixComboBox);
            this.sendGroupBox.Controls.Add(this.fileTextBox);
            this.sendGroupBox.Controls.Add(this.fileButton);
            this.sendGroupBox.Controls.Add(this.countTextBox);
            this.sendGroupBox.Controls.Add(this.countLabel);
            this.sendGroupBox.Controls.Add(this.unitLabel);
            this.sendGroupBox.Controls.Add(this.intevalTextBox);
            this.sendGroupBox.Controls.Add(this.intervalLabel);
            this.sendGroupBox.Controls.Add(this.loopCheckBox);
            this.sendGroupBox.Controls.Add(this.sendHexCheckBox);
            this.sendGroupBox.Controls.Add(this.sendButton);
            this.sendGroupBox.Name = "sendGroupBox";
            this.sendGroupBox.TabStop = false;
            // 
            // suffixComboBox
            // 
            this.suffixComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("suffixComboBox.AutoCompleteCustomSource"),
            resources.GetString("suffixComboBox.AutoCompleteCustomSource1"),
            resources.GetString("suffixComboBox.AutoCompleteCustomSource2")});
            this.suffixComboBox.FormattingEnabled = true;
            this.suffixComboBox.Items.AddRange(new object[] {
            resources.GetString("suffixComboBox.Items"),
            resources.GetString("suffixComboBox.Items1"),
            resources.GetString("suffixComboBox.Items2"),
            resources.GetString("suffixComboBox.Items3")});
            resources.ApplyResources(this.suffixComboBox, "suffixComboBox");
            this.suffixComboBox.Name = "suffixComboBox";
            // 
            // fileTextBox
            // 
            resources.ApplyResources(this.fileTextBox, "fileTextBox");
            this.fileTextBox.Name = "fileTextBox";
            // 
            // fileButton
            // 
            resources.ApplyResources(this.fileButton, "fileButton");
            this.fileButton.Name = "fileButton";
            this.fileButton.UseVisualStyleBackColor = true;
            // 
            // countTextBox
            // 
            resources.ApplyResources(this.countTextBox, "countTextBox");
            this.countTextBox.Name = "countTextBox";
            // 
            // countLabel
            // 
            resources.ApplyResources(this.countLabel, "countLabel");
            this.countLabel.Name = "countLabel";
            // 
            // unitLabel
            // 
            resources.ApplyResources(this.unitLabel, "unitLabel");
            this.unitLabel.Name = "unitLabel";
            // 
            // intevalTextBox
            // 
            resources.ApplyResources(this.intevalTextBox, "intevalTextBox");
            this.intevalTextBox.Name = "intevalTextBox";
            // 
            // intervalLabel
            // 
            resources.ApplyResources(this.intervalLabel, "intervalLabel");
            this.intervalLabel.Name = "intervalLabel";
            // 
            // loopCheckBox
            // 
            resources.ApplyResources(this.loopCheckBox, "loopCheckBox");
            this.loopCheckBox.Name = "loopCheckBox";
            this.loopCheckBox.UseVisualStyleBackColor = true;
            // 
            // sendHexCheckBox
            // 
            resources.ApplyResources(this.sendHexCheckBox, "sendHexCheckBox");
            this.sendHexCheckBox.Name = "sendHexCheckBox";
            this.sendHexCheckBox.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            resources.ApplyResources(this.sendButton, "sendButton");
            this.sendButton.Name = "sendButton";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // SendTextBox
            // 
            resources.ApplyResources(this.SendTextBox, "SendTextBox");
            this.SendTextBox.Name = "SendTextBox";
            // 
            // displayPanel
            // 
            resources.ApplyResources(this.displayPanel, "displayPanel");
            this.displayPanel.Controls.Add(this.dispalyGroupBox);
            this.displayPanel.Name = "displayPanel";
            // 
            // dispalyGroupBox
            // 
            resources.ApplyResources(this.dispalyGroupBox, "dispalyGroupBox");
            this.dispalyGroupBox.Controls.Add(this.displayTextBox);
            this.dispalyGroupBox.Name = "dispalyGroupBox";
            this.dispalyGroupBox.TabStop = false;
            // 
            // sendPanel
            // 
            resources.ApplyResources(this.sendPanel, "sendPanel");
            this.sendPanel.Controls.Add(this.inputGroupBox);
            this.sendPanel.Controls.Add(this.sendGroupBox);
            this.sendPanel.Name = "sendPanel";
            // 
            // inputGroupBox
            // 
            resources.ApplyResources(this.inputGroupBox, "inputGroupBox");
            this.inputGroupBox.Controls.Add(this.SendTextBox);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.TabStop = false;
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.portStatusLabel);
            this.statusPanel.Controls.Add(this.portStatuspictureBox);
            this.statusPanel.Controls.Add(this.statusResetButton);
            this.statusPanel.Controls.Add(this.sentTextBox);
            this.statusPanel.Controls.Add(this.sendCountLabel);
            this.statusPanel.Controls.Add(this.receiveTextBox);
            this.statusPanel.Controls.Add(this.recvCountLabel);
            resources.ApplyResources(this.statusPanel, "statusPanel");
            this.statusPanel.Name = "statusPanel";
            // 
            // portStatusLabel
            // 
            resources.ApplyResources(this.portStatusLabel, "portStatusLabel");
            this.portStatusLabel.Name = "portStatusLabel";
            // 
            // portStatuspictureBox
            // 
            this.portStatuspictureBox.Image = global::mscom.Properties.Resources.circle_red;
            resources.ApplyResources(this.portStatuspictureBox, "portStatuspictureBox");
            this.portStatuspictureBox.Name = "portStatuspictureBox";
            this.portStatuspictureBox.TabStop = false;
            // 
            // statusResetButton
            // 
            resources.ApplyResources(this.statusResetButton, "statusResetButton");
            this.statusResetButton.Name = "statusResetButton";
            this.statusResetButton.UseVisualStyleBackColor = true;
            // 
            // sentTextBox
            // 
            this.sentTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            resources.ApplyResources(this.sentTextBox, "sentTextBox");
            this.sentTextBox.Name = "sentTextBox";
            this.sentTextBox.TabStop = false;
            // 
            // sendCountLabel
            // 
            resources.ApplyResources(this.sendCountLabel, "sendCountLabel");
            this.sendCountLabel.Name = "sendCountLabel";
            // 
            // receiveTextBox
            // 
            this.receiveTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            resources.ApplyResources(this.receiveTextBox, "receiveTextBox");
            this.receiveTextBox.Name = "receiveTextBox";
            this.receiveTextBox.TabStop = false;
            // 
            // recvCountLabel
            // 
            resources.ApplyResources(this.recvCountLabel, "recvCountLabel");
            this.recvCountLabel.Name = "recvCountLabel";
            // 
            // suffixLabel
            // 
            resources.ApplyResources(this.suffixLabel, "suffixLabel");
            this.suffixLabel.Name = "suffixLabel";
            // 
            // clearDisplayButton
            // 
            resources.ApplyResources(this.clearDisplayButton, "clearDisplayButton");
            this.clearDisplayButton.Name = "clearDisplayButton";
            this.clearDisplayButton.UseVisualStyleBackColor = true;
            this.clearDisplayButton.Click += new System.EventHandler(this.clearDisplayButton_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.displaySettingGroupBox);
            this.Controls.Add(this.sendPanel);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.displayPanel);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.portBox.ResumeLayout(false);
            this.portBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portPictureBox)).EndInit();
            this.displaySettingGroupBox.ResumeLayout(false);
            this.displaySettingGroupBox.PerformLayout();
            this.sendGroupBox.ResumeLayout(false);
            this.sendGroupBox.PerformLayout();
            this.displayPanel.ResumeLayout(false);
            this.dispalyGroupBox.ResumeLayout(false);
            this.dispalyGroupBox.PerformLayout();
            this.sendPanel.ResumeLayout(false);
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portStatuspictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox portBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.PictureBox portPictureBox;
        private System.Windows.Forms.Button portButton;
        private System.Windows.Forms.ComboBox stopBitsComboBox;
        private System.Windows.Forms.Label stopBitsLabel;
        private System.Windows.Forms.ComboBox parityComboBox;
        private System.Windows.Forms.Label parityLabel;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.ComboBox dataBitsComboBox;
        private System.Windows.Forms.Label dataBitsLabel;
        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.GroupBox displaySettingGroupBox;
        private System.Windows.Forms.CheckBox showHexCheckbox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox timeStampCheckBox;
        private System.Windows.Forms.CheckBox displaySentCheckBox;
        private System.Windows.Forms.GroupBox sendGroupBox;
        private System.Windows.Forms.TextBox intevalTextBox;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.CheckBox loopCheckBox;
        private System.Windows.Forms.CheckBox sendHexCheckBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.TextBox SendTextBox;
        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.Panel sendPanel;
        private System.Windows.Forms.GroupBox dispalyGroupBox;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.Label recvCountLabel;
        private System.Windows.Forms.TextBox sentTextBox;
        private System.Windows.Forms.Label sendCountLabel;
        private System.Windows.Forms.TextBox receiveTextBox;
        private System.Windows.Forms.Button statusResetButton;
        private System.Windows.Forms.Label portStatusLabel;
        private System.Windows.Forms.PictureBox portStatuspictureBox;
        private System.Windows.Forms.ComboBox handshakeComboBox;
        private System.Windows.Forms.Label handshakeLabel;
        private System.Windows.Forms.CheckBox base64CheckBox;
        private System.Windows.Forms.ComboBox suffixComboBox;
        private System.Windows.Forms.Label suffixLabel;
        private System.Windows.Forms.Button clearDisplayButton;
    }
}

