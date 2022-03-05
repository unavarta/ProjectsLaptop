using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab
{
    public abstract class ProductoFerreteria
    {
        protected String nombreProducto;
        public double precProducto;
        public int cantProducto;
        public int codiProducto;

        public ProductoFerreteria(String nombreProducto, double precProducto, int cantProducto)
        {

            this.nombreProducto = nombreProducto;
            this.precProducto = precProducto;
            this.cantProducto = cantProducto;
        }

        public abstract double calcularPrecio(int _cantProducto, double _precioProducto);
        //Este metodo calcula precio y de acuerdo a la cantidad es el descuento que aplica.
        public abstract string descuentoAplicado(int _cantProducto);
        //Este metodo funciona para devolver un string con el porcentaje de descuento aplicado. 
        //Varia de clase heredada a clase.
            

        public String getnombreProducto()
        {
            return nombreProducto;
        }

    }
}
