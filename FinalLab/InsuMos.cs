using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab
{
    class InsuMos: ProdFerre
    {

        public double precioFinal;
        
        public InsuMos(String nombreProducto, double precProducto, int cantProducto)
            :base(nombreProducto, precProducto,cantProducto)
        {

        }


        public override double calcularPrecio(int cantProducto, double precioProducto)
        {
            //Llevando más de una docena de "insumos" se 
            //hará un descuento del 10% 
            if (cantProducto >= 12)
            {
                precioFinal = (precProducto * cantProducto) * 0.9;
            }else
            {
                precioFinal = precProducto * cantProducto;
            }

            return precioFinal;
        }






    }
}
