﻿/*
 * En este ejercicio, debes pedirle al usuario que introduzca su edad. Si es igual o mayor a 18, 
 * mostrarás en pantalla "Eres mayor de edad" y en caso contrario "Eres menor".
 */
using System;

namespace _06_Ejercicio_If_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dime tu edad");
            int edad = Int32.Parse(Console.ReadLine());
            if (edad >= 18) {
                Console.WriteLine("eres mayor de edad");
                
            }
            else { Console.WriteLine("eres menos de edad");
            }
        }
    }
}
