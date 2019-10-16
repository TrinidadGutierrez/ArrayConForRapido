using System;

namespace ArrayConForRapido
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 12, 15, 18, 24, 69 }; /*En esta linea se pueden poner la cantidad de Arrays
                                                que se  quiera*/

            numeros[3] = 100;/* De esta manera se puede modificar el valor de un Array indicando 
                                el espacio ,. de esta manera en vez de valer 24 la posicion  ["3"] 
                                pasara a valer 100 */

            for (int contador = 0; contador < numeros.Length; contador++)
            {
                System.Console.WriteLine("El elemento  " + (contador + 1) + "\t ES igual A :" + numeros[contador]);
            }
            Console.ReadKey();
        }
    }
}