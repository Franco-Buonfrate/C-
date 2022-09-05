using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_I01_El_relojero
{
    public partial class Form1 : Form
    {
        private Temporizador temporizador;
        public Form1()
        {
            InitializeComponent();
            temporizador = new Temporizador(1000);
            temporizador.TiempoCumplido += AsignarHora;
        }

        public void AsignarHora()
        {
            if (lbl_Hora.InvokeRequired)
            {
                Action asignarHora = AsignarHora;
                lbl_Hora.Invoke(asignarHora); 
            }
            else
            {
                this.lbl_Hora.Text = DateTime.Now.ToString("G");
            }

        }

        private void btn_IniciarReloj_Click(object sender, EventArgs e)
        {
            temporizador.IniciarTemporizador();
        }

        private void btn_DetenerReloj_Click(object sender, EventArgs e)
        {
            temporizador.DetenerTemporizador();
        }
    }
}
