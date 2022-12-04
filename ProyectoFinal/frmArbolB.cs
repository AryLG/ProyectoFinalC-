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
    public partial class frmArbolB : Form
    {
        ArbolBinario Arbol;
        public frmArbolB()
        {
            InitializeComponent();
            Arbol = new ArbolBinario();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtInsertar.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Debes ingresar un valor entero en cuadro de texto");
                txtInsertar.Clear();
                txtInsertar.Focus();
                return;
            }
            if (Arbol.Buscar(int.Parse(txtInsertar.Text)) == false)
            {


                NodoArbol n = new NodoArbol();

                n.Dato = int.Parse(txtInsertar.Text);

                Graphics nodo;
                nodo = CreateGraphics();
                Arbol.insertar1(n, nodo, this);

            }
            else
            {
                MessageBox.Show("Ya ha un nodo con ese dato");
            }



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtEliminar.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Debes ingresar un valor entero en cuadro de texto");
                txtEliminar.Clear();
                txtEliminar.Focus();
                return;
            }
            if (Arbol.Buscar(int.Parse(txtEliminar.Text)) == true)
            {
                Arbol.eliminarNodoHoja(int.Parse(txtEliminar.Text));
            }
            else
            {
                MessageBox.Show("El nodo con el numero " + txtBuscar.Text + " no existe, y por lo tanto no se puede eliminar", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtBuscar.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Debes ingresar un valor entero en cuadro de texto");
                txtBuscar.Clear();
                txtBuscar.Focus();
                return;
            }
            if (Arbol.Buscar(int.Parse(txtBuscar.Text)) == true)
            {
                MessageBox.Show("El nodo con el numero " + txtBuscar.Text + " existe", "Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El nodo con el numero " + txtBuscar.Text + " no existe", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInOrder_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Recorrido InOrden");
            listBox1.Items.Add("");
            Arbol.CallInOrden(listBox1);
        }

        private void btnPreOrder_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Recorrido PreOrden");
            listBox1.Items.Add("");
            Arbol.CallPreOrden(listBox1);
        }

        private void btnPostOrder_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Recorrido PosOrder");
            listBox1.Items.Add("");
            Arbol.CallPosOrden(listBox1);
        }
    }
    }

