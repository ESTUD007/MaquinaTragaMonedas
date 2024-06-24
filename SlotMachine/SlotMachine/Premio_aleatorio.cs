using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    internal class Premio_aleatorio :Premios
    {
        public string Consejo1 { get; set; }

        public string Consejo2 { get; set; }
        public double Probabilidad { get; set; }

        public Premio_aleatorio() { }

        public Premio_aleatorio(int id, int tipo, string nombre, char simbolo1, char simbolo2, char simbolo3, string consejo1, string consejo2, double probabilidad):base(id, tipo, nombre, simbolo1, simbolo2, simbolo3)
        {
            Consejo1 = consejo1;
            Consejo2 = consejo2;
            Probabilidad = probabilidad;
        }
        

        public override void MostrarInformacion()
        {
            string[] linea = File.ReadAllLines("premios.csv");
            //ajustar
            string[] separacion = linea[1].Split(';'); 

           
            
            
           
            base.MostrarInformacion();

            
                Console.WriteLine($" Consejo 1: {Consejo1}");
            
                Console.WriteLine($" Consejo 2: {Consejo2}");
                Console.WriteLine($" Probabilidad: {Probabilidad}");


        }
    }
}
