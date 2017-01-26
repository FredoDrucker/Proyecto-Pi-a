using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Aplicacion
    {
        private int idAplicacion, tiempo, posicion;
        private string nombre, nombreComercial;

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

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string NombreComercial
        {
            get
            {
                return nombreComercial;
            }

            set
            {
                nombreComercial = value;
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

        public int Tiempo
        {
            get
            {
                return tiempo;
            }

            set
            {
                tiempo = value;
            }
        }
    }
}
