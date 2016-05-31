using System;
using System.IO;
using System.Windows.Forms;

namespace sharpscreendrop {
	class SettingsHandler {
		private readonly string _settingsFile;
		internal string PublicDir {
			get;
			private set;
		}
		internal string PublicId {
			get;
			private set;
		}
		internal string Filepath {
			get;
			private set;
		}
		internal bool DateInName {
			get;
			private set;
		}
		internal string DateFormat {
			get;
			private set;
		}
		internal string Extension {
			get;
			private set;
		}
		internal bool NativeCapture {
			get;
			private set;
		}
		internal string Tool {
			get;
			private set;
		}
		internal bool NotifyOnError {
			get;
			private set;
		}
		internal bool NotifyOnSuccess {
			get;
			private set;
		}
		internal bool HotkeyEnabled {
			get;
			private set;
		}

		public SettingsHandler() {
			Directory.SetCurrentDirectory(Application.StartupPath);
			_settingsFile = "scrdrop.ini";
			if(!File.Exists(_settingsFile)) {
				try {
					var defaultsWriter = new StreamWriter(_settingsFile);
					const string defaults = "publicDir=<your Dropbox \"Public\" folder>\n" +
											"publicId=<the number after /u/ in your public links>\n" +
											"fileName=scrdrop\n" +
											"extension=png\n" +
											"nativeCapture=true\n" +
											"tool=C:\\Windows\\System32\\SnippingTool.exe\n" +
											"dateInName=true\n" +
											"dateFormat=yyyy-MM-dd\n" +
											"notifyOnSuccess=true\n" +
											"notifyOnError=true\n" +
											"hotkey=true\n";
					defaultsWriter.WriteLine(defaults);
					defaultsWriter.Close();
				} catch(IOException) {
					Console.WriteLine("Could not create settings file. Exiting");
					ScreenDrop.Exit();
				}
			}

			try {
				ReadSettings();
			} catch(InvalidDataException) {
				Console.WriteLine("Invalid settings in settings file");
			}
		}

		public void ReadSettings() {
			PublicDir = null;
			PublicId = null;
			Filepath = null;
			DateInName = false;
			DateFormat = null;
			Extension = null;
			NativeCapture = false;
			Tool = null;
			NotifyOnError = false;
			NotifyOnSuccess = false;
			HotkeyEnabled = false;

			const string publicDirPrefix = "publicDir=";
			const string publicIdPrefix = "publicId=";
			const string filenamePrefix = "fileName=";
			const string datePrefix = "dateInName=";
			const string dateFormatPrefix = "dateFormat=";
			const string extensionPrefix = "extension=";
			const string nativeCapturePrefix = "nativeCapture=";
			const string toolPrefix = "tool=";
			const string notifyOnErrorPrefix = "notifyOnError=";
			const string notifyOnSuccessPrefix = "notifyOnSuccess=";
			const string hotkeyPrefix = "hotkey=";
			const string commentPrefix = "#";
			const string trueValue = "true";

			var reader = File.OpenText(_settingsFile);
			string line;
			while((line = reader.ReadLine()) != null) {
				if(line.Length <= 0 || line.StartsWith(commentPrefix))
					continue;
				if(line.StartsWith(publicDirPrefix))
					PublicDir = line.Substring(publicDirPrefix.Length);
				else if(line.StartsWith(publicIdPrefix))
					PublicId = line.Substring(publicIdPrefix.Length);
				else if(line.StartsWith(filenamePrefix))
					Filepath = line.Substring(filenamePrefix.Length);
				else if(line.StartsWith(datePrefix)) {
					if(String.Compare(line.Substring(datePrefix.Length), trueValue, true) == 0)
						DateInName = true;
				}
				else if(line.StartsWith(dateFormatPrefix))
					DateFormat = line.Substring(dateFormatPrefix.Length);
				else if(line.StartsWith(extensionPrefix))
					Extension = line.Substring(extensionPrefix.Length);
				else if(line.StartsWith(nativeCapturePrefix)) {
					if(String.Compare(line.Substring(nativeCapturePrefix.Length), trueValue, true) == 0)
						NativeCapture = true;
				}
				else if(line.StartsWith(toolPrefix))
					Tool = line.Substring(toolPrefix.Length);
				else if(line.StartsWith(notifyOnErrorPrefix)) {
					if(String.Compare(line.Substring(notifyOnErrorPrefix.Length), trueValue, true) == 0)
						NotifyOnError = true;
				}
				else if(line.StartsWith(notifyOnSuccessPrefix)) {
					if(String.Compare(line.Substring(notifyOnSuccessPrefix.Length), trueValue) == 0)
						NotifyOnSuccess = true;
				}
				else if(line.StartsWith(hotkeyPrefix)) {
					if(String.Compare(line.Substring(hotkeyPrefix.Length), trueValue) == 0)
						HotkeyEnabled = true;
				}
				else
					throw new InvalidDataException("Illegal setting: " + line);
			}
			reader.Close();
		}

		internal void ClearSettingsFile() {
			var writer = new StreamWriter(_settingsFile);
			writer.Write("");
			writer.Close();
		}

		internal void WriteSetting(string name, string value) {
			var writer = new StreamWriter(_settingsFile, true);
			writer.Write(name + "=" + value + Environment.NewLine);
			writer.Close();
		}

		internal void WriteSetting(string name, bool value) {
			WriteSetting(name, value ? "true" : "false");
		}
	}
}
