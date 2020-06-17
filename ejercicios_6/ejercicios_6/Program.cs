using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ejercicios_6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Crear una aplicacion que muestre la tabla de multiplicar del (7), tips usar ciclo while.
            int numero_multiplicar = 7;
            int i = 0;
            int operacion;
            if (numero_multiplicar >= 7)
            {
                while (i < 12)
                {
                    i = i + 1;
                    operacion = numero_multiplicar * i;
                    Console.WriteLine(operacion);
                }
                Console. WriteLine("Eso es todo!, tabla de multiplicar del 7");
            }

                Console.WriteLine("PARA SABER SI UN NUMERO ES PRIMO PRESIONA ENTER");
                Console.ReadKey();
                //Crear una aplicación que le pida al usuario un numero positivo y
                //el sistema identifique si es primo o no.
                int a = 0, num;
                Console.Write("INGRESE UN NUMERO POSITIVO: ");
                num = (int) Convert.ToInt64(Console.ReadLine());
                for (int b = 1; b < (num + 1); b++)
                {
                    if (num % b == 0)
                    {
                        a++;
                    }
                }
                if (a != 2)
                {
                    Console.WriteLine("{0} No es un numero primo", num);
                }
                else
                {
                    Console.WriteLine("{0} Es un numero primo", num);
                }
                Console.WriteLine("PRESIONA ENTER PARA CONTINUAR");
                Console.ReadLine();
                Console.WriteLine("EL SIGUIENTE PROGRAMA DIRA LA CANTIDAD DE DIGITOS QUE TIENE UN NUMERO POSITIVO");
                Console.WriteLine("ENTER PARA INICIAR");
                Console.ReadKey();
                
                
                //Crear un programa que me diga la cantidad de digitos que tiene
                //un numero positivo. Mostrar en mensaje ej: El numero ingresado tiene (N) digitos.

                int numero_digitos = 0;
                Console.Write("INGRESE UN NUMERO POSITIVO: ");
                numero_digitos = (int) Convert.ToInt64(Console.ReadLine());
                int digitos = (int) Math.Floor(Math.Log10(numero_digitos) + 1);
                
                Console.WriteLine("El numero registrado tiene {0} digitos", digitos);
                Console.WriteLine("PRESIONA ENTER PARA SIGUIENTE PROGRAMA");

                Console.ReadKey();
                Console.WriteLine("EL SIGUIENTE PROGRAMA VA A GENERAR LOS NUMEROS ALEATORIOS EN UN RANGO DE 50-100, enter para continuar");
                Console.ReadKey();
                
                /*Crear una aplicación que genere un numero aleatorio entre 50 y 100.
                 Y pida al usuario si desea generar otro numero antes de terminar la aplicación. 
                 El programa debe terminar cuando el usuario presione la letra 'S'*/
                
                Random var = new Random();
                int random  = var.Next(50, 100);  // CREA EL NUMERO ENTRE 50 Y 100
                Console.WriteLine(random); 
                Console.WriteLine("Quieres generar otro numero?, presiona enter o de lo contrario 'S' para salir");


                //BUCLE PARA SALIR SI SE PRESIONA S
                while (Console.ReadKey().Key != ConsoleKey.S)
                {
                    int random_dos = var.Next(50, 100); // CREA EL NUMERO ENTRE 50 Y 100
                    Console.WriteLine(random_dos)
                        ;

                    Console.WriteLine("Digite 'S' para cerrar programa");

                }

                /*Crear una aplicación que muestre la cantidad de 0 que hay del 1 al 100.*/
                    Console.WriteLine("PRESIONA ENTER PARA SIGUIENTE PROGRAMA:");
                    Console.ReadKey();
                    
                    for (int z = 1; z <= 100; z++)
                    {

                        if (z % 10 == 0)
                        {

                            int j = 0;
                            
                            Console.WriteLine(j);
                        }
                    }
                    Console.WriteLine("ESTE PROGRAMA ACABA DE MOSTRAR LOS CEROS QUE HAY DEL 1 AL 100");
                    Console.WriteLine("PULSA ENTER PARA EL SIGUIENTE PROGRAMA!");
                    Console.ReadKey();

                    //Recorrer los números del 1 al 50 en un ciclo for.
                    Console.WriteLine("ESTE MOSTRARA TODOS LOS NUMEROS EN UN RANGO DE 1-50");
                    Console.WriteLine("PRESIONA ENTER PARA CONTINUAR");
                    Console.ReadKey();
                    int f;
                    for(f=1;f<=50;f++)
                    {
                        Console.Write(f);
                        Console.WriteLine("");
                    }
                    
                    Console.WriteLine("ENTER PARA SALIR");
                    Console.ReadKey();
                } 
        }

    }
        
    
