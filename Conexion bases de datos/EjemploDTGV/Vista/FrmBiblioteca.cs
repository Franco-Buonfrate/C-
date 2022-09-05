using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace Vista
{
    public partial class FrmBiblioteca : Form
    {
        public FrmBiblioteca()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefrescarBiblioteca();
        }

        private void RefrescarBiblioteca()
        {
            dtgvBiblioteca.DataSource = JuegoDao.Leer();
            dtgvBiblioteca.Refresh();
            dtgvBiblioteca.Update();
        }

        private Bibloteca RecuperarObjeto()
        {
            Bibloteca itemSeleccionado = null;
            if (dtgvBiblioteca.SelectedRows.Count>0)
            {
                itemSeleccionado = (Bibloteca)dtgvBiblioteca.CurrentRow.DataBoundItem;
            }
            return itemSeleccionado;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Bibloteca itemBorrar = RecuperarObjeto();
            if( itemBorrar is not null)
            {
                JuegoDao.Eliminar(itemBorrar.CodigoJuego);
                RefrescarBiblioteca();
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FrmAlta frmAlta = new FrmAlta();
            if (frmAlta.ShowDialog() == DialogResult.OK)
            {
                RefrescarBiblioteca();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Bibloteca itemModificar = RecuperarObjeto();
            if (itemModificar is not null)
            {
                FrmAlta frmAlta = new FrmAlta(itemModificar.CodigoJuego);
                if (frmAlta.ShowDialog() == DialogResult.OK)
                {
                    RefrescarBiblioteca();
                }
            }
        }

    }
}
