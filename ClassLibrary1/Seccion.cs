using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleJokes
{
    class Seccion
    {
        private string idSeccion, idLote, idBloque;
        private Double area, numPlantas;
        private int posicion;

        public string IdSeccion
        {
            get
            {
                return idSeccion;
            }

            set
            {
                idSeccion = value;
            }
        }

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

        public string IdBloque
        {
            get
            {
                return idBloque;
            }

            set
            {
                idBloque = value;
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

        public double NumPlantas
        {
            get
            {
                return numPlantas;
            }

            set
            {
                numPlantas = value;
            }
        }

        public int Posicion
        {
            get
            {
                return posicion;
            }

            set
            {
                posicion = value;
            }
        }
    }
}
