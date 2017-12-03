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
		public static Thread hilo;
		public static ManualResetEvent semaforo;
		public static List<Button> botones = new List<Button>();

		public static string consola = "";

		public Form1() {
			semaforo = new ManualResetEvent(false);
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			consola = "Presiona [Enter] para empezar la ejecución...";
			panel2.Refresh();
			ThreadStart funcion = () => {
				semaforo.Reset();
				semaforo.WaitOne();
				int retorno = Funciones.NodosBiarbol(4, 4, 0, 1, 0);
				consola = "La función terminó retornando " + retorno;
				botones.Clear();

				Program.form1.Invoke((Action)delegate {
					Program.form1.panel1.Controls.RemoveAt(botones.Count());
					Program.form1.panel2.Refresh();
				});
			};
			hilo = new Thread(funcion); 
			hilo.Start();
		}

		private void Form1_KeyPress(object sender, KeyPressEventArgs e) {
			semaforo.Set();
		}


		public static void Imprimir(int total, int max, int actual, string frase) {
			Button boton = new Button();
			boton.Click += new EventHandler(cualquierBoton_Click);
			boton.Left = 10;
			boton.Width = 276;
			boton.Height = 75;
			boton.Font = new Font("Consolas", 12, FontStyle.Bold);
			boton.ForeColor = Color.White;
			boton.BackColor = Color.FromArgb(140, 191, 204);
			boton.FlatStyle = FlatStyle.Flat;
			boton.FlatAppearance.BorderSize = 0;
			boton.TabStop = false;

			consola = "Se está ejecutando la función, presione [Enter]";

			semaforo.Reset();

			Program.form1.Invoke((Action) delegate{
				if (botones.Count - 1 < actual) {
					boton.Text = frase;
					// boton.Top = 490 - 90 - (80 * botones.Count()) + Program.form1.panel1.AutoScrollPosition.Y;
					boton.Top = 10 + (80 * botones.Count()) + Program.form1.panel1.AutoScrollPosition.Y;

					botones.Add(boton);
					Program.form1.panel1.Controls.Add(boton);
				} else if (botones.Count - 1 > actual) {
					Program.form1.panel1.Controls.RemoveAt(botones.Count() - 1);
					botones.RemoveAt(botones.Count() - 1);
				}
			});

			semaforo.WaitOne();
		}

		private void panel2_Paint(object sender, PaintEventArgs e) {
			e.Graphics.DrawString(">> " + consola, new Font("Consolas", 12), new SolidBrush(panel2.ForeColor), 10, 10);
		}

		private void panel1_Paint(object sender, PaintEventArgs e) {
			e.Graphics.DrawRectangle(
				new Pen(
					new SolidBrush(Color.White), 4), 2, 2, 292, 9000);
			e.Graphics.TranslateTransform(AutoScrollPosition.X, AutoScrollPosition.Y);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			hilo.Abort();
		}

		private void panel1_Scroll(object sender, ScrollEventArgs e) {
			Program.form1.panel1.Invalidate();
		}

		public static void cualquierBoton_Click(object sender, EventArgs e) {
			Button button = sender as Button;
			MessageBox.Show(button.Text);
			Program.form1.panel1.Focus();
		}
	}
}
