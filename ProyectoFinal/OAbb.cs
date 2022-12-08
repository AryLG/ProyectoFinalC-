using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _EDD_Tarea3
{
    public partial class OAbb : Form
    {
        ABB arbol;
        public OAbb()
        {
            InitializeComponent();
            arbol = new ABB();
        } 
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbInsertar.Text) == false)
            {
                arbol.Insertar(tbInsertar.Text);
                Txt();
                string ruta = arbol.Graficar();
                System.Threading.Thread.Sleep(1000);
                FileStream file = new FileStream(ruta, FileMode.Open);
                Image img = Image.FromStream(file);
                pictureBox1.Image = img;
                file.Close();
            }
            tbInsertar.Clear();
        }
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            arbol.limpiar();
            Txt();
            string ruta = arbol.Graficar();
            System.Threading.Thread.Sleep(1000);
            FileStream file = new FileStream(ruta, FileMode.Open);
            Image img = Image.FromStream(file);
            pictureBox1.Image = img;
            file.Close();
            tbInsertar.Clear();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbInsertar.Text) == false)
            {
                arbol.Eliminar(tbInsertar.Text);
                Txt();
                string ruta = arbol.Graficar();
                System.Threading.Thread.Sleep(1000);
                FileStream file = new FileStream(ruta, FileMode.Open);
                Image img = Image.FromStream(file);
                pictureBox1.Image = img;
                file.Close();
            }
            tbInsertar.Clear();
        }
        private void Txt()
        {
            tbInorden.Text = arbol.Inorden();
            tbPreorden.Text = arbol.Preorden();
            tbPostorden.Text = arbol.Postorden();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            arbol.limpiar();
            string ruta = arbol.Graficar();
            System.Threading.Thread.Sleep(1000);
            Application.Exit();
        }
    }
}
