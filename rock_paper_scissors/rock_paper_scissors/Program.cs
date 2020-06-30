using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            
            string cpu = "";
            string jugador = "";
            string resultado = "";
            
            Random rnd = new Random();
            n = rnd.Next(1,4);
        
            if (n==1){
                cpu = "piedra";
            }
            if (n==2){
                cpu = "papel";
            }
            if (n==3){
                cpu = "tijeras"; 
            }
            Console.Write("Para jugar escribe: piedra, papel o tijeras. (*EN MINUSCULAS*): ");
            jugador = Console.ReadLine();
            if (cpu == "piedra"){
                if(jugador == "piedra") {
                    resultado="Es un empate";
                }
                if (jugador=="papel"){
                    resultado="Ganaste!";
                }
                if (jugador=="tijeras")
                    resultado="Perdiste";
            }
            if (cpu == "papel"){
                if(jugador == "papel") {
                    resultado="Es un empate";
                }
                if (jugador=="tijeras"){
                    resultado="Ganaste!";
                }
                if (jugador=="piedra")
                    resultado="Perdiste";
            }
            if (cpu == "tijeras"){
                if(jugador == "tijeras") {
                    resultado="Es un empate";
                }
                if (jugador=="piedra"){
                    resultado="Ganaste!";
                }
                if (jugador=="papel")
                    resultado="Perdiste";
            }
            Console.WriteLine("{0} vs {1}", jugador, cpu );
            Console.WriteLine(resultado);
            Console.WriteLine("Presiona enter para salir: ");
            Console.ReadLine();
        }
    }
}