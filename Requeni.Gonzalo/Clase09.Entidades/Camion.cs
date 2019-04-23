using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Camion : Vehiculo
    {
        protected float tara;

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
            return base.ToString() + " - Tara: " + this.tara;
        }

        public Camion(float tara, string patente, Byte cantRuedas, EMarca marca):base(patente,cantRuedas,marca)
        {
            this.tara = tara;
        }
    }
}
