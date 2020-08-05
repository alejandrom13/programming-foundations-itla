using System;
using System.Collections;

namespace PRACTICA_FINAL
{
  internal class Program
  {
    public class Empleado
    {
      public string nombre { get; set; }
      public DateTime creacion { get; set; }
      public bool activa { get; set; }
      public string rol { get; set; }
      public bool inactiva { get; set; }
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
      string[] credenciales1 = new string[2];
      credenciales1[0] = "40213664937"; //CEDULA
      credenciales1[1] = "13022002";//CLAVE


      //EMPLEADO 2 
      Empleado empleado2 = new Empleado()
      {
        nombre = "MIGUEL RAMON MORETA JIMENEZ",
        creacion = new DateTime(2005, 5, 1),
        activa = true,
        rol = "ADMINISTRADOR"
      };
      
      listaEmpleados.Add("01000042413", empleado2);
      listaEmpleados.Add(empleado2, "01052005");
      string[] credenciales2 = new string[2];
      credenciales2[0] = "01000042413";//CEDULA
      credenciales2[1] = "01052005";//CLAVE

      //EMPLEADO 3
      Empleado empleado3 = new Empleado()
      {
        nombre = "JAVIER DE LOS SANTOS RAMIREZ",
        creacion = new DateTime(2004, 7, 10),
        activa = false,
        rol = "VENDEDOR"
      };
      
      listaEmpleados.Add("01000013215", empleado3);
      listaEmpleados.Add(empleado3, "10072004");
      string[] credenciales3 = new string[2];
      credenciales3[0] = "01000013215";//CEDULA
      credenciales3[1] = "10072004";//CLAVE


      Console.Write("INGRESE SU NUMERO DE CEDULA: ");
      string cedula_empleado = Console.ReadLine();
      Console.Write("INGRESE SU CLAVE: ");
      string clave_empleado = Console.ReadLine();
      
      
      
      
      while (!listaEmpleados.ContainsKey(cedula_empleado) || !listaEmpleados.ContainsValue(clave_empleado))
      {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("CREDENCIALES NO ENCONTRADAS EN EL SISTEMA");
        Console.WriteLine("-----------------------------------------");
        Console.Write("INGRESE SU NUMERO DE CEDULA NUEVAMENTE: ");
        cedula_empleado = Console.ReadLine();

        Console.Write("INGRESE SU CLAVE: ");
        clave_empleado = Console.ReadLine();
        
      }
      

      while (cedula_empleado == credenciales1[0] && clave_empleado != credenciales1[1] 
             || cedula_empleado == credenciales2[0] && clave_empleado != credenciales2[1] 
             || cedula_empleado == credenciales3[0] && clave_empleado != credenciales3[1])
      {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("CREDENCIALES NO ENCONTRADAS EN EL SISTEMA");
        Console.WriteLine("-----------------------------------------");
        Console.Write("INGRESE SU NUMERO DE CEDULA NUEVAMENTE: ");
        cedula_empleado = Console.ReadLine();

        Console.Write("INGRESE SU CLAVE: ");
        clave_empleado = Console.ReadLine();
      }

      
        Empleado empleado = (Empleado) listaEmpleados[cedula_empleado];
        if (cedula_empleado == credenciales1[0] && clave_empleado == credenciales1[1] 
            || cedula_empleado == credenciales2[0] && clave_empleado == credenciales2[1] 
            || cedula_empleado == credenciales3[0] && clave_empleado == credenciales3[1] && empleado.activa)
        {
        
        Console.WriteLine("Bienvenido a la plataforma {0}", empleado.nombre);
        Console.WriteLine("Usted ha accedido con el usuario {0}, y su rol es: {1}", cedula_empleado, empleado.rol);
        Console.WriteLine("SU CUENTA ESTA ACTIVA");
        
        }

        else if (empleado.activa == false)
        {
          Console.WriteLine("LA CUENTA DE {0} ESTA INACTIVA, NO PUEDE ACCEDER", empleado.nombre);
        }
    }
    }
  }

  