using System;

namespace exersice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que pida al usuario un número entero y diga si es par.
            int num;
           
            Console.WriteLine("Ingrese un número: ");
            
            num = Convert.ToInt32(Console.ReadLine());
            
            if (num%2 == 0) {
                Console.Write("El número es par");
            }
            else {
                Console.Write("El número es impar");
            }
        }
    }
}