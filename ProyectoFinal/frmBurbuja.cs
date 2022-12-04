using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Burbuja
{
    public partial class frmBurbuja : Form
    {
        public frmBurbuja()
        {
            InitializeComponent();
        }
        int[] vector = new int[100];
        int n, i;
        int contador2 = 0;
        int comparaciones = 0;

        Stopwatch contador = new Stopwatch();
        public void generarDatos(int n)
        {
            Random aleatorio = new Random();
            for(i=0; i<n; i++)
            {
                vector[i] = aleatorio.Next(1, 101);
            }
        }
        void burbuja(int n)
        {
            int recorrido, actual, aux;
            
            for(recorrido=1; recorrido<n; recorrido++)
            {
                contador2++;
                for(actual=0; actual<n-recorrido;  actual++)
                {
                    if (vector[actual] > vector[actual+1])
                    {
                        aux = vector[actual];
                        vector[actual] = vector[actual + 1];
                        vector[actual + 1] = aux;
                    }
                    comparaciones++;
                }
                lblntercambios.Text= contador2.ToString();
                tbComparaciones.Text = comparaciones.ToString();
            }
        }
        void burbuja2(int n)
        {
            int recorrido, actual, aux;

            for (recorrido = 1; recorrido < n; recorrido++)
            {
                contador2++;
                for (actual = 0; actual < n - recorrido; actual++)
                {
                    if (vector[actual] < vector[actual + 1])
                    {
                        aux = vector[actual];
                        vector[actual] = vector[actual + 1];
                        vector[actual + 1] = aux;
                    }
                    comparaciones++;
                }
                lblntercambios.Text = contador2.ToString();
                tbComparaciones.Text = comparaciones.ToString();
            }
        }
        void Mostrar(int n,ListBox listBox0)
        {
            for (i = 0; i < n; i++)
            {
                listBox0.Items.Add(vector[i]);
            }
        }
        private void BtnGenerarDatos_Click(object sender, EventArgs e)
        {
            
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                n = int.Parse(txtn.Text);
                contador.Restart();
                generarDatos(n);
                contador.Stop();
                lblTiempoGenerar.Text = contador.Elapsed.TotalMilliseconds.ToString() + "Millisegundos";
                Mostrar(n, listBox1);
               
           
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            contador.Restart();
            burbuja(n);
            contador.Stop();
            lblTiempoOrdenar.Text = contador.Elapsed.TotalMilliseconds.ToString() + "Millisegundos";
            Mostrar(n, listBox2);

        }

        private void btnOrdenar2_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            contador.Restart();
            burbuja2(n);
            contador.Stop();
            label5.Text = contador.Elapsed.TotalMilliseconds.ToString() + "Millisegundos";
            Mostrar(n, listBox3);          
        }

        private void Burbuja_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
