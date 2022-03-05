using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalLab
{
    
    public partial class FormCliente : Form
    {
        //objeto repositorio
        RepositorioProductoFerreteria RepoForm = new RepositorioProductoFerreteria();

        //lista de compras que luego se mostrara al finalizar la compra. 
        List<ProductoFerreteria> listaCompras = new List<ProductoFerreteria>();

        int i = 0;

        public FormCliente()
        {
            InitializeComponent();
        }


        #region Botones Radiales
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
        #region Botones Carrito
        private void but_borrarCart_Click(object sender, EventArgs e)
        {
            listaCompras.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void but_lista_Click(object sender, EventArgs e)
        {
            double precioTotal = 0;

            if (listaCompras.Count != 0)
            { 
                foreach (ProductoFerreteria i in listaCompras)
                {
                   
                    precioTotal += i.calcularPrecio(i.cantProducto, i.precProducto);
                }

                MessageBox.Show("Carrito: " + listaCompras.Count + "Articulos. " + "Precio Final: $" + precioTotal);
            }
            else
            {
                MessageBox.Show("Carrito vacio. Ingrese productos.");
            }


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
                    listaCompras.Add(new Herramienta(_nombreProducto, _precProducto, _cantProducto, _colorHerra));

                    //metodo agregar a datagridview 
                    agregardgv();

                    lb_agregarProducto.Text = "Herramienta agregada al carrito.";
                    lb_agregarProducto.ForeColor = Color.Green;

                    //al agregarse al carrito se borrara la cantidad indicada del stock de la base de datos 
                    int.TryParse(tb_codigoProducto.Text, out int codigo_producto);
                    Boolean verificarResta = RepoForm.restarStockVenta(_cantProducto, codigo_producto);

                    if (verificarResta == true)
                    {
                        MessageBox.Show("Stock restado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al restar la cantidad del stock.");
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
                    listaCompras.Add(new Herreria(_nombreProducto, _precProducto, _cantProducto));

                    lb_agregarProducto.Text = "Herreria agregada al carrito.";
                    lb_agregarProducto.ForeColor = Color.Green;

                    //metodo agregar a datagridview 
                    agregardgv();

                    //al agregarse al carrito se borrara la cantidad indicada del stock de la base de datos 
                    int.TryParse(tb_codigoProducto.Text, out int codigo_producto);
                    Boolean verificarResta = RepoForm.restarStockVenta(_cantProducto, codigo_producto);

                    if (verificarResta == true)
                    {
                        MessageBox.Show("Stock restado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al restar la cantidad del stock.");
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
                    listaCompras.Add(new Insumo(_nombreProducto, _precProducto, _cantProducto));

                    lb_agregarProducto.Text = "Insumo agregado al carrito.";
                    lb_agregarProducto.ForeColor = Color.Green;
                    
                    //metodo agregar a datagridview 
                    agregardgv();

                    //al agregarse al carrito se borrara la cantidad indicada del stock de la base de datos 
                    int.TryParse(tb_codigoProducto.Text, out int codigo_producto);
                    Boolean verificarResta = RepoForm.restarStockVenta(_cantProducto, codigo_producto);

                    if (verificarResta == true)
                    {
                        MessageBox.Show("Stock restado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al restar la cantidad del stock.");
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
        #endregion
        private void limpiarTextBox()
        {
            tb_codigoProducto.Text = null;
            tb_cantProducto.Text = null;
            tb_colorHerra.Text = null;
            tb_nombreProducto.Text = null;
            tb_precProducto.Text = null;
        }

        private void agregardgv()
        {
            //adicionar nuevo renglon
            int n = dataGridView1.Rows.Add();

            //guardar la informacion
            dataGridView1.Rows[n].Cells[0].Value = tb_nombreProducto.Text;
            dataGridView1.Rows[n].Cells[1].Value = tb_cantProducto.Text;

            int cantProducto = Convert.ToInt32(tb_cantProducto.Text);
            double precioProducto = Convert.ToDouble(tb_precProducto.Text);

            foreach (ProductoFerreteria i in listaCompras)
            {
                dataGridView1.Rows[n].Cells[2].Value = i.calcularPrecio(cantProducto, precioProducto);
                dataGridView1.Rows[n].Cells[3].Value = i.descuentoAplicado(cantProducto);
            }

            limpiarTextBox();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            rb_Herreria.Checked = true;

            tb_cantProducto.Text = null;
            tb_codigoProducto.Text = null;
            tb_colorHerra.Text = null;
            tb_nombreProducto.Text = null;
            tb_precProducto.Text = null;
        }
    }
}
