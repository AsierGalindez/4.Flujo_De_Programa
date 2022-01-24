/*
 * Crear un programa que muestre el valor de sumar todos los números desde 1 hasta el número que introduzca el usuario. 
 * Por ejemplo si introduce el 8 debería mostrar 36 (1 + 2+ 3+ 4+ 5+ 6+ 7+ 8)
 * Pistas:
 * 1. Deberás crear una variable donde vayas almacenando el valor de sumar cada uno de los números.  
 * 2. Si definimos bien la condición de un bucle for, podemos hacer que el valor de i se corresponda con cada uno de los números que queremos sumar. 
 */
using System;

namespace _20_Ejercicio_Repaso_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int suma = 0;
            Console.WriteLine("dame un número");
            num = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                suma = suma + i;//suma+=i es lo mismo
            }
            Console.WriteLine(suma);
        }
    }
}