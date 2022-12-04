using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using Microsoft.VisualStudio.GraphModel;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class ArbolBinario
    {
        int Profundidad = 0;

        int x = 650;
        int y = 30;
        int x1 = 650;
        int y1 = 30;
        public int indiceInorden = 0;
        int Xin = 120;
        private NodoArbol Auxiliar;
        public NodoArbol auxiliar
        {
            get { return Auxiliar; }
            set { Auxiliar = value; }
        }
        private NodoArbol Raiz;
        public NodoArbol raiz
        {
            get { return Raiz; }
            set { Raiz = value; }
        }
        private NodoArbol Anterior;
        public NodoArbol anterior
        {
            get { return Anterior; }
            set { Anterior = value; }
        }
        //Constructor e inicializador de variables de arbol binario
        public ArbolBinario()
        {
            auxiliar = null;
            raiz = null;
            anterior = null;
        }
        public void insertar1(NodoArbol n, Graphics graphics, Form f)
        {
            //Se llama a la clase arbol binario y se le da memoria
            ArbolBinario arbol = new ArbolBinario();
            //En caso de que no exista raiz quiere decir que 
            //nuestro arbol esta vacio y estamos insertando el primer nodo
            if (raiz == null)//si raiz == null(Si no hay nada en el arbol)
            {

                raiz = n;//La raiz se iguala al nodo que se va a insertar
                raiz.derecha = null;
                raiz.izquierda = null;
                graphics.FillEllipse(Brushes.Cyan, 650, 30, 35, 35);
                graphics.DrawString(n.Dato + "", f.Font, Brushes.Purple, 660, 40);
                Pen mynodoraiz = new Pen(Color.Orange, 3);
                graphics.DrawEllipse(mynodoraiz, 650, 30, 35, 35);
                //Derecha e izquierda son nulos 
                //pues acabamos de insertar el primer nodo
                MessageBox.Show("El Nodo fue añadido como Raíz", "Arbol Binario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else//si raiz no es nulo
            {
                auxiliar = raiz;
                anterior = raiz;
                while (auxiliar != null)//Si auxiliar no es nulo
                {
                    if (n.Dato <= auxiliar.Dato)//si el valor del nodo a insertar es menor a el valor de auxiliar
                    {
                        anterior = auxiliar;
                        auxiliar = auxiliar.izquierda;
                        if (Profundidad == 0)
                        {
                            x -= 258;

                        }
                        if (Profundidad == 1)
                        {
                            x -= 135;

                        }
                        if (Profundidad == 2)
                        {
                            x -= 64;

                        }
                        if (Profundidad == 3)
                        {
                            x -= 32;

                        }

                    }
                    else//si el valor del nodo a insertar es mayor a el valor de auxiliar
                    {
                        anterior = auxiliar;
                        auxiliar = auxiliar.derecha;
                        if (Profundidad == 0)
                        {
                            x += 258;

                        }
                        if (Profundidad == 1)
                        {
                            x += 135;

                        }
                        if (Profundidad == 2)
                        {
                            x += 64;

                        }
                        if (Profundidad == 3)
                        {
                            x += 32;

                        }


                    }
                    y += 50;

                    Profundidad++;
                }
                if (n.Dato <= anterior.Dato)//Si el valor del nodo es menor que al anterior osea la raiz
                {

                    graphics.FillEllipse(Brushes.Cyan, x, y, 35, 35);
                    graphics.DrawString(n.Dato + "", f.Font, Brushes.Purple, x + 10, y + 10);
                    Pen mynodoraiz = new Pen(Color.Orange, 3);
                    graphics.DrawEllipse(mynodoraiz, x, y, 35, 35);

                    if (Profundidad == 0)
                    {
                        Pen mylinea = new Pen(Brushes.Orange, 2);
                        graphics.DrawLine(mylinea, x + 15, y + 10, x + 23, y - 20);

                    }
                    if (Profundidad == 1)
                    {
                        Pen mylinea = new Pen(Brushes.Orange, 2);
                        graphics.DrawLine(mylinea, x + 15, y + 10, x + 155, y - 20);
                    }
                    if (Profundidad == 2)
                    {
                        Pen mylinea = new Pen(Brushes.Orange, 2);
                        graphics.DrawLine(mylinea, x + 15, y + 10, x + 84, y - 20);
                    }
                    if (Profundidad == 3)
                    {
                        Pen mylinea = new Pen(Brushes.Orange, 2);
                        graphics.DrawLine(mylinea, x + 15, y + 10, x + 52, y - 20);
                    }

                    MessageBox.Show("El Nodo fue añadido por el lado Izquierdo", "Arbol Binario",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Añadimos el nodo del lado izquierda pues la propiedad 
                    //de un arbol binario es que los valores inferiores que la 
                    //raiz van al lado izquierdo y las mayores al lado derecho

                    anterior.izquierda = n;
                }
                else//Si el valor del nodo no es menor que al anterior osea la raiz
                {
                    graphics.FillEllipse(Brushes.Cyan, x, y, 35, 35);

                    graphics.DrawString(n.Dato + "", f.Font, Brushes.Purple, x + 10, y + 10);
                    Pen mynodoraiz = new Pen(Color.Orange, 3);
                    graphics.DrawEllipse(mynodoraiz, x, y, 35, 35);

                    if (Profundidad == 0)
                    {
                        Pen mylinea = new Pen(Brushes.Orange, 2);
                        graphics.DrawLine(mylinea, x + 15, y + 10, x - 278, y - 20);

                    }
                    if (Profundidad == 1)
                    {
                        Pen mylinea = new Pen(Brushes.Orange, 2);
                        graphics.DrawLine(mylinea, x + 15, y + 10, x - 155, y - 20);
                    }
                    if (Profundidad == 2)
                    {
                        Pen mylinea = new Pen(Brushes.Orange, 2);
                        graphics.DrawLine(mylinea, x + 15, y + 10, x - 84, y - 20);
                    }
                    if (Profundidad == 3)
                    {
                        Pen mylinea = new Pen(Brushes.Orange, 2);
                        graphics.DrawLine(mylinea, x + 10, y + 15, x - 52, y - 20);
                    }
                    MessageBox.Show("El Nodo fue añadido por el lado Derecho", "Arbol Binario",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Añadimos el nodo del lado derecho pues la propiedad 
                    //de un arbol binario es que los valores inferiores que la 
                    //raiz van al lado izquierdo y las mayores al lado derecho
                    anterior.derecha = n;
                }
                //igualamos izquierda y derecha de nuestro nodo a insertar pues,
                //se entiende que este al ser el ultimo agregado no tiene nodos hijos
                n.izquierda = null;
                n.derecha = null;
            }
            Profundidad = 0;
            x = 650;
            y = 30;
            x1 = 650;
            y1 = 30;
            indiceInorden = 0;
        }

        //Método InOrden
        public void InOrden1(NodoArbol vacio, Graphics graphics, Form f)
        {
            if (indiceInorden == 0)
            {
                vacio = raiz;
            }
            //En este metodo visitamos primero el lado izquierdo del arbol y luego el derecho
            ArbolBinario arbol = new ArbolBinario();
            if (vacio != null)
            {
                indiceInorden++;
                arbol.InOrden1(vacio.izquierda, graphics, f);//Aqui recorremos recursivamente el arbol
                                                             //primero se revisa la izquierda y cuando se llega al final de la izquierda entonces se escribe el valor

                graphics.FillEllipse(Brushes.White, Xin + (indiceInorden * 35), 650, 35, 35);
                Pen esfera = new Pen(Brushes.Black, 3);
                graphics.DrawEllipse(esfera, Xin + (indiceInorden * 35), 650, 35, 35);

                graphics.DrawString(vacio.Dato + "", f.Font, Brushes.Black, Xin + (indiceInorden * 35) + 10, 660);

                arbol.InOrden1(vacio.derecha, graphics, f);
            }

        }
        //Método insertar
        public void insertar(NodoArbol p, ListBox l1, ListBox l2, ListBox l3)
        {
            //Se llama a la clase arbol binario y se le da memoria
            ArbolBinario arbol = new ArbolBinario();
            //En caso de que no exista raiz quiere decir que 
            //nuestro arbol esta vacio y estamos insertando el primer nodo
            if (raiz == null)//si raiz == null(Si no hay nada en el arbol)
            {

                raiz = p;//La raiz se iguala al nodo que se va a insertar
                raiz.derecha = null;
                raiz.izquierda = null;

                //Derecha e izquierda son nulos 
                //pues acabamos de insertar el primer nodo
                MessageBox.Show("El Nodo fue añadido como Raíz", "Arbol Binario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else//si raiz no es nulo
            {
                auxiliar = raiz;
                anterior = raiz;
                while (auxiliar != null)//Si auxiliar no es nulo
                {
                    if (p.Dato <= auxiliar.Dato)//si el valor del nodo a insertar es menor a el valor de auxiliar
                    {
                        anterior = auxiliar;
                        auxiliar = auxiliar.izquierda;
                    }
                    else//si el valor del nodo a insertar es mayor a el valor de auxiliar
                    {
                        anterior = auxiliar;
                        auxiliar = auxiliar.derecha;
                    }
                }
                if (p.Dato <= anterior.Dato)//Si el valor del nodo es menor que al anterior osea la raiz
                {
                    MessageBox.Show("El Nodo fue añadido por el lado Izquierdo", "Arbol Binario",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Añadimos el nodo del lado izquierda pues la propiedad 
                    //de un arbol binario es que los valores inferiores que la 
                    //raiz van al lado izquierdo y las mayores al lado derecho
                    anterior.izquierda = p;
                }
                else//Si el valor del nodo no es menor que al anterior osea la raiz
                {
                    MessageBox.Show("El Nodo fue añadido por el lado Derecho", "Arbol Binario",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Añadimos el nodo del lado derecho pues la propiedad 
                    //de un arbol binario es que los valores inferiores que la 
                    //raiz van al lado izquierdo y las mayores al lado derecho
                    anterior.derecha = p;
                }
                //igualamos izquierda y derecha de nuestro nodo a insertar pues,
                //se entiende que este al ser el ultimo agregado no tiene nodos hijos
                p.izquierda = null;
                p.derecha = null;
            }
            auxiliar = raiz;
            arbol.InOrden(auxiliar, l1);
            arbol.PreOrden(auxiliar, l2);
            arbol.PostOrden(auxiliar, l3);

        }
        //Método InOrden
        public void InOrden(NodoArbol aux, ListBox l1)
        {

            //En este metodo visitamos primero el lado izquierdo del arbol y luego el derecho
            ArbolBinario arbol = new ArbolBinario();
            if (aux != null)
            {
                arbol.InOrden(aux.izquierda, l1);//Aqui recorremos recursivamente el arbol
                                                 //primero se revisa la izquierda y cuando se llega al final de la izquierda entonces se escribe el valor

                l1.Items.Add("Valor:     " + aux.Dato);

                l1.Items.Add("");
                arbol.InOrden(aux.derecha, l1);
                indiceInorden++;
            }
        }
        //Método PreOrden
        public void PreOrden(NodoArbol aux, ListBox l2)
        {
            ArbolBinario arbol = new ArbolBinario();
            if (aux != null)
            {
                //Este revisa primero la raiz y la escribe
                l2.Items.Add("Valor:     " + aux.Dato);

                l2.Items.Add("");
                arbol.PreOrden(aux.izquierda, l2);
                arbol.PreOrden(aux.derecha, l2);
            }
        }
        //Método PostOrden
        public void PostOrden(NodoArbol aux, ListBox l3)
        {
            //Este revisa primero el lado derecho
            //y la la raiz al final
            if (aux != null)
            {
                PostOrden(aux.izquierda, l3);
                PostOrden(aux.derecha, l3);
                l3.Items.Add("Valor:     " + aux.Dato);

                l3.Items.Add("");
            }
        }
        //Evento de Llamada al método InOrden
        public void CallInOrden(ListBox l1)
        {
            ArbolBinario arbol = new ArbolBinario();
            if (raiz == null)
            {
                return;
            }
            auxiliar = raiz;
            arbol.InOrden(auxiliar, l1);


        }
        //Evento de Llamada al método PreOrden
        public void CallPreOrden(ListBox l2)
        {
            if (raiz == null)
            {
                return;
            }
            ArbolBinario arbol = new ArbolBinario();
            auxiliar = raiz;
            arbol.PreOrden(auxiliar, l2);
        }
        //Evento de Llamada al método PosOrden
        public void CallPosOrden(ListBox l3)
        {
            if (raiz == null)
            {
                return;
            }
            ArbolBinario arbol = new ArbolBinario();
            auxiliar = raiz;
            arbol.PostOrden(auxiliar, l3);
        }
        public NodoArbol Borrar(NodoArbol n, int Dato)
        {
            if (n == null)
            {
                return n;
            }

            if (Dato < n.Dato)
            {
                n.izquierda = Borrar(n.izquierda, Dato);
            }
            if (Dato > n.Dato)
            {
                n.derecha = Borrar(n.derecha, Dato);
            }
            else
            {
                //Caso sin hijos
                if (n.izquierda == null && n.derecha == null)
                {
                    n = null;
                    return n;
                }
                //Caso un hijo, hacer el caso espejo
                else if (n.izquierda == null)
                {
                    NodoArbol padre;
                    padre = BuscarPadre(Dato, n);
                    padre.derecha = n.derecha;
                    return n;
                }
                else if (n.derecha == null)
                {
                    NodoArbol padre;
                    padre = BuscarPadre(Dato, n);
                    padre.izquierda = n.izquierda;
                    return n;
                }
                //Caso Con dos hijos
                else
                {
                    NodoArbol minimo = null;
                    minimo.Dato = EncuentraMinimo(n.derecha);
                    n.Dato = minimo.Dato;
                    n.derecha = Borrar(n.derecha, minimo.Dato);
                }

            }
            return null;
        }
        NodoArbol trabajo = null;
        public int EncuentraMinimo(NodoArbol n)
        {
            if (n == null)
            {
                return 0;
            }
            trabajo = n;
            int minimo = trabajo.Dato;
            while (trabajo.izquierda != null)
            {
                trabajo = trabajo.izquierda;
                minimo = trabajo.Dato;
            }
            return minimo;
        }

        public NodoArbol EncuentraMaximo(NodoArbol n)
        {
            if (n == null)
            {
                return n;
            }
            trabajo = n;
            NodoArbol Maximo = trabajo;
            while (trabajo.derecha != null)
            {
                trabajo = trabajo.derecha;
                Maximo = trabajo;
            }
            return Maximo;
        }

        public bool Buscar(int Dato)
        {
            auxiliar = raiz;

            while (auxiliar != null)
            {
                if (Dato == auxiliar.Dato)
                {
                    return true;
                }
                if (auxiliar.izquierda == null && auxiliar.derecha == null)
                {
                    return false;
                }
                if (auxiliar.izquierda == null && auxiliar.derecha != null && Dato < auxiliar.Dato)
                {
                    return false;
                }
                if (auxiliar.derecha == null && auxiliar.izquierda != null && Dato > auxiliar.Dato)
                {
                    return false;
                }
                if (Dato > auxiliar.Dato && auxiliar.derecha != null)
                {
                    auxiliar = auxiliar.derecha;
                }
                else if (Dato < auxiliar.Dato && auxiliar.izquierda != null)
                {
                    auxiliar = auxiliar.izquierda;
                }



            }
            return false;

        }
        public void eliminar(int Dato)
        {
            //eliminar raiz
            if (Buscar(Dato) == true)
            {
                if (raiz.Dato == Dato && raiz.izquierda == null && raiz.derecha == null)
                {
                    raiz = null;
                }
                else
                {
                    NodoArbol nRaiz = EncuentraMaximo(raiz.izquierda);
                    nRaiz = raiz.derecha;
                    raiz = nRaiz;


                }

            }
        }
        public NodoArbol BuscarPadre(int Dato, NodoArbol n)
        {
            NodoArbol temp = null;
            if (n == null)
            {
                return null;
            }
            //Verificar si es el padre
            if (n.izquierda != null)
            {
                if (n.izquierda.Dato == Dato)
                {
                    return n;
                }
            }

            if (n.derecha != null)
            {
                if (n.derecha.Dato == Dato)
                {
                    return n;
                }
            }
            //Si tengo izquierda proceso izquierda
            if (n.izquierda != null && Dato < n.Dato)
            {
                temp = BuscarPadre(Dato, n.izquierda);
            }
            //Si tengo derecha proceso derecha
            if (n.derecha != null && Dato > n.Dato)
            {
                temp = BuscarPadre(Dato, n.derecha);
            }
            return temp;

        }

        public void eliminarNodoHoja(int Dato)
        {
            auxiliar = raiz;
            NodoArbol auxiliar1 = null;
            while (auxiliar != null)
            {
                if (auxiliar.Dato == Dato)
                {
                    if (auxiliar.Dato > auxiliar1.Dato)
                    {
                        auxiliar1.derecha = null;
                        break;
                    }
                    if (auxiliar.Dato < auxiliar1.Dato)
                    {
                        auxiliar1.izquierda = null;
                        break;
                    }
                }
                if (Dato > auxiliar.Dato && auxiliar.derecha != null)
                {
                    auxiliar1 = auxiliar;
                    auxiliar = auxiliar.derecha;
                }
                if (Dato < auxiliar.Dato && auxiliar.izquierda != null)
                {
                    auxiliar1 = auxiliar;
                    auxiliar = auxiliar.izquierda;
                }
            }
        }
    }
}
        

    
