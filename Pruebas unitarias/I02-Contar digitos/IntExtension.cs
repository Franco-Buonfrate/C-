using System;

namespace I02_Contar_digitos
{
    public static class IntExtension
    {
        public static int ContarCantidadDeDigitos(this long numero)
        {
            string numeroString = Math.Abs(numero).ToString();
            //numeroString = numeroString.Replace("-", "");


            return numeroString.Length;
        }
    }
}
