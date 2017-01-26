using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Lote
    {
        private string idLote, semilla;
        private int ciclo;
        private double area;
        private DateTime fecha;

        public string IdLote
        {
            get
            {
                return idLote;
            }

            set
            {
                idLote = value;
            }
        }

        public string Semilla
        {
            get
            {
                return semilla;
            }

            set
            {
                semilla = value;
            }
        }

        public int Ciclo
        {
            get
            {
                return ciclo;
            }

            set
            {
                ciclo = value;
            }
        }

        public double Area
        {
            get
            {
                return area;
            }

            set
            {
                area = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }
    }
}
