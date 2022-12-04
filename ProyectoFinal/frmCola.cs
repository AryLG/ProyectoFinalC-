using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }
        Cola C = new Cola();
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtDato.Text == "")
            {
                MessageBox.Show("Ingresa dato");

            }
            if (txtDato.Text != "")
            {

                Nodo n = new Nodo();
                n.Dato = int.Parse(txtDato.Text);
                C.Insertar(n);
                MessageBox.Show(C.ToString());
                txtDato.Clear();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (C.EstaVacia() == false)
            {
                C.Eliminar();
                if (C.EstaVacia() == false)
                {
                    MessageBox.Show(C.ToString());
                }

            }

            if (C.EstaVacia())
            {
                MessageBox.Show("Cola vacia");
            };

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (C.EstaVacia() == false)
            {
                MessageBox.Show(C.ToString());

            }
            if (C.EstaVacia())
            {
                MessageBox.Show("Cola vacia");
            };
        }
    }
}
