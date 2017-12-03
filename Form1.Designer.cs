namespace PilaDeLlamadas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.panel1.AutoScroll = true;
			this.panel1.Location = new System.Drawing.Point(656, 80);
			this.panel1.Margin = new System.Windows.Forms.Padding(20, 20, 10, 20);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(323, 500);
			this.panel1.TabIndex = 0;
			this.panel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel1_Scroll);
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(67)))), ((int)(((byte)(80)))));
			this.panel2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(202)))), ((int)(((byte)(216)))));
			this.panel2.Location = new System.Drawing.Point(29, 330);
			this.panel2.Margin = new System.Windows.Forms.Padding(20, 10, 20, 20);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(20);
			this.panel2.Size = new System.Drawing.Size(604, 250);
			this.panel2.TabIndex = 7;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(650, 29);
			this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(307, 31);
			this.label1.TabIndex = 8;
			this.label1.Text = "REPRESENTACIÓN DE LA PILA";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(23, 289);
			this.label2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 31);
			this.label2.TabIndex = 9;
			this.label2.Text = "CONSOLA";
			// 
			// panel3
			// 
			this.panel3.Location = new System.Drawing.Point(29, 80);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(604, 186);
			this.panel3.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(23, 29);
			this.label3.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(387, 31);
			this.label3.TabIndex = 11;
			this.label3.Text = "DATOS DEL REGISTRO DE ACTIVACIÓN";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1008, 609);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pila de llamadas | Lenguajes de programación";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label3;
	}
}

