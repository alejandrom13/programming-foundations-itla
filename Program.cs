using System;
using System.Collections;

namespace PRACTICA_FINAL
{
  internal class Program
  {
    public class Empleado
    {
      public string nombre {get; set;}
      public DateTime creacion {get; set;}
      public bool activa {get; set;}
      public string rol { get; set; }
    }
    
    public static void Main(string[] args)
    {
      
      Hashtable listaEmpleados = new Hashtable();
      
      //EMPLEADO 1
      Empleado empleado1 = new Empleado()
      {
        nombre = "ALEJANDRO ANTONIO MATOS CIPRIAN",
        creacion = new DateTime(2002, 2, 13),
        activa = true,
        rol = "SUPERVISOR",
      };
       listaEmpleados.Add("40213664937", empleado1);
       listaEmpleados.Add(empleado1, "13022002");
       
      //EMPLEADO 2 
      Empleado empleado2 = new Empleado()
      {
        nombre = "MIGUEL RAMON MORETA JIMENEZ",
        creacion = new DateTime(2005, 5, 1),
        activa = true,
        rol = "ADMINISTRADOR",
      };
      listaEmpleados.Add("01000042413", empleado2);
      listaEmpleados.Add(empleado2, "01052005");
      
      //EMPLEADO 3
      Empleado empleado3 = new Empleado()
      {
        nombre = "JAVIER DE LOS SANTOS RAMIREZ",
        creacion = new DateTime(2004, 7, 10),
        activa = false,
        rol = "VENDEDOR",

      };
      listaEmpleados.Add("01000013215", empleado3);
      listaEmpleados.Add(empleado3, "10072004");
      
      Console.Write("INGRESE SU NUMERO DE CEDULA: ");
      string cedula_empleado = Console.ReadLine();
      
      
      while (!listaEmpleados.ContainsKey(cedula_empleado))
              {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("CEDULA NO ENCONTRADA EN EL SISTEMA");
                Console.WriteLine("----------------------------------");
                Console.Write("INGRESE SU NUMERO DE CEDULA NUEVAMENTE: ");
                cedula_empleado = Console.ReadLine();
              }
              
                Console.Write("INGRESE SU CLAVE: ");
                string clave_empleado = Console.ReadLine();
                
                
                while (!listaEmpleados.ContainsValue(clave_empleado))
                {
                  Console.WriteLine("----------------------------------");
                  Console.WriteLine("CLAVE NO ENCONTRADA EN EL SISTEMA");
                  Console.WriteLine("----------------------------------");
                  Console.Write("INGRESE SU CLAVE NUEVAMENTE: ");
                  clave_empleado = Console.ReadLine();
                }

              
      if (!listaEmpleados.ContainsKey(cedula_empleado) && listaEmpleados.ContainsValue(clave_empleado))
       {
         Console.WriteLine("DATOS EQUIVOCADOS");
       }
      else
      {
        Empleado empleado = (Empleado) listaEmpleados[cedula_empleado];
        Console.WriteLine("Bienvenido a la plataforma {0}", empleado.nombre);
        Console.WriteLine("Usted ha accedido con el usuario {0}, y su rol es: {1}", cedula_empleado, empleado.rol);
        if (empleado.activa) { Console.WriteLine("Su cuenta está: ACTIVA y fue creada el {0}", empleado.creacion); }
        else { Console.WriteLine("SU CUENTA ESTA INACTIVA, POR LO TANTO NO PUEDE ACCEDER AL SISTEMA"); }

      }
      



      

     



      
      

      // Hashtable empleado_1 = new Hashtable();

      // //EMPLEADO 1
      // empleado_1.Add("nombre", "ALEJANDRO ANTONIO MATOS CIPRIAN");
      // empleado_1.Add("cedula", "40213664937");
      // empleado_1.Add("clave", "13022002");
      // empleado_1.Add("rol", "SUPERVISOR");
      // DateTime empleado1_creacion = new DateTime(2002, 2, 13);
      // empleado_1.Add("estado", "ACTIVA");
      //
      // //EMPLEADO 2
      // Hashtable empleado_2 = new Hashtable();
      // empleado_2.Add("nombre", "MIGUEL RAMON MORETA JIMENEZ");
      // empleado_2.Add("cedula", "01000042413");
      // empleado_2.Add("clave", "01052005");
      // empleado_2.Add("rol", "ADMINISTRADOR");
      // DateTime empleado2_creacion = new DateTime(2005, 5, 1);
      // empleado_2.Add("estado", "ACTIVA");
      //
      // //EMPLEADO 3
      // Hashtable empleado_3 = new Hashtable();
      // empleado_3.Add("nombre", "JAVIER DE LOS SANTOS RAMIREZ");
      // empleado_3.Add("cedula", "01000013215");
      // empleado_3.Add("clave", "10072004");
      // empleado_3.Add("rol", "VENDEDOR");
      // DateTime empleado3_creacion = new DateTime(2004, 7, 10);
      // empleado_3.Add("estado", "INACTIVA");
      //
      // //BIENVENIDA
      // Console.WriteLine("HOLA BIENVENIDO A AMC CONSULTING");
      // Console.WriteLine("---");
      // Console.WriteLine("PRESIONE LA TECLA 'ENTER' PARA INICIAR SESION");
      // Console.ReadKey();
      //
      // //INPUT CEDULA Y CLAVE
      // string cedula_empleado = "";
      // string clave_empleado;
      // while (cedula_empleado != (string) empleado_1["nombre"] || cedula_empleado != (string) empleado_2["nombre"] || cedula_empleado != (string) empleado_3["nombre"])
      // {
      //   Console.Write("Ingrese su numero de cédula: ");
      //   cedula_empleado = Console.ReadLine();
      // }
      //
      //
      // Console.Write("Ingrese su clave: ");
      // clave_empleado = Console.ReadLine();
      //

    }
  }
}
  