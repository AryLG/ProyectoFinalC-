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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }
        PilaConArreglo PilaArr = new PilaConArreglo();
        PilaConLista PilaLista = new PilaConLista();
        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtMaximo.Text != "")
            {
                int m = int.Parse(txtMaximo.Text);
                PilaArr = new PilaConArreglo(m);
                txtMaximo.Clear();
                txtNumero.Focus();
                MessageBox.Show("PILA CREADA");
            }
            else { MessageBox.Show("INGRESE EL TAMAÑO DE LA PILA"); }
        }

        private void btnPushArreglo_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text != "")
            {
                int n = int.Parse(txtNumero.Text);
                PilaArr.push(n);
                txtpila.Text = PilaArr.ToString();
                txtMaximo.Clear();
                txtNumero.Clear();
                txtNumero.Focus();

            }
            else
            {
                MessageBox.Show("INGRESE UN NUMERO");
                txtNumero.Focus();
            }
        }

        private void btnPopArreglo_Click(object sender, EventArgs e)
        {
            if (!PilaArr.estaVacia)
            {
                string dato;
                dato = PilaArr.pop() + "";
                txtpila.Text = PilaArr.ToString();
            }
            else { MessageBox.Show("LA PILA ESTA VACIA"); }
        }

        private void btnBuscarArreglo_Click(object sender, EventArgs e)
        {
            if (txtBuscarArreglo.Text != "")
                if (!PilaArr.Buscar(int.Parse(txtBuscarArreglo.Text)) == true)
                {
                    MessageBox.Show("EL NODO CON EL DATO " + txtBuscarArreglo.Text + " NO EXISTE EN LA PILA");
                    txtBuscarArreglo.Text = "";
                    txtBuscarArreglo.Focus();
                }
                else
                {
                    MessageBox.Show("EL NODO CON EL DATO " + txtBuscarArreglo.Text + " SI EXISTE EN LA PILA");
                    txtBuscarArreglo.Text = "";
                    txtBuscarArreglo.Focus();
                }
            else
            {
                MessageBox.Show("INSERTE DATO A BUSCAR");
                txtBuscarArreglo.Focus();
            }
        }

        private void btnCimaArreglo_Click(object sender, EventArgs e)
        {
            PilaArr.cima();
        }

        private void BtnPushLista_Click(object sender, EventArgs e)
        {
            if (txtNumeroLista.Text != "")
            {
                Nodo n = new Nodo();
                n.Dato = int.Parse(txtNumeroLista.Text);
                PilaLista.push(n);
                lbltexto.Text = PilaLista.ToString();
                txtNumeroLista.Text = "";
                txtNumeroLista.Focus();
            }
            else
            {
                MessageBox.Show("INGRESE UN NUMERO");
                txtNumeroLista.Focus();
            }
        }

        private void btnPopLista_Click(object sender, EventArgs e)
        {
            if (PilaLista.pop() == true)
            {

                lbltexto.Text = PilaLista.ToString();
            }
            else
            {
                MessageBox.Show("LA PILA ESTA VACIA");

            }
        }

        private void btnbuscarnodo_Click(object sender, EventArgs e)
        {
            if (txtbuscarnodo.Text != "")
                if (!PilaLista.Buscar(int.Parse(txtbuscarnodo.Text)) == true)
                {
                    MessageBox.Show("EL NODO CON EL DATO " + txtbuscarnodo.Text + " NO EXISTE EN LA PILA");
                    txtbuscarnodo.Text = "";
                    txtbuscarnodo.Focus();
                }
                else
                {
                    MessageBox.Show("EL NODO CON EL DATO " + txtbuscarnodo.Text + " SI EXISTE PILA");
                    txtbuscarnodo.Text = "";
                    txtbuscarnodo.Focus();
                }
            else
            {
                MessageBox.Show("INSERTE DATO A BUSCAR");
                txtbuscarnodo.Focus();
            }
        }

        private void btnCimaPilalista_Click(object sender, EventArgs e)
        {
            PilaLista.CimaPila();
        }
    }
}
