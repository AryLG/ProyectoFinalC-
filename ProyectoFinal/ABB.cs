using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace _EDD_Tarea3
{
    class ABB
    {
        private NodoABB raiz { get; set; }
        public ABB()
        { raiz = null; }
        public void Insertar(string nuevoDato)
        { raiz = Insertar(raiz, nuevoDato); }
        private NodoABB Insertar(NodoABB raiz, string nuevoDato)
        {
            if (raiz == null)
            { 
                raiz = new NodoABB(nuevoDato);
                return raiz;
            }
            if (string.Compare(raiz.dato, nuevoDato) == 1)
            {
                raiz.izquierdo = Insertar(raiz.izquierdo, nuevoDato);
                return raiz;
            }
            if (string.Compare(raiz.dato, nuevoDato) == -1)
            {
                raiz.derecho = Insertar(raiz.derecho, nuevoDato);
                return raiz;
            }
            return raiz;
        }
        public void Eliminar(string dato)
        { raiz = Eliminar(raiz, dato);}
        private NodoABB Eliminar(NodoABB raiz, string dato)
        {
            if (raiz == null)
            { return raiz; }
            if (string.Compare(raiz.dato, dato) > 0)
            {
                raiz.izquierdo = Eliminar(raiz.izquierdo, dato);
                return raiz;
            }
            if (string.Compare(raiz.dato, dato) < 0)
            {
                raiz.derecho = Eliminar(raiz.derecho, dato);
                return raiz;
            }
            if (raiz.izquierdo == null && raiz.derecho == null)
            {
                raiz = null;
                return raiz;
            }
            if (raiz.izquierdo == null && raiz.derecho != null)
            {
                raiz = raiz.derecho;
                return raiz;
            }
            if (raiz.izquierdo != null && raiz.derecho == null)
            {
                raiz = raiz.izquierdo;
                return raiz;
            }
            else
            {
                NodoABB nodoDeValorMinimo = ObtenerNodoDeValorMinimo(raiz.derecho);
                raiz.dato = nodoDeValorMinimo.dato;
                raiz.derecho = Eliminar(raiz.derecho, nodoDeValorMinimo.dato);
            }
            return raiz;
        }
        private NodoABB ObtenerNodoDeValorMinimo(NodoABB raiz)
        {
            NodoABB nodoActual = raiz;
            while (nodoActual != null && nodoActual.izquierdo != null)
            { nodoActual = nodoActual.izquierdo; }
            return nodoActual;
        }
        public string Inorden()
        {
            string cadena = "";
            return Inorden(raiz, ref cadena);
        }
        private string Inorden(NodoABB rama,ref string cadena)
        {
            if (rama != null)
            {
                Inorden(rama.izquierdo, ref cadena);
                if (String.IsNullOrEmpty(cadena) == true)
                {
                    cadena += rama.dato;
                    return cadena;
                }
                cadena += ", " + rama.dato;
                Inorden(rama.derecho, ref cadena);
            }
            return cadena;
        }
        public string Preorden()
        {
            string cadena = "";
            return Preorden(this.raiz, ref cadena);
        }
        private string Preorden(NodoABB rama, ref string cadena)
        {
            if (rama != null)
            {
                if (String.IsNullOrEmpty(cadena) == true)
                {
                    cadena += rama.dato;
                }
                else
                { cadena += ", " + rama.dato; }
                Preorden(rama.izquierdo,ref  cadena);
                Preorden(rama.derecho, ref cadena);
            }
            return cadena;
        }
        public string Postorden()
        {
            string cadena = "";
            return Postorden(raiz, ref cadena);
        }
        private string Postorden(NodoABB rama, ref string cadena)
        {
            if (rama != null)
            {
                Postorden(rama.izquierdo,ref cadena);
                Postorden(rama.derecho,ref cadena);
                if (String.IsNullOrEmpty(cadena) == true)
                { cadena += rama.dato; }
                else
                { cadena += ", " + rama.dato; }
            }
            return cadena;
        }
        public string Graficar()
        {
            string dot = "digraph G {\n\nnode [shape = record,height=.1];\nsplines=\"line\";\n\n";
            Graficar(raiz, ref dot);
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
        private void Graficar(NodoABB rama, ref string cadena)
        {
            if ( rama != null)
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
        public void limpiar()
        { raiz = null; }
    }
}