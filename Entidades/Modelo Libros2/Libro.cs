using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_Libros2
{
    public abstract class Libro
    {
        protected Autor autor;
        protected int cantidadDePaginas;
        protected static Random generadorDePaginas;
        protected float precio;
        protected string titulo;

        static Libro()
        {
            Libro.generadorDePaginas = new Random();
        }
        public Libro(float precio, string titulo, Autor autor)
        {
            this.precio = precio;
            this.titulo = titulo;
            this.autor = autor;
        }
        public Libro(string titulo, string apellido, string nombre, float precio):this(precio, titulo, new Autor(nombre,titulo))
        {
        }
        public int CantidadDePaginas
        {
            get
            {
                if (this.cantidadDePaginas == 0)
                {
                    this.cantidadDePaginas = generadorDePaginas.Next(10, 571);
                }
                return this.cantidadDePaginas;
            }
        }
        private static string Mostrar(Libro l)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"AUTOR: {(string)l.autor}");
            sb.AppendLine($"TITULO: {l.titulo}");
            sb.AppendLine($"CANTIDAD DE PAGINAS: {l.CantidadDePaginas}");
            sb.AppendLine($"PRECIO: {l.precio}");
            return sb.ToString();
        }
        public static bool operator ==(Libro a, Libro b)
        {
            return a.autor == b.autor && a.titulo == b.titulo;
        }
        public static bool operator !=(Libro a, Libro b)
        {
            return !(a == b);
        }
        public static explicit operator string(Libro l)
        {
            return Mostrar(l);
        }

    }
}
/*
Todos sus atributos son protegidos. 
Posee un constructor de clase y un constructor de instancia sobrecargado. 
La propiedad (de sólo lectura) CantidadDePaginas, retornará el valor correspondiente del atributo cantidadDePaginas, que 
se inicializará en dicha propiedad, si y sólo si su valor es cero. Para inicializar dicho atributo, se utilizará el atributo estático 
generadorDePaginas (valores aleatorios entre 10 y 570). Ninguno debe de repetirse. 
El método privado y de clase Mostrar, retornará una cadena detallando los atributos de la clase.
Sobrecarga de operadores:
Igualdad (Libro, Libro). Retornará true, si los títulos y los autores son iguales, false, caso contrario.
Explícito. Retornará el detalle completo del libro que recibe como parámetro
 */
