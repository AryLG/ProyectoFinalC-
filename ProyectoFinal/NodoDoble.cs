using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class NodoDoble
    {
        private NodoDoble siguiente;
        private NodoDoble atras;
        private int dato;
        public NodoDoble Atras
        {
            get { return atras; }
            set { atras = value; }
        }
        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public NodoDoble Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public NodoDoble()
        {
            dato = 0;
            atras = null;
            siguiente = null;
        }
        public override string ToString()
        {
            return dato.ToString();
        }
    }
}
