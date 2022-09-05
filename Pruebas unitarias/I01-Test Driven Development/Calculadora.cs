using System;

namespace I01_Test_Driven_Development
{
    public static class Calculadora
    {
        public static int Add(string numeros)
        {
            int retorno = 0;
            string[] numerosString;
            try
            {
                if (numeros == string.Empty)
                {
                    retorno = 0;
                }
                else if (numeros.Contains(',') || numeros.Contains("\n"))
                {
                    char delimitador = ',';
                    if (numeros.Contains("//"))
                    {
                        delimitador = numeros[2];
                        numeros = numeros.Remove(0, 3);
                    }
                    numerosString = numeros.Split(delimitador, '\n');
                    foreach (string numero in numerosString)
                    {
                        if (int.Parse(numero) < 0)
                        {
                            throw new Exception("No se permiten numeros negativos");
                        }
                        retorno += int.Parse(numero);
                    }
                }
                else
                {
                    retorno = int.Parse(numeros);
                }
                return retorno;
            }
            catch (FormatException)
            {
                Console.WriteLine("ingreso Invalido");
                return 0;
            }
        }
    }
}
