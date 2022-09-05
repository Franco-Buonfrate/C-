using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bibloteca
    {
        private int codigoJuego;
        private string genero;
        private string juego;
        private string usuario;

        public Bibloteca(string usuario, string genero, string juego, int codigoJuego)
        {
            this.usuario = usuario;
            this.genero = genero;
            this.juego = juego;
            this.codigoJuego = codigoJuego;
        }

        public int CodigoJuego { get => codigoJuego; }
        public string Genero { get => genero;}
        public string Juego { get => juego;}
        public string Usuario { get => usuario;}


    }
}
