namespace mscom
{
	partial class Base64Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base64Form));
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.toBase64RadioButton = new System.Windows.Forms.RadioButton();
            this.fromBase64RadioButton = new System.Windows.Forms.RadioButton();
            this.exchangeButton = new System.Windows.Forms.Button();
            this.radioGroupPanel = new System.Windows.Forms.Panel();
            this.hexCheckBox = new System.Windows.Forms.CheckBox();
            this.radioGroupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceTextBox.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceTextBox.Location = new System.Drawing.Point(12, 67);
            this.sourceTextBox.Multiline = true;
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(808, 252);
            this.sourceTextBox.TabIndex = 0;
            // 
            // targetTextBox
            // 
            this.targetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.targetTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.targetTextBox.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetTextBox.Location = new System.Drawing.Point(12, 336);
            this.targetTextBox.Multiline = true;
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.ReadOnly = true;
            this.targetTextBox.Size = new System.Drawing.Size(808, 324);
            this.targetTextBox.TabIndex = 3;
            // 
            // convertButton
            // 
            this.convertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.convertButton.Location = new System.Drawing.Point(653, 12);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(167, 42);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // toBase64RadioButton
            // 
            this.toBase64RadioButton.AutoSize = true;
            this.toBase64RadioButton.Checked = true;
            this.toBase64RadioButton.Location = new System.Drawing.Point(3, 10);
            this.toBase64RadioButton.Name = "toBase64RadioButton";
            this.toBase64RadioButton.Size = new System.Drawing.Size(114, 22);
            this.toBase64RadioButton.TabIndex = 5;
            this.toBase64RadioButton.TabStop = true;
            this.toBase64RadioButton.Text = "To Base64";
            this.toBase64RadioButton.UseVisualStyleBackColor = true;
            // 
            // fromBase64RadioButton
            // 
            this.fromBase64RadioButton.AutoSize = true;
            this.fromBase64RadioButton.Location = new System.Drawing.Point(145, 10);
            this.fromBase64RadioButton.Name = "fromBase64RadioButton";
            this.fromBase64RadioButton.Size = new System.Drawing.Size(132, 22);
            this.fromBase64RadioButton.TabIndex = 6;
            this.fromBase64RadioButton.Text = "From Base64";
            this.fromBase64RadioButton.UseVisualStyleBackColor = true;
            // 
            // exchangeButton
            // 
            this.exchangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exchangeButton.Location = new System.Drawing.Point(480, 12);
            this.exchangeButton.Name = "exchangeButton";
            this.exchangeButton.Size = new System.Drawing.Size(167, 42);
            this.exchangeButton.TabIndex = 7;
            this.exchangeButton.Text = "Switch";
            this.exchangeButton.UseVisualStyleBackColor = true;
            this.exchangeButton.Click += new System.EventHandler(this.exchangeButton_Click);
            // 
            // radioGroupPanel
            // 
            this.radioGroupPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioGroupPanel.Controls.Add(this.fromBase64RadioButton);
            this.radioGroupPanel.Controls.Add(this.toBase64RadioButton);
            this.radioGroupPanel.Location = new System.Drawing.Point(13, 12);
            this.radioGroupPanel.Name = "radioGroupPanel";
            this.radioGroupPanel.Size = new System.Drawing.Size(307, 42);
            this.radioGroupPanel.TabIndex = 9;
            // 
            // hexCheckBox
            // 
            this.hexCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hexCheckBox.AutoSize = true;
            this.hexCheckBox.Location = new System.Drawing.Point(326, 23);
            this.hexCheckBox.Name = "hexCheckBox";
            this.hexCheckBox.Size = new System.Drawing.Size(124, 22);
            this.hexCheckBox.TabIndex = 10;
            this.hexCheckBox.Text = "Hex Format";
            this.hexCheckBox.UseVisualStyleBackColor = true;
            // 
            // Base64Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 672);
            this.Controls.Add(this.hexCheckBox);
            this.Controls.Add(this.radioGroupPanel);
            this.Controls.Add(this.exchangeButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.targetTextBox);
            this.Controls.Add(this.sourceTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Base64Form";
            this.Text = "Base64 Tool";
            this.radioGroupPanel.ResumeLayout(false);
            this.radioGroupPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox sourceTextBox;
		private System.Windows.Forms.TextBox targetTextBox;
		private System.Windows.Forms.Button convertButton;
		private System.Windows.Forms.RadioButton toBase64RadioButton;
		private System.Windows.Forms.RadioButton fromBase64RadioButton;
		private System.Windows.Forms.Button exchangeButton;
		private System.Windows.Forms.Panel radioGroupPanel;
		private System.Windows.Forms.CheckBox hexCheckBox;
	}
}
