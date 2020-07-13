using System;

namespace sistema_de_elecciones
{
    class Program
    {
        //ALEJANDRO MATOS 2019-8540
        /*
         * Crear una aplicación para un sistema de votaciones: 
            Caracteristicas:
            - Cantidad de candidatos 4
            - Cantidad de votos 1,000, estos seran de forma aleatoria.
            - Los resultados se mostraran (Total de votos por candidatos, % de votos acumulados y Ordenados descendente).
            - El sistema es tipo consola en C#.
            - Datos candidato: Partido, Nombre completo, poscición a la que aspira (presidente).
            - Partidos: Fecha de fundacion (ficticia), Nombre completo y siglas
         */
        struct candidato
        {
            public string nombreCandidato;
            public string posicion;
            public string fechaCreacion;
            public string nombrePartido;
            public string siglas;
            public int cantidadVotos;
            public int posicionCandidato;
            
        }
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO A ESTE SISTEMA DE ELECCIONES!");
            Console.WriteLine("PARA VER LOS RESULTADOS HAGA CLICK EN LA TECLA 'ENTER'");
            Console.ReadLine();
            
            candidato[] nombre_candidato = new candidato[4],
                posicion_candidato = new candidato[4],
                fecha_creacion = new candidato[4],
                nombre_partido = new candidato[4],
                siglas_partido = new candidato[4],
                candidato = new candidato[4],
                posicion = new candidato[4];
          

            //PRIMER CANDIDATO
            nombre_candidato[0].nombreCandidato = "Juan Pablo Duarte";
            posicion_candidato[0].posicion = "Presidente";
            fecha_creacion[0].fechaCreacion = "12 de julio del 2019";
            nombre_partido[0].nombrePartido = "Partido de Dominicanos Unidos";
            siglas_partido[0].siglas = "PDU";
            candidato[0].cantidadVotos = 0;
            
            //SEGUNDO CANDIDATO
            nombre_candidato[1].nombreCandidato = "Haraca Kiko";
            posicion_candidato[1].posicion = "Presidente";
            fecha_creacion[1].fechaCreacion = "13 de Agosto 1998";
            nombre_partido[1].nombrePartido = "Partido Revolucionario Social";
            siglas_partido[1].siglas = "PRS";
            candidato[1].cantidadVotos = 0;
            
            //TERCER CANDIDATO
            nombre_candidato[2].nombreCandidato = "Penco Garcia Beltré";
            posicion_candidato[2].posicion = "Presidente";
            fecha_creacion[2].fechaCreacion = "16 de Enero 1998";
            nombre_partido[2].nombrePartido = "Partido Santo Domingo";
            siglas_partido[2].siglas = "PSD";
            candidato[2].cantidadVotos = 0;
            
            //CUARTO CANDIDATO
            nombre_candidato[3].nombreCandidato = "Tayota Jimenez";
            posicion_candidato[3].posicion = "Presidente";
            fecha_creacion[3].fechaCreacion = "12 de Enero 1988";
            nombre_partido[3].nombrePartido = "Partido Católico";
            siglas_partido[3].siglas = "PC";
            candidato[3].cantidadVotos = 0;
            
            //OPERACION DE VOTOS
            do {
                Random rnd = new Random();
                int random = rnd.Next(0, 1000);
                if (random <= 500 && random % 2 == 0)
                {
                    candidato[0].cantidadVotos = candidato[0].cantidadVotos + 1;
                }

                if (random > 500 && random % 2 == 0)
                {
                    candidato[1].cantidadVotos = candidato[1].cantidadVotos + 1;
                }

                if (random <= 500 && random % 2 != 0)
                {
                    candidato[2].cantidadVotos = candidato[2].cantidadVotos + 1;
                }
                
                if (random > 500 && random % 2 != 0)
                {
                    candidato[3].cantidadVotos = candidato[3].cantidadVotos + 1;
                }
            } 
            while ((candidato[0].cantidadVotos + candidato[1].cantidadVotos + candidato[2].cantidadVotos + candidato[3].cantidadVotos) < 1000);
           
            
            Console.WriteLine("***RESULTADOS DE LAS ELECCIONES***");
            Console.WriteLine("");
            
            int mayorCantidad = candidato[0].cantidadVotos;
            int menorCantidad = mayorCantidad;
            posicion[0].posicionCandidato = 0;
            posicion[3].posicionCandidato = 0;
            for (int i = 1; i <= 3; i++)
            {
                if (candidato[i].cantidadVotos >= mayorCantidad)
                { mayorCantidad = candidato[i].cantidadVotos; posicion[0].posicionCandidato = 1; }
                else
                {
                    if (candidato[i].cantidadVotos <= menorCantidad)
                    { menorCantidad = candidato[i].cantidadVotos; posicion[3].posicionCandidato = 1; }
                }
            }
            mayorCantidad = 0;
            menorCantidad = 0;
            posicion[1].posicionCandidato = -1;
            posicion[2].posicionCandidato = -1;
            for (int e = 0; e <= 3; e++) 
            {
                if (e != posicion[0].posicionCandidato && e != posicion[3].posicionCandidato)
                {
                    if (candidato[e].cantidadVotos >= mayorCantidad)
                    { mayorCantidad = candidato[e].cantidadVotos; posicion[1].posicionCandidato = e; }
                    else
                    { menorCantidad = candidato[e].cantidadVotos; posicion[2].posicionCandidato = e; }
                }
            }
            if (posicion[2].posicionCandidato == -1) 
            {
                for (int a = 0;a <= 3;a++) 
                {
                    if (a != posicion[0].posicionCandidato && a != posicion[3].posicionCandidato && a != posicion[1].posicionCandidato) 
                    { posicion[2].posicionCandidato = a; }
                }
            }
            //RESULTADOS CON DATOS DE CADA PARTIDO
            for(int v = 0; v <= 3; v++)
            {
                //CANDIDATO
                Console.WriteLine("**PARTIDO {0}**", v + 1);
                Console.WriteLine("NOMBRE: " + nombre_partido[posicion[v].posicionCandidato].nombrePartido, "(" + siglas_partido[v].siglas + ")");
                Console.WriteLine("FECHA DE CREACION: {0}", fecha_creacion[v].fechaCreacion);
                Console.WriteLine("CANDIDATO: {0}", nombre_candidato[posicion[v].posicionCandidato].nombreCandidato);

                Console.WriteLine(candidato[posicion[v].posicionCandidato].cantidadVotos + " VOTOS");
                 double porciento = (candidato[posicion[v].posicionCandidato].cantidadVotos * 1000) * 0.0001;
                Console.WriteLine("["+porciento + "%]");
                Console.WriteLine("");
                
            }  
            Console.WriteLine(nombre_candidato[posicion[0].posicionCandidato].nombreCandidato + " es el nuevo presidente electo del pais");
        }
    }
}
