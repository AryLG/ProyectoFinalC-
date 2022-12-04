namespace Ordenamiento_Mezcla_Natural
{
    partial class frmMezcla
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtElementos = new System.Windows.Forms.TextBox();
            this.btnRecAsc = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lvwMostar = new System.Windows.Forms.ListView();
            this.lblStadistica = new System.Windows.Forms.Label();
            this.lvwOrdenado = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Transparent;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.Teal;
            this.btnCrear.Location = new System.Drawing.Point(368, 219);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(85, 29);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear Vector";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtElementos
            // 
            this.txtElementos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.txtElementos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtElementos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElementos.ForeColor = System.Drawing.Color.White;
            this.txtElementos.Location = new System.Drawing.Point(260, 219);
            this.txtElementos.Name = "txtElementos";
            this.txtElementos.Size = new System.Drawing.Size(77, 19);
            this.txtElementos.TabIndex = 1;
            // 
            // btnRecAsc
            // 
            this.btnRecAsc.BackColor = System.Drawing.Color.Transparent;
            this.btnRecAsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecAsc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecAsc.ForeColor = System.Drawing.Color.Teal;
            this.btnRecAsc.Location = new System.Drawing.Point(30, 254);
            this.btnRecAsc.Name = "btnRecAsc";
            this.btnRecAsc.Size = new System.Drawing.Size(225, 31);
            this.btnRecAsc.TabIndex = 2;
            this.btnRecAsc.Text = "Recorrido Ascendente";
            this.btnRecAsc.UseVisualStyleBackColor = false;
            this.btnRecAsc.Click += new System.EventHandler(this.btnRecAsc_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Teal;
            this.button3.Location = new System.Drawing.Point(30, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "Recorrido Descendente";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(27, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero de elementos del vector:";
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.Teal;
            this.btnMostrar.Location = new System.Drawing.Point(459, 219);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(85, 29);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Mostrar Vector";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lvwMostar
            // 
            this.lvwMostar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.lvwMostar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwMostar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvwMostar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwMostar.ForeColor = System.Drawing.Color.White;
            this.lvwMostar.HideSelection = false;
            this.lvwMostar.Location = new System.Drawing.Point(0, 0);
            this.lvwMostar.Name = "lvwMostar";
            this.lvwMostar.Size = new System.Drawing.Size(573, 38);
            this.lvwMostar.TabIndex = 6;
            this.lvwMostar.UseCompatibleStateImageBehavior = false;
            // 
            // lblStadistica
            // 
            this.lblStadistica.AutoSize = true;
            this.lblStadistica.BackColor = System.Drawing.Color.Transparent;
            this.lblStadistica.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStadistica.ForeColor = System.Drawing.Color.White;
            this.lblStadistica.Location = new System.Drawing.Point(361, 277);
            this.lblStadistica.Name = "lblStadistica";
            this.lblStadistica.Size = new System.Drawing.Size(31, 24);
            this.lblStadistica.TabIndex = 7;
            this.lblStadistica.Text = "---";
            // 
            // lvwOrdenado
            // 
            this.lvwOrdenado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.lvwOrdenado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwOrdenado.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvwOrdenado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwOrdenado.ForeColor = System.Drawing.Color.White;
            this.lvwOrdenado.HideSelection = false;
            this.lvwOrdenado.Location = new System.Drawing.Point(0, 38);
            this.lvwOrdenado.Name = "lvwOrdenado";
            this.lvwOrdenado.Size = new System.Drawing.Size(573, 35);
            this.lvwOrdenado.TabIndex = 8;
            this.lvwOrdenado.UseCompatibleStateImageBehavior = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(199, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 33);
            this.label9.TabIndex = 42;
            this.label9.Text = "Merge Sort";
            // 
            // frmMezcla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.lol;
            this.ClientSize = new System.Drawing.Size(573, 560);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lvwOrdenado);
            this.Controls.Add(this.lblStadistica);
            this.Controls.Add(this.lvwMostar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnRecAsc);
            this.Controls.Add(this.txtElementos);
            this.Controls.Add(this.btnCrear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMezcla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mezcla Natural";
            this.Load += new System.EventHandler(this.frmMezcla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtElementos;
        private System.Windows.Forms.Button btnRecAsc;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ListView lvwMostar;
        private System.Windows.Forms.Label lblStadistica;
        private System.Windows.Forms.ListView lvwOrdenado;
        private System.Windows.Forms.Label label9;
    }
}

