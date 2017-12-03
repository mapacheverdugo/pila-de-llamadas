using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilaDeLlamadas {

	static class Program {

		/// <summary>
		/// Punto de entrada principal para la aplicación.
		/// </summary>
		// [STAThread]
		public static Form1 form1 = new Form1();

		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			//Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(form1);
		}
	}
}
