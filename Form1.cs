using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PilaDeLlamadas {
	public partial class Form1 : Form {
		public static string retorno = "";
		public static ManualResetEvent semaforo;
		public static List<Button> buttons = new List<Button>();


		public Form1() {
			semaforo = new ManualResetEvent(false);
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			retorno = "Presiona [Enter] para empezar la ejecución...";
			panel2.Refresh();
			ThreadStart starter = () => {
				int retorno1 = Funciones.NodosBiarbol(4, 4, 0, 1, 0);
				retorno = "La función terminó retornando " + retorno1;
				buttons.Clear();

				Program.form1.Invoke((Action)delegate {
					Program.form1.panel1.Controls.RemoveAt(buttons.Count());
					Program.form1.panel2.Refresh();
				});
			};
			Thread hilo = new Thread(starter); 
			hilo.Start();
		}

		private void Form1_KeyPress(object sender, KeyPressEventArgs e) {
			semaforo.Set();
		}

		public static void Imprimir(int total, int max, int actual, string frase) {
			
			semaforo.Reset();
			Button newButton = new Button();
			newButton.Left = 10;
			newButton.Width = 276;
			newButton.Height = 75;
			newButton.Font = new Font("Consolas", 12, FontStyle.Bold);
			newButton.ForeColor = Color.White;
			newButton.BackColor = Color.FromArgb(140, 191, 204);
			newButton.FlatStyle = FlatStyle.Flat;
			newButton.FlatAppearance.BorderSize = 0;
			newButton.Text = frase;
			retorno = "Se está ejecutando la función, presione [Enter]";

			Program.form1.Invoke((Action) delegate{
				if (buttons.Count - 1 < actual) {
					newButton.Text = frase;
					newButton.Top = 490 - 85 - (80 * buttons.Count()) + Program.form1.panel1.AutoScrollPosition.Y;

					buttons.Add(newButton);
					Program.form1.panel1.Controls.Add(newButton);
				} else if (buttons.Count - 1 > actual) {
					Program.form1.panel1.Controls.RemoveAt(buttons.Count() - 1);
					buttons.RemoveAt(buttons.Count() - 1);
				}
			});

			semaforo.WaitOne();

		}

		private void panel2_Paint(object sender, PaintEventArgs e) {
			e.Graphics.DrawString(">> " + retorno, new Font("Consolas", 12), new SolidBrush(panel2.ForeColor), 10, 10);
		}

		private void panel1_Paint(object sender, PaintEventArgs e) {
			e.Graphics.DrawRectangle(
				new Pen(
					new SolidBrush(Color.White), 4), 2, -2, 292, 500);
		}
	}
}
