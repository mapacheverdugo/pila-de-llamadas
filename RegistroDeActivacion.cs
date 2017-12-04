using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaDeLlamadas {
	public class RegistroDeActivacion {
		public int Maximo;
		public int Actual;
		public int Total;
		public int Bytes;
		public string Frase;

		public RegistroDeActivacion(int m, int a, int t, int b, string f) {
			Maximo = m;
			Actual = a;
			Total = t;
			Bytes = b;
			Frase = f;
		}
	}
}
