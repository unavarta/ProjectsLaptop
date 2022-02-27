using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab
{
    public abstract class ProdFerre
    {
        protected String nombreProducto;
        public double precProducto;
        public int cantProducto;
        public int codiProducto;

        public ProdFerre(String nombreProducto, double precProducto, int cantProducto)
        {

            this.nombreProducto = nombreProducto;
            this.precProducto = precProducto;
            this.cantProducto = cantProducto;
        }

        public abstract double calcularPrecio(int _cantProducto, double _precioProducto);

        public String getnombreProducto()
        {
            return nombreProducto;
        }

    }
}
