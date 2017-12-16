namespace PilaDeLlamadas {
	partial class Pila {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pila));
			this.header = new System.Windows.Forms.Panel();
			this.back = new System.Windows.Forms.PictureBox();
			this.close = new System.Windows.Forms.PictureBox();
			this.stackPanel = new System.Windows.Forms.Panel();
			this.stackLabel = new System.Windows.Forms.Label();
			this.continue0 = new System.Windows.Forms.Button();
			this.consoleLabel = new System.Windows.Forms.Label();
			this.consolePanel = new System.Windows.Forms.Panel();
			this.consoleLine = new System.Windows.Forms.Label();
			this.registrosLabel = new System.Windows.Forms.Label();
			this.registroPanel = new System.Windows.Forms.Panel();
			this.registrosT = new System.Windows.Forms.Label();
			this.registrosM = new System.Windows.Forms.Label();
			this.memoriaB = new System.Windows.Forms.Label();
			this.registrosA = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.header.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
			this.consolePanel.SuspendLayout();
			this.registroPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// header
			// 
			this.header.BackColor = System.Drawing.Color.DarkTurquoise;
			this.header.Controls.Add(this.back);
			this.header.Controls.Add(this.close);
			this.header.Dock = System.Windows.Forms.DockStyle.Top;
			this.header.Location = new System.Drawing.Point(0, 0);
			this.header.Name = "header";
			this.header.Size = new System.Drawing.Size(1024, 40);
			this.header.TabIndex = 14;
			this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.header_MouseMove);
			// 
			// back
			// 
			this.back.Dock = System.Windows.Forms.DockStyle.Left;
			this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
			this.back.Location = new System.Drawing.Point(0, 0);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(60, 40);
			this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.back.TabIndex = 6;
			this.back.TabStop = false;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// close
			// 
			this.close.Dock = System.Windows.Forms.DockStyle.Right;
			this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
			this.close.Location = new System.Drawing.Point(964, 0);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(60, 40);
			this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.close.TabIndex = 5;
			this.close.TabStop = false;
			this.close.Click += new System.EventHandler(this.close_Click);
			this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
			this.close.MouseHover += new System.EventHandler(this.close_MouseHover);
			this.close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.close_MouseMove);
			// 
			// stackPanel
			// 
			this.stackPanel.AutoScroll = true;
			this.stackPanel.Location = new System.Drawing.Point(679, 157);
			this.stackPanel.Margin = new System.Windows.Forms.Padding(20);
			this.stackPanel.Name = "stackPanel";
			this.stackPanel.Size = new System.Drawing.Size(316, 398);
			this.stackPanel.TabIndex = 15;
			this.stackPanel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.stackPanel_Scroll);
			this.stackPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.stackPanel_Paint);
			// 
			// stackLabel
			// 
			this.stackLabel.AutoSize = true;
			this.stackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stackLabel.ForeColor = System.Drawing.Color.White;
			this.stackLabel.Location = new System.Drawing.Point(675, 113);
			this.stackLabel.Name = "stackLabel";
			this.stackLabel.Size = new System.Drawing.Size(198, 24);
			this.stackLabel.TabIndex = 17;
			this.stackLabel.Text = "REPRESENTACIÓN";
			// 
			// continue0
			// 
			this.continue0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.continue0.Cursor = System.Windows.Forms.Cursors.Hand;
			this.continue0.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.continue0.Enabled = false;
			this.continue0.FlatAppearance.BorderSize = 0;
			this.continue0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.continue0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.continue0.ForeColor = System.Drawing.Color.White;
			this.continue0.Location = new System.Drawing.Point(0, 588);
			this.continue0.Name = "continue0";
			this.continue0.Size = new System.Drawing.Size(1024, 60);
			this.continue0.TabIndex = 19;
			this.continue0.Text = "CONTINUAR";
			this.continue0.UseVisualStyleBackColor = false;
			this.continue0.Click += new System.EventHandler(this.continue0_Click);
			// 
			// consoleLabel
			// 
			this.consoleLabel.AutoSize = true;
			this.consoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.consoleLabel.ForeColor = System.Drawing.Color.White;
			this.consoleLabel.Location = new System.Drawing.Point(25, 339);
			this.consoleLabel.Name = "consoleLabel";
			this.consoleLabel.Size = new System.Drawing.Size(109, 24);
			this.consoleLabel.TabIndex = 21;
			this.consoleLabel.Text = "CONSOLA";
			// 
			// consolePanel
			// 
			this.consolePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
			this.consolePanel.Controls.Add(this.consoleLine);
			this.consolePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
			this.consolePanel.Location = new System.Drawing.Point(29, 383);
			this.consolePanel.Margin = new System.Windows.Forms.Padding(20);
			this.consolePanel.Name = "consolePanel";
			this.consolePanel.Size = new System.Drawing.Size(610, 172);
			this.consolePanel.TabIndex = 20;
			// 
			// consoleLine
			// 
			this.consoleLine.AutoSize = true;
			this.consoleLine.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.consoleLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
			this.consoleLine.Location = new System.Drawing.Point(14, 17);
			this.consoleLine.Margin = new System.Windows.Forms.Padding(10);
			this.consoleLine.Name = "consoleLine";
			this.consoleLine.Size = new System.Drawing.Size(432, 19);
			this.consoleLine.TabIndex = 10;
			this.consoleLine.Text = ">> Presiona [Enter] para empezar la ejecución..";
			this.consoleLine.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// registrosLabel
			// 
			this.registrosLabel.AutoSize = true;
			this.registrosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.registrosLabel.ForeColor = System.Drawing.Color.White;
			this.registrosLabel.Location = new System.Drawing.Point(25, 113);
			this.registrosLabel.Name = "registrosLabel";
			this.registrosLabel.Size = new System.Drawing.Size(278, 24);
			this.registrosLabel.TabIndex = 25;
			this.registrosLabel.Text = "REGISTRO DE ACTIVACIÓN";
			// 
			// registroPanel
			// 
			this.registroPanel.Controls.Add(this.registrosT);
			this.registroPanel.Controls.Add(this.registrosM);
			this.registroPanel.Controls.Add(this.memoriaB);
			this.registroPanel.Controls.Add(this.registrosA);
			this.registroPanel.Controls.Add(this.label4);
			this.registroPanel.Controls.Add(this.label3);
			this.registroPanel.Controls.Add(this.label2);
			this.registroPanel.Controls.Add(this.label1);
			this.registroPanel.Location = new System.Drawing.Point(29, 157);
			this.registroPanel.Margin = new System.Windows.Forms.Padding(20);
			this.registroPanel.Name = "registroPanel";
			this.registroPanel.Size = new System.Drawing.Size(610, 162);
			this.registroPanel.TabIndex = 24;
			// 
			// registrosT
			// 
			this.registrosT.AutoSize = true;
			this.registrosT.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.registrosT.ForeColor = System.Drawing.Color.White;
			this.registrosT.Location = new System.Drawing.Point(482, 95);
			this.registrosT.Margin = new System.Windows.Forms.Padding(10);
			this.registrosT.Name = "registrosT";
			this.registrosT.Size = new System.Drawing.Size(108, 19);
			this.registrosT.TabIndex = 9;
			this.registrosT.Text = "0 registros";
			this.registrosT.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// registrosM
			// 
			this.registrosM.AutoSize = true;
			this.registrosM.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.registrosM.ForeColor = System.Drawing.Color.White;
			this.registrosM.Location = new System.Drawing.Point(482, 54);
			this.registrosM.Margin = new System.Windows.Forms.Padding(10);
			this.registrosM.Name = "registrosM";
			this.registrosM.Size = new System.Drawing.Size(108, 19);
			this.registrosM.TabIndex = 8;
			this.registrosM.Text = "0 registros";
			this.registrosM.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// memoriaB
			// 
			this.memoriaB.AutoSize = true;
			this.memoriaB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.memoriaB.ForeColor = System.Drawing.Color.White;
			this.memoriaB.Location = new System.Drawing.Point(518, 133);
			this.memoriaB.Margin = new System.Windows.Forms.Padding(10);
			this.memoriaB.Name = "memoriaB";
			this.memoriaB.Size = new System.Drawing.Size(72, 19);
			this.memoriaB.TabIndex = 7;
			this.memoriaB.Text = "0 bytes";
			this.memoriaB.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// registrosA
			// 
			this.registrosA.AutoSize = true;
			this.registrosA.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.registrosA.ForeColor = System.Drawing.Color.White;
			this.registrosA.Location = new System.Drawing.Point(482, 13);
			this.registrosA.Margin = new System.Windows.Forms.Padding(10);
			this.registrosA.Name = "registrosA";
			this.registrosA.Size = new System.Drawing.Size(108, 19);
			this.registrosA.TabIndex = 4;
			this.registrosA.Text = "0 registros";
			this.registrosA.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
			this.label4.Location = new System.Drawing.Point(10, 133);
			this.label4.Margin = new System.Windows.Forms.Padding(10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(243, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Memoria necesaria actualmente: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
			this.label3.Location = new System.Drawing.Point(10, 93);
			this.label3.Margin = new System.Windows.Forms.Padding(10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(229, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Registros de activación totales:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
			this.label2.Location = new System.Drawing.Point(10, 53);
			this.label2.Margin = new System.Windows.Forms.Padding(10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(243, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Registros de activación máximos:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
			this.label1.Location = new System.Drawing.Point(10, 13);
			this.label1.Margin = new System.Windows.Forms.Padding(10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(241, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Registros de activación actuales:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(440, 69);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(216, 26);
			this.label5.TabIndex = 26;
			this.label5.Text = "CAMBIO DE BASE";
			// 
			// Pila
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1024, 648);
			this.ControlBox = false;
			this.Controls.Add(this.label5);
			this.Controls.Add(this.registrosLabel);
			this.Controls.Add(this.registroPanel);
			this.Controls.Add(this.consoleLabel);
			this.Controls.Add(this.consolePanel);
			this.Controls.Add(this.continue0);
			this.Controls.Add(this.stackLabel);
			this.Controls.Add(this.stackPanel);
			this.Controls.Add(this.header);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "Pila";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pila_FormClosing);
			this.Load += new System.EventHandler(this.Pila_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pila_KeyPress);
			this.header.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
			this.consolePanel.ResumeLayout(false);
			this.consolePanel.PerformLayout();
			this.registroPanel.ResumeLayout(false);
			this.registroPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel header;
		private System.Windows.Forms.Panel stackPanel;
		private System.Windows.Forms.Label stackLabel;
		private System.Windows.Forms.Button continue0;
		private System.Windows.Forms.Label consoleLabel;
		private System.Windows.Forms.Panel consolePanel;
		private System.Windows.Forms.PictureBox close;
		private System.Windows.Forms.PictureBox back;
		private System.Windows.Forms.Label registrosLabel;
		private System.Windows.Forms.Panel registroPanel;
		private System.Windows.Forms.Label memoriaB;
		private System.Windows.Forms.Label registrosA;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label consoleLine;
		private System.Windows.Forms.Label registrosT;
		private System.Windows.Forms.Label registrosM;
		private System.Windows.Forms.Label label5;
	}
}