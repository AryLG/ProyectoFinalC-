namespace ProyectoFinal
{
    partial class MenuPrincipal
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
            this.btnListaDoble = new System.Windows.Forms.Button();
            this.btnListaSimple = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListaDoble
            // 
            this.btnListaDoble.BackColor = System.Drawing.Color.Transparent;
            this.btnListaDoble.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListaDoble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaDoble.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaDoble.ForeColor = System.Drawing.Color.Teal;
            this.btnListaDoble.Location = new System.Drawing.Point(319, 408);
            this.btnListaDoble.Name = "btnListaDoble";
            this.btnListaDoble.Size = new System.Drawing.Size(155, 58);
            this.btnListaDoble.TabIndex = 3;
            this.btnListaDoble.Text = "Metodo de Ordenamiento";
            this.btnListaDoble.UseVisualStyleBackColor = false;
            this.btnListaDoble.Click += new System.EventHandler(this.btnListaDoble_Click);
            // 
            // btnListaSimple
            // 
            this.btnListaSimple.BackColor = System.Drawing.Color.Transparent;
            this.btnListaSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaSimple.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaSimple.ForeColor = System.Drawing.Color.Teal;
            this.btnListaSimple.Location = new System.Drawing.Point(74, 408);
            this.btnListaSimple.Name = "btnListaSimple";
            this.btnListaSimple.Size = new System.Drawing.Size(155, 58);
            this.btnListaSimple.TabIndex = 2;
            this.btnListaSimple.Text = "Estructuras";
            this.btnListaSimple.UseVisualStyleBackColor = false;
            this.btnListaSimple.Click += new System.EventHandler(this.btnListaSimple_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.pictureBox1.BackgroundImage = global::ProyectoFinal.Properties.Resources.lol;
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources._8100189;
            this.pictureBox1.Location = new System.Drawing.Point(210, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoFinal.Properties.Resources.kj;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(847, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.lol;
            this.ClientSize = new System.Drawing.Size(573, 560);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnListaDoble);
            this.Controls.Add(this.btnListaSimple);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListaDoble;
        private System.Windows.Forms.Button btnListaSimple;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}