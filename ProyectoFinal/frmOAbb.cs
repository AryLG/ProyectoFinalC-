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
using ProyectoFinal;

namespace OrdenamientoABB
{
    public partial class frmOAbb : Form
    {
        OOABB arbol;
        public frmOAbb()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        { agregar(false); }

        private void btnInvertidos_Click(object sender, EventArgs e)
        { agregar(true); }

        private void agregar(bool invertido)
        {
            if (String.IsNullOrEmpty(txtCantidad.Text) == true)
            { return; }

            arbol = new OOABB();

            int[] datos = new int[int.Parse(txtCantidad.Text)];
            Random r = new Random();
            string cadena = "";
            for (int i = 0; i < datos.Length; i++)
            {
                datos[i] = r.Next(0, 500);
                cadena += ", " + datos[i];
            }
            txtSinOrdenar.Text = cadena;

            //invertido
            if (invertido)
            {
                double tiempoIniciali = double.Parse(DateTime.Now.Ticks.ToString());
                for (int i = 0; i < datos.Length; i++)
                {
                    arbol.Insertar(datos[i], invertido);
                }
                txtInorden.Text = arbol.Inorden();
                double tiempoFinali = double.Parse(DateTime.Now.Ticks.ToString());
                MessageBox.Show("El tiempo total en milisegundos fue: " + ((tiempoFinali - tiempoIniciali) / 10000));

                string ruta = arbol.Graficar();

                System.Threading.Thread.Sleep(1000);
                FileStream file = new FileStream(ruta, FileMode.Open);
                Image img = Image.FromStream(file);
                pictureBox1.Image = img;
                file.Close();

            }
            else
            {
                //no invertido
                double tiempoInicial = double.Parse(DateTime.Now.Ticks.ToString());
                for (int i = 0; i < datos.Length; i++)
                {
                    arbol.Insertar(datos[i], invertido);
                }
                txtInorden.Text = arbol.Inorden();
                double tiempoFinal = double.Parse(DateTime.Now.Ticks.ToString());
                MessageBox.Show("El tiempo total en milisegundos fue: " + ((tiempoFinal - tiempoInicial) / 10000));

                string ruta = arbol.Graficar();

                System.Threading.Thread.Sleep(1000);
                FileStream file = new FileStream(ruta, FileMode.Open);
                Image img = Image.FromStream(file);
                pictureBox1.Image = img;
                file.Close();
                MessageBox.Show("El tiempo total en milisegundos fue: " + ((tiempoFinal - tiempoInicial) / 10000));

            }

        }

        private void label12_Click(object sender, EventArgs e)
        {
            Form2 F = new Form2();
            F.Show(); DoubleBuffered = true;
            this.Hide();
        }
    }
}
