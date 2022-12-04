using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoFinal
{
    class PilaConLista
    {
        public Nodo top;

        public Nodo Top
        {
            get { return top; }
            set { top = value; }
        }

        public PilaConLista()
        {
            top = null;
        }

        public override string ToString()
        {
            string r = "";
            Nodo h = top;
            while (h != null)
            {
                r += h.Dato + Environment.NewLine;
                h = h.Siguiente;

            }
            return r;
        }

        public void push(Nodo n)
        {
            if (top == null)
            {
                top = n;

                return;
            }

            if (top != null)
            {

                n.Siguiente = top;
                top = n;
                return;
            }
        }

        public bool pop()
        {
            if (top != null)
            {
                top = top.Siguiente;
                return true;
            }
            return false;

        }

        public bool Buscar(int n)
        {
            Nodo h;
            h = top;

            while (h != null)
            {
                if (n == h.Dato)
                {
                    return true;
                }
                h = h.Siguiente;
            }
            return false;
        }

        public void CimaPila()
        {
            int n;

            if (top == null)
            {
                MessageBox.Show("LA PILA ESTA VACIA.");
            }
            else
            {
                n = top.Dato;
                MessageBox.Show("EL ULTIMO ELEMENTO AGREGADO CONTIENE EL DATO: " + n);
            }

        }
    }
}
