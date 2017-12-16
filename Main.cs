using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace PilaDeLlamadas {
	public partial class Main : Form {
		public int funcion = 0;
		private int p1 = 0;
		private int p2 = 0;
		// Código necesario para poder hacer drag a la aplicación
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();
		// --------------------------------------------------------

		public Pila ventana;

		public Main() {
			InitializeComponent();
		}

		private void close_Click(object sender, EventArgs e) {
			Application.Exit(); // Cerrar al hacer click en el botón close
		}

		// Código necesario para poder hacer drag a la aplicación
		private void header_MouseMove(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Left) {
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void title_MouseMove(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Left) {
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
		// --------------------------------------------------------

		private void Main_Load(object sender, EventArgs e) {

		}

		private void cambio_Click(object sender, EventArgs e) {
			funcion = 1;
			functionsPanel.Hide();
			inputPanel.Show();
			functionLabel.Text = "CAMBIO DE BASE";
			functionDescription.Text = "Convierte un entero no negativo n, expresado en una base b menor o igual a 9, a su equivalente numérico en base 10";
			parameter1.Text = "Ingrese el entero n";
			parameter2.Text = "Ingrese la base b";
			textBox1.Text = "" + 4210321;
			textBox2.Text = "" + 5;
		}

		private void piramide_Click(object sender, EventArgs e) {
			funcion = 2;
			functionsPanel.Hide();
			inputPanel.Show();
			functionLabel.Text = "PIRÁMIDE DE ESFERAS";
			functionDescription.Text = "Determina la cantidad de esferas de acero necesarias para construir una pirámide de base cuadrada y n niveles";
			parameter1.Text = "Ingrese el entero n";
			parameter2.Hide();
			textBox2.Hide();
			panel1.Hide();
			textBox1.Text = "" + 9;
		}

		private void biarbol_Click(object sender, EventArgs e) {
			funcion = 3;
			functionsPanel.Hide();
			inputPanel.Show();
			functionLabel.Text = "NODOS BI-ÁRBOL BINARIO";
			functionDescription.Text = "Determinar el número de nodos de un bi-árbol binario";
			parameter1.Text = "Ingrese los niveles del primer árbol";
			parameter2.Text = "Ingrese los niveles del segundo árbol";
			textBox1.Text = "" + 4;
			textBox2.Text = "" + 4;
		}

		private void personas_Click(object sender, EventArgs e) {
			funcion = 4;
			functionsPanel.Hide();
			inputPanel.Show();
			functionLabel.Text = "GRUPO DE PERSONAS";
			functionDescription.Text = "Obtiene la cantidad total de grupos diferentes de k personas que es posible formar con n personas";
			parameter1.Text = "Ingrese el entero n";
			parameter2.Text = "Ingrese el entero k";
			textBox1.Text = "" + 6;
			textBox2.Text = "" + 3;

		}

		private void wallis_Click(object sender, EventArgs e) {
			funcion = 5;
			functionsPanel.Hide();
			inputPanel.Show();
			functionLabel.Text = "PRODUCTO DE WALLIS";
			functionDescription.Text = "Obtener el producto de Wallis con n iteraciones, cuando n → ∞ el resultado es π/2";
			parameter1.Text = "Ingrese el entero n";
			parameter2.Hide();
			textBox2.Hide();
			panel1.Hide();
			textBox1.Text = "" + 20;
		}

		private void pictureBox1_Click(object sender, EventArgs e) {
			Process.Start("https://github.com/mapacheverdugo/pila-de-llamadas/");
		}

		private void run_Click(object sender, EventArgs e) {
			parameter2.Show();
			textBox2.Show();
			p1 = Int32.Parse(textBox1.Text);
			p2 = Int32.Parse(textBox2.Text);
			panel1.Show();
			functionsPanel.Show();
			inputPanel.Hide();
			Hide(); // Ocultar el menú principal
			ventana = new Pila(this, funcion, p1, p2); // Declaro la nueva ventana
			ventana.ShowDialog(); // Abro esa ventana
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
	}
}
