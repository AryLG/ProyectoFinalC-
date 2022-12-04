namespace OrdenamientoRapido
{
    partial class frmRapido
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
            this.btnQSAsc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQSDes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQSAsc
            // 
            this.btnQSAsc.BackColor = System.Drawing.Color.Transparent;
            this.btnQSAsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQSAsc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQSAsc.ForeColor = System.Drawing.Color.Teal;
            this.btnQSAsc.Location = new System.Drawing.Point(12, 196);
            this.btnQSAsc.Name = "btnQSAsc";
            this.btnQSAsc.Size = new System.Drawing.Size(285, 28);
            this.btnQSAsc.TabIndex = 0;
            this.btnQSAsc.Text = "Ordenar ascendente";
            this.btnQSAsc.UseVisualStyleBackColor = false;
            this.btnQSAsc.Click += new System.EventHandler(this.btnQSAsc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresar números a ordenar separados por comas:";
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.ForeColor = System.Drawing.Color.White;
            this.txtNum.Location = new System.Drawing.Point(12, 168);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(549, 19);
            this.txtNum.TabIndex = 2;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.Color.White;
            this.txtResultado.Location = new System.Drawing.Point(12, 239);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(549, 228);
            this.txtResultado.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Teal;
            this.btnClear.Location = new System.Drawing.Point(12, 473);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(549, 28);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQSDes
            // 
            this.btnQSDes.BackColor = System.Drawing.Color.Transparent;
            this.btnQSDes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQSDes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQSDes.ForeColor = System.Drawing.Color.Teal;
            this.btnQSDes.Location = new System.Drawing.Point(303, 196);
            this.btnQSDes.Name = "btnQSDes";
            this.btnQSDes.Size = new System.Drawing.Size(258, 28);
            this.btnQSDes.TabIndex = 5;
            this.btnQSDes.Text = "Ordenar descendente";
            this.btnQSDes.UseVisualStyleBackColor = false;
            this.btnQSDes.Click += new System.EventHandler(this.btnQSDes_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(386, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Crear arreglo random";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(209, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 33);
            this.label9.TabIndex = 22;
            this.label9.Text = "Quick Sort";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.kj;
            this.pictureBox1.Location = new System.Drawing.Point(-142, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(847, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // frmRapido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.lol;
            this.ClientSize = new System.Drawing.Size(573, 560);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnQSDes);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQSAsc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRapido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmRapido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQSAsc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQSDes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

