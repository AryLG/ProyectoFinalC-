using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientoABB
{
    class NodoOABBB
    {
        public int dato { get; set; }
        public NodoOABBB izquierdo { get; set; }
        public NodoOABBB derecho { get; set; }

        public NodoOABBB(int dato)
        {
            this.dato = dato;
            this.izquierdo = null;
            this.derecho = null;
        }
    }
}
