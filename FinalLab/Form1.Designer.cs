
namespace FinalLab
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.but_agregar = new System.Windows.Forms.Button();
            this.but_lista = new System.Windows.Forms.Button();
            this.but_stock = new System.Windows.Forms.Button();
            this.gb_grupo = new System.Windows.Forms.GroupBox();
            this.rb_Insumos = new System.Windows.Forms.RadioButton();
            this.rb_Herreria = new System.Windows.Forms.RadioButton();
            this.rb_Herramienta = new System.Windows.Forms.RadioButton();
            this.tb_nombreProducto = new System.Windows.Forms.TextBox();
            this.tb_cantProducto = new System.Windows.Forms.TextBox();
            this.lb_Nombre = new System.Windows.Forms.Label();
            this.lb_cantProducto = new System.Windows.Forms.Label();
            this.lb_precProducto = new System.Windows.Forms.Label();
            this.tb_precProducto = new System.Windows.Forms.TextBox();
            this.tb_colorHerra = new System.Windows.Forms.TextBox();
            this.lb_colorHerra = new System.Windows.Forms.Label();
            this.but_borrarCart = new System.Windows.Forms.Button();
            this.lb_agregarProducto = new System.Windows.Forms.Label();
            this.lb_contadorCarrito = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableferreteriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testdbDataSet = new FinalLab.testdbDataSet();
            this.lbcodigoProducto = new System.Windows.Forms.Label();
            this.tb_codigoProducto = new System.Windows.Forms.TextBox();
            this.but_actualizarStock = new System.Windows.Forms.Button();
            this.but_borrarBD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_precioCarrito = new System.Windows.Forms.Label();
            this.table_ferreteriaTableAdapter = new FinalLab.testdbDataSetTableAdapters.table_ferreteriaTableAdapter();
            this.butCargarTabla = new System.Windows.Forms.Button();
            this.tableferreteriaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableUpdateStatementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataGridFerreteria = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosDataGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gb_grupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableferreteriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableferreteriaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableUpdateStatementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFerreteria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // but_agregar
            // 
            this.but_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.but_agregar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.but_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_agregar.Font = new System.Drawing.Font("Helvetica Neue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_agregar.Location = new System.Drawing.Point(137, 279);
            this.but_agregar.Name = "but_agregar";
            this.but_agregar.Size = new System.Drawing.Size(121, 37);
            this.but_agregar.TabIndex = 1;
            this.but_agregar.Text = "Agregar al Carrito";
            this.but_agregar.UseVisualStyleBackColor = false;
            this.but_agregar.Click += new System.EventHandler(this.but_agregar_Click);
            // 
            // but_lista
            // 
            this.but_lista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.but_lista.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.but_lista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_lista.Font = new System.Drawing.Font("Helvetica Neue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_lista.Location = new System.Drawing.Point(15, 279);
            this.but_lista.Name = "but_lista";
            this.but_lista.Size = new System.Drawing.Size(116, 37);
            this.but_lista.TabIndex = 2;
            this.but_lista.Text = "Mostrar Carrito";
            this.but_lista.UseVisualStyleBackColor = false;
            this.but_lista.Click += new System.EventHandler(this.but_lista_Click);
            // 
            // but_stock
            // 
            this.but_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.but_stock.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.but_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_stock.Font = new System.Drawing.Font("Helvetica Neue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_stock.Location = new System.Drawing.Point(16, 349);
            this.but_stock.Name = "but_stock";
            this.but_stock.Size = new System.Drawing.Size(115, 37);
            this.but_stock.TabIndex = 4;
            this.but_stock.Text = "Insertar ";
            this.but_stock.UseVisualStyleBackColor = false;
            this.but_stock.Click += new System.EventHandler(this.but_stock_Click);
            // 
            // gb_grupo
            // 
            this.gb_grupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.gb_grupo.Controls.Add(this.rb_Insumos);
            this.gb_grupo.Controls.Add(this.rb_Herreria);
            this.gb_grupo.Controls.Add(this.rb_Herramienta);
            this.gb_grupo.Font = new System.Drawing.Font("Helvetica Neue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_grupo.ForeColor = System.Drawing.Color.White;
            this.gb_grupo.Location = new System.Drawing.Point(12, 13);
            this.gb_grupo.Name = "gb_grupo";
            this.gb_grupo.Size = new System.Drawing.Size(366, 79);
            this.gb_grupo.TabIndex = 5;
            this.gb_grupo.TabStop = false;
            this.gb_grupo.Text = "Tipo de Producto";
            // 
            // rb_Insumos
            // 
            this.rb_Insumos.AutoSize = true;
            this.rb_Insumos.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.rb_Insumos.Font = new System.Drawing.Font("Helvetica Neue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Insumos.Location = new System.Drawing.Point(264, 41);
            this.rb_Insumos.Name = "rb_Insumos";
            this.rb_Insumos.Size = new System.Drawing.Size(67, 18);
            this.rb_Insumos.TabIndex = 2;
            this.rb_Insumos.TabStop = true;
            this.rb_Insumos.Text = "Insumos";
            this.rb_Insumos.UseVisualStyleBackColor = true;
            this.rb_Insumos.CheckedChanged += new System.EventHandler(this.rb_Insumos_CheckedChanged);
            // 
            // rb_Herreria
            // 
            this.rb_Herreria.AutoSize = true;
            this.rb_Herreria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.rb_Herreria.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.rb_Herreria.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.rb_Herreria.Font = new System.Drawing.Font("Helvetica Neue", 8.25F);
            this.rb_Herreria.Location = new System.Drawing.Point(146, 41);
            this.rb_Herreria.Name = "rb_Herreria";
            this.rb_Herreria.Size = new System.Drawing.Size(65, 18);
            this.rb_Herreria.TabIndex = 1;
            this.rb_Herreria.TabStop = true;
            this.rb_Herreria.Text = "Herreria";
            this.rb_Herreria.UseVisualStyleBackColor = false;
            this.rb_Herreria.CheckedChanged += new System.EventHandler(this.rb_Herreria_CheckedChanged);
            // 
            // rb_Herramienta
            // 
            this.rb_Herramienta.AutoSize = true;
            this.rb_Herramienta.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.rb_Herramienta.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.rb_Herramienta.Font = new System.Drawing.Font("Helvetica Neue", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Herramienta.Location = new System.Drawing.Point(20, 41);
            this.rb_Herramienta.Name = "rb_Herramienta";
            this.rb_Herramienta.Size = new System.Drawing.Size(85, 18);
            this.rb_Herramienta.TabIndex = 0;
            this.rb_Herramienta.TabStop = true;
            this.rb_Herramienta.Text = "Herramienta";
            this.rb_Herramienta.UseVisualStyleBackColor = true;
            this.rb_Herramienta.CheckedChanged += new System.EventHandler(this.rb_Herramienta_CheckedChanged);
            // 
            // tb_nombreProducto
            // 
            this.tb_nombreProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.tb_nombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_nombreProducto.Font = new System.Drawing.Font("Helvetica Neue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nombreProducto.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_nombreProducto.Location = new System.Drawing.Point(15, 118);
            this.tb_nombreProducto.Name = "tb_nombreProducto";
            this.tb_nombreProducto.Size = new System.Drawing.Size(363, 20);
            this.tb_nombreProducto.TabIndex = 6;
            // 
            // tb_cantProducto
            // 
            this.tb_cantProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.tb_cantProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_cantProducto.Font = new System.Drawing.Font("Helvetica Neue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cantProducto.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_cantProducto.Location = new System.Drawing.Point(15, 165);
            this.tb_cantProducto.Name = "tb_cantProducto";
            this.tb_cantProducto.Size = new System.Drawing.Size(169, 20);
            this.tb_cantProducto.TabIndex = 7;
            // 
            // lb_Nombre
            // 
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Font = new System.Drawing.Font("Helvetica Neue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nombre.Location = new System.Drawing.Point(12, 101);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(98, 14);
            this.lb_Nombre.TabIndex = 8;
            this.lb_Nombre.Text = "Nombre producto:";
            // 
            // lb_cantProducto
            // 
            this.lb_cantProducto.AutoSize = true;
            this.lb_cantProducto.Font = new System.Drawing.Font("Helvetica Neue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cantProducto.Location = new System.Drawing.Point(13, 148);
            this.lb_cantProducto.Name = "lb_cantProducto";
            this.lb_cantProducto.Size = new System.Drawing.Size(141, 14);
            this.lb_cantProducto.TabIndex = 9;
            this.lb_cantProducto.Text = "Cantidad: (Herreria en grs.)";
            // 
            // lb_precProducto
            // 
            this.lb_precProducto.AutoSize = true;
            this.lb_precProducto.Font = new System.Drawing.Font("Helvetica Neue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_precProducto.Location = new System.Drawing.Point(13, 191);
            this.lb_precProducto.Name = "lb_precProducto";
            this.lb_precProducto.Size = new System.Drawing.Size(89, 14);
            this.lb_precProducto.TabIndex = 12;
            this.lb_precProducto.Text = "Precio producto:";
            // 
            // tb_precProducto
            // 
            this.tb_precProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.tb_precProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_precProducto.Font = new System.Drawing.Font("Helvetica Neue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_precProducto.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_precProducto.Location = new System.Drawing.Point(15, 209);
            this.tb_precProducto.Name = "tb_precProducto";
            this.tb_precProducto.Size = new System.Drawing.Size(363, 20);
            this.tb_precProducto.TabIndex = 13;
            // 
            // tb_colorHerra
            // 
            this.tb_colorHerra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.tb_colorHerra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_colorHerra.Font = new System.Drawing.Font("Helvetica Neue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_colorHerra.ForeColor = System.Drawing.Color.White;
            this.tb_colorHerra.Location = new System.Drawing.Point(15, 251);
            this.tb_colorHerra.Name = "tb_colorHerra";
            this.tb_colorHerra.Size = new System.Drawing.Size(363, 20);
            this.tb_colorHerra.TabIndex = 16;
            // 
            // lb_colorHerra
            // 
            this.lb_colorHerra.AutoSize = true;
            this.lb_colorHerra.Font = new System.Drawing.Font("Helvetica Neue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_colorHerra.Location = new System.Drawing.Point(13, 234);
            this.lb_colorHerra.Name = "lb_colorHerra";
            this.lb_colorHerra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_colorHerra.Size = new System.Drawing.Size(97, 14);
            this.lb_colorHerra.TabIndex = 17;
            this.lb_colorHerra.Text = "Color herramienta:";
            // 
            // but_borrarCart
            // 
            this.but_borrarCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.but_borrarCart.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.but_borrarCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_borrarCart.Font = new System.Drawing.Font("Helvetica Neue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_borrarCart.ForeColor = System.Drawing.Color.White;
            this.but_borrarCart.Location = new System.Drawing.Point(263, 279);
            this.but_borrarCart.Name = "but_borrarCart";
            this.but_borrarCart.Size = new System.Drawing.Size(115, 37);
            this.but_borrarCart.TabIndex = 19;
            this.but_borrarCart.Text = "Limpiar Carrito";
            this.but_borrarCart.UseVisualStyleBackColor = false;
            this.but_borrarCart.Click += new System.EventHandler(this.but_borrarCart_Click);
            // 
            // lb_agregarProducto
            // 
            this.lb_agregarProducto.AutoSize = true;
            this.lb_agregarProducto.Location = new System.Drawing.Point(13, 389);
            this.lb_agregarProducto.Name = "lb_agregarProducto";
            this.lb_agregarProducto.Size = new System.Drawing.Size(0, 14);
            this.lb_agregarProducto.TabIndex = 16;
            // 
            // lb_contadorCarrito
            // 
            this.lb_contadorCarrito.AutoSize = true;
            this.lb_contadorCarrito.Location = new System.Drawing.Point(12, 403);
            this.lb_contadorCarrito.Name = "lb_contadorCarrito";
            this.lb_contadorCarrito.Size = new System.Drawing.Size(0, 14);
            this.lb_contadorCarrito.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica Neue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 14);
            this.label1.TabIndex = 21;
            this.label1.Text = "Estado base datos:";
            // 
            // tableferreteriaBindingSource
            // 
            this.tableferreteriaBindingSource.DataMember = "table_ferreteria";
            this.tableferreteriaBindingSource.DataSource = this.testdbDataSet;
            // 
            // testdbDataSet
            // 
            this.testdbDataSet.DataSetName = "testdbDataSet";
            this.testdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbcodigoProducto
            // 
            this.lbcodigoProducto.AutoSize = true;
            this.lbcodigoProducto.Font = new System.Drawing.Font("Helvetica Neue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcodigoProducto.Location = new System.Drawing.Point(190, 148);
            this.lbcodigoProducto.Name = "lbcodigoProducto";
            this.lbcodigoProducto.Size = new System.Drawing.Size(93, 14);
            this.lbcodigoProducto.TabIndex = 23;
            this.lbcodigoProducto.Text = "Codigo Producto:";
            // 
            // tb_codigoProducto
            // 
            this.tb_codigoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.tb_codigoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_codigoProducto.Font = new System.Drawing.Font("Helvetica Neue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codigoProducto.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_codigoProducto.Location = new System.Drawing.Point(193, 165);
            this.tb_codigoProducto.Name = "tb_codigoProducto";
            this.tb_codigoProducto.Size = new System.Drawing.Size(185, 20);
            this.tb_codigoProducto.TabIndex = 24;
            // 
            // but_actualizarStock
            // 
            this.but_actualizarStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.but_actualizarStock.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.but_actualizarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_actualizarStock.Font = new System.Drawing.Font("Helvetica Neue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_actualizarStock.Location = new System.Drawing.Point(137, 349);
            this.but_actualizarStock.Name = "but_actualizarStock";
            this.but_actualizarStock.Size = new System.Drawing.Size(121, 37);
            this.but_actualizarStock.TabIndex = 25;
            this.but_actualizarStock.Text = "Actualizar";
            this.but_actualizarStock.UseVisualStyleBackColor = false;
            this.but_actualizarStock.Click += new System.EventHandler(this.but_actualizarStock_Click);
            // 
            // but_borrarBD
            // 
            this.but_borrarBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.but_borrarBD.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.but_borrarBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_borrarBD.Font = new System.Drawing.Font("Helvetica Neue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_borrarBD.Location = new System.Drawing.Point(263, 349);
            this.but_borrarBD.Name = "but_borrarBD";
            this.but_borrarBD.Size = new System.Drawing.Size(115, 37);
            this.but_borrarBD.TabIndex = 26;
            this.but_borrarBD.Text = "Borrar";
            this.but_borrarBD.UseVisualStyleBackColor = false;
            this.but_borrarBD.Click += new System.EventHandler(this.but_borrarBD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 14);
            this.label2.TabIndex = 28;
            this.label2.Text = "Acciones para Base de Datos:";
            // 
            // lb_precioCarrito
            // 
            this.lb_precioCarrito.AutoSize = true;
            this.lb_precioCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_precioCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_precioCarrito.Location = new System.Drawing.Point(12, 417);
            this.lb_precioCarrito.Name = "lb_precioCarrito";
            this.lb_precioCarrito.Size = new System.Drawing.Size(0, 13);
            this.lb_precioCarrito.TabIndex = 29;
            // 
            // table_ferreteriaTableAdapter
            // 
            this.table_ferreteriaTableAdapter.ClearBeforeFill = true;
            // 
            // butCargarTabla
            // 
            this.butCargarTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.butCargarTabla.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.butCargarTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCargarTabla.Font = new System.Drawing.Font("Helvetica Neue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCargarTabla.Location = new System.Drawing.Point(806, 392);
            this.butCargarTabla.Name = "butCargarTabla";
            this.butCargarTabla.Size = new System.Drawing.Size(103, 38);
            this.butCargarTabla.TabIndex = 30;
            this.butCargarTabla.Text = "Recargar Tabla";
            this.butCargarTabla.UseVisualStyleBackColor = false;
            this.butCargarTabla.Click += new System.EventHandler(this.butCargarTabla_Click);
            // 
            // tableferreteriaBindingSource1
            // 
            this.tableferreteriaBindingSource1.DataMember = "table_ferreteria";
            this.tableferreteriaBindingSource1.DataSource = this.testdbDataSet;
            // 
            // tableUpdateStatementBindingSource
            // 
            this.tableUpdateStatementBindingSource.DataSource = typeof(MySqlX.XDevAPI.Relational.TableUpdateStatement);
            // 
            // DataGridFerreteria
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Helvetica Neue", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridFerreteria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridFerreteria.AutoGenerateColumns = false;
            this.DataGridFerreteria.BackgroundColor = System.Drawing.Color.Honeydew;
            this.DataGridFerreteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridFerreteria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.DataGridFerreteria.DataSource = this.productosDataGridBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Helvetica Neue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridFerreteria.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridFerreteria.GridColor = System.Drawing.Color.Gray;
            this.DataGridFerreteria.Location = new System.Drawing.Point(384, 30);
            this.DataGridFerreteria.Name = "DataGridFerreteria";
            this.DataGridFerreteria.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DataGridFerreteria.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridFerreteria.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.DataGridFerreteria.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridFerreteria.Size = new System.Drawing.Size(525, 355);
            this.DataGridFerreteria.TabIndex = 32;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // productosDataGridBindingSource
            // 
            this.productosDataGridBindingSource.DataSource = typeof(FinalLab.ProductosDataGrid);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(921, 470);
            this.Controls.Add(this.DataGridFerreteria);
            this.Controls.Add(this.butCargarTabla);
            this.Controls.Add(this.lb_precioCarrito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.but_borrarBD);
            this.Controls.Add(this.but_actualizarStock);
            this.Controls.Add(this.tb_codigoProducto);
            this.Controls.Add(this.lbcodigoProducto);
            this.Controls.Add(this.but_stock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_contadorCarrito);
            this.Controls.Add(this.lb_agregarProducto);
            this.Controls.Add(this.but_borrarCart);
            this.Controls.Add(this.lb_colorHerra);
            this.Controls.Add(this.tb_colorHerra);
            this.Controls.Add(this.tb_precProducto);
            this.Controls.Add(this.lb_precProducto);
            this.Controls.Add(this.lb_cantProducto);
            this.Controls.Add(this.lb_Nombre);
            this.Controls.Add(this.tb_cantProducto);
            this.Controls.Add(this.tb_nombreProducto);
            this.Controls.Add(this.gb_grupo);
            this.Controls.Add(this.but_lista);
            this.Controls.Add(this.but_agregar);
            this.Font = new System.Drawing.Font("Helvetica Neue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Ferreteria Los Hermanos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_grupo.ResumeLayout(false);
            this.gb_grupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableferreteriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableferreteriaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableUpdateStatementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFerreteria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button but_agregar;
        private System.Windows.Forms.Button but_lista;
        private System.Windows.Forms.Button but_stock;
        private System.Windows.Forms.GroupBox gb_grupo;
        private System.Windows.Forms.RadioButton rb_Insumos;
        private System.Windows.Forms.RadioButton rb_Herreria;
        private System.Windows.Forms.RadioButton rb_Herramienta;
        private System.Windows.Forms.TextBox tb_nombreProducto;
        private System.Windows.Forms.TextBox tb_cantProducto;
        private System.Windows.Forms.Label lb_Nombre;
        private System.Windows.Forms.Label lb_cantProducto;
        private System.Windows.Forms.Label lb_precProducto;
        private System.Windows.Forms.TextBox tb_precProducto;
        private System.Windows.Forms.TextBox tb_colorHerra;
        private System.Windows.Forms.Label lb_colorHerra;
        private System.Windows.Forms.Button but_borrarCart;
        private System.Windows.Forms.Label lb_agregarProducto;
        private System.Windows.Forms.Label lb_contadorCarrito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbcodigoProducto;
        private System.Windows.Forms.TextBox tb_codigoProducto;
        private System.Windows.Forms.Button but_actualizarStock;
        private System.Windows.Forms.Button but_borrarBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_precioCarrito;
        private testdbDataSet testdbDataSet;
        private System.Windows.Forms.BindingSource tableferreteriaBindingSource;
        private testdbDataSetTableAdapters.table_ferreteriaTableAdapter table_ferreteriaTableAdapter;
        private System.Windows.Forms.Button butCargarTabla;
        private System.Windows.Forms.BindingSource tableferreteriaBindingSource1;
        private System.Windows.Forms.BindingSource tableUpdateStatementBindingSource;
        private System.Windows.Forms.DataGridView DataGridFerreteria;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productosDataGridBindingSource;
    }
}

