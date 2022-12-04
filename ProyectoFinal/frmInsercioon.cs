using System;
using System.Windows.Forms;

namespace AppAlg
{
  public partial class frmInsercioon : Form
  {
    int[] arreglo;
    Random r = new Random();
    int comparaciones = 0;
    int intercambios = 0;
    public frmInsercioon()
    {
      InitializeComponent();
    }   
    public void Ordenar(int[] arreglo)
    {
      comparaciones = 0;
      intercambios = 0;
      tbArregloC.Text = MostrarLista();
      int n = arreglo.Length;
      for (int i = 1; i < n; ++i)
      {
        int key = arreglo[i];
        int j = i - 1;
        while (j >= 0 && arreglo[j] > key)
        {
          comparaciones++;
          arreglo[j + 1] = arreglo[j];
          j = j - 1;
        }
        arreglo[j + 1] = key;
        intercambios++;
      }
    }
    public string MostrarLista()
    {
      string numeros = "";
      if (arreglo.Length != 0)
      {
        for (int i = 0; i < arreglo.Length; i++)
        {
          numeros += arreglo[i] + ", ";
        }
      }
      return numeros;
    }
    public void crearArreglo(int tamaño)
    {
      arreglo = new int[tamaño];
      for (int i = 0; i < arreglo.Length; i++)
      {
        arreglo[i] = r.Next(-100, 100);
      }
      tbArregloC.Text = MostrarLista();
    }
    private void btnCrear_Click(object sender, EventArgs e)
    {
      int tamaño = int.Parse(txtTamaño.Text);
      txtTamaño.Clear();
      crearArreglo(tamaño);
      Ordenar(arreglo);
      tbArregloO.Text = MostrarLista();
      tbComparaciones.Text = comparaciones + "";
      tbIntercambios.Text = intercambios + "";
    }

        private void frmInsercioon_Load(object sender, EventArgs e)
        {

        }
    }
}
