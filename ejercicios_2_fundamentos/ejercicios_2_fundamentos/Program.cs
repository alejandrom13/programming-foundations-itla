using System;

namespace ejercicios_2_fundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1.: Crear un programa que use el operador condicional para mostrar el valor
             absoluto de un numero de la siguiente forma: si el numero es positivo, se mostrara
             tal cual; si es negativo, se mostrara el signo cambiado.*/
            Console.WriteLine("Hola profesor!, Mi nombre es Alejandro Matos y hoy le voy a enseñar mis programas.");
            Console.WriteLine("El primero es un programa que muestra el valor absoluto de un número y dice si es positivo o negativo");
            Console.WriteLine("Haga click en la tecla 'Enter' para empezar!");
            Console.ReadLine();
            

            int n1;

            Console.Write("Digite un número: ");
            
            n1 = Convert.ToInt32(Console.ReadLine());

            if (n1 > 0)
            {
                Console.WriteLine("{0} es positivo y el valor absoluto es {0}", n1);
            }
            else if (n1 < 0)
            {
                int n2;
                n2 = n1 * (-1);
                Console.WriteLine("{0} es negativo y su valor absoluto es: {1} ", n1, n2);
            }
            
            /*Usar el operador condicional para calcular el menor de dos numeros.*/
            
            Console.WriteLine("Increible!, no es asi?");
            Console.WriteLine("");
            Console.WriteLine("Bueno ahora voy a adivinar cual es el menor de dos números, haz click en enter para continuar!");
            Console.ReadLine();
            int num1, num2, numeroMenor;
            
            Console.Write("Escriba un número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriba otro: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            numeroMenor = num1 < num2 ? num1 : num2;
            
            Console.WriteLine("El menor de los numeros es: {0}", numeroMenor);
            
            /*Crear un programa que lea una letra tecleada por el usuario y diga si se trata
             de un signo de puntuacion, una cifra numerica o algun otro caracter. */
            Console.WriteLine("Fantastico!!!!");
            Console.WriteLine("Ahora te voy a decir si digitas un numero, una letra acentuada o algun otro caractér");
            Console.WriteLine("Clickea enter para continuar");
            Console.ReadLine();

            char tecla;
            Console.Write("Digite un caractér: ");
            tecla = Convert.ToChar(Console.ReadLine() ?? string.Empty);

            if (char.IsLetter(tecla))
            {
                Console.WriteLine("Es una letra");
            }
            else if(char.IsDigit(tecla))
            {
                Console.WriteLine("Es una cifra numérica");
            }
            else if (char.IsPunctuation(tecla))
            {
                Console.WriteLine("Es un signo");
            }
            else
            {
                Console.WriteLine("Ese caractér no esta definido en mi sistema!");
            }
            
            /* Crear un programa que lea una letra tecleada por el usuario y diga si se trata de una vocal,
             una cifra numerica o una constante. Tips: usar dato tipo "char".*/
            
            Console.WriteLine("Bien!, ahora  te voy a decir si el caracter que pongas se trata de una vocal, una cifra numerica o constante ");
            Console.WriteLine("Presiona Enter");
            Console.ReadLine();

            string letra2;
            Console.Write("Digite un caractér: ");
            letra2 = Convert.ToString(Console.ReadLine());
            if (letra2 == "a" || letra2 == "e" || letra2 == "i" || letra2 == "o" || letra2 == "u")
            {
                Console.WriteLine("Es una vocal");
            }
            
            else
            {
                var l = char.Parse(letra2);
                if (char.IsDigit(l))
                {
                    Console.WriteLine("Es una cifra numerica");
                }
            }
           
            /*  Crear un programa que escriba en pantalla los
             numeros pares del 23 al 7 en orden descendente, usando while.*/
            
            Console.WriteLine("Ahora te voy a escribir los numeros pares del 23 al 7 en orden ascendente");
            Console.WriteLine("Presiona enter para ver los resultados");
            Console.ReadLine();
            
            int num_par = 23;

            num_par = num_par - 1;
            while (num_par > 7)
            {
                Console.WriteLine(num_par);
                num_par = num_par - 2;
            }
            
            Console.WriteLine("Esto es todo por hoy, espero que la pase bien!");


        }
    }
}