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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }
        ListaDoble listaD = new ListaDoble();
        private void txtInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                NodoDoble n = new NodoDoble();
                if (listaD.BuscarNodo(int.Parse(txtDato.Text)) == true)
                {
                    txtDato.Clear();
                    MessageBox.Show("El NUMERO QUE ESTA NO ES POSIBLE DUPLICARSE");
                    return;
                }
                else
                {
                    n.Dato = int.Parse(txtDato.Text);
                    listaD.Insertarnodo(n);
                    MessageBox.Show(listaD.DesplegarListaPU());

                }
                txtDato.Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("INGRESE UN DATO");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtDato.Text != "")
            {
                if (listaD.BuscarNodo(int.Parse(txtDato.Text)) == true)
                {
                    listaD.EliminarNodo(int.Parse(txtDato.Text));
                    txtDato.Clear();
                    MessageBox.Show(listaD.DesplegarListaPU());
                }
                else
                {
                    MessageBox.Show("El dato " + txtDato.Text + " No existe en esta lista");
                    txtDato.Clear();
                }
            }
            else
            {
                MessageBox.Show("INGRESE UN DATO");
            }
        }

        private void btnBuscado_Click(object sender, EventArgs e)
        {
            if (txtDato.Text != "")
            {


                if (listaD.BuscarNodo(int.Parse(txtDato.Text)) == false)
                {
                    MessageBox.Show("El dato no existe");
                }

                if (listaD.BuscarNodo(int.Parse(txtDato.Text)) == true)
                {
                    MessageBox.Show("El dato " + txtDato.Text + "   si existe");
                    txtDato.Clear();
                }
            }
            else
            {
                MessageBox.Show("INGRESE UN DATO");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listaD.DesplegarListaPU());
        }
    }
}
