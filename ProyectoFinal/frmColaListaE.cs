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

namespace ColaListaEnlazada
{
    public partial class frmColaListaE : Form
    {
        public frmColaListaE()
        {
            InitializeComponent();
        }
        ColaLE colaDinamica = new ColaLE();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            colaDinamica.Agregar(txtDato.Text);
            txtCola.Text = colaDinamica.ToString();
            txtDato.Clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            colaDinamica.Eliminar();
            txtCola.Text = colaDinamica.ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Form3 F = new Form3();
            F.Show(); DoubleBuffered = true;
            this.Hide();
        }
    }
}
