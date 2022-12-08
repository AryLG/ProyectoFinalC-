using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using ProyectoFinal;

namespace Grafos
{
     public partial class frmGrafos : Form
     {
        //
          // VARIABLES GLOBALES __________________________________________________________
          private Grafo MiGrafo;
          private bool _agregandoNodo;
          private Point _posicionNodo;
          private string _nombreNodo;
          private Graphics g;
          private Pen Lapiz = new Pen(Color.Black, 3);
          private Brush Pincel = new SolidBrush(Color.Teal);//Color de nodo
          private Brush PincelNodoBuscado = new SolidBrush(Color.Plum); //Color de recorridos
          private Brush PincelFuente = new SolidBrush(Color.White);
          private Brush PincelFuentePeso = new SolidBrush(Color.Black);
          private Brush PincelFuenteNodoBuscado = new SolidBrush(Color.Black);
          private Pen LapizFuente = new Pen(Color.White, 1);
         
          private Pen LapizArco = new Pen(Color.MediumAquamarine, 5);//ARCO
          private Font Fuente = new Font("Calibri", 16, FontStyle.Bold);
          private Size Tamaño = new Size(40, 40);
          private int TipoGrafo = 0; // 0 - dirigido, 1 - no dirigido
        

          // VARIABLES AUXILIARES PARA DIBUJAR GRAFO
          Rectangle R;
          Brush pincel;
          Point P1, P2, P3;
          StringFormat formato = new StringFormat();

          // FIN VARIABLES GLOBALES __________________________________________________________

          public frmGrafos()
          {
               InitializeComponent();
          }
          private void ActualizarInformacion(Grafo G)
          {
               lbVertices.Items.Clear();
               lbArcos.Items.Clear();
               foreach (KeyValuePair<string, Point> Vertice in G.Vertices)
               {
                    lbVertices.Items.Add(Vertice.Key);
               }
               foreach (KeyValuePair<string, int> Arco in G.Arcos)
               {
                    lbArcos.Items.Add(Arco.Key );
               }
               DibujarGrafo(G);
          }
          private void frmGrafos_Load(object sender, EventArgs e)
          {
               MiGrafo = new Grafo(this.TipoGrafo);
               _agregandoNodo = false;
               g = pbGrafo.CreateGraphics();
               this.DoubleBuffered = true;
               formato.Alignment = StringAlignment.Center;
               formato.LineAlignment = StringAlignment.Center;
               cbTipoGrafo.SelectedIndex = 0;
               this.ConfigurarFlecha();
              
          }
          private void ConfigurarFlecha()
          {
               if (this.TipoGrafo == 0)
                    LapizArco.EndCap = LineCap.ArrowAnchor;
               else
                    LapizArco.EndCap = LineCap.Flat;
          }
          private void btNuevoGrafo_Click(object sender, EventArgs e)
          {
               if (MessageBox.Show("¿Desea crear un nuevo grafo?", "Nuevo grafo", MessageBoxButtons.YesNo) == DialogResult.Yes)
               {
                    MiGrafo = new Grafo(this.TipoGrafo);
                    ActualizarInformacion(MiGrafo);
                    VaciarTextBox();
                    ConfigurarFlecha();
               }
          }
          private void btAgregarVertice_Click(object sender, EventArgs e)
          {
               string vertice = txAgregarVertice.Text.Trim();
               if (vertice == string.Empty) MessageBox.Show("Debe ingresar el nombre del vértice.");
               else
                   if (MiGrafo.ExisteVertice(vertice));
               else
               {
                    _agregandoNodo = true;
                    _nombreNodo = vertice;
                    pbGrafo.Focus();
                    pbGrafo.Cursor = Cursors.Hand;
                    MostrarIndicacion("Haga clic en la posición dónde desea ubicar el vértice.");
               }
          }
          
