using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FinalLab
{
    public partial class Form1 : Form
    {
        //lista de compras que luego se mostrara al finalizar la compra. 
        List<ProdFerre> listaCompras = new List<ProdFerre>();

        //Objeto para el conectador de la base de datos al.NET 
        ManejadorBD controladorBD = new ManejadorBD();
        MySqlConnection connectTest;

        public Form1()
        {
            InitializeComponent();
        }

        #region BotonesRadiales
        private void rb_Herramienta_CheckedChanged(object sender, EventArgs e)
        {
            tb_cantProducto.Enabled = true;
            tb_colorHerra.Enabled = true;

        }

        private void rb_Herreria_CheckedChanged(object sender, EventArgs e)
        {
            tb_colorHerra.Enabled = false;
            tb_colorHerra.Text = null;

        }

        private void rb_Insumos_CheckedChanged(object sender, EventArgs e)
        {
            tb_colorHerra.Enabled = false;
            tb_colorHerra.Text = null;

        }
        #endregion

        #region BotonesCarrito
        private void but_borrarCart_Click(object sender, EventArgs e)
        {
            listaCompras.Clear();
        }

        private void but_agregar_Click(object sender, EventArgs e)
        {
            if (rb_Herramienta.Checked)
            {
                //el if abajo funciona con valores true y a su vez convierte los datos de string a sus respectivos tipos.
                //esto funcionara de esta forma para la mayor parte del codigo escrito en este metodo.
                if (int.TryParse(tb_cantProducto.Text, out int _cantProducto) && double.TryParse(tb_precProducto.Text, out double _precProducto))
                {
                    string _nombreProducto = tb_nombreProducto.Text;
                    string _colorHerra = tb_colorHerra.Text;
                    listaCompras.Add(new HerraMienta(_nombreProducto, _precProducto, _cantProducto, _colorHerra));

                    lb_agregarProducto.Text = "Herramienta agregada al carrito.";
                    lb_agregarProducto.ForeColor = Color.Green;

                    //al agregarse al carrito se borrara la cantidad indicada del stock de la base de datos 
                    int codigo_producto = int.Parse(tb_codigoProducto.Text);
                    string sql = "UPDATE table_ferreteria SET stock_producto = (stock_producto -'" + _cantProducto + "') WHERE codigo_producto='" + codigo_producto + "'";

                    MySqlConnection conexionBD = controladorBD.ConnectBD();

                    conexionBD.Open();

                    try
                    {
                        MySqlCommand command = new MySqlCommand(sql, conexionBD);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Base datos modificada!");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al guardar." + ex.Message);
                    }
                    finally
                    {
                        conexionBD.Close();
                    }

                    //se limpian todos los text boxes.
                    limpiarTextBox();
                }
                else
                {
                    lb_agregarProducto.Text = "Error en el tipeo de datos.";
                    lb_agregarProducto.ForeColor = Color.Red;
                }

            }
            else if (rb_Herreria.Checked)
            {
                if (int.TryParse(tb_cantProducto.Text, out int _cantProducto) && double.TryParse(tb_precProducto.Text, out double _precProducto))
                {
                    string _nombreProducto = tb_nombreProducto.Text;
                    listaCompras.Add(new HerreRia(_nombreProducto, _precProducto, _cantProducto));

                    lb_agregarProducto.Text = "Herreria agregada al carrito.";
                    lb_agregarProducto.ForeColor = Color.Green;

                    //al agregarse al carrito se borrara la cantidad indicada del stock de la base de datos 
                    int codigo_producto = int.Parse(tb_codigoProducto.Text);
                    string sql = "UPDATE table_ferreteria SET stock_producto = (stock_producto -'" + _cantProducto + "') WHERE codigo_producto='" + codigo_producto + "'";

                    MySqlConnection conexionBD = controladorBD.ConnectBD();

                    conexionBD.Open();

                    try
                    {
                        MySqlCommand command = new MySqlCommand(sql, conexionBD);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Base datos modificada!");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al guardar." + ex.Message);
                    }
                    finally
                    {
                        conexionBD.Close();
                    }

                    //se limpian todos los text boxes.
                    limpiarTextBox();
                }
                else
                {
                    lb_agregarProducto.Text = "Error en el tipeo de datos.";
                    lb_agregarProducto.ForeColor = Color.Red;
                }
            }
            else if (rb_Insumos.Checked)
            {
                if (int.TryParse(tb_cantProducto.Text, out int _cantProducto) && double.TryParse(tb_precProducto.Text, out double _precProducto))
                {
                    string _nombreProducto = tb_nombreProducto.Text;
                    listaCompras.Add(new InsuMos(_nombreProducto, _precProducto, _cantProducto));

                    lb_agregarProducto.Text = "Insumo agregado al carrito.";
                    lb_agregarProducto.ForeColor = Color.Green;

                    //al agregarse al carrito se borrara la cantidad indicada del stock de la base de datos 
                    int codigo_producto = int.Parse(tb_codigoProducto.Text);
                    string sql = "UPDATE table_ferreteria SET stock_producto = (stock_producto -'" + _cantProducto + "') WHERE codigo_producto='" + codigo_producto + "'";

                    MySqlConnection conexionBD = controladorBD.ConnectBD();

                    conexionBD.Open();

                    try
                    {
                        MySqlCommand command = new MySqlCommand(sql, conexionBD);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Base datos modificada!");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al guardar." + ex.Message);
                    }
                    finally
                    {
                        conexionBD.Close();
                    }

                    //se limpian todos los text boxes.
                    limpiarTextBox();
                }
                else
                {
                    lb_agregarProducto.Text = "Error en el tipeo de datos.";
                    lb_agregarProducto.ForeColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Error. Seleccionar un tipo de producto."); //SI NO SE SELECCIONA NINGUN TIPO DE PRODUCTO. 
            }
        }

        private void but_lista_Click(object sender, EventArgs e)
        {
            double precioTotal = 0;

            if (listaCompras.Count > 1)
            {
                lb_contadorCarrito.Text = "Carrito: " + listaCompras.Count + " Artículos.";
                lb_precioCarrito.ForeColor = Color.Green;

                foreach (ProdFerre i in listaCompras)
                {
                    precioTotal += i.calcularPrecio(i.cantProducto, i.precProducto);

                    lb_precioCarrito.Text = "Precio total: $" + Convert.ToString(precioTotal);

                }
            }
            else if (listaCompras.Count == 1)
            {
                lb_contadorCarrito.Text = "Carrito: " + listaCompras.Count + " Artículo.";
                lb_precioCarrito.ForeColor = Color.Green;

                foreach (ProdFerre i in listaCompras)
                {
                    precioTotal += i.calcularPrecio(i.cantProducto, i.precProducto);

                    lb_precioCarrito.Text = "Precio total: $" + Convert.ToString(precioTotal);
                }

            }
            else if (listaCompras.Count == 0)
            {
                lb_contadorCarrito.Text = "Carrito vacio.";
                lb_precioCarrito.Text = "Precio total: $0";
                lb_agregarProducto.Text = "";
            }
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'testdbDataSet.table_ferreteria' Puede moverla o quitarla según sea necesario.
            //this.table_ferreteriaTableAdapter.Fill(this.testdbDataSet.table_ferreteria);

            //seleccionaremos al radio button de herramienta por defecto. 
            rb_Herramienta.Checked = true;
            cargarTabla(null);

            try
            {
                connectTest = controladorBD.ConnectBD();

                connectTest.Open();

                label1.ForeColor = Color.Green;
                label1.Text = "Estado base datos: Conectada!";

                connectTest.Close();
            }
            catch (Exception x)
            {

                label1.ForeColor = Color.Red;
                label1.Text = "Estado base datos: No conectada!";

            }
        }

        #region BotonesBaseDatos
        private void but_stock_Click(object sender, EventArgs e)
        {
            if (rb_Herramienta.Checked)
            {

                int codigo_producto = int.Parse(tb_codigoProducto.Text);
                string nombre_producto = tb_nombreProducto.Text;
                int stock_producto = int.Parse(tb_cantProducto.Text);
                double precio_producto = double.Parse(tb_precProducto.Text);
                string color_producto = tb_colorHerra.Text;

                string sql = "INSERT INTO table_ferreteria(codigo_producto, nombre_producto, stock_producto, color_producto, precio_producto) " +
                    "VALUES ('" + codigo_producto + "','" + nombre_producto + "','" + stock_producto + "','" + color_producto + "','" + precio_producto + "')";

                MySqlConnection conexionBD = controladorBD.ConnectBD();

                conexionBD.Open();
               
                try
                {
                    MySqlCommand command = new MySqlCommand(sql, conexionBD);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Base datos actualizada!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al guardar" + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }

                //limpiar todos los text boxes
                limpiarTextBox();

            }
            else if (rb_Herreria.Checked == true || rb_Insumos.Checked == true)
            {

                int codigo_producto = int.Parse(tb_codigoProducto.Text);
                string nombre_producto = tb_nombreProducto.Text;
                int stock_producto = int.Parse(tb_cantProducto.Text);
                double precio_producto = double.Parse(tb_precProducto.Text);

                string sql = "INSERT INTO table_ferreteria(codigo_producto, nombre_producto, stock_producto, color_producto, precio_producto) " +
                    "VALUES ('" + codigo_producto + "','" + nombre_producto + "','" + stock_producto + "','" + null + "','" + precio_producto + "')";

                MySqlConnection conexionBD = controladorBD.ConnectBD();

                conexionBD.Open();

                try
                {
                    MySqlCommand command = new MySqlCommand(sql, conexionBD);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Base datos actualizada!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al guardar" + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }

                //limpiar todos los text boxes
                limpiarTextBox();
            }
        }

        private void but_actualizarStock_Click(object sender, EventArgs e)
        {
            if (rb_Herramienta.Checked)
            {

                int codigo_producto = int.Parse(tb_codigoProducto.Text);
                string nombre_producto = tb_nombreProducto.Text;
                int stock_producto = int.Parse(tb_cantProducto.Text);
                int precio_producto = int.Parse(tb_precProducto.Text);
                string color_producto = tb_colorHerra.Text;

                string sql = "UPDATE table_ferreteria SET nombre_producto='" + nombre_producto + "', stock_producto='" + stock_producto + "', precio_producto='" + precio_producto + "', color_producto='" + color_producto + "' WHERE codigo_producto='" + codigo_producto + "'";

                MySqlConnection conexionBD = controladorBD.ConnectBD();

                conexionBD.Open();

                try
                {
                    MySqlCommand command = new MySqlCommand(sql, conexionBD);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Base datos modificada!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al guardar." + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }

                //limpiar todos los text boxes
                limpiarTextBox();
            }
            else if (rb_Herreria.Checked == true || rb_Insumos.Checked == true)
            {

                int codigo_producto = int.Parse(tb_codigoProducto.Text);
                string nombre_producto = tb_nombreProducto.Text;
                int stock_producto = int.Parse(tb_cantProducto.Text);
                double precio_producto = double.Parse(tb_precProducto.Text);

                string sql = "UPDATE table_ferreteria SET nombre_producto='" + nombre_producto + "', stock_producto='" + stock_producto + "', precio_producto='" + precio_producto + "' WHERE codigo_producto='" + codigo_producto + "'";

                MySqlConnection conexionBD = controladorBD.ConnectBD();

                conexionBD.Open();

                try
                {
                    MySqlCommand command = new MySqlCommand(sql, conexionBD);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Base datos modificada!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al guardar" + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }

                //limpiar todos los text boxes
                limpiarTextBox();
            }
        }

        private void but_borrarBD_Click(object sender, EventArgs e)
        {
            int codigo_producto = int.Parse(tb_codigoProducto.Text);

            string sql = "DELETE FROM table_ferreteria WHERE codigo_producto =" + codigo_producto;

            MySqlConnection conexionBD = controladorBD.ConnectBD();
            conexionBD.Open();


            try
            {
                MySqlCommand command = new MySqlCommand(sql, conexionBD);
                command.ExecuteNonQuery();
                MessageBox.Show("FILA BORRADA!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR AL ELIMINAR!" + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }

            //limpiar todos los text boxes
            limpiarTextBox();
        }
        #endregion
       
        private void butCargarTabla_Click(object sender, EventArgs e)
        {
            cargarTabla(null);
        }

        private void cargarTabla(string data)
        {
            List<ProductosDataGrid> listaDataGrid = new List<ProductosDataGrid>();
            DataGridFerreteria.DataSource = controladorBD.ConsultaBD(data);
        }
        private void limpiarTextBox()
        {
            tb_codigoProducto.Text = null;
            tb_cantProducto.Text = null;
            tb_colorHerra.Text = null;
            tb_nombreProducto.Text = null;
            tb_precProducto.Text = null;
        }
    }
}
