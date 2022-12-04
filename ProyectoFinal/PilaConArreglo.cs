using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    class PilaConArreglo
    {
        private int top;
        private int maximo;
        private int[] lapila;

        public PilaConArreglo()
        {
            top = -1;
            maximo = 0;
            lapila = new int[0];

        }

        public PilaConArreglo(int max)
        {
            lapila = new int[max];
            maximo = max;
            top = -1;
        }

        public bool pilallena()
        {
            if (top == maximo - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool pilavacia()
        {
            if (top == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void push(int n)
        {
            if (pilallena() == true)
            {
                MessageBox.Show("LA PILA ESTA LLENA");

            }
            else
            {
                top++;
                lapila[top] += n;

            }
        }

        public int pop()
        {
            int n = 0;
            if (pilavacia() == true)
            {
                return -1;
            }
            else
            {
                n = lapila[top];
                top--;
                return n;
            }
        }

        public override string ToString()
        {
            string r = "";

            for (int i = top; i >= 0; i--)
            {
                r += lapila[i] + " " + Environment.NewLine;
            }
            return r;
        }
        public bool estaVacia
        {

            get
            {
                bool vacia = false;
                if (top == -1)
                {
                    vacia = true;
                }
                return vacia;
            }
        }

        public bool Buscar(int n)
        {
            int r;

            for (int i = top; i >= 0; i--)
            {
                r = lapila[i];
                if (r == n)
                {
                    return true;
                }
            }
            return false;
        }

        public void cima()
        {
            int n;
            if (top == -1)
            {
                MessageBox.Show("LA PILA ESTA VACIA.");

            }
            else
            {
                n = lapila[top];
                MessageBox.Show("EL ULTIMO ELEMENTO AGREGADO CONTIENE EL DATO: " + n);
            }
        }
    }
}