          private void MostrarIndicacion(string mensaje)
          {
               lbIndicacion.Text = mensaje.Trim();
          }
          private void pbGrafo_MouseMove(object sender, MouseEventArgs e)
          {
               if (_agregandoNodo)
               {
                    _posicionNodo = new Point(e.X, e.Y);
                    DibujarGrafo(MiGrafo);
               }
          }
          private void DibujarGrafo(Grafo grafo, bool BuscarVertice = false, string VerticeBuscado = "", Queue<string> Rec = null)
          {
            if (g == null)
            {
                return;
            }
            g.Clear(Color.White);
               foreach (KeyValuePair<string, Point> Vertice in grafo.Vertices)
               {
                    R = new Rectangle(Vertice.Value, Tamaño);
                    g.DrawEllipse(Lapiz, R);
                    g.FillEllipse(((BuscarVertice && Vertice.Key == VerticeBuscado) || (Rec != null && Rec.Contains(Vertice.Key))) ? PincelNodoBuscado : Pincel, R);
                    pincel = ((BuscarVertice && Vertice.Key == VerticeBuscado) ? PincelFuenteNodoBuscado : PincelFuente);
                    g.DrawString(Vertice.Key, Fuente, pincel, Vertice.Value + new Size(20, 20), formato);
               }
               foreach (KeyValuePair<string, int> Arco in grafo.Arcos)
               {
                    try
                    {
                         string[] nombresVertices = Arco.Key.Split('_');
                         P1 = MiGrafo.Vertices[nombresVertices[0]] + new Size(20, 20);
                         P2 = MiGrafo.Vertices[nombresVertices[1]] + new Size(20, 20);
                         if (P1.X < P2.X)
                         {
                              P1 += new Size(14, 0);
                              P2 -= new Size(14, 0);
                         }
                         else if (P2.X < P1.X)
                         {
                              P2 += new Size(14, 0);
                              P1 -= new Size(14, 0);
                         }
                         if (P1.Y < P2.Y)
                         {
                              P1 += new Size(0, 14);
                              P2 -= new Size(0, 14);
                         }
                         else
                         {
                              P2 += new Size(0, 14);
                              P1 -= new Size(0, 14);
                         }
                         P3 = MidPoint(P1, P2);
                         g.DrawLine(LapizArco, P1, P2);
                         R = new Rectangle(P3 - new Size(12, 10), new Size(25, 20));
                       
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show(ex.Message);
                    }
               }

               if (_agregandoNodo)
               {
                    R = new Rectangle(_posicionNodo, Tamaño);
                    g.DrawEllipse(Lapiz, R);
                    g.FillEllipse(Pincel, R);
                    g.DrawString(_nombreNodo, Fuente, PincelFuente, _posicionNodo + new Size(20, 20), formato);
               }
          }
          private static Point Punto23(Point P1, Point P2)
          {

               int x = (Math.Max(P1.X, P2.X) - Math.Min(P1.X, P2.X)) * 2 / 3 + Math.Min(P1.X, P2.X);

               int y = (Math.Max(P1.Y, P2.Y) - Math.Min(P1.Y, P2.Y)) * 2 / 3 + Math.Min(P1.Y, P2.Y);

               return new Point(x, y);
          }
          private static Point MidPoint(Point pt1, Point pt2)
          {
               var midX = (pt1.X + pt2.X) / 2;
               var midY = (pt1.Y + pt2.Y) / 2;
               return new Point(midX, midY);
          }
          private void pbGrafo_Paint(object sender, PaintEventArgs e)
          {

          }
          private void pbGrafo_Click(object sender, EventArgs e)
          {
               if (_agregandoNodo)
               {
                    MiGrafo.AgregarVertice(_nombreNodo, _posicionNodo);
                    MostrarIndicacion(string.Empty);
                    _agregandoNodo = false;
                    pbGrafo.Cursor = Cursors.Default;
                    ActualizarInformacion(MiGrafo);
                    VaciarTextBox();
               }
          }
          private void VaciarTextBox()
          {
               txOrigen.Text = txDestino.Text = txAgregarVertice.Text = string.Empty;
            
          }
          private void btAgregarArco_Click(object sender, EventArgs e)
          {
               if (TipoGrafo == 1)
               {
                    string Origen = txOrigen.Text.Trim();
                    string Destino = txDestino.Text.Trim();
                    if (Origen != string.Empty && Destino != string.Empty)
                    {
                         MiGrafo.AgregarArco(Origen, Destino);
                         ActualizarInformacion(MiGrafo);
                         MiGrafo.AgregarArco(Destino, Origen);
                         ActualizarInformacion(MiGrafo);
                         VaciarTextBox();
                    }
                    else
                    {
                         MessageBox.Show("Debe ingresar los vértices origen y destino.");
                    }
               }
               else
               {
                    string Origen = txOrigen.Text.Trim();
                    string Destino = txDestino.Text.Trim();
                    if (Origen != string.Empty && Destino != string.Empty)
                    {
                         MiGrafo.AgregarArco(Origen, Destino);
                         ActualizarInformacion(MiGrafo);
                         VaciarTextBox();
                    }
                    else
                    {
                         MessageBox.Show("Debe ingresar los vértices origen y destino.");
                    }
               }

          }
          private void btEliminarVertice_Click(object sender, EventArgs e)
          {
               if (lbVertices.Items.Count > 0)
               {
                    if (lbVertices.SelectedItems.Count > 0)
                    {
                         MiGrafo.EliminarVertice(lbVertices.SelectedItem.ToString());
                         ActualizarInformacion(MiGrafo);
                    }
                    else
                    {
                         MessageBox.Show("Debe seleccionar el vértice a eliminar.");
                    }
               }
               else
               {
                    MessageBox.Show("No existen vértices en el grafo.");
               }
          }
          private void btEliminarArco_Click(object sender, EventArgs e)
          {
               if (lbArcos.Items.Count > 0)
               {
                    if (lbArcos.SelectedItems.Count > 0)
                    {
                         string[] verts = lbArcos.SelectedItem.ToString().Split(';')[0].Split('_');
                         MiGrafo.EliminarArco(verts[0], verts[1]);
                         ActualizarInformacion(MiGrafo);
                    }
                    else
                    {
                         MessageBox.Show("Debe seleccionar el arco a eliminar.");
                    }
               }
               else
               {
                    MessageBox.Show("No existen arcos en el grafo.");
               }
          }
          private void frmGrafos_SizeChanged(object sender, EventArgs e)
          {
               try
               {
                    this.DibujarGrafo(MiGrafo);
               }
               catch (Exception)
               {
               }

          }

        private void nuPeso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.Show(); DoubleBuffered = true;
            this.Hide();
        }

        private void cbTipoGrafo_SelectedIndexChanged(object sender, EventArgs e)
          {
               this.TipoGrafo = cbTipoGrafo.SelectedIndex;
          }

          public static void MostrarTabla(int[,] pTabla)
          {
               int n = 0;

               for (n = 0; n < pTabla.GetLength(0); n++)
               {
                    Console.WriteLine("{0}--> {1}\t{2}\t{3}", n, pTabla[n, 0], pTabla[n, 1], pTabla[n, 2]);
               }
               Console.WriteLine("------");
          }

   

      


          
     }
    
}
