using System.Windows.Forms;
using System.IO;

namespace sharpscreendrop {
	class ClipboardHandler {
		internal System.Drawing.Image GetClipboard() {
			if(!Clipboard.ContainsImage())
				throw new InvalidDataException();
			return Clipboard.GetImage();
		}

		internal void SetClipboard(string str) {
			Clipboard.SetText(str);
		}
	}
}
