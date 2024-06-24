using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    internal class Maquina
    {
        public Maquina() { }
        public static List<Premios> listaPremios { get; set; } = new List<Premios>();
        public char[,] IniciaMaquina()
        {
            
            char[] slots = { 'Y', '1', '0', '*', '2', 'U', '5', '8' };

            char[,] MatrizSlot = new char[3, 3];
            Random random = new Random();





            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int randomIndex = random.Next(slots.Length); // Seleccionar un símbolo aleatorio
                    MatrizSlot[i, j] = slots[randomIndex];
                }
            }
            Console.WriteLine("Máquina tragamonedas:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(MatrizSlot[i, j] + " ");
                }
                Console.WriteLine();
            }
            return MatrizSlot;
            /*
            if (MatrizSlot[1, 0] == MatrizSlot[1, 1] && MatrizSlot[1, 1] == MatrizSlot[1, 2])
            {
                Console.WriteLine("GANASTE");
                listaPremios.Ca

                

            }*/

        }
        public void CargarProductosDesdeCSV(string rutaArchivo)
        {
            using (StreamReader reader = new StreamReader(rutaArchivo))
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
                        
                        listaPremios.Add(new Premio_simple(id, tipo, nombre, simbolo1, simbolo2, simbolo3, consejo1));

                    }
                    // Determinar el tipo de producto en función del contenido de los campos adicionales
                    else if (fields.Length > 7)
                    {
                        
                        string consejo2 = fields[7];
                        
                        double probabilidad = double.Parse(fields[8]);
                        listaPremios.Add(new Premio_aleatorio(id, tipo, nombre, simbolo1, simbolo2, simbolo3, consejo1, consejo2, probabilidad));

                    }
                    else 
                    {
                        // Si no coincide con ninguno de los casos anteriores, mostrar un error
                        Console.WriteLine($" Error: La línea del archivo CSV no tiene el formato correcto para un producto: {line}");

                    }
                    
                }
            }

        }
    }
}

