using colaCircularDinamica;
using ColaListaEnlazada;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmColaCircularD F = new frmColaCircularD();
            F.Show();
            DoubleBuffered = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmColaListaE F = new frmColaListaE();
            F.Show();
            DoubleBuffered = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 F = new Form2();
            F.Show();
            DoubleBuffered = true;
            this.Hide();
        }
    }
}
