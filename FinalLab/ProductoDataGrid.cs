using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab
{
    class ProductoDataGrid
    {
        //esta clase se utiliza para enviar del form a la base de datos lo que se debe actualizar o borrar.

        private int _codigo;
        private string _nombre;
        private int _stock;
        private string _color;
        private double _precio;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public string Color { get => _color; set => _color = value; }
        public double Precio { get => _precio; set => _precio = value; }
    }
}
