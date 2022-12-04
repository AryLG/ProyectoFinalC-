using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace Grafos
{
     public class Grafo
     {
          public Dictionary<string, Point> Vertices;
          public Dictionary<string, int> Arcos;
          private Queue<string> Recorrido;
          private Queue<string> Cola;
          private Dictionary<string, bool> Marca;
          List<string> Visitados;
          private int TipoGrafo;

          public Grafo(int tipo)
          {
               Vertices = new Dictionary<string, Point>();
               Arcos = new Dictionary<string, int>();
               this.TipoGrafo = tipo;
          }
          public void AgregarVertice(string vertice, Point posicion)
          {
               if (!ExisteVertice(vertice))
               {
                    Vertices.Add(vertice, posicion);
               }
               else
               {
                    MessageBox.Show("El vértice ya existe.");
               }

          }
        public void EliminarVertice(string vertice)
        {
            if (ExisteVertice(vertice))
            {
                Dictionary<string,int> NuevaLista = new Dictionary<string,int>();
                foreach (KeyValuePair<string, int> Arco in Arcos)
                {
                    if (!(Arco.Key.StartsWith(vertice) || Arco.Key.EndsWith(vertice)))
                    {
                        NuevaLista.Add(Arco.Key,Arco.Value);
                    }
                }
                this.Arcos = NuevaLista;
                Vertices.Remove(vertice);
               }
               else
            {
                MessageBox.Show("El vértice no existe.");
            }
        }
        public void AgregarArco(string ver1, string ver2)
        {
            if (ExisteVertice(ver1) && ExisteVertice(ver2))
            {
                if (!ExisteArco(ver1, ver2))
                {
                    Arcos.Add(ver1.Trim() + "_" + ver2.Trim(),0);
                    if (this.TipoGrafo == 1)
                        Arcos.Add(ver2.Trim() + "_" + ver1.Trim(),0);
                }
                else
                {
                    MessageBox.Show("El arco ya existe.");
                }
            }
            else
            {
                MessageBox.Show("Ambos vértices especificados deben existir para poder agregar un arco.");
            }
        }
        public void EliminarArco(string ver1, string ver2)
        {
            if (ExisteVertice(ver1) && ExisteVertice(ver2))
            {
                if (ExisteArco(ver1, ver2))
                {
                    Arcos.Remove(ver1.Trim() + "_" + ver2.Trim());
                    if (this.TipoGrafo == 1)
                        Arcos.Remove(ver2.Trim() + "_" + ver1.Trim());
                }
                else
                {
                    MessageBox.Show("El arco especificado no existe.");
                }
            }
            else
            {
                MessageBox.Show("Ambos vértices especificados deben existir.");
            }
        }
        public bool ExisteVertice(string vertice)
        {
            return Vertices.Where(X => X.Key == vertice).Count() > 0;
        }
        public bool ExisteArco(string ver1, string ver2)
        {
            return Arcos.Where(X => X.Key == ver1.Trim() + "_" + ver2.Trim()).Count() > 0;
        }
        public Queue<string> RecorridoAnchura(string ver)
        {
            Recorrido = new Queue<string>();
            if (Vertices.Count > 0)
            {
                Cola = new Queue<string>();
                Marca = new Dictionary<string,bool>();
                Queue<string> VerticesGrafo = ListaDeVerticesDelGrafo(ver);
                foreach (string V in VerticesGrafo) Marca.Add(V, false);
                foreach (string V in VerticesGrafo)
                    if (!Marca[V]) RecorridoNodoAnchura(V);
            }
            return Recorrido;
        }
        private void RecorridoNodoAnchura(string Vertice)
        {
            Marca[Vertice] = true;
            Cola.Enqueue(Vertice);
            while (Cola.Count > 0)
            {
                string VerticeSacado = Cola.Dequeue();
                Recorrido.Enqueue(VerticeSacado);
                foreach (string Hijo in HijosDelNodo(VerticeSacado))
                {
                    if (!Marca[Hijo])
                    {
                        Marca[Hijo] = true;
                        Cola.Enqueue(Hijo);
                    }
                }
            }
        }
        public Queue<string> RecorridoProfundidad(string ver)
        {
            Recorrido = new Queue<string>();
            if (Vertices.Count > 0)
            {
                Marca = new Dictionary<string, bool>();
                Queue<string> VerticesGrafo = ListaDeVerticesDelGrafo(ver);
                foreach (string V in VerticesGrafo) Marca.Add(V, false);
                foreach (string V in VerticesGrafo)
                    if (!Marca[V]) RecorrerNodoProfundidad(V);
            }
            return Recorrido;
        }
        private void RecorrerNodoProfundidad(string Vertice)
        {
            Marca[Vertice] = true;
            Recorrido.Enqueue(Vertice);
            foreach (string H in HijosDelNodo(Vertice))
                if (!Marca[H]) RecorrerNodoProfundidad(H);
        }
        public Queue<string> ListaDeVerticesDelGrafo(string VerticeInicial)
        {
            Queue<string> Lista = new Queue<string>();
            foreach (KeyValuePair<string, Point> Vert in Vertices)
                if (Vert.Key == VerticeInicial)
                    Lista.Enqueue(Vert.Key);
            foreach (KeyValuePair<string, Point> Vert in Vertices)
                if (!Lista.Contains(Vert.Key))
                    Lista.Enqueue(Vert.Key);    
            return Lista;
        }
        public Queue<string> HijosDelNodo(string Nodo)
        {
            Queue<string> Hijos = new Queue<string>();
            foreach (KeyValuePair<string, int> Arco in Arcos)
                if (Arco.Key.StartsWith(Nodo)) Hijos.Enqueue(Arco.Key.Substring(Arco.Key.IndexOf('_') + 1, Arco.Key.Length - Arco.Key.IndexOf('_') - 1));
            return Hijos;
        }

        public Dictionary<string, int> Dijkstra(string s)
        {
            Recorrido = new Queue<string>();
            Visitados = new List<string>();
            int n = this.Vertices.Count;
            Debug.Print("Número de vértices: {0}", n);
            Dictionary<string,int> Distancia = new Dictionary<string,int>();
            Dictionary<string,bool> Visto = new Dictionary<string,bool>();
            foreach (KeyValuePair<string,Point> w in this.Vertices)
            {
                Visto.Add(w.Key, false);
                Distancia[w.Key] = PesoDelArcoEntreNodos(s, w.Key);
                Debug.Print("Distancia[{0}] = {1}", w.Key, Distancia[w.Key]);
            }
            Distancia[s] = 0;
            Visto[s] = true;
            bool VistosTodos = true;
            foreach (KeyValuePair<string, bool> V in Visto)
                if (!V.Value) VistosTodos = false;
            while (!VistosTodos)
            {
                int DistanciaMinima = 9999999;
                string VerticeDistanciaMinima = string.Empty;
                foreach (KeyValuePair<string, bool> D in Visto)
                    if (!D.Value && Distancia[D.Key] < DistanciaMinima)
                    {
                        DistanciaMinima = Distancia[D.Key];
                        VerticeDistanciaMinima = D.Key;
                    }
                Visto[VerticeDistanciaMinima] = true;
                foreach (string w in HijosDelNodo(VerticeDistanciaMinima))
                {
                    if (Distancia[w] > Distancia[VerticeDistanciaMinima] + PesoDelArcoEntreNodos(VerticeDistanciaMinima, w) || Distancia[w] <= 0)
                    {
                        Distancia[w] = Distancia[VerticeDistanciaMinima] + PesoDelArcoEntreNodos(VerticeDistanciaMinima, w);
                        Debug.Print("Distancia[{0}] = {1}",w,Distancia[w]);
                    }
                        
                }
                VistosTodos = true;
                foreach (KeyValuePair<string, bool> V in Visto)
                    if (!V.Value) VistosTodos = false;
            }
            return Distancia;
        }
        private int PesoDelArcoEntreNodos(string N1, string N2)
        {
            if (Arcos.Where(A => A.Key == N1 + "_" + N2).Count() == 1)
            {
                KeyValuePair<string, int> Arco = Arcos.Where(A => A.Key == N1 + "_" + N2).Single();
                return Arco.Value;
            }
            else
                return -1;
        }
        public void GradoVertice(string ver)
        {
            if (ExisteVertice(ver))
            {
                int ArcosEntrantes = 0;
                int ArcosSalientes = 0;
                foreach (KeyValuePair<string,int> Arco in this.Arcos)
                {
                    if (Arco.Key.StartsWith(ver))
                        ArcosSalientes++;
                    else if (Arco.Key.EndsWith(ver))
                        ArcosEntrantes++;
                }
                string Texto = string.Empty;
                if (this.TipoGrafo == 0)
                {
                    string NL = Environment.NewLine;
                    Texto = string.Format("GRADO DEL VERTICE [{0}] {1} Arcos salientes: {2} {3} Arcos entrantes: {4} {5} Grado del vértice: {6}", ver, NL, ArcosSalientes, NL, ArcosEntrantes, NL, ArcosEntrantes + ArcosSalientes);
                }
                else
                {
                    Texto = string.Format("GRADO DEL VERTICE [{0}]: {1}", ver, ArcosSalientes);
                }
                MessageBox.Show(Texto);
            }
            else
                MessageBox.Show("El vértice especificado no existe.");
        }

    }
}
