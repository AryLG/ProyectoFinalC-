using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class NodoArbol
    {

        private int dato;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }


        private NodoArbol Derecha;

        public NodoArbol derecha
        {
            get { return Derecha; }
            set { Derecha = value; }
        }

        private NodoArbol Izquierda;

        public NodoArbol izquierda
        {
            get { return Izquierda; }
            set { Izquierda = value; }
        }
        public NodoArbol()
        {
            Dato = 0;

            derecha = null;
            Izquierda = null;

        }
    }

}

