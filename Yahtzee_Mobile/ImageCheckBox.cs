using System.Drawing;
using System.Windows.Forms;

namespace Yahtzee_Mobile
{
	public class ImageCheckBox : Control
	{
		private Image _unchecked;
		private Image _checked;

		private bool _ischecked;

		public void SetImages(Image checkedimage, Image uncheckedimage)
		{
			_unchecked = uncheckedimage;
			_checked = checkedimage;

			Invalidate();
		}

		protected override void OnPaint(PaintEventArgs pea)
		{
			Graphics g = pea.Graphics;

			// Draw the correct image - checked or unchecked
			if (this.Enabled) // Don't draw anything if the control is disabled
			{
				if (this.Checked && _checked != null)
				{
					g.DrawImage(_checked, 0, 0);
				}
				else if (_unchecked != null)
				{
					g.DrawImage(_unchecked, 0, 0);
				}
			}
		}

		private void InitializeComponent()
		{
			this.BackColor = System.Drawing.SystemColors.Control;
		}

		protected override void OnClick(System.EventArgs e)
		{
			Checked = !Checked;
			Invalidate();
		}

		public bool Checked
		{
			get { return _ischecked; }
			set { _ischecked = value; Invalidate();  }
		}
	}
}
