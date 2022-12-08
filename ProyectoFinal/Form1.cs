using _EDD_Tarea3;
using AppAlg;
using appMetododeselecciónnuevo;
using Burbuja;
using CountingSort;
using Grafos;
using Ordenamiento_Mezcla_Natural;
using OrdenamientoRapido;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListaSimple_Click(object sender, EventArgs e)
        {
            frmListaSimple F = new frmListaSimple();
            F.Show(); DoubleBuffered = true;


        }

        private void btnListaDoble_Click(object sender, EventArgs e)
        {
            frmListaDoble F = new frmListaDoble();
            F.Show(); DoubleBuffered = true;
        }

        private void btnListaCircular_Click(object sender, EventArgs e)
        {
            frmListaCircular F = new frmListaCircular();
            F.Show(); DoubleBuffered = true;
        }

        private void btnListaDobleCircular_Click(object sender, EventArgs e)
        {
            frmListaDobleCircular F = new frmListaDobleCircular();
            F.Show(); DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
        }

        private void btnPila_Click(object sender, EventArgs e)
        {
            frmPila F = new frmPila();
            F.Show();
            DoubleBuffered = true;
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            Form3 F = new Form3();
            F.Show();
            DoubleBuffered = true;
        }

        private void btnArbolB_Click(object sender, EventArgs e)
        {
            OAbb F = new OAbb();
            F.Show();
            DoubleBuffered = true;
        }

        private void btnGrafo_Click(object sender, EventArgs e)
        {
            frmGrafos F = new frmGrafos();
            F.Show();
            DoubleBuffered = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            DoubleBuffered = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmBurbuja F = new frmBurbuja();
            F.Show();
            DoubleBuffered = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
             frmInsercioon F= new frmInsercioon();
            F.Show();
            DoubleBuffered = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmCuentas F = new frmCuentas();
            F.Show();
            DoubleBuffered = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMezcla F = new frmMezcla();
            F.Show();
            DoubleBuffered = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoubleBuffered = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSeleccion F = new frmSeleccion();
            F.Show();
            DoubleBuffered = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmRapido F = new frmRapido();
            F.Show();DoubleBuffered = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MenuPrincipal F = new MenuPrincipal();
            F.Show();
            DoubleBuffered = true;
            this.Hide();
        }
    }
}
