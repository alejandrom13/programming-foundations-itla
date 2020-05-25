
using System;

namespace exersice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //MENU
            int menu;
            Console.WriteLine("1) Programa que dice si es par");
            Console.WriteLine("2) Programa que dice cual es el número mayor");
            Console.WriteLine("3) Programa que verifica si un numero es multiplo del segundo");
            Console.WriteLine("4) Verificar si dos números son multiplos de 10");
            Console.WriteLine("5) Multiplica dos números y analiza cuando se multiplica por 0");
            Console.WriteLine("6) Programa que divide y analiza si el segundo número es 0 ");
            Console.WriteLine("7) Programa que dice si un número es múltiplo de 4 o de 5");
            Console.WriteLine("8) Programa que compara dos números y analiza si son positivos o negativos");
            Console.WriteLine("9) Programa que pide 3 números y muestra el mayor de los tres");
           
            Console.Write("Elija un programa del 1 al 9: ");
            menu = Convert.ToInt16(Console.ReadLine());

            //PRIMER PROGRAMA
            if (menu == 1)
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
            
            //SEGUNDO PROGRAMA
            else if (menu == 2)
            {
                // Crear un programa que pida al usuario dos números enteros y diga cuál es el mayor de ellos
                int n1, n2;
                
                Console.Write("Digite el primer número: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite el segundo número: ");
                n2 = Convert.ToInt32(Console.ReadLine());

                if (n1 > n2)
                {
                    Console.Write(n1 + " es mayor que " + n2);
                }
                else
                {
                    Console.Write(n2 + " es mayor que " + n1);
                }

            }
            
            //TERCER PROGRAMA
            else if (menu == 3)
            {
                // Crear un programa que pida al usuario dos números enteros y diga si el primero es múltiplo del segundo
                int n1, n2;
                Console.Write("Escribe el primer número: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite el segundo número: ");
                n2 = Convert.ToInt32(Console.ReadLine());

                if (n1 % n2 == 0)
                {
                    Console.WriteLine(n1 + " es multiplo de " + n2);
                }
                else
                {
                    Console.Write(n1 + " no es multiplo de " + n2);
                }
                
            }
            //CUARTO PROGRAMA
            else if (menu == 4)
            {
                /* Crear un programa que pida al usuario un número entero. Si es múltiplo de 10,
                se lo avisará al usuario y pedirá un segundo número, para decir a continuación
                si este segundo número también es múltiplo de 10. */

                int n1, n2;
                Console.Write("Digite un número: ");
                n1 = Convert.ToInt32(Console.ReadLine());

                if (n1 % 10 == 0)
                {
                    Console.Write(n1 + " es múltiplo de 10");
                }
                else
                {
                    Console.WriteLine(n1 + " no es múltiplo de 10");
                }
                Console.WriteLine();
                Console.Write("Digite otro número: ");
                n2 = Convert.ToInt32(Console.ReadLine());

                if (n2 % 10 == 0)
                {
                    Console.Write(n2 + " es múltiplo de 10");
                }
                else
                {
                    Console.Write(n2 + " no es múltiplo de 10");
                }
            }
            
            //QUINTO PROGRAMA
            else if (menu == 5)
            {
                 /*Crear un programa que multiplique dos números enteros de la siguiente forma:
                  pedirá al usuario un primer número entero. Si el número que se que teclee es 0, 
                  escribirá en pantalla "El producto de 0 por cualquier número es 0". Si se ha tecleado 
                  un número distinto de cero, se pedirá al usuario un segundo número y se mostrará el 
                  producto de ambos.*/

                 int n1, n2;
                 int res;
                 
                 Console.WriteLine("Digite el primer número: ");
                 n1 = Convert.ToInt32(Console.ReadLine());
                 if (n1 == 0)
                 {
                     Console.Write("El producto de 0 por cualquier número es 0");    
                 }
                 else
                 {
                     Console.Write("Digite el segundo número: ");
                     n2 = Convert.ToInt32(Console.ReadLine());

                     if (n2 == 0)
                     {
                         Console.Write("El producto de 0 por cualquier número es 0");
                     }
                     else
                     {
                         res = n1 * n2;
                         Console.Write("El total de la multiplicación es: " + res);

                     }
                 }
            }
            
            //SEXTO PROGRAMA
            else if (menu == 6)
            {
                /* Crear un programa que pida al usuario dos números enteros.
                 Si el segundo no es cero, mostrará el resultado de dividir entre el primero y el segundo. 
                 Por el contrario, si el segundo número es cero, escribirá "Error: No se puede dividir entre cero".*/

                int n1, n2;
                int res;                                                                   
                                                                            
                Console.Write("Digite el primer número: ");                                
                n1 = Convert.ToInt32(Console.ReadLine());                                  
                
                Console.Write("Digite el segundo número: ");                           
                n2 = Convert.ToInt32(Console.ReadLine());                              
                                                                        
                if (n2 == 0)                                                           
                {                                                                      
                    Console.Write("Error: no se puede dividir entre 0");       
                }                                                                      
                else                                                                   
                {                                                                      
                    res = n1 / n2;                                                     
                    Console.Write("El total de la division es: " + res);         
                                                                        
                }                                                                      
            }
            
            //SEPTIMO PROGRAMA
            else if (menu == 7)
            {
                /* Crear un programa que pida al usuario un número entero y diga si es múltiplo de 4 o de 5.*/

                int n1;
                Console.Write("Digite un numero: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                if (n1 % 4 == 0)
                {
                    Console.Write(n1 + " es multiplo de 4");
                }
                else if (n1 % 5 == 0)
                {
                    Console.Write(n1 + " es multiplo de 5");
                }
                else
                {
                    Console.Write(n1 + " no es multiplo ni de 4 ni de 5");
                }
            }
            
            //OCTAVO PROGRAMA
            else if (menu == 8)
            {
                /*Crear un programa que pida al usuario dos números enteros y diga
                 "Uno de los números es positivo", "Los dos números son positivos" 
                 o bien "Ninguno de los números es positivo", según corresponda.*/

                int n1, n2;
                
                Console.Write("Digite el primer número: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite el segundo número: ");
                n2 = Convert.ToInt32(Console.ReadLine());

                if (n1 < 0 && n2 < 0)
                {
                    Console.Write("Ambos números son negativos");
                }
                else if (n1 > 0 && n2 > 0)
                {
                    Console.Write("Ambos números son positivos");
                }
                else if (n1 < 0 && n2 > 0)
                {
                    Console.Write("El primer numero es negativo y el segundo positivo");
                }
                else if (n1 > 0 && n2 < 0)
                {
                    Console.Write("El primer numero es positivo y el segundo negativo");
                }
                else
                {
                    Console.Write("Datos incorrectos");
                }
            }
            
            //ULTIMO PROGRAMA
            else if (menu == 9)
            {
                /*Crear un programa que pida al usuario tres números reales y muestre cuál es el mayor de los tres.*/

                int n1, n2, n3;
                Console.Write("Digite el primer número: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite el segundo número: ");
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite el tercer número: ");
                n3 = Convert.ToInt32(Console.ReadLine());

                if (n1 > n2 && n1 > n3)
                {
                    Console.Write(n1 + " es el mayor de los tres");
                }
                else if (n2 > n1 && n2 > n3)
                {
                    Console.Write(n2 + " es el mayor de los tres");
                }
                else if (n3 > n1 && n3 > n2)
                {
                    Console.Write(n3 + " es el mayor de los tres");
                }
                else
                {
                    Console.Write("Datos incorrectos");
                }
            }
            else
            {
                Console.Write("Ha ingresado el número incorrecto, vuelva a iniciar el programa");
            }
        }
    }
}