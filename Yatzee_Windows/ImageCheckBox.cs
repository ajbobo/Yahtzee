using System.Drawing;
using System.Windows.Forms;

namespace Yatzee_Windows
{
	class ImageCheckBox : CheckBox
	{
		private Image _unchecked;
		private Image _checked;

		private bool _hasmouse;

		public void SetImages(Image checkedimage, Image uncheckedimage)
		{
			_unchecked = uncheckedimage;
			_checked = checkedimage;
		}

		protected override void OnPaint(PaintEventArgs pea)
		{
			Graphics g = pea.Graphics;

			// Draw a background that matches the control because images have transparent areas
			if (!_hasmouse)
				g.FillRectangle(SystemBrushes.Control, 0, 0, this.Width, this.Height);
			else
				g.FillRectangle(SystemBrushes.Highlight, 0, 0, this.Width, this.Height);

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

		protected override void OnMouseEnter(System.EventArgs eventargs)
		{
			_hasmouse = true;

			base.OnMouseEnter(eventargs);
		}

		protected override void OnMouseLeave(System.EventArgs eventargs)
		{
			_hasmouse = false;

			base.OnMouseLeave(eventargs);
		}
	}
}
