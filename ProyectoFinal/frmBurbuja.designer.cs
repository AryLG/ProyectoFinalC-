using System;

namespace Burbuja
{
    partial class frmBurbuja
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarDatos = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.txtn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTiempoGenerar = new System.Windows.Forms.Label();
            this.lblTiempoOrdenar = new System.Windows.Forms.Label();
            this.btnOrdenar2 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbComparaciones = new System.Windows.Forms.Label();
            this.lblntercambios = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPasadas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(37, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "N:\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGenerarDatos
            // 
            this.btnGenerarDatos.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnGenerarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerarDatos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGenerarDatos.Location = new System.Drawing.Point(144, 117);
            this.btnGenerarDatos.Name = "btnGenerarDatos";
            this.btnGenerarDatos.Size = new System.Drawing.Size(96, 23);
            this.btnGenerarDatos.TabIndex = 3;
            this.btnGenerarDatos.Text = "GENERAR\r\n";
            this.btnGenerarDatos.UseVisualStyleBackColor = false;
            this.btnGenerarDatos.Click += new System.EventHandler(this.BtnGenerarDatos_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrdenar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOrdenar.Location = new System.Drawing.Point(246, 115);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(140, 27);
            this.btnOrdenar.TabIndex = 4;
            this.btnOrdenar.Text = "ASCENDENTE\r\n";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(144, 148);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(96, 234);
            this.listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.Color.White;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Location = new System.Drawing.Point(246, 148);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(140, 234);
            this.listBox2.TabIndex = 6;
            // 
            // txtn
            // 
            this.txtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.txtn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtn.ForeColor = System.Drawing.Color.White;
            this.txtn.Location = new System.Drawing.Point(61, 117);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(77, 19);
            this.txtn.TabIndex = 0;
            this.txtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tiempo de ejecuccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Generar Datos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 492);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ordenar:";
            // 
            // lblTiempoGenerar
            // 
            this.lblTiempoGenerar.AutoSize = true;
            this.lblTiempoGenerar.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempoGenerar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoGenerar.ForeColor = System.Drawing.Color.Aqua;
            this.lblTiempoGenerar.Location = new System.Drawing.Point(145, 446);
            this.lblTiempoGenerar.Name = "lblTiempoGenerar";
            this.lblTiempoGenerar.Size = new System.Drawing.Size(30, 18);
            this.lblTiempoGenerar.TabIndex = 10;
            this.lblTiempoGenerar.Text = "0:0";
            // 
            // lblTiempoOrdenar
            // 
            this.lblTiempoOrdenar.AutoSize = true;
            this.lblTiempoOrdenar.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempoOrdenar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoOrdenar.ForeColor = System.Drawing.Color.Aqua;
            this.lblTiempoOrdenar.Location = new System.Drawing.Point(108, 492);
            this.lblTiempoOrdenar.Name = "lblTiempoOrdenar";
            this.lblTiempoOrdenar.Size = new System.Drawing.Size(30, 18);
            this.lblTiempoOrdenar.TabIndex = 11;
            this.lblTiempoOrdenar.Text = "0:0";
            // 
            // btnOrdenar2
            // 
            this.btnOrdenar2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnOrdenar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrdenar2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOrdenar2.Location = new System.Drawing.Point(403, 115);
            this.btnOrdenar2.Name = "btnOrdenar2";
            this.btnOrdenar2.Size = new System.Drawing.Size(139, 27);
            this.btnOrdenar2.TabIndex = 12;
            this.btnOrdenar2.Text = "DESCENDENTE";
            this.btnOrdenar2.UseVisualStyleBackColor = false;
            this.btnOrdenar2.Click += new System.EventHandler(this.btnOrdenar2_Click);
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.listBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.ForeColor = System.Drawing.Color.White;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 18;
            this.listBox3.Location = new System.Drawing.Point(403, 148);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(139, 234);
            this.listBox3.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(108, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "0:0";
            // 
            // tbComparaciones
            // 
            this.tbComparaciones.AutoSize = true;
            this.tbComparaciones.BackColor = System.Drawing.Color.Transparent;
            this.tbComparaciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbComparaciones.ForeColor = System.Drawing.Color.Aqua;
            this.tbComparaciones.Location = new System.Drawing.Point(526, 496);
            this.tbComparaciones.Name = "tbComparaciones";
            this.tbComparaciones.Size = new System.Drawing.Size(17, 18);
            this.tbComparaciones.TabIndex = 22;
            this.tbComparaciones.Text = "0";
            // 
            // lblntercambios
            // 
            this.lblntercambios.AutoSize = true;
            this.lblntercambios.BackColor = System.Drawing.Color.Transparent;
            this.lblntercambios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblntercambios.ForeColor = System.Drawing.Color.Aqua;
            this.lblntercambios.Location = new System.Drawing.Point(526, 450);
            this.lblntercambios.Name = "lblntercambios";
            this.lblntercambios.Size = new System.Drawing.Size(17, 18);
            this.lblntercambios.TabIndex = 21;
            this.lblntercambios.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(418, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Comparaciones:";
            // 
            // lblPasadas
            // 
            this.lblPasadas.AutoSize = true;
            this.lblPasadas.BackColor = System.Drawing.Color.Transparent;
            this.lblPasadas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasadas.ForeColor = System.Drawing.Color.White;
            this.lblPasadas.Location = new System.Drawing.Point(418, 450);
            this.lblPasadas.Name = "lblPasadas";
            this.lblPasadas.Size = new System.Drawing.Size(75, 18);
            this.lblPasadas.TabIndex = 19;
            this.lblPasadas.Text = "Pasadas:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.kj;
            this.pictureBox1.Location = new System.Drawing.Point(-104, -21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(847, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(213, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 33);
            this.label9.TabIndex = 24;
            this.label9.Text = "Bubble Sort";
            // 
            // frmBurbuja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.lol;
            this.ClientSize = new System.Drawing.Size(573, 560);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbComparaciones);
            this.Controls.Add(this.lblntercambios);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPasadas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.btnOrdenar2);
            this.Controls.Add(this.lblTiempoOrdenar);
            this.Controls.Add(this.lblTiempoGenerar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnGenerarDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtn);
            this.Name = "frmBurbuja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Burbuja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarDatos;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTiempoGenerar;
        private System.Windows.Forms.Label lblTiempoOrdenar;
        private System.Windows.Forms.Button btnOrdenar2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tbComparaciones;
        private System.Windows.Forms.Label lblntercambios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPasadas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;

        public EventHandler GenerarDatos_Click { get; private set; }
    }
}

