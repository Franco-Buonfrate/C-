using System;

namespace Modelo_Libros2
{
    public class Autor
    {
        private string apellido;
        private string nombre;
        public Autor(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public static bool operator ==(Autor a, Autor b)
        {
            return a.nombre == b.nombre && a.apellido == b.apellido;
        }
        public static bool operator !=(Autor a, Autor b)
        {
            return !(a == b);
        }
        public static implicit operator string(Autor a)
        {
            return $"{a.nombre} - {a.apellido}";
        }

    }
}
/*
 Autor posee todos sus atributos privados, un único constructor y sobrecargas de operadores:
Igualdad (Autor, Autor). Retornará true, si los nombres y los apellidos son iguales, false, caso contrario.
Implícito. Retornará el nombre y apellido del autor que recibe como parámetro.
 */
