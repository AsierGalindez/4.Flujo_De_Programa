/*
 * Escribe un programa que muestre  en pantalla “Feliz cumpleaños” repetido tantas veces como años tenga.
 */
using System;

namespace _19_Ejercicio_Repaso_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;

            edad = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= edad ; i++)
            {
                Console.WriteLine("Feliz " + i + " cumpleaños");
            }
        }
    }
}
