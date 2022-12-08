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
    public partial class frmListaCircular : Form
    {
        public frmListaCircular()
        {
            InitializeComponent();
        }
        ListaCircular ListaC = new ListaCircular();
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int d = int.Parse(txtDato.Text);
                txtDato.Clear();
                if (ListaC.Eliminar(d) == true)
                {
                    MessageBox.Show("Nodo ha sido eliminado: " + ListaC.ToString());
                }
                else
                {
                    MessageBox.Show("Nodo no existe");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dato no valido");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (ListaC.Head == null)
            {
                MessageBox.Show("Lista vacia");
            }
            if (ListaC.Head != null)
            {
                MessageBox.Show(ListaC.ToString());
            }
        }

        private void btnBuscado_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListaC.Buscar(int.Parse(txtDato.Text)) == true)
                {
                    MessageBox.Show("Nodo encontrado");
                }
                else
                {
                    MessageBox.Show("Nodo no encontrado");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El dato buscado no es valio...");
            }
            txtDato.Clear();
        }

        private void txtInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListaC.Head == null)
                {
                    Nodo n = new Nodo();
                    n.Dato = int.Parse(txtDato.Text);
                    ListaC.Insertar(n);
                    txtDato.Clear();
                    MessageBox.Show("Nodo insertado exitosamente: " + ListaC.ToString());
                    txtDato.Focus();
                    return;
                }

                if (ListaC.Head != null)
                {
                    if (ListaC.Buscar(int.Parse(txtDato.Text)) == true)
                    {
                        MessageBox.Show("El nodo que intentas ingresar ya existe");
                        txtDato.Clear();
                    }
                    else if (ListaC.Buscar(int.Parse(txtDato.Text)) == false)
                    {
                        Nodo n = new Nodo();
                        n.Dato = int.Parse(txtDato.Text);
                        ListaC.Insertar(n);
                        txtDato.Clear();
                        MessageBox.Show("Nodo insertado exitosamente: " + ListaC.ToString());
                        txtDato.Focus();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hiciste algo mal");
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
