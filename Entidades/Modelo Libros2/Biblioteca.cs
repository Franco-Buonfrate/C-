using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_Libros2
{
    public class Biblioteca
    {
        private int capacidad;
        private List<Libro> libros;
        private Biblioteca()
        {
            this.libros = new List<Libro>();
        }
        private Biblioteca(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }
        public double PrecioDeManuales
        {
            get
            {
                return this.ObtenerPrecio(ELibro.PrecioDeManuales);
            }
        }
        public double PrecioDeNovelas
        {
            get
            {
                return this.ObtenerPrecio(ELibro.PrecioDeNovelas);
            }
        }
        public double PrecioTotal
        {
            get
            {
                return this.ObtenerPrecio(ELibro.PrecioTotal);
            }
        }
        public static string Mostrar(Biblioteca b)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Capacidad: {b.capacidad}");
            sb.AppendLine($"Total por manuales: {b.PrecioDeManuales}");
            sb.AppendLine($"Total por novelas: {b.PrecioDeNovelas}");
            sb.AppendLine($"Total: {b.PrecioTotal}");
            sb.AppendLine("*******************************************");
            sb.AppendLine("Listado de libros");
            sb.AppendLine("*******************************************");
            foreach (Libro libro in b.libros)
            {
                sb.AppendLine("");
                sb.AppendLine(libro.ToString());
            }
            return sb.ToString();
        }
        public static implicit operator Biblioteca(int capacidad)
        {
            return new Biblioteca(capacidad);
        }
        public static bool operator ==(Biblioteca b, Libro l)
        {
            return b.libros.Contains(l);
        }
        public static bool operator !=(Biblioteca b, Libro l)
        {
            return !(b == l);
        }
        public static Biblioteca operator +(Biblioteca b, Libro l)
        {
            if (b != l)
            {
                if (b.libros.Count < b.capacidad)
                {
                    b.libros.Add(l);
                }
                else
                {
                    Console.WriteLine("No hay mas lugar en la biblioteca");
                }
            }
            else
            {
                Console.WriteLine("El libro ya esta en la biblioteca");
            }
            return b;
        }
        private double ObtenerPrecio(ELibro tipoLibro)
        {
            double acum=0;
            foreach (Libro libro in this.libros)
            {
                switch (tipoLibro)
                {
                    case ELibro.PrecioDeManuales:
                        if (libro is Manual)
                        {
                            acum += (double)(Manual)libro;
                        }
                            break;
                    case ELibro.PrecioDeNovelas:
                        if (libro is Novela)
                        {
                            acum += (double)(Novela)libro;
                        }
                        break;
                    case ELibro.PrecioTotal:
                        if (libro is Manual)
                        {
                            acum += (double)(Manual)libro;
                        }
                        if (libro is Novela)
                        {
                            acum += (double)(Novela)libro;
                        }
                        break;
                }
            }
            return acum;
        }


    }
}
/*
El método público de clase Mostrar, retornará una cadena con toda la información de la biblioteca, incluyendo el detalle 
(completo) de cada uno de sus libros. Reutilizar código.
Sobrecarga de operadores:
Igualdad, retornará true, si es que el manual o la novela ya se encuentra en la biblioteca, false, caso contrario. Reutilizar código.
Adición, si la biblioteca posee capacidad de almacenar al menos un libro más y ese manual o novel no se encuentra en la 
biblioteca, lo agregará a la colección, caso contrario, informará lo acontecido. Reutilizar código.
Método privado y de instancia ObtenerPrecio, retornará el valor de la biblioteca de acuerdo con el enumerado ELibro que 
recibe como parámetro. Las propiedades públicas PrecioDeManuales, PrecioDeNovelas y PrecioTotal están asociadas al 
método ObtenerPrecio. Reutilizar código. 
 */
