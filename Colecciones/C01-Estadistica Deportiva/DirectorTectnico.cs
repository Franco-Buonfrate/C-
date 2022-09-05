using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01_Estadistica_Deportiva
{
    public class DirectorTectnico:Persona
    {
        private DateTime fechaNacimiento;

        private DirectorTectnico(string nombre) : base(nombre)
        {

        }
        DirectorTectnico(long dni, string nombre, DateTime fechaNacimiento) : base(dni, nombre)
        {
            this.FechaNacimiento = fechaNacimiento;
        }

        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        string MostrarDatos()
        {
            return $"{base.MostrarDatos()}\nFecha de nacimiento: {FechaNacimiento}";
        }

        public static bool operator ==(DirectorTectnico dt1, DirectorTectnico dt2)
        {
            return dt1.Nombre == dt2.Nombre && dt1.FechaNacimiento == dt2.FechaNacimiento;
        }
        public static bool operator !=(DirectorTectnico dt1, DirectorTectnico dt2)
        {
            return !(dt1 == dt2);
        }
    }

}
