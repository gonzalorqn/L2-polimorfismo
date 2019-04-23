using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public abstract class Vehiculo
    {
        protected string _patente;
        protected EMarca _marca;
        protected Byte _cantidadRuedas;

        public override string ToString()
        {
            return "Patente: " + this._patente + " - Marca: " + this._marca.ToString() + " - Cantidad ruedas: " + this._cantidadRuedas;
        }

        public string Patente
        {
            get { return this._patente; }
        }

        public Vehiculo(string patente, Byte cantRuedas,EMarca marca)
        {
            this._patente = patente;
            this._cantidadRuedas = cantRuedas;
            this._marca = marca;
        }

        public static bool operator ==(Vehiculo v1,Vehiculo v2)
        {
            return (v1._patente == v2._patente && v1._marca == v2._marca);
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public abstract double Precio { get; set; }

        public abstract double CalcularPrecioConIVA();
    }
}
