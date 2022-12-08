using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace OrdenamientoABB
{
    class OOABB
    {
        private NodoOABBB raiz { get; set; }

        public OOABB()
        { raiz = null; }

        public void Insertar(int nuevoDato, bool invertido)
        {
            if (invertido)
            {
                raiz = InsertarInvertido(raiz, nuevoDato);
                return;
            }
            raiz = Insertar(raiz, nuevoDato);
        }

        private NodoOABBB Insertar(NodoOABBB raiz, int nuevoDato)
        {
            if (raiz == null)
            {
                raiz = new NodoOABBB(nuevoDato);
                return raiz;
            }
            if (raiz.dato > nuevoDato)
            {
                raiz.izquierdo = Insertar(raiz.izquierdo, nuevoDato);
                return raiz;
            }
            if (raiz.dato < nuevoDato)
            {
                raiz.derecho = Insertar(raiz.derecho, nuevoDato);
                return raiz;
            }
            return raiz;
        }
        private NodoOABBB InsertarInvertido(NodoOABBB raiz, int nuevoDato)
        {
            if (raiz == null)
            {
                raiz = new NodoOABBB(nuevoDato);
                return raiz;
            }
            if (raiz.dato < nuevoDato)
            {
                raiz.izquierdo = InsertarInvertido(raiz.izquierdo, nuevoDato);
                return raiz;
            }

            raiz.derecho = InsertarInvertido(raiz.derecho, nuevoDato);
            return raiz;
        }

        //Ordenamiento en In-Orden
        public string Inorden()
        {
            string cadena = "";
            return Inorden(this.raiz, ref cadena);
        }

        private string Inorden(NodoOABBB rama, ref string cadena)
        {
            if (rama != null)
            {
                Inorden(rama.izquierdo, ref cadena);
                cadena += ", " + rama.dato;
                Inorden(rama.derecho, ref cadena);
            }
            return cadena;
        }
        public string Graficar()
        {
            string dot = "digraph G {\n\nnode [shape = record,height=.1];\nsplines=\"line\";\n\n";
            Graficar(this.raiz, ref dot);
            dot += "}";

            StreamWriter sw = new StreamWriter("C:\\dot.txt");
            sw.Write(dot);
            sw.Close();

            string ruta = "C:\\dot.txt";
            string ruta2 = "C:\\Arbol.png";

            string cmd = "dot -Tpng " + ruta + " -o " + ruta2;
            System.Diagnostics.ProcessStartInfo miProceso = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + cmd);
            System.Diagnostics.Process.Start(miProceso);
            return ruta2;
        }

        private void Graficar(NodoOABBB rama, ref string cadena)
        {
            if (rama != null)
            {
                cadena += "nodo" + rama.dato + "[label = \" <f2>|<f1> " + rama.dato + " |<f0> \"];\n";

                Graficar(rama.izquierdo, ref cadena);
                Graficar(rama.derecho, ref cadena);

                if (rama.izquierdo != null)
                { cadena += "\"nodo" + rama.dato + "\":f2 -> \"nodo" + rama.izquierdo.dato + "\":f1;\n"; }

                if (rama.derecho != null)
                { cadena += "\"nodo" + rama.dato + "\":f0 -> \"nodo" + rama.derecho.dato + "\":f1;\n"; }
            }
        }

    }
}
