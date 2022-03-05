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
        //objeto repositorio
        RepositorioProductoFerreteria RepoForm = new RepositorioProductoFerreteria();


        //Objeto para el conectador de la base de datos al DataGridView
        ManejadorBD conectorBD = new ManejadorBD();

        //lista de compras que luego se mostrara al finalizar la compra. 
        List<ProductoFerreteria> listaCompras = new List<ProductoFerreteria>();
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
        private void Form1_Load(object sender, EventArgs e)
        {
            

            //seleccionaremos al radio button de herramienta por defecto. 
            rb_Herramienta.Checked = true;
            cargarTabla(null);
            Boolean verificarConexion = RepoForm.verificarConexion();

            if (verificarConexion == true)
            {
                lb_baseDatos.Text = "Estado base datos: Conectada!";
                lb_baseDatos.ForeColor = Color.Green;
            }
            else
            {
                lb_baseDatos.Text = "Estado base datos: Desconectada!";
                lb_baseDatos.ForeColor = Color.Red;
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
                Boolean estadoConsulta = RepoForm.insertarProducto(codigo_producto, nombre_producto, stock_producto, color_producto, precio_producto);

                if (estadoConsulta)
                {
                    MessageBox.Show("El producto se inserto correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al insertar producto.");
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

                Boolean estadoConsulta = RepoForm.insertarProducto(codigo_producto, nombre_producto, stock_producto, null, precio_producto);

                if (estadoConsulta)
                {
                    MessageBox.Show("El producto se inserto correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al insertar producto.");
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
                int stock_producto = int.Parse(tb_cantProducto.Text);

                Boolean verificarActualiStock = RepoForm.actualizarStock(stock_producto, codigo_producto);

                if (verificarActualiStock == true)
                {
                    MessageBox.Show("Stock actualizado correctamente.");
                }
                else
                {
                    MessageBox.Show("Error en la actualizacion del stock.");
                }

                //limpiar todos los text boxes
                limpiarTextBox();
            }
            else if (rb_Herreria.Checked == true || rb_Insumos.Checked == true)
            {

                int codigo_producto = int.Parse(tb_codigoProducto.Text);
                int stock_producto = int.Parse(tb_cantProducto.Text);

                Boolean verificarActualiStock = RepoForm.actualizarStock(stock_producto, codigo_producto);

                if (verificarActualiStock == true)
                {
                    MessageBox.Show("Stock actualizado correctamente.");
                }
                else
                {
                    MessageBox.Show("Error en la actualizacion del stock.");
                }

                //limpiar todos los text boxes
                limpiarTextBox();
            }
        }

        private void but_borrarBD_Click(object sender, EventArgs e)
        {
            int codigo_producto;


            if (int.TryParse(tb_codigoProducto.Text, out codigo_producto))
            {
                Boolean filaBorrada = RepoForm.borrarFilaStock(codigo_producto);

                if (filaBorrada == true)
                {
                    MessageBox.Show("Fila eliminada correctamente!");
                }
                else
                {
                    MessageBox.Show("Error al eliminar la fila.");
                }


                //limpiar todos los text boxes
                limpiarTextBox();
            }
            else
            {
                MessageBox.Show("Ingrese un codigo para ser borrado.");
            }
                   
           
        }
        #endregion
       
        private void butCargarTabla_Click(object sender, EventArgs e)
        {
            cargarTabla(null);
        }

        private void cargarTabla(string data)
        {
            List<ProductoDataGrid> listaDataGrid = new List<ProductoDataGrid>();
            DataGridFerreteria.DataSource = conectorBD.ConsultaBD(data);
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
