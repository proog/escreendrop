using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace sharpscreendrop {
	class HotkeyHandler {
		private readonly int _modifier;
		private readonly int _key;
		private readonly IntPtr _hWnd;
		private readonly int _id;

		public HotkeyHandler(int modifier, Keys key, Form form) {
			_modifier = modifier;
			_key = (int)key;
			_hWnd = form.Handle;
			_id = GetHashCode();
		}

		internal bool Register() {
			return RegisterHotKey(_hWnd, _id, _modifier, _key);
		}

		internal bool Unregister() {
			return UnregisterHotKey(_hWnd, _id);
		}

		[DllImport("user32.dll")]
		private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

		[DllImport("user32.dll")]
		private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		public override sealed int GetHashCode() {
			return _modifier ^ _key ^ _hWnd.ToInt32();
		}

		internal static class Constants {
			public const int NOMOD = 0x0000;
			public const int ALT = 0x0001;
			public const int CTRL = 0x0002;
			public const int SHIFT = 0x0004;
			public const int WIN = 0x0008;

			public const int WM_HOTKEY_MSG_ID = 0x0312;
		}
	}
}
