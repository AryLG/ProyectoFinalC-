using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class Cola
    {
        public Nodo frente;
        public Nodo Frente
        {
            get { return frente; }
            set { frente = value; }
        }
        public Nodo final;
        public Nodo Final
        {
            get { return final; }
            set { final = value; }
        }

        public Cola()
        {
            frente = null;
            final = null;
        }
        public override string ToString()
        {
            string r = "";
            Nodo f = frente;
            while (f != null)
            {
                r += f.Dato + " ";
                f = f.Siguiente;
            }
            return r;
        }
        public bool EstaVacia()
        {
            if (Frente == null)
                return (true);
            else
                return (false);
        }
        public void Insertar(Nodo n)
        {
            if (frente == null)
            {
                frente = n;
                final = n;
                return;
            }

            if (final.Siguiente == null)
            {
                n.Siguiente = final.Siguiente;
                final.Siguiente = n;
                final = n;
                return;
            }


        }
        public void Eliminar()
        {

            if (Frente == Final)
            {
                //Nodo f = new Nodo();
                //f = Frente;
                Frente = null;
                Final = null;
            }

            if (frente != null)
            {
                //Nodo f = new Nodo();
                //f = frente;
                frente = frente.Siguiente;
                //f = null;
            }
        }

    }
}
