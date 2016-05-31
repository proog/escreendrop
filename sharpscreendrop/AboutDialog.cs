using System;
using System.Windows.Forms;

namespace sharpscreendrop {
	public partial class AboutDialog : Form {
		public AboutDialog() {
			InitializeComponent();

			linkLabel1.Links.Add(0, 17, "http://permortensen.com");

			Visible = true;
		}

		private void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
		}

		private void CloseButtonClick(object sender, EventArgs e) {
			Visible = false;
			Dispose();
		}
	}
}
