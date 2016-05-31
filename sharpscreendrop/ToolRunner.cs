using System.Drawing;
using System.IO;
using System.Diagnostics;

namespace sharpscreendrop {
	class ToolRunner : CaptureProvider {
		private Image _existingImage;
		private string _tool;

		public ToolRunner(string tool) {
			_tool = tool;
			Run();
		}

		private void Run() {
			if(_tool == null || _tool.Length <= 0) {
				ScreenDrop.TrayHandler.DisplayError("No tool specified");
				return;
			}

			try {
				if(!File.Exists(_tool)) {
					_tool = GetSystem32Replacement();
					if(!File.Exists(_tool)) {
						ScreenDrop.TrayHandler.DisplayError("The specified tool does not exist");
						return;
					}
				}

				try {
					_existingImage = new ClipboardHandler().GetClipboard(); //match with this later to see if changed
				} catch(InvalidDataException) {
					_existingImage = new Bitmap(1, 1);
				}

				var info = new ProcessStartInfo { FileName = _tool };
				var p = Process.Start(info);
				p.WaitForInputIdle();
				p.WaitForExit();
			} catch(IOException) {
				ScreenDrop.TrayHandler.DisplayError("Could not run tool: an IO error occurred");
			}

			//get clipboard contents
			try {
				Image = new ClipboardHandler().GetClipboard();
				if(ImagesEqual(Image, _existingImage)) //if an old image was accessed (i.e. not the screenshot)
					throw new InvalidDataException();
				Successful = true;
			} catch(InvalidDataException) {
				Successful = false;
				ScreenDrop.TrayHandler.DisplayError("No new image found in clipboard");
			}
		}

		private bool ImagesEqual(Image img1, Image img2) {
			if(img1.Width != img2.Width || img1.Height != img2.Height)
				return false; //width or height is different

			var bmp1 = new Bitmap(img1);
			var bmp2 = new Bitmap(img2);

			for(int i = 0; i < bmp1.Width; i++) {
				for(int j = 0; j < bmp1.Height; j++) {
					string img1Pixel = bmp1.GetPixel(i, j).ToString();
					string img2Pixel = bmp2.GetPixel(i, j).ToString();

					if(!img1Pixel.Equals(img2Pixel))
						return false; //a different pixel found
				}
			}

			//at this point, width, height and all pixels are equal
			return true;
		}

		private string GetSystem32Replacement() {
			string newTool = _tool.ToLower();
			if(newTool.Contains("system32"))
				newTool = newTool.Replace("system32", "sysnative");
			return newTool;
		}
	}
}
