using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I03_A_contar_palabras
{
    public partial class FormContadorDePalabras : Form
    {
        public FormContadorDePalabras()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contadorPalabras = ObtenerContadorPalabras();
            List<KeyValuePair<string, int>> podio = ObtenerPodio(contadorPalabras);

            MostrarPodio(podio);
        }

        private List<KeyValuePair<string, int>> ObtenerPodio(Dictionary<string, int> contadorPalabras)
        {
            List<KeyValuePair<string, int>> podio = contadorPalabras.ToList();
            podio.Sort(CompararCantidadRepeticiones);
            return podio;
        }

        private void MostrarPodio(List<KeyValuePair<string,int>> lista)
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (lista.Count == 0)
            {
                stringBuilder.AppendLine("No se ingredaron palabras");
            }
            else
            {
                for (int i = 0; i < 3 && i<lista.Count; i++)
                {
                    KeyValuePair<string, int> par = lista[i];
                    stringBuilder.AppendLine($"Palabra: {par.Key} - Cantidad: {par.Value}");
                }

                /*
                foreach(KeyValuePair<string, int> par in lista)
                {
                    stringBuilder.AppendLine($"Palabra: {par.Key} - Cantidad: {par.Value}");
                }
                */
            }
            MessageBox.Show(stringBuilder.ToString(), "Podio");
        }

        private int CompararCantidadRepeticiones(KeyValuePair<string, int> primerElemento, KeyValuePair<string, int> segundoElemento)
        {
            return segundoElemento.Value - primerElemento.Value;
        }

        private Dictionary<string, int> ObtenerContadorPalabras()
        {
            Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();
            string texto = this.rTxtPalabras.Text;
            string[] palabras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string palabra in palabras)
            {
                if (contadorPalabras.ContainsKey(palabra))
                {
                    contadorPalabras[palabra]++;
                }
                else
                {
                    contadorPalabras.Add(palabra, 1);
                }
            }
            return contadorPalabras;
        }
    }
}
