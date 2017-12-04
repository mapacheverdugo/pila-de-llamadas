namespace PilaDeLlamadas
{
    partial class Main
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
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.header = new System.Windows.Forms.Panel();
			this.title = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.cambio = new System.Windows.Forms.Button();
			this.piramide = new System.Windows.Forms.Button();
			this.wallis = new System.Windows.Forms.Button();
			this.biarbol = new System.Windows.Forms.Button();
			this.personas = new System.Windows.Forms.Button();
			this.functionsPanel = new System.Windows.Forms.Panel();
			this.inputPanel = new System.Windows.Forms.Panel();
			this.parameter1 = new System.Windows.Forms.Label();
			this.parameter2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.run = new System.Windows.Forms.Button();
			this.functionDescription = new System.Windows.Forms.TextBox();
			this.functionLabel = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.close = new System.Windows.Forms.PictureBox();
			this.header.SuspendLayout();
			this.functionsPanel.SuspendLayout();
			this.inputPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// header
			// 
			this.header.BackColor = System.Drawing.Color.DarkTurquoise;
			this.header.Controls.Add(this.close);
			this.header.Controls.Add(this.title);
			this.header.Dock = System.Windows.Forms.DockStyle.Top;
			this.header.Location = new System.Drawing.Point(0, 0);
			this.header.Name = "header";
			this.header.Size = new System.Drawing.Size(1024, 40);
			this.header.TabIndex = 13;
			this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.header_MouseMove);
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title.ForeColor = System.Drawing.Color.White;
			this.title.Location = new System.Drawing.Point(12, 12);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(368, 17);
			this.title.TabIndex = 4;
			this.title.Text = "Pila de llamadas | Universidad Tecnológica Metropolitana";
			this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_MouseMove);
			// 
			// cambio
			// 
			this.cambio.BackColor = System.Drawing.Color.DarkTurquoise;
			this.cambio.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cambio.FlatAppearance.BorderSize = 0;
			this.cambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cambio.ForeColor = System.Drawing.Color.White;
			this.cambio.Location = new System.Drawing.Point(0, 0);
			this.cambio.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
			this.cambio.Name = "cambio";
			this.cambio.Size = new System.Drawing.Size(440, 60);
			this.cambio.TabIndex = 20;
			this.cambio.Text = "Cambio de base";
			this.cambio.UseVisualStyleBackColor = false;
			this.cambio.Click += new System.EventHandler(this.cambio_Click);
			// 
			// piramide
			// 
			this.piramide.BackColor = System.Drawing.Color.DarkTurquoise;
			this.piramide.Cursor = System.Windows.Forms.Cursors.Hand;
			this.piramide.FlatAppearance.BorderSize = 0;
			this.piramide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.piramide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.piramide.ForeColor = System.Drawing.Color.White;
			this.piramide.Location = new System.Drawing.Point(0, 80);
			this.piramide.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
			this.piramide.Name = "piramide";
			this.piramide.Size = new System.Drawing.Size(440, 60);
			this.piramide.TabIndex = 27;
			this.piramide.Text = "Pirámide de esferas";
			this.piramide.UseVisualStyleBackColor = false;
			this.piramide.Click += new System.EventHandler(this.piramide_Click);
			// 
			// wallis
			// 
			this.wallis.BackColor = System.Drawing.Color.DarkTurquoise;
			this.wallis.Cursor = System.Windows.Forms.Cursors.Hand;
			this.wallis.FlatAppearance.BorderSize = 0;
			this.wallis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.wallis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.wallis.ForeColor = System.Drawing.Color.White;
			this.wallis.Location = new System.Drawing.Point(0, 320);
			this.wallis.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
			this.wallis.Name = "wallis";
			this.wallis.Size = new System.Drawing.Size(440, 60);
			this.wallis.TabIndex = 28;
			this.wallis.Text = "Producto de Wallis";
			this.wallis.UseVisualStyleBackColor = false;
			this.wallis.Click += new System.EventHandler(this.wallis_Click);
			// 
			// biarbol
			// 
			this.biarbol.BackColor = System.Drawing.Color.DarkTurquoise;
			this.biarbol.Cursor = System.Windows.Forms.Cursors.Hand;
			this.biarbol.FlatAppearance.BorderSize = 0;
			this.biarbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.biarbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.biarbol.ForeColor = System.Drawing.Color.White;
			this.biarbol.Location = new System.Drawing.Point(0, 160);
			this.biarbol.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
			this.biarbol.Name = "biarbol";
			this.biarbol.Size = new System.Drawing.Size(440, 60);
			this.biarbol.TabIndex = 28;
			this.biarbol.Text = "Nodos de un bi-árbol binario";
			this.biarbol.UseVisualStyleBackColor = false;
			this.biarbol.Click += new System.EventHandler(this.biarbol_Click);
			// 
			// personas
			// 
			this.personas.BackColor = System.Drawing.Color.DarkTurquoise;
			this.personas.Cursor = System.Windows.Forms.Cursors.Hand;
			this.personas.FlatAppearance.BorderSize = 0;
			this.personas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.personas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.personas.ForeColor = System.Drawing.Color.White;
			this.personas.Location = new System.Drawing.Point(0, 240);
			this.personas.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
			this.personas.Name = "personas";
			this.personas.Size = new System.Drawing.Size(440, 60);
			this.personas.TabIndex = 29;
			this.personas.Text = "Grupos de personas";
			this.personas.UseVisualStyleBackColor = false;
			this.personas.Click += new System.EventHandler(this.personas_Click);
			// 
			// functionsPanel
			// 
			this.functionsPanel.Controls.Add(this.cambio);
			this.functionsPanel.Controls.Add(this.personas);
			this.functionsPanel.Controls.Add(this.piramide);
			this.functionsPanel.Controls.Add(this.biarbol);
			this.functionsPanel.Controls.Add(this.wallis);
			this.functionsPanel.Location = new System.Drawing.Point(529, 107);
			this.functionsPanel.Name = "functionsPanel";
			this.functionsPanel.Size = new System.Drawing.Size(441, 380);
			this.functionsPanel.TabIndex = 30;
			// 
			// inputPanel
			// 
			this.inputPanel.Controls.Add(this.parameter1);
			this.inputPanel.Controls.Add(this.parameter2);
			this.inputPanel.Controls.Add(this.panel2);
			this.inputPanel.Controls.Add(this.panel1);
			this.inputPanel.Controls.Add(this.run);
			this.inputPanel.Controls.Add(this.functionDescription);
			this.inputPanel.Controls.Add(this.functionLabel);
			this.inputPanel.Location = new System.Drawing.Point(529, 107);
			this.inputPanel.Name = "inputPanel";
			this.inputPanel.Size = new System.Drawing.Size(439, 380);
			this.inputPanel.TabIndex = 31;
			this.inputPanel.Visible = false;
			// 
			// parameter1
			// 
			this.parameter1.AutoSize = true;
			this.parameter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.parameter1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
			this.parameter1.Location = new System.Drawing.Point(-4, 102);
			this.parameter1.Name = "parameter1";
			this.parameter1.Size = new System.Drawing.Size(142, 20);
			this.parameter1.TabIndex = 10;
			this.parameter1.Text = "Ingrese el entero n";
			// 
			// parameter2
			// 
			this.parameter2.AutoSize = true;
			this.parameter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.parameter2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
			this.parameter2.Location = new System.Drawing.Point(-4, 206);
			this.parameter2.Name = "parameter2";
			this.parameter2.Size = new System.Drawing.Size(142, 20);
			this.parameter2.TabIndex = 8;
			this.parameter2.Text = "Ingrese el entero n";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Location = new System.Drawing.Point(0, 140);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(442, 48);
			this.panel2.TabIndex = 11;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ForeColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(15, 11);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(401, 28);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Location = new System.Drawing.Point(0, 240);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(442, 48);
			this.panel1.TabIndex = 9;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.ForeColor = System.Drawing.Color.White;
			this.textBox2.Location = new System.Drawing.Point(15, 11);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(401, 28);
			this.textBox2.TabIndex = 1;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// run
			// 
			this.run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(206)))), ((int)(((byte)(113)))));
			this.run.Cursor = System.Windows.Forms.Cursors.Hand;
			this.run.FlatAppearance.BorderSize = 0;
			this.run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.run.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.run.ForeColor = System.Drawing.Color.White;
			this.run.Location = new System.Drawing.Point(0, 320);
			this.run.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
			this.run.Name = "run";
			this.run.Size = new System.Drawing.Size(439, 60);
			this.run.TabIndex = 26;
			this.run.Text = "EJECUTAR";
			this.run.UseVisualStyleBackColor = false;
			this.run.Click += new System.EventHandler(this.run_Click);
			// 
			// functionDescription
			// 
			this.functionDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
			this.functionDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.functionDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.functionDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
			this.functionDescription.Location = new System.Drawing.Point(0, 38);
			this.functionDescription.Multiline = true;
			this.functionDescription.Name = "functionDescription";
			this.functionDescription.ReadOnly = true;
			this.functionDescription.Size = new System.Drawing.Size(439, 61);
			this.functionDescription.TabIndex = 4;
			// 
			// functionLabel
			// 
			this.functionLabel.AutoSize = true;
			this.functionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.functionLabel.ForeColor = System.Drawing.Color.White;
			this.functionLabel.Location = new System.Drawing.Point(-4, 0);
			this.functionLabel.Margin = new System.Windows.Forms.Padding(20, 0, 3, 10);
			this.functionLabel.Name = "functionLabel";
			this.functionLabel.Size = new System.Drawing.Size(201, 24);
			this.functionLabel.TabIndex = 25;
			this.functionLabel.Text = "PILA DE LLAMADAS";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.pictureBox2);
			this.panel3.Location = new System.Drawing.Point(60, 106);
			this.panel3.Margin = new System.Windows.Forms.Padding(20);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(429, 381);
			this.panel3.TabIndex = 32;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::PilaDeLlamadas.Properties.Resources.utem;
			this.pictureBox2.Location = new System.Drawing.Point(3, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(258, 67);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = global::PilaDeLlamadas.Properties.Resources.github;
			this.pictureBox1.Location = new System.Drawing.Point(495, 562);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(50, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 16;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// close
			// 
			this.close.Dock = System.Windows.Forms.DockStyle.Right;
			this.close.Image = global::PilaDeLlamadas.Properties.Resources.letter_x;
			this.close.Location = new System.Drawing.Point(964, 0);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(60, 40);
			this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.close.TabIndex = 6;
			this.close.TabStop = false;
			this.close.Click += new System.EventHandler(this.close_Click);
			this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
			this.close.MouseHover += new System.EventHandler(this.close_MouseHover);
			this.close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.close_MouseMove);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1024, 648);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.inputPanel);
			this.Controls.Add(this.functionsPanel);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.header);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pila de llamadas | Lenguajes de programación";
			this.Load += new System.EventHandler(this.Main_Load);
			this.header.ResumeLayout(false);
			this.header.PerformLayout();
			this.functionsPanel.ResumeLayout(false);
			this.inputPanel.ResumeLayout(false);
			this.inputPanel.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Panel header;
		private System.Windows.Forms.Label title;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button cambio;
		private System.Windows.Forms.Button piramide;
		private System.Windows.Forms.Button wallis;
		private System.Windows.Forms.Button biarbol;
		private System.Windows.Forms.Button personas;
		private System.Windows.Forms.Panel functionsPanel;
		private System.Windows.Forms.Panel inputPanel;
		private System.Windows.Forms.Label parameter1;
		private System.Windows.Forms.Label parameter2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button run;
		private System.Windows.Forms.TextBox functionDescription;
		private System.Windows.Forms.Label functionLabel;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox close;
	}
}

