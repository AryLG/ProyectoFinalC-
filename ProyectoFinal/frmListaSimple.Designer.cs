namespace ProyectoFinal
{
    partial class frmListaSimple
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtInsertar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnBuscado = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Teal;
            this.btnEliminar.Location = new System.Drawing.Point(200, 304);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(141, 30);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtInsertar
            // 
            this.txtInsertar.BackColor = System.Drawing.Color.Transparent;
            this.txtInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtInsertar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsertar.ForeColor = System.Drawing.Color.Teal;
            this.txtInsertar.Location = new System.Drawing.Point(200, 220);
            this.txtInsertar.Name = "txtInsertar";
            this.txtInsertar.Size = new System.Drawing.Size(141, 30);
            this.txtInsertar.TabIndex = 1;
            this.txtInsertar.Text = "Insertar";
            this.txtInsertar.UseVisualStyleBackColor = false;
            this.txtInsertar.Click += new System.EventHandler(this.txtInsertar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.Teal;
            this.btnMostrar.Location = new System.Drawing.Point(200, 276);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(141, 30);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnBuscado
            // 
            this.btnBuscado.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscado.ForeColor = System.Drawing.Color.Teal;
            this.btnBuscado.Location = new System.Drawing.Point(200, 248);
            this.btnBuscado.Name = "btnBuscado";
            this.btnBuscado.Size = new System.Drawing.Size(141, 30);
            this.btnBuscado.TabIndex = 3;
            this.btnBuscado.Text = "Buscar";
            this.btnBuscado.UseVisualStyleBackColor = false;
            this.btnBuscado.Click += new System.EventHandler(this.btnBuscado_Click);
            // 
            // txtDato
            // 
            this.txtDato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDato.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDato.Location = new System.Drawing.Point(200, 185);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(141, 19);
            this.txtDato.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(210, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 33);
            this.label9.TabIndex = 13;
            this.label9.Text = "Lista Simple";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.kj;
            this.pictureBox1.Location = new System.Drawing.Point(-144, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(847, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // frmListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.lol;
            this.ClientSize = new System.Drawing.Size(573, 560);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.btnBuscado);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtInsertar);
            this.Controls.Add(this.btnEliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListaSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button txtInsertar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnBuscado;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}