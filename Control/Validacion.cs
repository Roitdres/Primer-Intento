using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

        namespace Control
    {
        public class Validacion
        {
            /*
             * Metodo que convierte entradas a enteros positivos
             */
            public int aEntero(String dato)
            {
                int valor = -1; //Se devuelve -1 cuando da error
                try
                {
                    valor = Convert.ToInt32(dato);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Error se esperaba un numero entero");
                }
                return valor;
            }

            /*
             * Metodo que convierte entradas a numeros reales
             */

            public double aReal(string dato)
            {
                double valor = -1; //Se devuelve -1 cuando da error
                try
                {
                    valor = Convert.ToDouble(dato);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Error se esperaba un numero real");
                    Console.WriteLine(ex.Message);
                }
                return valor;
            }
        }
    }


