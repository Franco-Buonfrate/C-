using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_Libros2
{
    public class Manual:Libro
    {
        public ETipo tipo;
        public Manual(string titulo, string apellido, string nombre, float precio, ETipo tipo) : base(precio, titulo, new Autor(nombre, apellido))
        {
            this.tipo = tipo;
        }
        public static bool operator ==(Manual a, Manual b)
        {
            return (Libro)a == b && a.tipo == b.tipo;
        }
        public static bool operator !=(Manual a, Manual b)
        {
            return !(a == b);
        }
        public static explicit operator Single(Manual m)
        {
            return m.precio;
        }
        public override bool Equals(object obj)
        {
            return obj is Manual && this == (Manual)obj;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((string)this);
            sb.AppendLine($"TIPO: {this.tipo}");
            return sb.ToString();
        }

    }
}
/*
Manual posee un único atributo propio, que será inicializado por su único constructor.
Sobrecarga de operadores:
Igualdad (Manual, Manual). Retornará true, si los libros y los tipos son iguales, false, caso contrario. Reutilizar código.
Explícito. Retornará el precio del manual que recibe como parámetro.
Polimorfismo en Equals. Retornará true, si el parámetro recibido es igual a la instancia actual. Reutilizar código.
Polimorfismo en ToString, retornará una cadena conteniendo la información completa del objeto. Reutilizar código.

 */
