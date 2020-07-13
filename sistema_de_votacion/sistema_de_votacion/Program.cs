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
            candidato[] nombreCand = new candidato[4];
            candidato[] posicionCand = new candidato[4];
            candidato[] fecha_creacion = new candidato[4];
            candidato[] nombre_partido = new candidato[4];
            candidato[] siglas_partido = new candidato[4];
            candidato[] candidato = new candidato[4];
            candidato[] posicion = new candidato[4];

            //PRIMER CANDIDATO
            nombreCand[0].nombreCandidato = "Juan Pablo Duarte";
            posicionCand[0].posicion = "Presidente";
            fecha_creacion[0].fechaCreacion = "12 de julio del 2019";
            nombre_partido[0].nombrePartido = "Partido de Dominicanos Unidos";
            siglas_partido[0].siglas = "PDU";
            candidato[0].cantidadVotos = 0;
            
            //SEGUNDO CANDIDATO
            nombreCand[1].nombreCandidato = "Haraca Kiko";
            posicionCand[1].posicion = "Presidente";
            fecha_creacion[1].fechaCreacion = "13 de Agosto 1998";
            nombre_partido[1].nombrePartido = "Partido Revolucionario Social";
            siglas_partido[1].siglas = "PRS";
            candidato[1].cantidadVotos = 0;
            
            //TERCER CANDIDATO
            nombreCand[2].nombreCandidato = "Penco Garcia Beltré";
            posicionCand[2].posicion = "Presidente";
            fecha_creacion[2].fechaCreacion = "16 de Enero 1998";
            nombre_partido[2].nombrePartido = "Partido Santo Domingo";
            siglas_partido[2].siglas = "PSD";
            candidato[2].cantidadVotos = 0;
            
            //CUARTO CANDIDATO
            nombreCand[3].nombreCandidato = "Tayota Jimenez";
            posicionCand[3].posicion = "Presidente";
            fecha_creacion[3].fechaCreacion = "12 de Enero 1988";
            nombre_partido[3].nombrePartido = "Partido Católico";
            siglas_partido[3].siglas = "PC";
            candidato[3].cantidadVotos = 0;
            
            do
            {
                Random rnd = new Random();
                int rand = rnd.Next(0, 1000);
                if (rand <= 500 && rand % 2 == 0) { candidato[0].cantidadVotos = candidato[0].cantidadVotos + 1; }
                if (rand > 500 && rand % 2 == 0) { candidato[1].cantidadVotos = candidato[1].cantidadVotos + 1; }
                if (rand <= 500 && rand % 2 != 0) { candidato[2].cantidadVotos = candidato[2].cantidadVotos + 1; }
                if (rand > 500 && rand % 2 != 0) { candidato[3].cantidadVotos = candidato[3].cantidadVotos + 1; }
            } while ((candidato[0].cantidadVotos + candidato[1].cantidadVotos + candidato[2].cantidadVotos + candidato[3].cantidadVotos) < 1000);
            
            //CANDIDATOS
            Console.WriteLine("CANDIDATOS A LA PRESIDENCIA");
            for (int i = 0; i <= 3; i++)
            {

                Console.WriteLine();
                
                
                
               
            }
            Console.WriteLine("------------");
            Console.WriteLine("Porcentaje de Votos por partido en orden descendente. ");
            Console.WriteLine(" ");
            int mayor = candidato[0].cantidadVotos;
            int menor = mayor;
            posicion[0].posicionCandidato = 0;
            posicion[3].posicionCandidato = 0;
            for (int i = 1; i <= 3; i++)
            {
                if (candidato[i].cantidadVotos >= mayor)
                {
                    mayor = candidato[i].cantidadVotos;
                    posicion[0].posicionCandidato = i;
                }
                else
                {
                    if (candidato[i].cantidadVotos <= menor)
                    {
                        menor = candidato[i].cantidadVotos;
                        posicion[3].posicionCandidato = i;
                    }
                }
            }
            mayor = 0;
            menor = 0;
            posicion[1].posicionCandidato = -1;
            posicion[2].posicionCandidato = -1;
            for (int j = 0; j <= 3; j++)
            {
                if (j != posicion[0].posicionCandidato && j != posicion[3].posicionCandidato)
                {
                    if (candidato[j].cantidadVotos >= mayor)
                    {
                        mayor = candidato[j].cantidadVotos;
                        posicion[1].posicionCandidato = j;
                    }
                    else
                    {
                        menor = candidato[j].cantidadVotos;
                        posicion[2].posicionCandidato = j;
                    }
                }
            }
            if (posicion[2].posicionCandidato == -1) 
            {
                for (int a = 0;a <= 3;a++) 
                {
                    if (a != posicion[0].posicionCandidato && a != posicion[3].posicionCandidato && a != posicion[1].posicionCandidato) 
                    {
                        posicion[2].posicionCandidato = a;
                    }
                }

            }
            //RESULTADOS CON DATOS DE CADA PARTIDO
            for(int k = 0; k <= 3; k++)
            {
                //CANDIDATO
                Console.WriteLine("**PARTIDO {0}**", k + 1);
                Console.WriteLine("NOMBRE: " + nombre_partido[posicion[k].posicionCandidato].nombrePartido, "(" + siglas_partido[k].siglas + ")");
                Console.WriteLine("FECHA DE CREACION: {0}", fecha_creacion[k].fechaCreacion);
                Console.WriteLine("CANDIDATO: {0}", nombreCand[posicion[k].posicionCandidato].nombreCandidato);

                Console.WriteLine(candidato[posicion[k].posicionCandidato].cantidadVotos + " VOTOS");
                 double porciento = (candidato[posicion[k].posicionCandidato].cantidadVotos * 1000) * 0.0001;
                Console.WriteLine("["+porciento + "%]");
                Console.WriteLine("");
                
            }  
            Console.WriteLine(nombreCand[posicion[0].posicionCandidato].nombreCandidato + " Es el nuevo presidente electo del pais");
        }
      

    }
    }
