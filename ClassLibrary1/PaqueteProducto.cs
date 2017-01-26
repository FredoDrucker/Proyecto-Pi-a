using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class PaqueteProducto
    {
        private int idAplicacion;
        private string idProducto, dosis;

        public string Dosis
        {
            get
            {
                return dosis;
            }

            set
            {
                dosis = value;
            }
        }

        public int IdAplicacion
        {
            get
            {
                return idAplicacion;
            }

            set
            {
                idAplicacion = value;
            }
        }

        public string IdProducto
        {
            get
            {
                return idProducto;
            }

            set
            {
                idProducto = value;
            }
        }
    }
}
