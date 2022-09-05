using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_Libros2
{
    public class Novela:Libro
    {
        public EGenero genero;
        public Novela(string titulo, float precio, Autor autor, EGenero genero) : base(precio, titulo, autor)
        {
            this.genero = genero;
        }
        public static bool operator ==(Novela a, Novela b)
        {
            return (Libro)a == b && a.genero == b.genero;
        }
        public static bool operator !=(Novela a, Novela b)
        {
            return !(a == b);
        }
        public static implicit operator Single(Novela a)
        {
            return a.precio;
        }
        public override bool Equals(object obj)
        {
            return obj is Novela && this == (Novela)obj;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((string)this);
            sb.AppendLine($"GENERO: {this.genero}");
            return sb.ToString();
        }

    }
}
/*
Novela posee un único atributo propio, que será inicializado por su único constructor.
Sobrecarga de operadores:
Igualdad (Novela, Novela). Retornará true, si los libros y los géneros son iguales, false, caso contrario. Reutilizar código.
Implícito. Retornará el precio de la novela que recibe como parámetro.
Polimorfismo en Equals. Retornará true, si el parámetro recibido es igual a la instancia actual. Reutilizar código.
Polimorfismo en ToString, retornará una cadena conteniendo la información completa del objeto. Reutilizar código
 */
