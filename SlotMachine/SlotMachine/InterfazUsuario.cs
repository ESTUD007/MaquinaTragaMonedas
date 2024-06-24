using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    internal class InterfazUsuario
    {
        public void MenuAdmin()
        {
            // Ruta del archivo CSV
            string filePath = "premios.csv";
            // Lista para almacenar los productos leídos del archivo
            List<Premios> listaPremios = new List<Premios>();

            Maquina maquina = new Maquina();
            InterfazUsuario interfazUsuario = new InterfazUsuario();
            bool stopAdmin = false;

            while (stopAdmin == false)
            {
                Console.WriteLine();
                Console.WriteLine(" ###################################");
                Console.WriteLine(" ##          J U G A D O R        ##");
                Console.WriteLine(" ###################################");
                Console.WriteLine(" ##  1.Jugar                      ##");
                Console.WriteLine(" ##  2.Ver Premios                ##");
                Console.WriteLine(" ##  3.Cargar Premios             ##");
                Console.WriteLine(" ##  4.Salir                      ##");
                Console.WriteLine(" ###################################");
                Console.WriteLine();
                Console.Write(" Selecciona una opcion: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        maquina.IniciaMaquina();

                        Console.WriteLine(" 1.Jugar ");
                        Console.WriteLine(" 2.Salir ");
                        Console.Write(" Selecciona una opcion: ");
                        int seguirJugando = int.Parse(Console.ReadLine());
                        switch (seguirJugando)
                        {
                            case 1:
                                maquina.IniciaMaquina();
                                break;
                            case 2:
                                Console.WriteLine("----- PREMIOS DISPONIBLES -----");
                                foreach (Premios p in listaPremios)
                                {
                                    p.MostrarInformacion();
                                    Console.WriteLine();
                                }
                                Console.WriteLine("---------------------------------");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine(" Información de todos los premios:");
                        foreach (Premios p in listaPremios)
                        {
                            p.MostrarInformacion();
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        
                            try
                            {
                                // Llama al método para cargar productos desde el archivo CSV
                                maquina.CargarProductosDesdeCSV(filePath);
                                Console.WriteLine(" Productos guardados exitosamente.");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine($" Error: {e.Message}");
                            }
 

                        break;
                    case 4:
                        stopAdmin = true;
                        break;
                    default:
                        Console.WriteLine("Selecciona una opción valida");
                        break;
                }
            }
        }
    }
}
