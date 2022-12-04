namespace ProyectoFinal
{
    partial class frmCola
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.Teal;
            this.btnMostrar.Location = new System.Drawing.Point(227, 243);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(100, 32);
            this.btnMostrar.TabIndex = 11;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Teal;
            this.btnEliminar.Location = new System.Drawing.Point(227, 269);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 31);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtDato
            // 
            this.txtDato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.txtDato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDato.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDato.ForeColor = System.Drawing.Color.White;
            this.txtDato.Location = new System.Drawing.Point(227, 180);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(100, 19);
            this.txtDato.TabIndex = 9;
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.Transparent;
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.Color.Teal;
            this.btnInsertar.Location = new System.Drawing.Point(227, 217);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(100, 32);
            this.btnInsertar.TabIndex = 8;
            this.btnInsertar.Text = "Insertar ";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.kj;
            this.pictureBox1.Location = new System.Drawing.Point(-124, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(847, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(247, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 33);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cola";
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.lol;
            this.ClientSize = new System.Drawing.Size(573, 560);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.btnInsertar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
    }
}