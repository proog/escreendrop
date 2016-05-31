using System.Collections.Generic;
using System.Linq;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace sharpscreendrop {
	class NativeCaptureRunner : CaptureProvider {
		public NativeCaptureRunner() {
			Screen[] screens = Screen.AllScreens;
			IEnumerable<Screen> sortedScreens = screens.OrderBy(x => x.Bounds.X);

			int imageWidth = 0;
			int imageHeight = 0;

			foreach(Screen scr in screens) {
				imageWidth += scr.Bounds.Width;
				if(scr.Bounds.Height > imageHeight) //to account for different resolutions
					imageHeight = scr.Bounds.Height;
			}

			var bmp = new Bitmap(imageWidth, imageHeight, PixelFormat.Format32bppArgb);
			Graphics gfx = Graphics.FromImage(bmp); //create drawing surface with screen dimensions

			int lastWidth = 0; //the last used screen's width

			foreach(Screen scr in sortedScreens) {
				try {
					gfx.CopyFromScreen(scr.Bounds.X, scr.Bounds.Y, lastWidth, 0, scr.Bounds.Size, CopyPixelOperation.SourceCopy); //copy screenshot to drawing surface
				} catch(Win32Exception) {
					Successful = false;
					ScreenDrop.TrayHandler.DisplayError("Could not capture screen");
					return;
				}

				lastWidth = scr.Bounds.Width;
			}

			Image = bmp;
			Successful = true;
		}
	}
}
