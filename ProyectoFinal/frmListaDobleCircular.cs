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
    public partial class frmListaDobleCircular : Form
    {
        public frmListaDobleCircular()
        {
            InitializeComponent();
        }
        ListaDobleCircular ListaDC = new ListaDobleCircular();
        private void txtInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListaDC.Head == null)
                {
                    NodoDoble n = new NodoDoble();
                    n.Dato = int.Parse(txtDato.Text);
                    ListaDC.Insertar(n);
                    MessageBox.Show("Nodo insertado exitosamente: " + ListaDC.ToString());
                    txtDato.Clear();
                    txtDato.Focus();
                    return;
                }

                if (ListaDC.Head != null)
                {
                    if (ListaDC.Buscar(int.Parse(txtDato.Text)) == true)
                    {
                        MessageBox.Show("El nodo que intentas ingresar ya existe");
                    }
                    else if (ListaDC.Buscar(int.Parse(txtDato.Text)) == false)
                    {
                        NodoDoble n = new NodoDoble();
                        n.Dato = int.Parse(txtDato.Text);
                        ListaDC.Insertar(n);
                        txtDato.Clear();
                        MessageBox.Show("Nodo insertado exitosamente: " + ListaDC.ToString());
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Te equivocaste");
            }
            txtDato.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDato.Text != "")
                {
                    int d = int.Parse(txtDato.Text);
                    if (ListaDC.Eliminar(d) == true)
                    {
                        MessageBox.Show("Nodo eliminado: " + ListaDC.ToString());
                    }
                    else if (ListaDC.Eliminar(d) == false)
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
                if (ListaDC.Head == null)
                {
                    MessageBox.Show("Lista vacia");
                    return;
                }
                if (ListaDC.Buscar(int.Parse(txtDato.Text)) == true)
                {
                    MessageBox.Show("Nodo encontrado");
                }
                else if (ListaDC.Buscar(int.Parse(txtDato.Text)) == false)
                {
                    MessageBox.Show("Nodo no encontrado");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hiciste algo mal");
            }
            txtDato.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (ListaDC.Head == null)
            {
                MessageBox.Show("Lista vacia");
            }
            if (ListaDC.Head != null)
            {
                MessageBox.Show(ListaDC.ToString());
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
