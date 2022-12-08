using ProyectoFinal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colaCircularDinamica
{
    public partial class frmColaCircularD : Form
    {
        public frmColaCircularD()
        {
            InitializeComponent();
        }
        Cola circular = new Cola();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            circular.Agregar(txtDato.Text);
            txtDato.Clear();
            txtCola.Text = circular.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            circular.Eliminar();
            txtCola.Text = circular.ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Form3 F = new Form3();
            F.Show(); DoubleBuffered = true;
            this.Hide();
        }
    }
}
