using SlotMachine;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SlotMachine
{
    internal class Program
    {
        private static string claveSecreta = "ADMIN";
        
        static void Main(string[] args)
        {
            // Ruta del archivo CSV
            string filePath = "premios.csv";
            
            
            // Lista para almacenar los productos leídos del archivo
           Premios datosPremio = new Premios();
            Maquina maquina = new Maquina();
            InterfazUsuario interfazUsuario=new InterfazUsuario();
            maquina.CargarProductosDesdeCSV(filePath);
            

            bool stop = false;
            char[,] matriz = new char[3, 3];

            while (stop==false) {
                    Console.WriteLine();
                    Console.WriteLine(" ###################################");
                    Console.WriteLine(" ##          J U G A D O R        ##");
                    Console.WriteLine(" ###################################");
                    Console.WriteLine(" ##  1.Jugar                      ##");
                    Console.WriteLine(" ##  2.Ver Premios                ##");
                    Console.WriteLine(" ##  3.Opciones Admin             ##");
                    Console.WriteLine(" ##  4.Salir                      ##");
                    Console.WriteLine(" ###################################");
                    Console.WriteLine();
                    Console.Write(" Selecciona una opcion: ");
                    int opcion = int.Parse(Console.ReadLine());
                

                    switch (opcion)
                    {
                        case 1:
                        bool detener = false;
                        while (detener == false)
                        {
                            matriz=maquina.IniciaMaquina();

                            using (StreamReader reader = new StreamReader(filePath))
                            {
                                string line;
                                while ((line = reader.ReadLine()) != null)
                                {
                                    // Dividir la línea en campos utilizando el delimitador "|"
                                    string[] fields = line.Split(';');

                                    // Parsear los campos comunes a todos los productos
                                    int id = int.Parse(fields[0]);
                                    int tipo = int.Parse(fields[1]);
                                    string nombre = fields[2];
                                    char simbolo1 = char.Parse(fields[3]);
                                    char simbolo2 = char.Parse(fields[4]);
                                    char simbolo3 = char.Parse(fields[5]);
                                    string consejo1 = fields[6];
                               
                                    if (fields.Length == 7)
                                    {
                                        if (matriz[1, 0] == matriz[1, 1] && matriz[1, 1] == matriz[1, 2])
                                        {
                                            if (simbolo1 == matriz[1, 0])
                                            {
                                                Console.Write(consejo1);

                                            }
                                        }
                                    }else if (fields.Length > 7)
                                    {
                                        string consejo2 = fields[7];
                                        double probabilidad = double.Parse(fields[8]);

                                        Random random = new Random();
                                        double aleatorio = random.NextDouble();

                                        if (matriz[1, 0] == matriz[1, 1] && matriz[1, 1] == matriz[1, 2])
                                        {
                                            if (simbolo1 == matriz[1, 0])
                                            {
                                                if(aleatorio<probabilidad)
                                                    Console.Write(consejo2);
                                                else
                                                    Console.Write(consejo1);

                                            }
                                        }

                                }
                             }

                            }

                            Console.WriteLine(" 1.Jugar ");
                            Console.WriteLine(" 2.Salir ");
                            Console.Write(" Selecciona una opcion: ");
                            int seguirJugando = int.Parse(Console.ReadLine());
                            switch (seguirJugando)
                            {
                                case 1:
                                    
                                    break;
                                case 2:

                                    detener = true;
                                    
                                    break;
                            }
                        }
                            break;
                        case 2:
                        Console.WriteLine("----- PREMIOS DISPONIBLES -----");
                        foreach (Premios p in Maquina.listaPremios)
                        {
                            p.MostrarPremios();
                            Console.WriteLine();
                        }
                        Console.WriteLine("Introduce la Id para informacion detallada: ");
                        int ID_informacion = int.Parse(Console.ReadLine());

                        datosPremio = Maquina.listaPremios[ID_informacion];
                        datosPremio.MostrarInformacion();
                        


                        

                        break;
                        case 3:
                            Console.WriteLine("Introduce la contraseña: ");
                            string clave = Console.ReadLine();
                            if(clave == claveSecreta)
                            {
                                interfazUsuario.MenuAdmin();
                            }
                            else
                            {
                                Console.WriteLine("Clave erronea");
                            }
                            break;
                        case 4:
                            stop = true;
                            break;
                        default:
                            Console.WriteLine("Selecciona una opción valida");
                            break;
                    }
                } 
            } 
        }
    }
