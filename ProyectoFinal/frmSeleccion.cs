using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace appMetododeselecciónnuevo
{
    public partial class frmSeleccion : Form
    {
        public frmSeleccion()
        {
            InitializeComponent();
        }
        public int n;
        public int i;
        int contador = 0;
        int comparaciones = 0;
        int intercambios = 0;
        public void generarDatos()
        {
            int[] datos = new int[int.Parse(txttamaño.Text)];
            Random r = new Random();
            for (i = 0; i < datos.Length; i++)
            {
                datos[i] = r.Next(0, 100);
            }
            Ejecutar(datos);
        }
        public void ordenamientoseleccion(int[] datos)
        {
            int tamaño = datos.Length;
            int minimo = 0;
            int aux = 0;
            for (int i = 0; i < tamaño; i++)
            {
                contador++;
                minimo = i;
                for (int j = i + 1; j < tamaño; j++)
                {
                    comparaciones++;
                    if (datos[j] < datos[minimo])
                    {
                        minimo = j;
                    }
                    intercambios++;
                }
                aux = datos[i];
                datos[i] = datos[minimo];
                datos[minimo] = aux;
            }
            txtvectorordenadoa.Text += "Vector Ordenado Menor a Mayor" + Environment.NewLine;
            foreach (int dato in datos)
            {
                txtvectorordenadoa.Text += dato + Environment.NewLine;
            }
            txtmayor.Text += "Vector Ordenado Mayor a Menor" + Environment.NewLine;
            for (int t = datos.Length; t > 0; t--)
            {
                txtmayor.Text += datos[t - 1]+ Environment.NewLine;
            }
            lblpa.Text = contador.ToString();
            lblcomparaciones.Text = comparaciones.ToString();
            lblis.Text = intercambios.ToString();
        }
        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            generarDatos();
        }
        private void Ejecutar(int[] datos)
        {
            txtvectorordenadoa.Text += "Vector Desordenado" + Environment.NewLine;
            foreach (int dato in datos)
            {
                txtvectorordenadoa.Text += dato + Environment.NewLine;
            }
            txtmayor.Text += "Vector Desordenado" + Environment.NewLine;
            foreach (int dato in datos)
            {
                txtmayor.Text += dato + Environment.NewLine;
            }
            long tiempoInicial = DateTime.Now.Ticks;
            ordenamientoseleccion(datos);
            long tiempoFinal = DateTime.Now.Ticks;
            lbltiempoenordenar.Text = ((tiempoFinal - tiempoInicial) / 10000.0).ToString();
        }
        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtvectorordenadoa.Clear();
            txttamaño.Clear();
            txtmayor.Clear();
        }
        private void btncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSeleccion_Load(object sender, EventArgs e)
        {

        }
    }
}
