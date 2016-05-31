using System;
using System.IO;
using System.Windows.Forms;

namespace sharpscreendrop {
	static class ScreenDrop {
		internal static SettingsHandler SettingsHandler {
			get;
			private set;
		}
		internal static TrayHandler TrayHandler {
			get;
			private set;
		}

		public static void Exit() {
			Environment.Exit(0);
		}

		[STAThread]
		public static void Main() {
			try {
				SettingsHandler = new SettingsHandler();
			} catch(IOException) {
				Exit();
			}

			Application.EnableVisualStyles();
			TrayHandler = new TrayHandler();
			Application.Run();
		}
	}
}
