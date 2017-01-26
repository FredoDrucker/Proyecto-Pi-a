using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleJokes
{
    class Bloque
    {
        private String idBloque, idLote, area;
        private int posicion;

        public string Area
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
