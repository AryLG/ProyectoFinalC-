using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class ListaSimpleC
    {
        private Nodo head;

        public Nodo Head
        {
            get { return head; }
            set { head = value; }
        }
        public ListaSimpleC()
        {
            head = null;
        }

        public override string ToString()
        {
            string r = "";
            Nodo h = head;
            while (h != null)
            {
                r += " " + h.Dato;
                h = h.Siguiente;
            }

            return r;
        }

        //Insertar 

        public void Insertar(Nodo n)
        {
            if (head == null) // Si esta vacia.
            {
                head = n;
                return;
            }

            if (n.Dato < head.Dato) //Si el dato de n es menor que el dato de head.
            {
                n.Siguiente = head;
                head = n;
                return;
            }


            Nodo h = head; // igualamos h a head
            while (h.Siguiente != null)
            {
                if (n.Dato < h.Siguiente.Dato)//
                {
                    break;
                }

                h = h.Siguiente; // Se mueve al siguiente
            }
            n.Siguiente = h.Siguiente;
            h.Siguiente = n;
            return;
        }

        public bool Buscar(int DatoDelNodo)
        {
            Nodo h = head;
            while (h != null)
            {
                if (DatoDelNodo == h.Dato)
                {
                    return true;
                }
                if (DatoDelNodo < h.Dato)
                {
                    return false;
                }
                h = h.Siguiente;
            }
            return false;
        }

        public bool Eliminar(int nodobuscado)
        {
            Nodo h = head;
            Nodo ant = null;
            if (head != null)
            {
                do
                {
                    if (h.Dato == nodobuscado)
                    {
                        //ELIMINAR EL UNICO NODO DE LA LISTA
                        if (head.Siguiente == null)
                        {
                            head = null;
                            return true;
                        }
                        ////ELIMINAR PRIMER NODO DE LA LISTA
                        if (h == head)
                        {
                            head = head.Siguiente;
                            return true;
                        }
                        //ELIMINAR ULTIMO NODO DE LA LISTA
                        if (h.Siguiente == null)
                        {
                            ant.Siguiente = null;
                            return true;
                        }
                        //ELIMINAR UN NODO DE ENMEDIO DE LA LISTA
                        else
                        {
                            ant.Siguiente = h.Siguiente;
                            return true;
                        }
                    }
                    ant = h;
                    h = h.Siguiente;
                } while (h != null);
            }
            return false;
        }
    }
}
