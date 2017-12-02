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
			KeyEventArgs KeyEvent;
			KeyUp += new KeyEventHandler(sender, KeyEvent);
			Funciones.CambioDeBase(354, 6, 1, 1, 1, panel1);
		}

		static List<Button> buttons = new List<Button>();

		/*public int getY() {
			int Y = panel1.AutoScrollPosition.Y;
			return Y;
		}*/
		
		public static void continuar() {
			KeyEventArgs e;
			do {

			}while(e.KeyCode == Keys.Enter);
		}

		public static void Imprimir(int total, int max, int actual, string frase, Panel p){
			Button newButton = new Button();
			newButton.Left = 0;
			newButton.Width = 100;
			newButton.Height = 50;
			newButton.BackColor = Color.Aquamarine;
			newButton.FlatStyle = FlatStyle.Flat;
			newButton.FlatAppearance.BorderSize = 0;

			if(buttons.Count() < actual) {
				newButton.Text = frase;
				newButton.Top = (60 * buttons.Count()) + p.AutoScrollPosition.Y;

				buttons.Add(newButton);
				p.Controls.Add(newButton);
			} else if (buttons.Count > actual) {
				p.Controls.RemoveAt(buttons.Count() - 1);
				buttons.RemoveAt(buttons.Count() - 1);
			}

			continuar();
		}
	}
}
