namespace AppAlg
{
  partial class frmInsercioon
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
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.LbArregloC = new System.Windows.Forms.Label();
            this.LbArregloO = new System.Windows.Forms.Label();
            this.LbComparaciones = new System.Windows.Forms.Label();
            this.LbIntercambios = new System.Windows.Forms.Label();
            this.tbComparaciones = new System.Windows.Forms.TextBox();
            this.tbArregloO = new System.Windows.Forms.TextBox();
            this.tbArregloC = new System.Windows.Forms.TextBox();
            this.tbIntercambios = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTamaño
            // 
            this.txtTamaño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.txtTamaño.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTamaño.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamaño.ForeColor = System.Drawing.Color.White;
            this.txtTamaño.Location = new System.Drawing.Point(122, 227);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(210, 19);
            this.txtTamaño.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(53, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tamaño";
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Transparent;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.Teal;
            this.btnCrear.Location = new System.Drawing.Point(352, 224);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(125, 26);
            this.btnCrear.TabIndex = 23;
            this.btnCrear.Text = "Crear arreglo";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // LbArregloC
            // 
            this.LbArregloC.AutoSize = true;
            this.LbArregloC.BackColor = System.Drawing.Color.Transparent;
            this.LbArregloC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbArregloC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LbArregloC.Location = new System.Drawing.Point(53, 262);
            this.LbArregloC.Name = "LbArregloC";
            this.LbArregloC.Size = new System.Drawing.Size(112, 18);
            this.LbArregloC.TabIndex = 20;
            this.LbArregloC.Text = "Arreglo creado";
            // 
            // LbArregloO
            // 
            this.LbArregloO.AutoSize = true;
            this.LbArregloO.BackColor = System.Drawing.Color.Transparent;
            this.LbArregloO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbArregloO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LbArregloO.Location = new System.Drawing.Point(53, 288);
            this.LbArregloO.Name = "LbArregloO";
            this.LbArregloO.Size = new System.Drawing.Size(130, 18);
            this.LbArregloO.TabIndex = 32;
            this.LbArregloO.Text = "Arreglo ordenado";
            // 
            // LbComparaciones
            // 
            this.LbComparaciones.AutoSize = true;
            this.LbComparaciones.BackColor = System.Drawing.Color.Transparent;
            this.LbComparaciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbComparaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LbComparaciones.Location = new System.Drawing.Point(53, 316);
            this.LbComparaciones.Name = "LbComparaciones";
            this.LbComparaciones.Size = new System.Drawing.Size(120, 18);
            this.LbComparaciones.TabIndex = 34;
            this.LbComparaciones.Text = "Comparaciones";
            // 
            // LbIntercambios
            // 
            this.LbIntercambios.AutoSize = true;
            this.LbIntercambios.BackColor = System.Drawing.Color.Transparent;
            this.LbIntercambios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIntercambios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LbIntercambios.Location = new System.Drawing.Point(53, 342);
            this.LbIntercambios.Name = "LbIntercambios";
            this.LbIntercambios.Size = new System.Drawing.Size(97, 18);
            this.LbIntercambios.TabIndex = 35;
            this.LbIntercambios.Text = "Intercambios";
            // 
            // tbComparaciones
            // 
            this.tbComparaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.tbComparaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbComparaciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbComparaciones.ForeColor = System.Drawing.Color.White;
            this.tbComparaciones.Location = new System.Drawing.Point(171, 315);
            this.tbComparaciones.Name = "tbComparaciones";
            this.tbComparaciones.Size = new System.Drawing.Size(62, 19);
            this.tbComparaciones.TabIndex = 36;
            // 
            // tbArregloO
            // 
            this.tbArregloO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.tbArregloO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbArregloO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArregloO.ForeColor = System.Drawing.Color.White;
            this.tbArregloO.Location = new System.Drawing.Point(189, 287);
            this.tbArregloO.Name = "tbArregloO";
            this.tbArregloO.Size = new System.Drawing.Size(365, 19);
            this.tbArregloO.TabIndex = 37;
            // 
            // tbArregloC
            // 
            this.tbArregloC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.tbArregloC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbArregloC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArregloC.ForeColor = System.Drawing.Color.White;
            this.tbArregloC.Location = new System.Drawing.Point(171, 261);
            this.tbArregloC.Name = "tbArregloC";
            this.tbArregloC.Size = new System.Drawing.Size(383, 19);
            this.tbArregloC.TabIndex = 38;
            // 
            // tbIntercambios
            // 
            this.tbIntercambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.tbIntercambios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIntercambios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIntercambios.ForeColor = System.Drawing.Color.White;
            this.tbIntercambios.Location = new System.Drawing.Point(156, 342);
            this.tbIntercambios.Name = "tbIntercambios";
            this.tbIntercambios.Size = new System.Drawing.Size(77, 19);
            this.tbIntercambios.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(215, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 33);
            this.label9.TabIndex = 41;
            this.label9.Text = "Insertion Sort";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.kj;
            this.pictureBox1.Location = new System.Drawing.Point(-117, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(847, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(21, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 18);
            this.label12.TabIndex = 43;
            this.label12.Text = "Anterior";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // frmInsercioon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.lol;
            this.ClientSize = new System.Drawing.Size(573, 560);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbIntercambios);
            this.Controls.Add(this.tbArregloC);
            this.Controls.Add(this.tbArregloO);
            this.Controls.Add(this.tbComparaciones);
            this.Controls.Add(this.LbIntercambios);
            this.Controls.Add(this.LbComparaciones);
            this.Controls.Add(this.LbArregloO);
            this.Controls.Add(this.LbArregloC);
            this.Controls.Add(this.txtTamaño);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInsercioon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmInsercioon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label LbArregloC;
        private System.Windows.Forms.Label LbArregloO;
        private System.Windows.Forms.Label LbComparaciones;
        private System.Windows.Forms.Label LbIntercambios;
        private System.Windows.Forms.TextBox tbComparaciones;
        private System.Windows.Forms.TextBox tbArregloO;
        private System.Windows.Forms.TextBox tbArregloC;
        private System.Windows.Forms.TextBox tbIntercambios;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
    }
}

