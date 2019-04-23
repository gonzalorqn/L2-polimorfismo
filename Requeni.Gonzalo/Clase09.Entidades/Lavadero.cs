using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Lavadero
    {
        private List<Vehiculo> _vehiculos;
        private float _precioAuto;
        private float _precioMoto;
        private float _precioCamion;

        private Lavadero()
        {
            this._vehiculos = new List<Vehiculo>();
        }

        public Lavadero(float auto, float moto, float camion) :this()
        {
            this._precioAuto = auto;
            this._precioMoto = moto;
            this._precioCamion = camion;
        }

        public string MiLavadero
        {
            get
            {
                string retorno = "";
                retorno += "Precio autos: " + this._precioAuto + " - Precio motos: " + this._precioMoto + " - Precio camiones: " + this._precioCamion;
                foreach (Vehiculo item in this._vehiculos)
                {
                    retorno += "\n";
                    retorno += item.ToString();
                }
                return retorno;
            }
        }

        public List<Vehiculo> Vehiculos
        {
            get { return this._vehiculos; }
        }

        public static bool operator ==(Lavadero l,Vehiculo v)
        {
            foreach (Vehiculo item in l._vehiculos)
            {
                if (item == v)
                    return true;  
            }
            return false;
        }

        public static bool operator !=(Lavadero l, Vehiculo v)
        {
            return !(l == v);
        }

        public static Lavadero operator +(Lavadero l, Vehiculo v)
        {
            if(l != v)
            {
                l._vehiculos.Add(v);
            }
            return l;
        }

        public static Lavadero operator -(Lavadero l, Vehiculo v)
        {
            if (l == v)
            {
                l._vehiculos.Remove(v);
            }
            return l;
        }
    }
}
