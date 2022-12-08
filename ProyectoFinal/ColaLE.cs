using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaListaEnlazada
{
    internal class ColaLE
    {
        private NodoLE head;
        private NodoLE tail;
        public ColaLE()
        {
            head = null;
            tail = null;
        }
        public void Agregar(string dato)
        {
            NodoLE nuevo = new NodoLE();
            nuevo.Dato = dato;
            if (head == null)
            {
                head = nuevo;
                tail = nuevo;
            }
            else
            {
                tail.Siguiente = nuevo;
                tail = nuevo;
            }
        }
        public void Eliminar()
        {
            if (head == tail)
            {
                head = null;
                tail = null;
                return;
            }
            head = head.Siguiente;
        }

        public override string ToString()
        {
            string cadena = "";
            NodoLE h = head;
            if (h != null)
            {
                cadena += h.ToString();
                h = h.Siguiente;
                while (h != null)
                {
                    cadena += ", " + h.ToString();
                    h = h.Siguiente;
                }
                return cadena;
            } 
            else
            {
                return "La cola está vacía.";
            }
            
        }
    }
}
