using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab
{
    class ManejadorBD
    {
        public MySqlConnection ConnectBD()
        {
            string connStr = "server=localhost; user=root; database=testdb; port=3306; password=password"; 
            
            MySqlConnection connObject = new MySqlConnection(connStr); //conectara a la base de datos.
            return connObject;
        }
        
        public List<Object> ConsultaBD(string Dato)
        {
            MySqlDataReader reader;

            List<Object> Lista = new List<object>();
            string sql;

            try
            {
                if (Dato == null) //muestra por defecto todos los productos
                {
                    sql = "SELECT * FROM table_ferreteria ORDER BY codigo_producto ASC";
                }
                else //aun no me decido si integrar un buscador
                {
                    sql = "SELECT * FROM table_ferreteria WHERE codigo_producto like'%" + Dato + "%' OR nombre_producto like'%" + Dato + "%' ORDER BY codigo_producto ASC";
                }

                MySqlConnection connectDataGrid = ConnectBD();
                connectDataGrid.Open();

                MySqlCommand comando = new MySqlCommand(sql, connectDataGrid);
                reader = comando.ExecuteReader();


                while (reader.Read()) //leera todos los productos hasta el final
                {
                    ProductosDataGrid prod = new ProductosDataGrid(); //objeto de la clase ProductosDataGrid

                    prod.Codigo = int.Parse(reader.GetString(0));
                    prod.Nombre = reader[1].ToString();
                    prod.Stock = int.Parse(reader[2].ToString());
                    prod.Color = reader[3].ToString();
                    prod.Precio = double.Parse(reader[4].ToString());

                    Lista.Add(prod); //funcionara como un array
                }
            }
            catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Lista;
        }
    }
}
