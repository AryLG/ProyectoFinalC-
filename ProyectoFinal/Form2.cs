using AppAlg;
using appMetododeselecciónnuevo;
using AppRS;
using Burbuja;
using CountingSort;
using Ordenamiento_Mezcla_Natural;
using OrdenamientoABB;
using OrdenamientoRapido;
using ShellSort;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmBurbuja F = new frmBurbuja();
            F.Show(); 
            DoubleBuffered = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmInsercioon F = new frmInsercioon();
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

        private void button7_Click(object sender, EventArgs e)
        {
            frmShellS F = new frmShellS();
            F.Show();
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
            F.Show();
            DoubleBuffered = true;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmRadix F = new frmRadix();
            F.Show();
            DoubleBuffered = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOAbb F = new frmOAbb();
            F.Show();
            DoubleBuffered = true;
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

