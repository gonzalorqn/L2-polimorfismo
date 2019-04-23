using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Moto : Vehiculo
    {
        protected float cilindrada;

        public override double Precio
        {
            get; set;
        }

        public override double CalcularPrecioConIVA()
        {
            return this.Precio * 1.21;
        }

        public override string ToString()
        {
            return base.ToString() + " - Cilindrada: " + this.cilindrada;
        }

        public Moto(float cilindrada, string patente, Byte cantRuedas, EMarca marca) : base(patente, cantRuedas, marca)
        {
            this.cilindrada = cilindrada;
        }
    }
}
