namespace ProyectoFinal
{
    partial class frmPila
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnCimaPilalista = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbuscarnodo = new System.Windows.Forms.TextBox();
            this.btnbuscarnodo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltexto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroLista = new System.Windows.Forms.TextBox();
            this.btnPopLista = new System.Windows.Forms.Button();
            this.BtnPushLista = new System.Windows.Forms.Button();
            this.btnCimaArreglo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuscarArreglo = new System.Windows.Forms.TextBox();
            this.btnBuscarArreglo = new System.Windows.Forms.Button();
            this.txtpila = new System.Windows.Forms.Label();
            this.btnPopArreglo = new System.Windows.Forms.Button();
            this.btnPushArreglo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 57;
            // 
            // btnCimaPilalista
            // 
            this.btnCimaPilalista.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCimaPilalista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCimaPilalista.ForeColor = System.Drawing.Color.Teal;
            this.btnCimaPilalista.Location = new System.Drawing.Point(281, 84);
            this.btnCimaPilalista.Name = "btnCimaPilalista";
            this.btnCimaPilalista.Size = new System.Drawing.Size(145, 27);
            this.btnCimaPilalista.TabIndex = 75;
            this.btnCimaPilalista.Text = "CIMA DE LA PILA";
            this.btnCimaPilalista.UseVisualStyleBackColor = false;
            this.btnCimaPilalista.Click += new System.EventHandler(this.btnCimaPilalista_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 18);
            this.label7.TabIndex = 77;
            this.label7.Text = "BUSCAR:";
            // 
            // txtbuscarnodo
            // 
            this.txtbuscarnodo.AcceptsTab = true;
            this.txtbuscarnodo.Location = new System.Drawing.Point(93, 84);
            this.txtbuscarnodo.Name = "txtbuscarnodo";
            this.txtbuscarnodo.Size = new System.Drawing.Size(85, 26);
            this.txtbuscarnodo.TabIndex = 71;
            // 
            // btnbuscarnodo
            // 
            this.btnbuscarnodo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnbuscarnodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscarnodo.ForeColor = System.Drawing.Color.Teal;
            this.btnbuscarnodo.Location = new System.Drawing.Point(184, 84);
            this.btnbuscarnodo.Name = "btnbuscarnodo";
            this.btnbuscarnodo.Size = new System.Drawing.Size(87, 28);
            this.btnbuscarnodo.TabIndex = 73;
            this.btnbuscarnodo.Text = "BUSCAR";
            this.btnbuscarnodo.UseVisualStyleBackColor = false;
            this.btnbuscarnodo.Click += new System.EventHandler(this.btnbuscarnodo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 76;
            // 
            // lbltexto
            // 
            this.lbltexto.AutoSize = true;
            this.lbltexto.Location = new System.Drawing.Point(6, 114);
            this.lbltexto.Name = "lbltexto";
            this.lbltexto.Size = new System.Drawing.Size(0, 18);
            this.lbltexto.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 72;
            this.label3.Text = "NUMERO:";
            // 
            // txtNumeroLista
            // 
            this.txtNumeroLista.Location = new System.Drawing.Point(93, 52);
            this.txtNumeroLista.Name = "txtNumeroLista";
            this.txtNumeroLista.Size = new System.Drawing.Size(85, 26);
            this.txtNumeroLista.TabIndex = 68;
            // 
            // btnPopLista
            // 
            this.btnPopLista.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPopLista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPopLista.ForeColor = System.Drawing.Color.Teal;
            this.btnPopLista.Location = new System.Drawing.Point(281, 52);
            this.btnPopLista.Name = "btnPopLista";
            this.btnPopLista.Size = new System.Drawing.Size(75, 26);
            this.btnPopLista.TabIndex = 70;
            this.btnPopLista.Text = "POP";
            this.btnPopLista.UseVisualStyleBackColor = false;
            this.btnPopLista.Click += new System.EventHandler(this.btnPopLista_Click);
            // 
            // BtnPushLista
            // 
            this.BtnPushLista.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnPushLista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPushLista.ForeColor = System.Drawing.Color.Teal;
            this.BtnPushLista.Location = new System.Drawing.Point(184, 52);
            this.BtnPushLista.Name = "BtnPushLista";
            this.BtnPushLista.Size = new System.Drawing.Size(87, 26);
            this.BtnPushLista.TabIndex = 69;
            this.BtnPushLista.Text = "PUSH";
            this.BtnPushLista.UseVisualStyleBackColor = false;
            this.BtnPushLista.Click += new System.EventHandler(this.BtnPushLista_Click);
            // 
            // btnCimaArreglo
            // 
            this.btnCimaArreglo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCimaArreglo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCimaArreglo.ForeColor = System.Drawing.Color.Teal;
            this.btnCimaArreglo.Location = new System.Drawing.Point(281, 122);
            this.btnCimaArreglo.Name = "btnCimaArreglo";
            this.btnCimaArreglo.Size = new System.Drawing.Size(145, 25);
            this.btnCimaArreglo.TabIndex = 87;
            this.btnCimaArreglo.Text = "CIMA DE LA PILA";
            this.btnCimaArreglo.UseVisualStyleBackColor = false;
            this.btnCimaArreglo.Click += new System.EventHandler(this.btnCimaArreglo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 89;
            this.label6.Text = "BUSCAR:";
            // 
            // txtBuscarArreglo
            // 
            this.txtBuscarArreglo.Location = new System.Drawing.Point(93, 121);
            this.txtBuscarArreglo.Name = "txtBuscarArreglo";
            this.txtBuscarArreglo.Size = new System.Drawing.Size(85, 26);
            this.txtBuscarArreglo.TabIndex = 85;
            // 
            // btnBuscarArreglo
            // 
            this.btnBuscarArreglo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuscarArreglo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarArreglo.ForeColor = System.Drawing.Color.Teal;
            this.btnBuscarArreglo.Location = new System.Drawing.Point(184, 121);
            this.btnBuscarArreglo.Name = "btnBuscarArreglo";
            this.btnBuscarArreglo.Size = new System.Drawing.Size(87, 26);
            this.btnBuscarArreglo.TabIndex = 86;
            this.btnBuscarArreglo.Text = "BUSCAR";
            this.btnBuscarArreglo.UseVisualStyleBackColor = false;
            this.btnBuscarArreglo.Click += new System.EventHandler(this.btnBuscarArreglo_Click);
            // 
            // txtpila
            // 
            this.txtpila.AutoSize = true;
            this.txtpila.Location = new System.Drawing.Point(12, 162);
            this.txtpila.Name = "txtpila";
            this.txtpila.Size = new System.Drawing.Size(0, 18);
            this.txtpila.TabIndex = 88;
            // 
            // btnPopArreglo
            // 
            this.btnPopArreglo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPopArreglo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPopArreglo.ForeColor = System.Drawing.Color.Teal;
            this.btnPopArreglo.Location = new System.Drawing.Point(281, 72);
            this.btnPopArreglo.Name = "btnPopArreglo";
            this.btnPopArreglo.Size = new System.Drawing.Size(87, 26);
            this.btnPopArreglo.TabIndex = 83;
            this.btnPopArreglo.Text = "POP";
            this.btnPopArreglo.UseVisualStyleBackColor = false;
            this.btnPopArreglo.Click += new System.EventHandler(this.btnPopArreglo_Click);
            // 
            // btnPushArreglo
            // 
            this.btnPushArreglo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPushArreglo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPushArreglo.ForeColor = System.Drawing.Color.Teal;
            this.btnPushArreglo.Location = new System.Drawing.Point(184, 72);
            this.btnPushArreglo.Name = "btnPushArreglo";
            this.btnPushArreglo.Size = new System.Drawing.Size(87, 26);
            this.btnPushArreglo.TabIndex = 82;
            this.btnPushArreglo.Text = "PUSH";
            this.btnPushArreglo.UseVisualStyleBackColor = false;
            this.btnPushArreglo.Click += new System.EventHandler(this.btnPushArreglo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 84;
            this.label2.Text = "NUMERO:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(93, 72);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(85, 26);
            this.txtNumero.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 81;
            this.label1.Text = "MAXIMO:";
            // 
            // txtMaximo
            // 
            this.txtMaximo.Location = new System.Drawing.Point(93, 31);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(85, 26);
            this.txtMaximo.TabIndex = 78;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrear.ForeColor = System.Drawing.Color.Teal;
            this.btnCrear.Location = new System.Drawing.Point(184, 31);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(87, 26);
            this.btnCrear.TabIndex = 79;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BtnPushLista);
            this.groupBox1.Controls.Add(this.btnPopLista);
            this.groupBox1.Controls.Add(this.txtNumeroLista);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbltexto);
            this.groupBox1.Controls.Add(this.btnbuscarnodo);
            this.groupBox1.Controls.Add(this.txtbuscarnodo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnCimaPilalista);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(40, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 216);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PILA CON LISTAS";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnCrear);
            this.groupBox2.Controls.Add(this.btnCimaArreglo);
            this.groupBox2.Controls.Add(this.txtMaximo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtBuscarArreglo);
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.btnBuscarArreglo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtpila);
            this.groupBox2.Controls.Add(this.btnPushArreglo);
            this.groupBox2.Controls.Add(this.btnPopArreglo);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Teal;
            this.groupBox2.Location = new System.Drawing.Point(40, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 230);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PILA CON ARREGLO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.kj;
            this.pictureBox1.Location = new System.Drawing.Point(-126, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(847, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(265, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 33);
            this.label9.TabIndex = 93;
            this.label9.Text = "PILA";
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.lol;
            this.ClientSize = new System.Drawing.Size(573, 560);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCimaPilalista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbuscarnodo;
        private System.Windows.Forms.Button btnbuscarnodo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltexto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroLista;
        private System.Windows.Forms.Button btnPopLista;
        private System.Windows.Forms.Button BtnPushLista;
        private System.Windows.Forms.Button btnCimaArreglo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscarArreglo;
        private System.Windows.Forms.Button btnBuscarArreglo;
        private System.Windows.Forms.Label txtpila;
        private System.Windows.Forms.Button btnPopArreglo;
        private System.Windows.Forms.Button btnPushArreglo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
    }
}