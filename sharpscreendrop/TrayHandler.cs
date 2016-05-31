using System;
using System.Drawing;
using System.Windows.Forms;

namespace sharpscreendrop {
	class TrayHandler : Form {
		private readonly NotifyIcon _trayIcon;
		private readonly ContextMenu _trayMenu;
		private readonly HotkeyHandler _hotkey;

		public TrayHandler() {
			_trayIcon = new NotifyIcon {
				Text = "eScreenDrop",
				Icon = new Icon(GetType(), "icon.ico")
			};

			_trayMenu = new ContextMenu();

			var captureItem = new MenuItem("&Capture now") { DefaultItem = true };
			captureItem.Click += CaptureClick;
			_trayMenu.MenuItems.Add(captureItem);

			_trayMenu.MenuItems.Add(new MenuItem("-"));

			var settingsItem = new MenuItem("&Settings");
			settingsItem.Click += SettingsClick;
			_trayMenu.MenuItems.Add(settingsItem);

			var aboutItem = new MenuItem("&About");
			aboutItem.Click += AboutClick;
			_trayMenu.MenuItems.Add(aboutItem);

			var exitItem = new MenuItem("&Exit");
			exitItem.Click += ExitClick;
			_trayMenu.MenuItems.Add(exitItem);

			_trayIcon.ContextMenu = _trayMenu;
			_trayIcon.DoubleClick += CaptureClick;
			_trayIcon.Visible = true;

			if(ScreenDrop.SettingsHandler.HotkeyEnabled) {
				_hotkey = new HotkeyHandler(HotkeyHandler.Constants.CTRL + HotkeyHandler.Constants.ALT, Keys.F10, this);
				_hotkey.Register();
			}
		}

		internal void CaptureClick(object sender, EventArgs e) {
			CaptureProvider cp;
			if(ScreenDrop.SettingsHandler.NativeCapture)
				cp = new NativeCaptureRunner();
			else
				cp = new ToolRunner(ScreenDrop.SettingsHandler.Tool);

			if(cp.Successful)
				new FileHandler(cp, ScreenDrop.SettingsHandler);
		}

		internal void SettingsClick(object sender, EventArgs e) {
			new SettingsDialog();
		}

		internal void AboutClick(object sender, EventArgs e) {
			new AboutDialog();
		}

		internal void ExitClick(object sender, EventArgs e) {
			if(_hotkey != null)
				_hotkey.Unregister();
			Dispose();
			_trayIcon.Dispose();
			ScreenDrop.Exit();
		}

		protected override void WndProc(ref Message m) { //called by hotkey
			if(m.Msg == HotkeyHandler.Constants.WM_HOTKEY_MSG_ID)
				CaptureClick(this, new EventArgs());
			base.WndProc(ref m);
		}

		protected override void Dispose(bool disposing) {
			if(disposing)
				_trayIcon.Dispose();
			base.Dispose(disposing);
		}

		internal void DisplayError(string message) {
			_trayIcon.ShowBalloonTip(200, "Error", message, ToolTipIcon.Error);
		}

		internal void DisplayMessage(string title, string message) {
			_trayIcon.ShowBalloonTip(200, title, message, ToolTipIcon.None);
		}
	}
}
