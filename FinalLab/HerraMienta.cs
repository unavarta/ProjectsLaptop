using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab
{
    class Herramienta : ProductoFerreteria
    {
        public String colorHerra;
        public double precioFinal;
        
        public Herramienta(String nombreProducto, double precProducto, int cantProducto, String colorHerra)
            :base(nombreProducto, precProducto, cantProducto)
        {   
            this.colorHerra = colorHerra;
        }

        public override double calcularPrecio(int cantProducto, double precProducto)
        {
            //Cantidad varía el precio, si se compran 5 o más el precio baja por 15%.
            //Si se compran más de 10 el descuento es del 30%.
            if (cantProducto >=  10)
            {
                precioFinal = ((precProducto * cantProducto) * 0.70);
            }
            else if (cantProducto >= 5 && cantProducto < 10)
            {
                precioFinal = ((precProducto * cantProducto) * 0.85);
            }
            else
            {
                precioFinal = precProducto * cantProducto;
            }

            return precioFinal;
        }
        public override string descuentoAplicado(int _cantProducto)
        {
            
            
            string descuentoAplicado;

            if (_cantProducto >= 10)
            {
                descuentoAplicado = "30%";
            }
            else if (cantProducto >= 5 && cantProducto < 10)
            {
                descuentoAplicado = "15%";
            }
            else
            {
                descuentoAplicado = "Sin descuento";
            }

            return descuentoAplicado;
        }
    }
}
