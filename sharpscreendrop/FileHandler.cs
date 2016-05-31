using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace sharpscreendrop {
	class FileHandler {
		private readonly string _file;

		public FileHandler(CaptureProvider captureProvider, SettingsHandler settingsHandler) {
			//create date
			string date = "";
			if(settingsHandler.DateInName)
				date = "-" + DateTime.Now.ToString(settingsHandler.DateFormat);

			//create suffix number
			int number = 1;
			string numberString = "";

			//create file
			string name;
			string path = settingsHandler.Filepath;
			string pathPart;
			string basePart;
			string subdirs; //for use in public link creation
			const string separator = "\\";

			if(path.Contains(separator)) {
				int filenameBegins = path.LastIndexOf(separator);
				subdirs = path.Substring(0, filenameBegins);
				pathPart = settingsHandler.PublicDir + separator + subdirs;
				basePart = path.Substring(filenameBegins);
				Directory.CreateDirectory(pathPart);
			}
			else {
				pathPart = settingsHandler.PublicDir + separator;
				basePart = path;
				subdirs = "";
			}

			do {
				if(number != 1)
					numberString = "-" + number;
				name = basePart + date + numberString + "." + settingsHandler.Extension;
				this._file = pathPart + name;
				number++;
			} while(File.Exists(this._file));

			try {
				Image image = captureProvider.Image;
				ImageFormat format;
				switch(settingsHandler.Extension.ToLower()) {
					case "bmp":
						format = ImageFormat.Bmp; break;
					case "jpg":
						format = ImageFormat.Jpeg; break;
					case "gif":
						format = ImageFormat.Gif; break;
					case "png":
						format = ImageFormat.Png; break;
					default:
						goto case "png";
				}
				image.Save(this._file, format);
			} catch(Exception) {
				ScreenDrop.TrayHandler.DisplayError("Could not save image file. Possible reason: malformed path - please check settings");
				return;
			}

			string publicLink = "http://dl.dropbox.com/u/" + settingsHandler.PublicId + "/" + subdirs.Replace(" ", "%20").Replace(separator, "/") + name.Replace(" ", "%20").Replace(separator, "/");
			try {
				new ClipboardHandler().SetClipboard(publicLink);
			} catch(ExternalException) { }

			if(settingsHandler.NotifyOnSuccess)
				ScreenDrop.TrayHandler.DisplayMessage("Screenshot saved", this._file + " was saved successfully.");
		}
	}
}
