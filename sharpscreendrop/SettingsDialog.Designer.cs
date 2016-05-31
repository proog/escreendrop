namespace sharpscreendrop {
	partial class SettingsDialog {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.generalTab = new System.Windows.Forms.TabPage();
			this.publicDirButton = new System.Windows.Forms.Button();
			this.publicIdText = new System.Windows.Forms.TextBox();
			this.publicDirText = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.nativeCaptureSelector = new System.Windows.Forms.RadioButton();
			this.toolButton = new System.Windows.Forms.Button();
			this.customToolSelector = new System.Windows.Forms.RadioButton();
			this.toolText = new System.Windows.Forms.TextBox();
			this.namingTab = new System.Windows.Forms.TabPage();
			this.dateFormatCombobox = new System.Windows.Forms.ComboBox();
			this.timestampCheckbox = new System.Windows.Forms.CheckBox();
			this.extensionCombobox = new System.Windows.Forms.ComboBox();
			this.baseNameText = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.miscTab = new System.Windows.Forms.TabPage();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.hotkeyCheckbox = new System.Windows.Forms.CheckBox();
			this.label10 = new System.Windows.Forms.Label();
			this.startupCheckbox = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.notifyErrorCheckbox = new System.Windows.Forms.CheckBox();
			this.notifySuccessCheckbox = new System.Windows.Forms.CheckBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.generalTab.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.namingTab.SuspendLayout();
			this.miscTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.generalTab);
			this.tabControl1.Controls.Add(this.namingTab);
			this.tabControl1.Controls.Add(this.miscTab);
			this.tabControl1.Location = new System.Drawing.Point(2, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(348, 175);
			this.tabControl1.TabIndex = 0;
			// 
			// generalTab
			// 
			this.generalTab.Controls.Add(this.publicDirButton);
			this.generalTab.Controls.Add(this.publicIdText);
			this.generalTab.Controls.Add(this.publicDirText);
			this.generalTab.Controls.Add(this.label2);
			this.generalTab.Controls.Add(this.label1);
			this.generalTab.Controls.Add(this.groupBox1);
			this.generalTab.Location = new System.Drawing.Point(4, 22);
			this.generalTab.Name = "generalTab";
			this.generalTab.Padding = new System.Windows.Forms.Padding(3);
			this.generalTab.Size = new System.Drawing.Size(340, 149);
			this.generalTab.TabIndex = 0;
			this.generalTab.Text = "General";
			this.generalTab.UseVisualStyleBackColor = true;
			// 
			// publicDirButton
			// 
			this.publicDirButton.Location = new System.Drawing.Point(257, 5);
			this.publicDirButton.Name = "publicDirButton";
			this.publicDirButton.Size = new System.Drawing.Size(75, 23);
			this.publicDirButton.TabIndex = 2;
			this.publicDirButton.Text = "Browse...";
			this.publicDirButton.UseVisualStyleBackColor = true;
			this.publicDirButton.Click += new System.EventHandler(this.PublicDirButtonClick);
			// 
			// publicIdText
			// 
			this.publicIdText.Location = new System.Drawing.Point(82, 38);
			this.publicIdText.Name = "publicIdText";
			this.publicIdText.Size = new System.Drawing.Size(239, 20);
			this.publicIdText.TabIndex = 3;
			// 
			// publicDirText
			// 
			this.publicDirText.Location = new System.Drawing.Point(82, 7);
			this.publicDirText.Name = "publicDirText";
			this.publicDirText.Size = new System.Drawing.Size(169, 20);
			this.publicDirText.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Public ID:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Public folder:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.nativeCaptureSelector);
			this.groupBox1.Controls.Add(this.toolButton);
			this.groupBox1.Controls.Add(this.customToolSelector);
			this.groupBox1.Controls.Add(this.toolText);
			this.groupBox1.Location = new System.Drawing.Point(6, 69);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(330, 74);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Screen capture method";
			// 
			// nativeCaptureSelector
			// 
			this.nativeCaptureSelector.AutoSize = true;
			this.nativeCaptureSelector.Location = new System.Drawing.Point(11, 46);
			this.nativeCaptureSelector.Name = "nativeCaptureSelector";
			this.nativeCaptureSelector.Size = new System.Drawing.Size(183, 17);
			this.nativeCaptureSelector.TabIndex = 7;
			this.nativeCaptureSelector.TabStop = true;
			this.nativeCaptureSelector.Text = "Self-contained full screen capture";
			this.nativeCaptureSelector.UseVisualStyleBackColor = true;
			// 
			// toolButton
			// 
			this.toolButton.Location = new System.Drawing.Point(251, 18);
			this.toolButton.Name = "toolButton";
			this.toolButton.Size = new System.Drawing.Size(75, 23);
			this.toolButton.TabIndex = 5;
			this.toolButton.Text = "Browse...";
			this.toolButton.UseVisualStyleBackColor = true;
			this.toolButton.Click += new System.EventHandler(this.ToolButtonClick);
			// 
			// customToolSelector
			// 
			this.customToolSelector.AutoSize = true;
			this.customToolSelector.Location = new System.Drawing.Point(11, 21);
			this.customToolSelector.Name = "customToolSelector";
			this.customToolSelector.Size = new System.Drawing.Size(83, 17);
			this.customToolSelector.TabIndex = 6;
			this.customToolSelector.TabStop = true;
			this.customToolSelector.Text = "Custom tool:";
			this.customToolSelector.UseVisualStyleBackColor = true;
			// 
			// toolText
			// 
			this.toolText.Location = new System.Drawing.Point(97, 20);
			this.toolText.Name = "toolText";
			this.toolText.Size = new System.Drawing.Size(148, 20);
			this.toolText.TabIndex = 4;
			// 
			// namingTab
			// 
			this.namingTab.Controls.Add(this.dateFormatCombobox);
			this.namingTab.Controls.Add(this.timestampCheckbox);
			this.namingTab.Controls.Add(this.extensionCombobox);
			this.namingTab.Controls.Add(this.baseNameText);
			this.namingTab.Controls.Add(this.label7);
			this.namingTab.Controls.Add(this.label6);
			this.namingTab.Controls.Add(this.label5);
			this.namingTab.Controls.Add(this.label4);
			this.namingTab.Location = new System.Drawing.Point(4, 22);
			this.namingTab.Name = "namingTab";
			this.namingTab.Padding = new System.Windows.Forms.Padding(3);
			this.namingTab.Size = new System.Drawing.Size(340, 149);
			this.namingTab.TabIndex = 1;
			this.namingTab.Text = "Naming";
			this.namingTab.UseVisualStyleBackColor = true;
			// 
			// dateFormatCombobox
			// 
			this.dateFormatCombobox.FormattingEnabled = true;
			this.dateFormatCombobox.Items.AddRange(new object[] {
            "yyyy-MM-dd",
            "MM-dd-yyyy",
            "dd-MM-yyyy"});
			this.dateFormatCombobox.Location = new System.Drawing.Point(105, 101);
			this.dateFormatCombobox.Name = "dateFormatCombobox";
			this.dateFormatCombobox.Size = new System.Drawing.Size(227, 21);
			this.dateFormatCombobox.TabIndex = 8;
			// 
			// timestampCheckbox
			// 
			this.timestampCheckbox.AutoSize = true;
			this.timestampCheckbox.Location = new System.Drawing.Point(108, 75);
			this.timestampCheckbox.Name = "timestampCheckbox";
			this.timestampCheckbox.Size = new System.Drawing.Size(15, 14);
			this.timestampCheckbox.TabIndex = 7;
			this.timestampCheckbox.UseVisualStyleBackColor = true;
			// 
			// extensionCombobox
			// 
			this.extensionCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.extensionCombobox.FormattingEnabled = true;
			this.extensionCombobox.Items.AddRange(new object[] {
            "PNG",
            "BMP",
            "GIF",
            "JPG"});
			this.extensionCombobox.Location = new System.Drawing.Point(105, 38);
			this.extensionCombobox.Name = "extensionCombobox";
			this.extensionCombobox.Size = new System.Drawing.Size(227, 21);
			this.extensionCombobox.TabIndex = 5;
			// 
			// baseNameText
			// 
			this.baseNameText.Location = new System.Drawing.Point(105, 6);
			this.baseNameText.Name = "baseNameText";
			this.baseNameText.Size = new System.Drawing.Size(227, 20);
			this.baseNameText.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 105);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(93, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "Timestamp format:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 75);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Timestamp:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 41);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Extension:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Base name:";
			// 
			// miscTab
			// 
			this.miscTab.Controls.Add(this.label14);
			this.miscTab.Controls.Add(this.label13);
			this.miscTab.Controls.Add(this.label12);
			this.miscTab.Controls.Add(this.label11);
			this.miscTab.Controls.Add(this.hotkeyCheckbox);
			this.miscTab.Controls.Add(this.label10);
			this.miscTab.Controls.Add(this.startupCheckbox);
			this.miscTab.Controls.Add(this.label3);
			this.miscTab.Controls.Add(this.notifyErrorCheckbox);
			this.miscTab.Controls.Add(this.notifySuccessCheckbox);
			this.miscTab.Controls.Add(this.label9);
			this.miscTab.Controls.Add(this.label8);
			this.miscTab.Location = new System.Drawing.Point(4, 22);
			this.miscTab.Name = "miscTab";
			this.miscTab.Size = new System.Drawing.Size(340, 149);
			this.miscTab.TabIndex = 2;
			this.miscTab.Text = "Misc";
			this.miscTab.UseVisualStyleBackColor = true;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label14.Location = new System.Drawing.Point(143, 10);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(180, 26);
			this.label14.TabIndex = 11;
			this.label14.Text = "Shows a balloon tip once a captured\r\nimage is saved.";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label13.Location = new System.Drawing.Point(143, 39);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(181, 26);
			this.label13.TabIndex = 10;
			this.label13.Text = "Shows a balloon tip if an error occurs\r\nduring capture.";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label12.Location = new System.Drawing.Point(143, 67);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(180, 26);
			this.label12.TabIndex = 9;
			this.label12.Text = "Starts eScreenDrop when you log in.\r\nOnly applies for the current user.";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label11.Location = new System.Drawing.Point(143, 96);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(179, 39);
			this.label11.TabIndex = 8;
			this.label11.Text = "Pressing Ctrl+Alt+F10 from anywhere\r\nwill begin capture. You must restart\r\nthe ap" +
				"plication for this to take effect.";
			// 
			// hotkeyCheckbox
			// 
			this.hotkeyCheckbox.AutoSize = true;
			this.hotkeyCheckbox.Location = new System.Drawing.Point(104, 96);
			this.hotkeyCheckbox.Name = "hotkeyCheckbox";
			this.hotkeyCheckbox.Size = new System.Drawing.Size(15, 14);
			this.hotkeyCheckbox.TabIndex = 7;
			this.hotkeyCheckbox.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(3, 96);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(78, 13);
			this.label10.TabIndex = 6;
			this.label10.Text = "Enable hotkey:";
			// 
			// startupCheckbox
			// 
			this.startupCheckbox.AutoSize = true;
			this.startupCheckbox.Location = new System.Drawing.Point(105, 67);
			this.startupCheckbox.Name = "startupCheckbox";
			this.startupCheckbox.Size = new System.Drawing.Size(15, 14);
			this.startupCheckbox.TabIndex = 5;
			this.startupCheckbox.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(4, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Run at startup:";
			// 
			// notifyErrorCheckbox
			// 
			this.notifyErrorCheckbox.AutoSize = true;
			this.notifyErrorCheckbox.Location = new System.Drawing.Point(105, 39);
			this.notifyErrorCheckbox.Name = "notifyErrorCheckbox";
			this.notifyErrorCheckbox.Size = new System.Drawing.Size(15, 14);
			this.notifyErrorCheckbox.TabIndex = 3;
			this.notifyErrorCheckbox.UseVisualStyleBackColor = true;
			// 
			// notifySuccessCheckbox
			// 
			this.notifySuccessCheckbox.AutoSize = true;
			this.notifySuccessCheckbox.Location = new System.Drawing.Point(105, 10);
			this.notifySuccessCheckbox.Name = "notifySuccessCheckbox";
			this.notifySuccessCheckbox.Size = new System.Drawing.Size(15, 14);
			this.notifySuccessCheckbox.TabIndex = 2;
			this.notifySuccessCheckbox.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(4, 39);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(76, 13);
			this.label9.TabIndex = 1;
			this.label9.Text = "Notify on error:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(4, 10);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(94, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "Notify on success:";
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(76, 184);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 1;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.OkButtonClick);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(196, 184);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 2;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// SettingsDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(353, 216);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "eScreenDrop settings";
			this.tabControl1.ResumeLayout(false);
			this.generalTab.ResumeLayout(false);
			this.generalTab.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.namingTab.ResumeLayout(false);
			this.namingTab.PerformLayout();
			this.miscTab.ResumeLayout(false);
			this.miscTab.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage generalTab;
		private System.Windows.Forms.TabPage namingTab;
		private System.Windows.Forms.TabPage miscTab;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox publicDirText;
		private System.Windows.Forms.TextBox toolText;
		private System.Windows.Forms.TextBox publicIdText;
		private System.Windows.Forms.Button publicDirButton;
		private System.Windows.Forms.Button toolButton;
		private System.Windows.Forms.ComboBox extensionCombobox;
		private System.Windows.Forms.TextBox baseNameText;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.CheckBox timestampCheckbox;
		private System.Windows.Forms.ComboBox dateFormatCombobox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox notifyErrorCheckbox;
		private System.Windows.Forms.CheckBox notifySuccessCheckbox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.RadioButton nativeCaptureSelector;
		private System.Windows.Forms.RadioButton customToolSelector;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox startupCheckbox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox hotkeyCheckbox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
	}
}