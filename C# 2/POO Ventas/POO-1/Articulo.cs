using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    internal class Articulo
    {
        private int codArticulo;
        private float precio;
        private int codMarca;
        public int CodigoArticulo
        {
            get { return codArticulo; }
            set { codArticulo = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int CodigoMarca
        {
            get { return codMarca; }
            set
            {
                if (value > 0 && value < 11)
                    codMarca = value;
                else
                    codMarca = -1;         
            }
        }

    }
}
