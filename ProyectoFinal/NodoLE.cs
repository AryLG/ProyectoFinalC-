using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaListaEnlazada
{
    internal class NodoLE
    {
        private string dato;
        private NodoLE siguiente;
        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public NodoLE Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public NodoLE()
        {
            dato = null;
            siguiente = null;
        }

        public NodoLE(string dato, NodoLE siguiente)
        {
            this.dato = dato;
            this.siguiente = siguiente;
        }

        public override string ToString()
        {
            return dato;
        }
    }
}
