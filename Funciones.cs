﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaDeLlamadas {
	public partial class Funciones {

		public static int CambioDeBase(int n, int b, int Max, int Total, int Actual) {
			Form1.Imprimir(Total, Max, Actual, "CambioDeBase(" + n + ", " + b + ")");
			if (n / 10 == 0) {
				return n;
			} else {
				int aux = CambioDeBase(n / 10, b, Max, Total + 1, Actual + 1);
				Form1.Imprimir(Total, Max, Actual, "CambioDeBase(" + n + ", " + b + ")");
				return aux * b + n - n / 10 * 10;
			}
		}

		public static int PiramideDeEsferas(int n, int Max, int Total, int Actual) {
			Form1.Imprimir(Total, Max, Actual, "PiramideDeEsferas(" + n + ")");
			if (n == 1) {
				return 1;
			} else {
				int aux = (n * n + PiramideDeEsferas(n - 1, Max, Total + 1, Actual + 1));
				Form1.Imprimir(Total, Max, Actual, "PriamideDeEsferas(" + n + ")");
				return aux;
			}
		}

		public static int NodosBiarbol(int i, int j, int max, int total, int actual) {
			total++;
			Form1.Imprimir(total, max, actual, "NodosBiarbol(" + i + ", " + j + ")");
			if (i == 0 || j == 0) {
				return 1;
			} else {
				int aux1 = NodosBiarbol(i - 1, j, max, total + 1, actual + 1);
				Form1.Imprimir(total, max, actual, "NodosBiarbol(" + i + ", " + j + ")");

				int aux2 = NodosBiarbol(i, j - 1, max, total + 1, actual + 1);
				Form1.Imprimir(total, max, actual, "NodosBiarbol(" + i + ", " + j + ")");
				return aux1 + 1 + aux2;
			}
		}

		public static int GruposDePersonas(int n, int k, int max, int total, int actual) {
			Form1.Imprimir(total, max, actual, "GruposDePersonas(" + n + ", " + k + ")");
			if (k > n) {
				return 0;
			} else if (k == 1) {
				return n;
			} else {
				int aux1 = GruposDePersonas(n - 1, k, max, total + 1, actual + 1);
				Form1.Imprimir(total, max, actual, "GruposDePersonas(" + n + ", " + k + ")");
				int aux2 = GruposDePersonas(n - 1, k - 1, max, total + 1, actual + 1);
				Form1.Imprimir(total, max, actual, "GruposDePersonas(" + n + ", " + k + ")");
				return (aux1 + aux2);
			}
		}

		public static float ProductoDeWallis(float n, int max, int total, int actual) {
			Form1.Imprimir(total, max, actual, "ProductoDeWallis(" + n + ")");
			if (n == 0) {
				return 1;
			} else {
				if ((n % 2) == 0) {
					float aux1 = ProductoDeWallis(n - 1, max, total + 1, actual + 1);
					Form1.Imprimir(total, max, actual, "ProductoDeWallis(" + n + ")");
					return ((n / (n + 1)) * aux1);
				} else {
					float aux2 = ProductoDeWallis(n - 1, max, total + 1, actual + 1);
					Form1.Imprimir(total, max, actual, "ProductoDeWallis(" + n + ")");
					return (((n + 1) / n) * aux2);
				}
			}
		}
	}
}
