using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    internal class Premio_simple : Premios
    {
        public string Consejo1 { get; set; }

        public Premio_simple() { }

        public Premio_simple(int id, int tipo, string nombre, char simbolo1, char simbolo2, char simbolo3, string consejo1) : base(id, tipo, nombre, simbolo1, simbolo2, simbolo3)
        {
            Consejo1 = consejo1;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($" Consejo: {Consejo1}");
        }
    }
}
