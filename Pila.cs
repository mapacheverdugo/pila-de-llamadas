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
	public partial class Pila : Form {

		Main principal;
		int funcion;

		public static Thread hilo;
		public static ManualResetEvent semaforo = new ManualResetEvent(false);
		public static List<Button> botones = new List<Button>();
		public static List<RegistroDeActivacion> stack = new List<RegistroDeActivacion>();
		public static int RegistrosTotales = 0;
		public static int RegistrosMaximos = 0;
		public static int Memoria = 0;
		private static int A = 0;
		private static int B = 0;

		// Código necesario para poder hacer drag a la aplicación
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();
		// --------------------------------------------------------

		public Pila(Main p, int f, int a) {
			InitializeComponent();
			principal = p;
			funcion = f;
			A = a;
		}

		public Pila(Main p, int f, int a, int b) {
			InitializeComponent();
			principal = p;
			funcion = f;
			A = a;
			B = b;
		}

		public static void Imprimir(ref int total, ref int max, int actual, int elementos, string frase) {
			if (actual > max) {
				max = actual;
			}

			Button boton = new Button();
			boton.Left = 10;
			boton.Width = 276;
			boton.Height = 40;
			boton.Font = new Font("Consolas", 12, FontStyle.Bold);
			boton.ForeColor = Color.White;
			boton.BackColor = Color.FromArgb(140, 191, 204);
			boton.FlatStyle = FlatStyle.Flat;
			boton.FlatAppearance.BorderSize = 0;
			boton.Text = frase;

			RegistroDeActivacion nuevo = new RegistroDeActivacion(max, actual, total, elementos, frase);

			semaforo.Reset();

			Program.form1.Invoke((Action)delegate {
				Program.form1.ventana.consoleLine.Text = "Se está ejecutando la función, presione [Enter]";
				if (botones.Count < actual) {
					boton.Text = frase;
					stack.Add(nuevo);
					// boton.Top = 490 - 90 - (80 * botones.Count()) + Program.form1.panel1.AutoScrollPosition.Y;
					boton.Top = 10 + (45 * botones.Count()) + Program.form1.ventana.stackPanel.AutoScrollPosition.Y;

					botones.Add(boton);
					Program.form1.ventana.stackPanel.Controls.Add(boton);
				} else if (botones.Count > actual) {
					Program.form1.ventana.stackPanel.Controls.RemoveAt(botones.Count() - 1);
					botones.RemoveAt(botones.Count() - 1);
					stack.RemoveAt(stack.Count() - 1);
				}
				Program.form1.ventana.registrosA.Text = stack.Last().Actual + " registros";
				Program.form1.ventana.registrosM.Text = RegistrosMaximos + " registros";
				Program.form1.ventana.registrosT.Text = RegistrosTotales + " registros";
				Program.form1.ventana.memoriaB.Text = (stack.Last().Bytes * RegistrosMaximos * 4) + " bytes";
			});

			semaforo.WaitOne();
		}

		private void Pila_FormClosing(object sender, FormClosingEventArgs e) {
			hilo.Abort();
		}

		private void back_Click(object sender, EventArgs e) {
			Close(); // Cierro esta ventana
			principal.Show(); // Desoculto la ventana principal
		}

		private void Pila_KeyPress(object sender, KeyPressEventArgs e) {
			Focus();
			semaforo.Set();
		}

		private void stackPanel_Paint(object sender, PaintEventArgs e) {
			e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.White), 4), 2, 2, 292, 9000);
			e.Graphics.TranslateTransform(AutoScrollPosition.X, AutoScrollPosition.Y);
		}

		private void stackPanel_Scroll(object sender, ScrollEventArgs e) {
			stackPanel.Invalidate();
		}

		private void Pila_Load(object sender, EventArgs e) {
			ThreadStart f = () => {
				RegistrosTotales = 0;
				RegistrosMaximos = 0;
				Memoria = 0;

				semaforo.Reset();
				semaforo.WaitOne();

				float retorno = 0;
				switch (funcion) {
					case 1:
						retorno = Funciones.CambioDeBase(A, B, ref RegistrosMaximos, ref RegistrosTotales, 1);
						break;
					case 2:
						retorno = Funciones.PiramideDeEsferas(A, ref RegistrosMaximos, ref RegistrosTotales, 1);
						break;
					case 3:
						retorno = Funciones.NodosBiarbol(A, B, ref RegistrosMaximos, ref RegistrosTotales, 1);
						break;
					case 4:
						retorno = Funciones.GruposDePersonas(A, B, ref RegistrosMaximos, ref RegistrosTotales, 1);
						break;
					case 5:
						retorno = Funciones.ProductoDeWallis(A, ref RegistrosMaximos, ref RegistrosTotales, 1);
						break;
				}
				
				botones.Clear();

				Program.form1.Invoke((Action)delegate {
					Program.form1.ventana.stackPanel.Controls.RemoveAt(botones.Count());
					Program.form1.ventana.consoleLine.Text = ">> La función terminó retornando " + retorno;
					Program.form1.ventana.consolePanel.Refresh();
					Program.form1.ventana.continue0.Enabled = true;
					Program.form1.ventana.continue0.BackColor = Color.FromArgb(132, 206, 113);
					Program.form1.ventana.registrosA.Text = "0 registros";
					Program.form1.ventana.registrosM.Text = RegistrosMaximos + " registros";
					Program.form1.ventana.registrosT.Text = RegistrosTotales + " registros";
					Program.form1.ventana.memoriaB.Text = (stack.Last().Bytes * RegistrosMaximos * 4) + " bytes";
				});
			};
			hilo = new Thread(f);
			hilo.Start();
		}

		private void close_MouseHover(object sender, EventArgs e) {
			close.BackColor = Color.Tomato;
		}

		private void close_MouseMove(object sender, MouseEventArgs e) {
			close.BackColor = Color.Tomato;
		}

		private void close_MouseLeave(object sender, EventArgs e) {
			close.BackColor = Color.DarkTurquoise;
		}

		private void continue0_Click(object sender, EventArgs e) {
			Close(); // Cierro esta ventana
			principal.Show(); // Desoculto la ventana principal
		}

		private void close_Click(object sender, EventArgs e) {
			Application.Exit(); // Cierro la aplicación
		}

		private void header_MouseMove(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Left) {
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
	}
}
