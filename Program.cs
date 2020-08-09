using System;

namespace practica7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //PRIMER PROGRAMA
        /*  Console.WriteLine("Un programa que pida al usuario 4 números, los memorice, \n " +
                            "calcule su media aritmética y después muestre en pantalla la media\n" +
                            " y los datos tecleados.\n" +
                            "*PRESIONE LA TECLA ENTER PARA CONTINUAR");
          Console.ReadKey();
          
            int[] num = {0, 0, 0, 0 };
            
            Console.Write("Digite el primer número: ");
            num[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite el segundo número: ");
            num[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite el tercer número: ");
            num[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite el cuarto número: ");
            num[3] = Convert.ToInt32(Console.ReadLine());

            int media_Aritmetica = (num[0] + num[1] + num[2] + num[3]) / num.Length;
            
            Console.WriteLine("Los numeros ingresados fueron: {0}, {1}, {2}, {3}", num[0], num[1], num[2], num[3]);
            Console.WriteLine("");
            Console.WriteLine("La media de todos los números digitados es: {0}", media_Aritmetica); */
            
        
            //SEGUNDO PROGRAMA
            /*Console.WriteLine("Un programa que pida al usuario 5 números reales y luego los muestre en el orden contrario al que se introdujeron \n" +
                              "*PULSA ENTER PARA CONTINUAR*");
            Console.ReadKey();

            float[] reverso = {0, 0, 0, 0, 0};
            Console.Write("Digite el primer número: ");
            reverso[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite el segundo número: ");
            reverso[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite el tercer número: ");
            reverso[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite el cuarto número: ");
            reverso[3] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite el quinto número: ");
            reverso[4] = Convert.ToInt32(Console.ReadLine());
            
            Array.Reverse(reverso);
            Console.WriteLine("NUMEROS DIGITADOS EN REVERSO: ");
            foreach (var array in reverso)
            {
                Console.WriteLine(array);
            } */
                
                
            //TERCER PROGRAMA
          /*  Console.WriteLine("Un programa que almacene los días de la semana en un array y luego mostrarlo. \n" +
                              "*PRESIONE ENTER PARA CONTINUAR");
            Console.ReadKey();

            Console.WriteLine("Los dias de la semana son: ");
            string[] semana = {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
            foreach (var dias in semana)
            {
                Console.WriteLine(" ");
                Console.WriteLine(dias);
            } */
            
          //CUARTO PROGRAMA
          /*Console.WriteLine("Un programa que almacene en una tabla el número de días que tiene cada mes\n" +
                            " (supondremos que es un año no bisiesto), pida al usuario que le indique un mes\n" +
                            " (1=enero, 12=diciembre) y muestre en pantalla el número de días que tiene ese mes.\n" +
                            "*PRESIONE ENTER PARA CONTINUAR*");
          Console.ReadKey();

          string[] dias =
          {
              "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto",
              "Septiembre", "Octubre", "Noviembre", "Diciembre"
          };
          
          int [] diasMes = {31,28,31,30,31,30,31,31,30,31,30,31};
          
          Console.Write("INGRESE EL MES EN NUMERO: ");
          int mes = Convert.ToInt32 (Console.ReadLine ());
          
          while (mes > 12 || mes <=0)
          {
              Console.Write("INGRESE EL MES EN NUMERO NUEVAMENTE: ");
              mes = Convert.ToInt32 (Console.ReadLine ());
          }
          Console.WriteLine("{0} tiene {1} dias", dias[mes-1], diasMes[mes-1]); */

          Console.WriteLine(
              "Un programa que almacene en una tabla el número de días que tiene cada mes (de un año no bisiesto)\n" +
              ", pida al usuario que le indique un mes (ej. 2 para febrero) y un día (ej. el día 15) \n" +
              "y diga qué número de día es dentro del año (por ejemplo, el 15 de febrero sería el día número 46,\n" +
              " el 31 de diciembre sería el día 365)\n" +
              "*PRESIONE ENTER PARA CONTINUAR");
          Console.ReadKey();
          
          
          DateTime EndDate = new DateTime(2020, 12, 31);
          
          
          
          string[] meses =
          {
              "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto",
              "Septiembre", "Octubre", "Noviembre", "Diciembre"
          };
          
          int [] diasMeses = {31,28,31,30,31,30,31,31,30,31,30,31};

          Console.Write("Escriba el mes en numero: ");
          int mes1 = Convert.ToInt32(Console.ReadLine());
          Console.Write("Escriba el dia: ");
          int dia1 = Convert.ToInt32(Console.ReadLine());
          DateTime fecha = new DateTime(2020, mes1, dia1);
          TimeSpan total = fecha - EndDate;
          int total2 = (total.Days + 365) + 1;
          
          
          Console.WriteLine("El dia {0} de {1} sería el dia numero {2}", dia1, meses[mes1 - 1], total2);


        }
    }
}