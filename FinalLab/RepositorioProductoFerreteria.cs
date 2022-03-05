using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FinalLab
{
    class RepositorioProductoFerreteria
    {
        ManejadorBD controladorBD = new ManejadorBD();
        MySqlConnection connectTest;

        public Boolean insertarProducto(int codigo_producto, string nombre_producto, int stock_producto, string color_producto, double precio_producto)
        {
            
            string sql = "INSERT INTO table_ferreteria(codigo_producto, nombre_producto, stock_producto, color_producto, precio_producto) " +
                    "VALUES ('" + codigo_producto + "','" + nombre_producto + "','" + stock_producto + "','" + color_producto + "','" + precio_producto + "')";

            MySqlConnection conexionBD = controladorBD.ConnectBD();

            conexionBD.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(sql, conexionBD);
                command.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                conexionBD.Close();
                return false;
            }
        }

        public Boolean verificarConexion()
        {
            try
            {
                connectTest = controladorBD.ConnectBD();
                connectTest.Open();
                return true;
            }
            catch(MySqlException ex)
            {
                connectTest.Close();
                return false;
            }
        }

        public Boolean restarStockVenta(int stock_producto, int codigo_producto)
        {
            string sql = "UPDATE table_ferreteria SET stock_producto = (stock_producto -'" + stock_producto + "') WHERE codigo_producto='" + codigo_producto + "'";
            MySqlConnection conexionBD = controladorBD.ConnectBD();
            conexionBD.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(sql, conexionBD);
                command.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                conexionBD.Close();
                return false;    
            }
        }

        public Boolean actualizarStock(int stock_producto, int codigo_producto)
        {
            string sql = "UPDATE table_ferreteria SET stock_producto='" + stock_producto + "' WHERE codigo_producto='" + codigo_producto + "'";

            MySqlConnection conexionBD = controladorBD.ConnectBD();

            conexionBD.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(sql, conexionBD);
                command.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                conexionBD.Close();
                return false;
            }
        }

        public Boolean borrarFilaStock(int codigo_producto)
        {
            string sql = "DELETE FROM table_ferreteria WHERE codigo_producto =" + codigo_producto;

            MySqlConnection conexionBD = controladorBD.ConnectBD();
            conexionBD.Open();


            try
            {
                MySqlCommand command = new MySqlCommand(sql, conexionBD);
                command.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

        /*
            > Separar las funcionalidades del Rol Cliente (Carrito de Compras) en otro formulario.

            > En el formulario de Carrito de Compras mostrar una lista con los productos que están en el carrito y el precio total.
            > En el formulario de Carrito de Compras mostrar el descuento aplicado.
            > Mejorar el nombre de las clases.
            > Aplicar Repositorios para separar la logica de datos de la lógica de presentación.*/
    }
}
