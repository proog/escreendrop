using System.Drawing;

namespace sharpscreendrop {
	abstract class CaptureProvider {
		public Image Image {
			get;
			protected set;
		}
		public bool Successful {
			get;
			protected set;
		}
	}
}
