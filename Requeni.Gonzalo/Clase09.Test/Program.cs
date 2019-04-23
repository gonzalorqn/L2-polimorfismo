using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculos;

namespace Clase09.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto a1 = new Auto(4,"AB 456 JF",4,EMarca.Honda);
            Moto m1 = new Moto(120,"AAA 321",2,EMarca.Zanella);
            Camion c1 = new Camion(150,"ASD 123",6,EMarca.Scania);

            Console.WriteLine(a1);
            Console.WriteLine(m1);
            Console.WriteLine(c1);

            Console.ReadLine();
        }
    }
}
