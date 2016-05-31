using System;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace sharpscreendrop {
	public partial class SettingsDialog : Form {
		private readonly SettingsHandler _sh;
		private readonly RegistryKey _startupKey;

		public SettingsDialog() {
			InitializeComponent();

			_sh = ScreenDrop.SettingsHandler;
			publicDirText.Text = _sh.PublicDir;
			publicIdText.Text = _sh.PublicId;
			toolText.Text = _sh.Tool;
			baseNameText.Text = _sh.Filepath;
			extensionCombobox.SelectedItem = _sh.Extension.ToUpper();
			timestampCheckbox.Checked = _sh.DateInName;
			dateFormatCombobox.Text = _sh.DateFormat;
			notifyErrorCheckbox.Checked = _sh.NotifyOnError;
			notifySuccessCheckbox.Checked = _sh.NotifyOnSuccess;
			hotkeyCheckbox.Checked = _sh.HotkeyEnabled;

			if(_sh.NativeCapture)
				nativeCaptureSelector.Checked = true;
			else
				customToolSelector.Checked = true;

			_startupKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			if(_startupKey != null) //null if operation failed, but probably doesn't happen
				startupCheckbox.Checked = (_startupKey.GetValue("eScreenDrop") != null);

			FormClosing += CancelButtonClick;

			Visible = true;
		}

		private void OkButtonClick(object sender, EventArgs e) {
			//save settings
			try {
				_sh.ClearSettingsFile();
				_sh.WriteSetting("publicDir", publicDirText.Text);
				_sh.WriteSetting("publicId", publicIdText.Text);
				_sh.WriteSetting("fileName", baseNameText.Text);
				_sh.WriteSetting("extension", ((string)extensionCombobox.SelectedItem).ToLower());
				_sh.WriteSetting("nativeCapture", nativeCaptureSelector.Checked);
				_sh.WriteSetting("tool", toolText.Text);
				_sh.WriteSetting("dateInName", timestampCheckbox.Checked);
				_sh.WriteSetting("dateFormat", dateFormatCombobox.Text);
				_sh.WriteSetting("notifyOnSuccess", notifySuccessCheckbox.Checked);
				_sh.WriteSetting("notifyOnError", notifyErrorCheckbox.Checked);
				_sh.WriteSetting("hotkey", hotkeyCheckbox.Checked);
				_sh.ReadSettings(); //refresh internal settings

				//set startup in registry
				if(startupCheckbox.Checked)
					_startupKey.SetValue("eScreenDrop", Application.ExecutablePath);
				else
					_startupKey.DeleteValue("eScreenDrop", false);
			} catch(IOException) {
				ScreenDrop.TrayHandler.DisplayError("Could not save settings: an IO error occurred");
				MessageBox.Show(this, "Could not save settings: an IO error occurred", "Error");
			}

			Visible = false;
			Dispose();
		}

		private void CancelButtonClick(object sender, EventArgs e) {
			//discard settings
			Visible = false;
			Dispose();
		}

		private void PublicDirButtonClick(object sender, EventArgs e) {
			var folderBrowser = new FolderBrowserDialog();
			folderBrowser.ShowDialog(this);
			if(folderBrowser.SelectedPath.Length <= 0)
				return;
			publicDirText.Text = folderBrowser.SelectedPath;
		}

		private void ToolButtonClick(object sender, EventArgs e) {
			var fileBrowser = new OpenFileDialog {
				Multiselect = false,
				Title = "Select tool",
				ShowHelp = false,
				Filter = "Executables (*.exe;*.bat;*.com)|*.exe;*.bat;*.exe"
			};
			fileBrowser.ShowDialog(this);
			if(fileBrowser.SafeFileName == null || fileBrowser.SafeFileName.Length <= 0)
				return;
			toolText.Text = fileBrowser.FileName;
		}
	}
}
