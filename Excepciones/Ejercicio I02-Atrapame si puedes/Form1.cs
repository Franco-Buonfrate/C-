using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_I02_Atrapame_si_puedes_library_;

namespace Ejercicio_I02_Atrapame_si_puedes
{
    public partial class form_Calculador : Form
    {
        public form_Calculador()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.txt_Kilometros.Text) && !string.IsNullOrEmpty(this.txt_Litros.Text))
                {
                    this.richTextBox1.Text += "Km/Litros: " + Calculador.Calcular(float.Parse(this.txt_Kilometros.Text), float.Parse(this.txt_Litros.Text)) + Environment.NewLine;
                }
                else
                {
                    throw new ParametrosVaciosException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese solo numeros");
            }
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error inesperado");
            }
        }
    }
}
