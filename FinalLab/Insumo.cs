using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab
{
    class Insumo: ProductoFerreteria
    {

        public double precioFinal;
        
        public Insumo(String nombreProducto, double precProducto, int cantProducto)
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

        public override string descuentoAplicado(int _cantProducto)
        {
            string descuentoAplicado;
            
            if (_cantProducto >= 12)
            {
                descuentoAplicado = "10%";
            }
            else
            {
                descuentoAplicado = "Sin descuento.";
            }

            return descuentoAplicado;
        }




    }
}
