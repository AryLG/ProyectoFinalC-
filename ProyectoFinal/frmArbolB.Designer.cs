namespace ProyectoFinal
{
    partial class frmArbolB
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.txtInsertar = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnPostOrder = new System.Windows.Forms.Button();
            this.btnPreOrder = new System.Windows.Forms.Button();
            this.btnInOrder = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(166, 23);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(12, 38);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(166, 23);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(184, 66);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 28;
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(184, 40);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtEliminar.TabIndex = 27;
            // 
            // txtInsertar
            // 
            this.txtInsertar.Location = new System.Drawing.Point(184, 14);
            this.txtInsertar.Name = "txtInsertar";
            this.txtInsertar.Size = new System.Drawing.Size(100, 20);
            this.txtInsertar.TabIndex = 26;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 318);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 349);
            this.listBox1.TabIndex = 25;
            // 
            // btnPostOrder
            // 
            this.btnPostOrder.Location = new System.Drawing.Point(12, 154);
            this.btnPostOrder.Name = "btnPostOrder";
            this.btnPostOrder.Size = new System.Drawing.Size(166, 23);
            this.btnPostOrder.TabIndex = 24;
            this.btnPostOrder.Text = "Metodo PostOrden";
            this.btnPostOrder.UseVisualStyleBackColor = true;
            this.btnPostOrder.Click += new System.EventHandler(this.btnPostOrder_Click);
            // 
            // btnPreOrder
            // 
            this.btnPreOrder.Location = new System.Drawing.Point(12, 125);
            this.btnPreOrder.Name = "btnPreOrder";
            this.btnPreOrder.Size = new System.Drawing.Size(166, 23);
            this.btnPreOrder.TabIndex = 23;
            this.btnPreOrder.Text = "Metodo PreOrden";
            this.btnPreOrder.UseVisualStyleBackColor = true;
            this.btnPreOrder.Click += new System.EventHandler(this.btnPreOrder_Click);
            // 
            // btnInOrder
            // 
            this.btnInOrder.Location = new System.Drawing.Point(12, 96);
            this.btnInOrder.Name = "btnInOrder";
            this.btnInOrder.Size = new System.Drawing.Size(166, 23);
            this.btnInOrder.TabIndex = 22;
            this.btnInOrder.Text = "Metodo InOrden";
            this.btnInOrder.UseVisualStyleBackColor = true;
            this.btnInOrder.Click += new System.EventHandler(this.btnInOrder_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(12, 12);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(166, 23);
            this.btnInsertar.TabIndex = 21;
            this.btnInsertar.Text = "Insertar Nodo";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // frmArbolB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.txtInsertar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnPostOrder);
            this.Controls.Add(this.btnPreOrder);
            this.Controls.Add(this.btnInOrder);
            this.Controls.Add(this.btnInsertar);
            this.Name = "frmArbolB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmArbolB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.TextBox txtInsertar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnPostOrder;
        private System.Windows.Forms.Button btnPreOrder;
        private System.Windows.Forms.Button btnInOrder;
        private System.Windows.Forms.Button btnInsertar;
    }
}