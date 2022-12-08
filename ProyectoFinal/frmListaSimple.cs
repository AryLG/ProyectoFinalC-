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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        ListaSimpleC ListSimple = new ListaSimpleC();


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDato.Text != "")
                {
                    int d = int.Parse(txtDato.Text);
                    if (ListSimple.Eliminar(d) == true)
                    {
                        MessageBox.Show("Nodo eliminado: " + ListSimple.ToString());
                    }
                    else if (ListSimple.Eliminar(d) == false)
                    {
                        MessageBox.Show("Nodo no encontrado");
                    }
                }
                else if (txtDato.Text == "")
                {
                    MessageBox.Show("Ingresa el dato del nodo a eliminar");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hiciste algo mal");
            }
            txtDato.Clear();
        }
    

        private void btnBuscado_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListSimple.Buscar(int.Parse(txtDato.Text)) == false)
                {
                    MessageBox.Show("El dato buscado no existe");
                }

                if (ListSimple.Buscar(int.Parse(txtDato.Text)) == true)
                {
                    MessageBox.Show("El nodo existe");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dato a buscar no es valido");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ListSimple.ToString());
        }

        private void txtInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListSimple.Buscar(int.Parse(txtDato.Text)) == true)
                {
                    txtDato.Clear();
                    MessageBox.Show("El numero ya existe y no se puede duplicar, elige otro");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El dato ingresado no corresponde a un numero");
            }
            Nodo n = new Nodo();
            try
            {
                n.Dato = int.Parse(txtDato.Text);
                txtDato.Clear();
                ListSimple.Insertar(n);
                MessageBox.Show(ListSimple.ToString());
                txtDato.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
           Form1 F = new Form1();
            F.Show(); DoubleBuffered = true;
            this.Hide();
        }
    }
}
