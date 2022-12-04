using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class ListaDobleCircular
    {
        private NodoDoble head;
        public NodoDoble Head
        {
            get { return head; }
            set { head = value; }
        }
        public ListaDobleCircular()
        {
            head = null;
        }
        public override string ToString()
        {
            string r = "";
            NodoDoble h = head;
            while (head != null)
            {
                r += " " + h.Dato;
                h = h.Siguiente;
                if (h == head)
                {
                    return r;
                }
            }
            return r;
        }

        public void Insertar(NodoDoble nuevo)
        {
            NodoDoble h = head;
            if (head == null)
            {
                head = nuevo;
                nuevo.Siguiente = nuevo;
                nuevo.Atras = nuevo;
                return;
            }
            if (nuevo.Dato < head.Dato)
            {
                nuevo.Siguiente = head;
                head.Atras.Siguiente = nuevo;
                nuevo.Atras = head.Atras;
                head.Atras = nuevo;
                head = nuevo;
                return;
            }
            while (h.Siguiente != head)
            {
                if (nuevo.Dato < h.Siguiente.Dato)
                {
                    break;
                }
                h = h.Siguiente;
            }
            nuevo.Siguiente = h.Siguiente;
            nuevo.Atras = h;
            h.Siguiente.Atras = nuevo;
            h.Siguiente = nuevo;
        }
        public bool Buscar(int DatoDelNodo)
        {
            NodoDoble h = head;
            bool a = false;
            while (h.Siguiente != head)
            {
                if (DatoDelNodo == h.Dato)
                {
                    a = true;
                }
                h = h.Siguiente;
            }
            if (h.Dato == DatoDelNodo)
            {
                a = true;
            }
            return a;
        }
        public bool Eliminar(int nodobuscado)
        {
            NodoDoble h = head;
            if (head != null)
            {
                do
                {
                    if (h.Dato == nodobuscado)
                    {
                        //ELIMINAR EL UNICO NODO DE LA LISTA
                        if (head.Siguiente == head && head.Atras == head)
                        {
                            head = null;
                            return true;
                        }
                        //ELIMINAR PRIMER NODO DE LA LISTA
                        if (h == head)
                        {
                            head.Atras.Siguiente = head.Siguiente;
                            head.Siguiente.Atras = head.Atras;
                            head = head.Siguiente;
                            return true;
                        }
                        //ELIMINAR ULTIMO NODO DE LA LISTA
                        if (h == head.Atras)
                        {
                            head.Atras = h.Atras;
                            head.Atras.Siguiente = head;
                            h = h.Atras;
                            return true;
                        }
                        //ELIMINAR UN NODO DE ENMEDIO DE LA LISTA
                        else
                        {
                            h.Atras.Siguiente = h.Siguiente; ;
                            h.Siguiente.Atras = h.Atras;
                            return true;
                        }
                    }
                    h = h.Siguiente;
                } while (h != head);
            }
            return false;
        }
    }
}
