using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class ListaDoble
    {
        private NodoDoble primero;
        private NodoDoble ultimo;

        public NodoDoble P_Primero
        {
            get { return primero; }
            set { primero = value; }
        }

        public ListaDoble()
        {
            primero = null;
            ultimo = null;
        }
        public void Insertarnodo(NodoDoble n)
        {
            if (primero == null)
            {
                primero = n;
                primero.Siguiente = null;
                primero.Atras = null;
                ultimo = null;
                return;
            }
            if (n.Dato < primero.Dato)
            {
                n.Siguiente = primero;
                primero = n;
                return;
            }
            if (n.Dato > primero.Dato)
            {
                NodoDoble h = primero;

                while (h.Siguiente != null)
                {
                    if (n.Dato < h.Siguiente.Dato)
                    {

                        n.Siguiente = h.Siguiente;
                        h.Siguiente = n;
                        n.Atras = h;
                        return;
                    }
                    h = h.Siguiente;
                }
                h.Siguiente = n;
                n.Siguiente = null;
                n.Atras = h;
                ultimo = n;
                return;
            }
        }
        public string DesplegarListaPU()
        {
            string Salida = "";
            NodoDoble h = primero;

            while (h != null)
            {
                Salida += h.Dato + ",";
                h = h.Siguiente;
            }
            return Salida;
        }

        public String DesplegarListaUP()
        {
            string Salida = "";
            NodoDoble h = ultimo;

            while (h != null)
            {
                Salida += h.Dato + ",";
                h = h.Atras;
            }
            return Salida;
        }
        public bool BuscarNodo(int nodoBuscado)
        {
            NodoDoble h = primero;

            while (h != null)
            {
                if (nodoBuscado == h.Dato)
                {
                    return true;
                }
                h = h.Siguiente;
            }
            return false;
        }
        public void ModificarNodo(int nodoBuscado, int valornuevo)
        {
            NodoDoble h = primero;

            while (h != null)
            {
                if (nodoBuscado == h.Dato)
                {
                    h.Dato = valornuevo;
                    return;
                }
                h = h.Siguiente;
            }

        }

        public void EliminarNodo(int n)
        {
            NodoDoble h = primero;

            while (h != null)
            {
                if (n == h.Dato)
                {
                    primero.Atras = null;
                    primero = h.Siguiente;
                    return;
                }
                if (n == h.Siguiente.Dato && h.Siguiente.Siguiente == null)
                {
                    h.Siguiente.Atras = h;
                    h.Siguiente = null;
                    ultimo = h;
                    return;
                }
                if (n == h.Siguiente.Dato)
                {
                    h.Siguiente.Siguiente.Atras = h;
                    h.Siguiente = h.Siguiente.Siguiente;
                    return;
                }


                h = h.Siguiente;
            }

        }
    }
}
