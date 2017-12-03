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
	public class Registros{

		int Maximo;
		int Actual;
		int Total;
		int bytes;
		string Frase;

		public Registros(int m, int a, int t, int b, string f){
			Maximo = m;
			Actual = a;
			Total = t;
			bytes = b;
			Frase = f;
		}
	}

	public partial class Form1 : Form {
		public static Thread hilo;
		public static ManualResetEvent semaforo;
		public static List<Button> botones = new List<Button>();
		public static List<Registros> stack = new List<Registros>();
		
		public static string consola = "";

		public Form1() {
			semaforo = new ManualResetEvent(false);
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			consola = "Presiona [Enter] para empezar la ejecución...";
			int ref1 = 0;
			int ref2 = 1;

			panel2.Refresh();
			ThreadStart starter = () => {
				int retorno = Funciones.NodosBiarbol(4, 4, ref ref1, ref ref2, 0);
				consola = "La función terminó retornando " + retorno;
				botones.Clear();

				Program.form1.Invoke((Action)delegate {
					Program.form1.panel1.Controls.RemoveAt(botones.Count());
					Program.form1.panel2.Refresh();
				});
			};
			hilo = new Thread(starter); 
			hilo.Start();
		}

		private void Form1_KeyPress(object sender, KeyPressEventArgs e) {
			semaforo.Set();
		}


		public static void Imprimir(ref int total, ref int max, int actual, string frase) {
			if(actual > max){
				max = actual;
			}

			Button boton = new Button();
			boton.Left = 10;
			boton.Width = 276;
			boton.Height = 75;
			boton.Font = new Font("Consolas", 12, FontStyle.Bold);
			boton.ForeColor = Color.White;
			boton.BackColor = Color.FromArgb(140, 191, 204);
			boton.FlatStyle = FlatStyle.Flat;
			boton.FlatAppearance.BorderSize = 0;
			boton.Text = frase;
			
			Registros nuevo = new Registros(max, actual, total, 0, frase);

			consola = "Se está ejecutando la función, presione [Enter]";

			semaforo.Reset();

			Program.form1.Invoke((Action) delegate{
				if (botones.Count - 1 < actual) {
					boton.Text = frase;
					stack.Add(nuevo);
					// boton.Top = 490 - 90 - (80 * botones.Count()) + Program.form1.panel1.AutoScrollPosition.Y;
					boton.Top = 10 + (80 * botones.Count()) + Program.form1.panel1.AutoScrollPosition.Y;

					botones.Add(boton);
					Program.form1.panel1.Controls.Add(boton);
				} else if (botones.Count - 1 > actual) {
					Program.form1.panel1.Controls.RemoveAt(botones.Count() - 1);
					botones.RemoveAt(botones.Count() - 1);
					stack.RemoveAt(stack.Count() - 1);
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
					new SolidBrush(Color.White), 4), 2, 2, 292, 500);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			hilo.Abort();
		}

		private void panel1_Scroll(object sender, ScrollEventArgs e) {
			this.Invalidate();
		}
	}
}
