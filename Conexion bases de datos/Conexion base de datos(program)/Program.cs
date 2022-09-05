using System;
using Conexion_bases_de_datos;

namespace Conexion_base_de_datos_program_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //PersonaAccesoDatos.Guardar("Juan");
                PersonaAccesoDatos.Modificar("Fernando", 5);  

                Persona personaID;
                personaID = PersonaAccesoDatos.LeerID(5);
                Console.WriteLine(personaID.nombre + " " + personaID.id);


                //PersonaAccesoDatos.Eliminar(4);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
