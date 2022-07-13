using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilistaCircular
{
    class TNodoTrabajador : TNodo
    {
        public int ID;
        public string Nombre;
        public string Oficio;

        public TNodoTrabajador(int iden, string nomb, string oficio)//:base()
        {
            ID = iden;
            Nombre = nomb;
            Oficio = oficio;
        }

        public int getID()
        {
            return ID;
        }

        public string getNombre()
        {
            return Nombre;
        }

        public string getOficio()
        {
            return Oficio;
        }
    }
}
