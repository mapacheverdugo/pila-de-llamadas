using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilaDeLlamadas {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
	
		}

		private void panel1_Scroll(object sender, ScrollEventArgs e) {
			panel1.Invalidate();
		}

		List<Button> buttons = new List<Button>();

		private void Form1_KeyUp(object sender, KeyEventArgs e) {
			Button newButton = new Button();
			newButton.Left = 0;
			newButton.Width = 100;
			newButton.Height = 50;
			newButton.BackColor = Color.Aquamarine;
			newButton.FlatStyle = FlatStyle.Flat;
			newButton.FlatAppearance.BorderSize = 0;

			if (e.KeyCode == Keys.Enter) {
				newButton.Text = "" + (buttons.Count() + 1);
				newButton.Top = (60 * buttons.Count()) + panel1.AutoScrollPosition.Y;

				buttons.Add(newButton);
				panel1.Controls.Add(newButton);
			} else if (e.KeyCode == Keys.Space & buttons.Any()) {
				panel1.Controls.RemoveAt(buttons.Count() - 1);
				buttons.RemoveAt(buttons.Count() - 1);
			}

			}
	}
}
