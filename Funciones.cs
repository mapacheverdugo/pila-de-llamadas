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
		/*
		static int PiramideDeEsferas(int n, ref int Max, ref int Total, int Actual) {
			Total++;
			Imprimir(ref Max, Total, Actual);
			if (n == 1) {
				return 1;
			} else {
				int aux = (n * n + PiramideDeEsferas(n - 1, ref Max, ref Total, Actual + 1));
				Imprimir(ref Max, Total, Actual);
				return aux;
			}
		}*/

		public static int NodosBiarbol(int i, int j, int max, int total, int actual) {
			total++;
			Form1.Imprimir(total, max, actual, "NodosBiarbol(" + i + ", " + j + ")");
			if (i == 0 || j == 0) {
				return 1;
			} else {
				int aux1 = NodosBiarbol(i - 1, j, max, total, actual + 1);
				Form1.Imprimir(total, max, actual, "NodosBiarbol(" + i + ", " + j + ")");

				int aux2 = NodosBiarbol(i, j - 1, max, total, actual + 1);
				Form1.Imprimir(total, max, actual, "NodosBiarbol(" + i + ", " + j + ")");
				return aux1 + 1 + aux2;
			}
		}
		/*

		static int GruposDePersonas(int n, int k, ref int max, ref int total, int actual) {
			total++;
			Imprimir(ref max, total, actual);
			if (k > n) {
				return 0;
			} else if (k == 1) {
				return n;
			} else {
				int aux1 = GruposDePersonas(n - 1, k, ref max, ref total, actual + 1);
				Imprimir(ref max, total, actual);
				int aux2 = GruposDePersonas(n - 1, k - 1, ref max, ref total, actual + 1);
				Imprimir(ref max, total, actual);
				return (aux1 + aux2);
			}
		}

		static float ProductoDeWallis(float n, ref int max, ref int total, int actual) {
			total++;
			Imprimir(ref max, total, actual);
			if (n == 0) {
				return 1;
			} else {
				if ((n % 2) == 0) {
					float aux1 = ProductoDeWallis(n - 1, ref max, ref total, actual + 1);
					Imprimir(ref max, total, actual);
					return ((n / (n + 1)) * aux1);
				} else {
					float aux2 = ProductoDeWallis(n - 1, ref max, ref total, actual + 1);
					Imprimir(ref max, total, actual);
					return (((n + 1) / n) * aux2);
				}
			}
		}*/
	}
}
