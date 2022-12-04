using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountingSort
{
    public partial class frmCuentas : Form
    {
        //Var
        int n;
      int comparaciones = 0;
        int pasadas = 0;
        public frmCuentas()
        {
            InitializeComponent();
        }
       

        Stopwatch contador = new Stopwatch();
        public  void countingSort(int[] array)
        {
            int min = 0;
            int max = 0;

            for (int i = 0; i < array.Length; i++)
            {
               
                if (array[i] < min)
                    min = array[i];
                if (array[i] > max)
                    max = array[i];
            }
            //
           
            int[] count = new int[max - min + 1];
            int z = 0;
           
            for (int i = 0; i < count.Length; i++)
                count[i] = 0;

            for (int i = 0; i < array.Length; i++)
                count[array[i] - min]++;
          
            for (int i = min; i <= max; i++)
            {            
               
                while (count[i - min]-- > 0) 
                {
                    pasadas++;
                    array[z] = i;
                    ++z;
                    
                }
                comparaciones++;
            }
            txtComp.Text = "";
            txtComp.Text = comparaciones.ToString();
            txtPasadas.Text = pasadas.ToString();
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if(txtNumero.Text != "")
            {
                txtComp.Text = "";
                lstMostrar.Items.Clear();
                lstMostrar2.Items.Clear(); 
                n = Convert.ToInt32(txtNumero.Text);
            int[] vector;
            vector = new int[n];
             
                Random r = new Random(); //numero random
                
                for (int i = 0; i < n; i++)
                {  
                    vector[i] = r.Next(1, 50);//del 1 al 20                 
                }
                countingSort(vector);
                for (int i = 0; i < vector.Length; i++)
                {
                    lstMostrar.Items.Add(vector[i]);
                    

                }

                //Cuando termina el ascendente lo hace en revesrsa
                Array.Reverse(vector);

                for (int i = 0; i < vector.Length; i++)
                {
                    lstMostrar2.Items.Add(vector[i]);
                  

                }   //tiempo en ordenar
                contador.Restart();
                txtTiempoOrdenar.Text = contador.Elapsed.TotalMilliseconds.ToString() + " 𝘮𝘪𝘭𝘪-𝘴𝘦𝘨𝘶𝘯𝘥𝘰𝘴";
                contador.Stop();
                
            }
          

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPasadas.Text = "";
            txtNumero.Text = "";
            txtComp.Text = "";
            lstMostrar.Items.Clear();
            lstMostrar2.Items.Clear();
            txtTiempoOrdenar.Text = "";
           
        }
       //
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmCuentas_Load(object sender, EventArgs e)
        {

        }
    }
}
