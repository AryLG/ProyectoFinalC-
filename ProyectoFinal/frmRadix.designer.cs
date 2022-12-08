namespace AppRS
{
    partial class frmRadix
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
            this.TxtTamaño = new System.Windows.Forms.TextBox();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.LtbArregloAleatorio = new System.Windows.Forms.ListBox();
            this.LtbArregloOrdenado = new System.Windows.Forms.ListBox();
            this.LtbArregloOrdenadoMN = new System.Windows.Forms.ListBox();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.LblTiempo = new System.Windows.Forms.Label();
            this.TxtTiempo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtTamaño
            // 
            this.TxtTamaño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.TxtTamaño.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTamaño.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTamaño.ForeColor = System.Drawing.Color.White;
            this.TxtTamaño.Location = new System.Drawing.Point(84, 256);
            this.TxtTamaño.Name = "TxtTamaño";
            this.TxtTamaño.Size = new System.Drawing.Size(100, 19);
            this.TxtTamaño.TabIndex = 0;
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.BackColor = System.Drawing.Color.Transparent;
            this.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.ForeColor = System.Drawing.Color.Teal;
            this.BtnIniciar.Location = new System.Drawing.Point(190, 256);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(75, 32);
            this.BtnIniciar.TabIndex = 1;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = false;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // LtbArregloAleatorio
            // 
            this.LtbArregloAleatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.LtbArregloAleatorio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LtbArregloAleatorio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LtbArregloAleatorio.ForeColor = System.Drawing.Color.White;
            this.LtbArregloAleatorio.FormattingEnabled = true;
            this.LtbArregloAleatorio.ItemHeight = 18;
            this.LtbArregloAleatorio.Location = new System.Drawing.Point(84, 301);
            this.LtbArregloAleatorio.Name = "LtbArregloAleatorio";
            this.LtbArregloAleatorio.Size = new System.Drawing.Size(100, 198);
            this.LtbArregloAleatorio.TabIndex = 2;
            // 
            // LtbArregloOrdenado
            // 
            this.LtbArregloOrdenado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.LtbArregloOrdenado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LtbArregloOrdenado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LtbArregloOrdenado.ForeColor = System.Drawing.Color.White;
            this.LtbArregloOrdenado.FormattingEnabled = true;
            this.LtbArregloOrdenado.ItemHeight = 18;
            this.LtbArregloOrdenado.Location = new System.Drawing.Point(210, 301);
            this.LtbArregloOrdenado.Name = "LtbArregloOrdenado";
            this.LtbArregloOrdenado.Size = new System.Drawing.Size(100, 198);
            this.LtbArregloOrdenado.TabIndex = 3;
            // 
            // LtbArregloOrdenadoMN
            // 
            this.LtbArregloOrdenadoMN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.LtbArregloOrdenadoMN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LtbArregloOrdenadoMN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LtbArregloOrdenadoMN.ForeColor = System.Drawing.Color.White;
            this.LtbArregloOrdenadoMN.FormattingEnabled = true;
            this.LtbArregloOrdenadoMN.ItemHeight = 18;
            this.LtbArregloOrdenadoMN.Location = new System.Drawing.Point(327, 301);
            this.LtbArregloOrdenadoMN.Name = "LtbArregloOrdenadoMN";
            this.LtbArregloOrdenadoMN.Size = new System.Drawing.Size(100, 198);
            this.LtbArregloOrdenadoMN.TabIndex = 4;
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.ForeColor = System.Drawing.Color.Teal;
            this.BtnBorrar.Location = new System.Drawing.Point(271, 254);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(75, 32);
            this.BtnBorrar.TabIndex = 9;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.Teal;
            this.BtnCerrar.Location = new System.Drawing.Point(352, 253);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 32);
            this.BtnCerrar.TabIndex = 10;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // LblTiempo
            // 
            this.LblTiempo.AutoSize = true;
            this.LblTiempo.BackColor = System.Drawing.Color.Transparent;
            this.LblTiempo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTiempo.ForeColor = System.Drawing.Color.Teal;
            this.LblTiempo.Location = new System.Drawing.Point(257, 205);
            this.LblTiempo.Name = "LblTiempo";
            this.LblTiempo.Size = new System.Drawing.Size(64, 18);
            this.LblTiempo.TabIndex = 11;
            this.LblTiempo.Text = "Tiempo:";
            // 
            // TxtTiempo
            // 
            this.TxtTiempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.TxtTiempo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTiempo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTiempo.ForeColor = System.Drawing.Color.White;
            this.TxtTiempo.Location = new System.Drawing.Point(327, 204);
            this.TxtTiempo.Name = "TxtTiempo";
            this.TxtTiempo.Size = new System.Drawing.Size(100, 19);
            this.TxtTiempo.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.kj;
            this.pictureBox1.Location = new System.Drawing.Point(-83, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(847, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(212, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 33);
            this.label11.TabIndex = 34;
            this.label11.Text = "Radix Sort";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 18);
            this.label12.TabIndex = 36;
            this.label12.Text = "Anterior";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // frmRadix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.lol;
            this.ClientSize = new System.Drawing.Size(573, 560);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtTiempo);
            this.Controls.Add(this.LblTiempo);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.LtbArregloOrdenadoMN);
            this.Controls.Add(this.LtbArregloOrdenado);
            this.Controls.Add(this.LtbArregloAleatorio);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.TxtTamaño);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRadix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTamaño;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.ListBox LtbArregloAleatorio;
        private System.Windows.Forms.ListBox LtbArregloOrdenado;
        private System.Windows.Forms.ListBox LtbArregloOrdenadoMN;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label LblTiempo;
        private System.Windows.Forms.TextBox TxtTiempo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

