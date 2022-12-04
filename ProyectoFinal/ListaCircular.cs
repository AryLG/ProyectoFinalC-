using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class ListaCircular
    {
        private Nodo head;
        public Nodo Head
        {
            get { return head; }
            set { head = value; }
        }
        public ListaCircular()
        {
            head = null;
        }
        public override string ToString()
        {
            Nodo h = head;
            String s = "";
            do
            {
                s += " " + h.Dato;
                h = h.Siguiente;
            } while (h != head);
            return s;
        }
        public void Insertar(Nodo nuevo)
        {
            Nodo h = head;
            if (head == null)
            {
                head = nuevo;
                nuevo.Siguiente = nuevo;
                return;
            }
            if (nuevo.Dato < head.Dato)
            {
                nuevo.Siguiente = head;

                while (h.Siguiente != head)
                {
                    h = h.Siguiente;
                }
                head = nuevo;
                h.Siguiente = head;
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
            h.Siguiente = nuevo;
        }
        public bool Buscar(int DatoDelNodo)
        {
            Nodo h = head;
            do
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
            } while (h != head);
            return false;
        }
        public bool Eliminar(int nodobuscado)
        {
            Nodo h;
            Nodo anterior;
            h = head;
            anterior = null;

            if (head != null)
            {
                do
                {
                    if (h.Dato == nodobuscado)
                    {
                        //Eliminar el unico
                        if (head.Siguiente == head)
                        {
                            head = null;
                        }

                        //Eliminar primero
                        if (h == head)
                        {
                            Nodo i = head;
                            do
                            {
                                i = i.Siguiente;
                            }
                            while (i.Siguiente != head);

                            head = head.Siguiente;
                            i.Siguiente = head;
                        }
                        //Eliminar ultimo
                        else if (h.Siguiente == head)
                        {
                            anterior.Siguiente = head;
                            h = anterior;
                        }
                        //Eliminar enmedio
                        else
                        {
                            anterior.Siguiente = h.Siguiente;
                        }
                        return true;
                    }
                    anterior = h;
                    h = h.Siguiente;

                } while (h != head);
            }
            if (head == null)
            {
                return false;
            }
            return false;
        }
    }
}
