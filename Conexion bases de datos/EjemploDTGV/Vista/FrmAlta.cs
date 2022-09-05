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

namespace Vista
{
    public partial class FrmAlta : Form
    {
        int codigoJuego;
        public FrmAlta(int codigoJuego) : this()
        {
            btnGuardar.Text = "Modificar";
            cmbUsuarios.Hide();
            lblUsuarios.Text = string.Empty;
            this.codigoJuego = codigoJuego;
            nupPrecio.Maximum = 10000;
            PintarForm();
        }

        private void PintarForm()
        {
            Juego juego = JuegoDao.LeerID(codigoJuego);

            txtNombre.Text = juego.Nombre;
            txtGenero.Text = juego.Genero;
            nupPrecio.Value = (decimal)juego.Precio;

        }
        public FrmAlta()
        {
            InitializeComponent();
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            cmbUsuarios.DataSource = UsuarioDao.Leer();
        }

        protected virtual void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.ToString();
            double precio = Convert.ToDouble(nupPrecio.Value);
            string genero = txtGenero.Text.ToString();
            if (btnGuardar.Text != "Modificar")
            {
                Usuario usuario = (Usuario)cmbUsuarios.SelectedItem;

                JuegoDao.Guardar(new Juego(nombre, precio, genero, usuario.CodigoUsuario));
            }
            else
            {
                Usuario usuario = (Usuario)cmbUsuarios.SelectedItem;
                JuegoDao.Modificar(new Juego(nombre, precio, genero, codigoJuego, usuario.CodigoUsuario));
            }
            DialogResult = DialogResult.OK;
        }
    }
}
