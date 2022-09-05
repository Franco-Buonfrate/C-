﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01_Lanzar_y_atrapar
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion()
        {
        }

        public MiExcepcion(string message) : base(message)
        {
        }

        public MiExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
