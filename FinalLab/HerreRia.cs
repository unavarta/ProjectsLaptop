using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab
{
    class Herreria : ProductoFerreteria
    {
        public double precioFinal;
        
        public Herreria(String nombreProducto, double precProducto, int cantProducto)
            : base(nombreProducto, precProducto, cantProducto)
        {
        
        }

        public override double calcularPrecio(int cantProducto, double precioProducto)
        {
            //Cantidad varía el precio, si se compran 250 o más gramos el precio baja por 7%.
            //Si se compran más de 500 el descuento es del 15%.
            //Si se lleva mas de 1000 grs, se hace un descuento del 35%.
            
            if (cantProducto >= 1000)
            {
                precioFinal = (precioProducto * 0.65);
            }
            else if (cantProducto >= 500 && cantProducto < 1000)
            {
                precioFinal = (precioProducto / 2) * 0.85;
            }
            else if (cantProducto >= 250 && cantProducto < 500)
            {
                precioFinal = (precioProducto / 4) * 0.93;
            }
            else
            {
                precioFinal = (cantProducto / 1000) * precioProducto;
            }
          
            return precioFinal;
        }

        public override string descuentoAplicado(int _cantProducto)
        {
            string descuentoAplicado;

            if (_cantProducto >= 1000)
            {
                descuentoAplicado = "35%";
            }
            else if (cantProducto >= 500 && cantProducto < 1000)
            {
                descuentoAplicado = "15%";
            }
            else if(cantProducto >= 250 && cantProducto < 500)
            {
                descuentoAplicado = "7%";
            }
            else
            {
                descuentoAplicado = "Sin descuento";
            }

            return descuentoAplicado;
        }
    }
}
