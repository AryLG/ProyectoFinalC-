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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
        
        }

        private void btnListaSimple_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.Show(); DoubleBuffered = true;
            this.Hide();
        }

        private void btnListaDoble_Click(object sender, EventArgs e)
        {
            Form2 F = new Form2();
            F.Show(); DoubleBuffered = true;
            this.Hide();
        }
    }
}
