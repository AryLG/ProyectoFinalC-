using ProyectoFinal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace AppRS
{
    public partial class frmRadix : Form
    {
        Random R = new Random();
        int[] arreglo;
        int mn = 0;
        int mx = 10000;
        public frmRadix()
        {
            InitializeComponent();
        }
        private void creararreglo()
        {
            int n =int.Parse(TxtTamaño.Text);
            arreglo = new int[n];
        }
        private void aleatorio()
        {
            creararreglo();
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = R.Next(mn, mx + 1);
            }
        }
        private void Borrar()
        {
            TxtTiempo.Clear();
            TxtTamaño.Clear();
            LtbArregloAleatorio.Items.Clear();
            LtbArregloOrdenado.Items.Clear();
            LtbArregloOrdenadoMN.Items.Clear();
        }
        private void sort()
        {
            int[] tmp = new int[arreglo.Length];
            //verificar si el cambio es mayor que 1 negativo de lo contrario el programa finaliza
            for (int shift = 31; shift > -1; shift--)
            {
                int j = 0;
                //si i es menor que la longitud de la matriz crea una variable booleana
                for (int i = 0; i < arreglo.Length; i++)
                {
                    bool move = (arreglo[i] << shift) >= 0;
                    //si el valor de shift es cero entonces
                    //no queremos mover los datos por que 
                    //el numero esta en la posicion incorrecta
                    if (shift == 0 ? !move : move)
                    {
                        //manejo el cambio
                        arreglo[i - j] = arreglo[i];
                    }
                    else
                    {
                        //esto continua hasta que el valor de shift ya no es
                        //mayor que uno negativo, significa que ya se pasó por todos los digitos de los numeros
                        tmp[j++] = arreglo[i];
                    }
                }
                //copiaremos la matriz
                Array.Copy(tmp, 0, arreglo, arreglo.Length - j, j);
            }
        }
        private void sortMN()
        {
            int[] tmp = new int[arreglo.Length];
            for (int shift = 31; shift > -1; shift--)
            {
                int j = 0;
                for (int i = 0; i < arreglo.Length; i++)
                {
                    bool move = (arreglo[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                    {
                        tmp[j++] = arreglo[i];
                    }
                    else
                    {
                        arreglo[i - j] = arreglo[i];
                    }
                }
                Array.Copy(tmp, 0, arreglo, arreglo.Length - j, j);
            }
        }
        private void imprimirArreglo()
        {
            foreach (var item in arreglo)
            {
                LtbArregloAleatorio.Items.Add(item);
            }
        }
        private void imprimirArregloOrdenado()
        {
            
            foreach (var item in arreglo)
            {
                LtbArregloOrdenado.Items.Add(item);
            }
        }
        private void imprimirArregloOrdenadoMN()
        {
            sortMN();
            foreach (var item in arreglo)
            {
                LtbArregloOrdenadoMN.Items.Add(item);
            }
        }
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtTamaño.Text))
            {
                MessageBox.Show("Primero inserta un tamaño");
            }
            else
            {
                aleatorio();
                imprimirArreglo();
                long tiempoinicial = DateTime.Now.Ticks;
                sort();
                long tiempoFinal = DateTime.Now.Ticks;
                TxtTiempo.Text = ((tiempoFinal - tiempoinicial) / 10000.0).ToString();
                imprimirArregloOrdenado();

                imprimirArregloOrdenadoMN();
            }
        }
        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtTamaño.Text))
            {
                MessageBox.Show("Primero inicia con un tamaño");
            }
            else
            {
                Borrar();
            }
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Form2 F = new Form2();
            F.Show(); DoubleBuffered = true;
            this.Hide();
        }
    }
}
