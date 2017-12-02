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
			KeyUp += new System.Windows.Forms.KeyEventHandler(KeyEvent);
		}

		private void KeyEvent(object sender, KeyEventArgs e) //Keyup Event 
	{
			if (e.KeyCode == Keys.F9) {
				MessageBox.Show("Function F9");
			}
			if (e.KeyCode == Keys.F6) {
				MessageBox.Show("Function F6");
			} else
				MessageBox.Show("No Function");

		}
	}
}
