using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    internal class Premios
    {
        public enum TipoPremio
        {
            PremioSimple,
            PremioAleatorio
        }
        //PROPIEDADES
        public int Id { get; set; }
        public string Nombre { get; set; }
        public char Simbolo1 { get; set; }
        public char Simbolo2 { get;set; }
        public char Simbolo3 { get; set; }

        public int Tipo { get; set; }

        //CONSTRUCTORES
        public Premios() { }

        public Premios(int id, int tipo, string nombre, char simbolo1, char simbolo2, char simbolo3)
        {
            Id = id;
            Nombre = nombre;
            Simbolo1 = simbolo1;
            Simbolo2 = simbolo2;
            Simbolo3 = simbolo3;
            Tipo = tipo;
        }

        //METODOS
        public void MostrarPremios()
        {
            Console.WriteLine($" Unidades: {Id}");
            Console.WriteLine($" Nombre: {Nombre}");


        }
        public virtual void MostrarInformacion()
        {

            Console.WriteLine($" Unidades: {Id}");
            Console.WriteLine($" Nombre: {Nombre}");
            Console.WriteLine($" Simbolo 1: {Simbolo1}");
            Console.WriteLine($" Simbolo 2: {Simbolo2}");
            Console.WriteLine($" Simbolo 3: {Simbolo3}");
            Console.WriteLine($" Tipo de premio: {Tipo}");
        }

    }



}
