
namespace FinalLab
{
    partial class FormCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.but_borrarCart = new System.Windows.Forms.Button();
            this.but_lista = new System.Windows.Forms.Button();
            this.but_agregar = new System.Windows.Forms.Button();
            this.gb_grupo = new System.Windows.Forms.GroupBox();
            this.rb_Insumos = new System.Windows.Forms.RadioButton();
            this.rb_Herreria = new System.Windows.Forms.RadioButton();
            this.rb_Herramienta = new System.Windows.Forms.RadioButton();
            this.tb_codigoProducto = new System.Windows.Forms.TextBox();
            this.lbcodigoProducto = new System.Windows.Forms.Label();
            this.lb_colorHerra = new System.Windows.Forms.Label();
            this.tb_colorHerra = new System.Windows.Forms.TextBox();
            this.tb_precProducto = new System.Windows.Forms.TextBox();
            this.lb_precProducto = new System.Windows.Forms.Label();
            this.lb_cantProducto = new System.Windows.Forms.Label();
            this.lb_Nombre = new System.Windows.Forms.Label();
            this.tb_cantProducto = new System.Windows.Forms.TextBox();
            this.tb_nombreProducto = new System.Windows.Forms.TextBox();
            this.descuento_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_agregarProducto = new System.Windows.Forms.Label();
            this.gb_grupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // but_borrarCart
            // 
            this.but_borrarCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.but_borrarCart.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.but_borrarCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_borrarCart.Font = new System.Drawing.Font("Helvetica Neue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_borrarCart.ForeColor = System.Drawing.Color.White;
            this.but_borrarCart.Location = new System.Drawing.Point(12, 248);
            this.but_borrarCart.Name = "but_borrarCart";
            this.but_borrarCart.Size = new System.Drawing.Size(178, 37);
            this.but_borrarCart.TabIndex = 22;
            this.but_borrarCart.Text = "Limpiar Carrito";
            this.but_borrarCart.UseVisualStyleBackColor = false;
            this.but_borrarCart.Click += new System.EventHandler(this.but_borrarCart_Click);
            // 
            // but_lista
            // 
            this.but_lista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.but_lista.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.but_lista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_lista.Font = new System.Drawing.Font("Helvetica Neue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_lista.ForeColor = System.Drawing.Color.White;
            this.but_lista.Location = new System.Drawing.Point(196, 248);
            this.but_lista.Name = "but_lista";
            this.but_lista.Size = new System.Drawing.Size(178, 37);
            this.but_lista.TabIndex = 21;
            this.but_lista.Text = "Mostrar Carrito";
            this.but_lista.UseVisualStyleBackColor = false;
            this.but_lista.Click += new System.EventHandler(this.but_lista_Click);
            // 
            // but_agregar
            // 
            this.but_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.but_agregar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.but_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_agregar.Font = new System.Drawing.Font("Helvetica Neue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_agregar.ForeColor = System.Drawing.Color.White;
            this.but_agregar.Location = new System.Drawing.Point(12, 291);
            this.but_agregar.Name = "but_agregar";
            this.but_agregar.Size = new System.Drawing.Size(362, 37);
            this.but_agregar.TabIndex = 20;
            this.but_agregar.Text = "Agregar al Carrito";
            this.but_agregar.UseVisualStyleBackColor = false;
            this.but_agregar.Click += new System.EventHandler(this.but_agregar_Click);
            // 
            // gb_grupo
            // 
            this.gb_grupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.gb_grupo.Controls.Add(this.rb_Insumos);
            this.gb_grupo.Controls.Add(this.rb_Herreria);
            this.gb_grupo.Controls.Add(this.rb_Herramienta);
            this.gb_grupo.Font = new System.Drawing.Font("Helvetica Neue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_grupo.ForeColor = System.Drawing.Color.White;
            this.gb_grupo.Location = new System.Drawing.Point(12, 12);
            this.gb_grupo.Name = "gb_grupo";
            this.gb_grupo.Size = new System.Drawing.Size(362, 79);
            this.gb_grupo.TabIndex = 23;
            this.gb_grupo.TabStop = false;
            this.gb_grupo.Text = "Tipo de Producto";
            // 
            // rb_Insumos
            // 
            this.rb_Insumos.AutoSize = true;
            this.rb_Insumos.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.rb_Insumos.Font = new System.Drawing.Font("Helvetica Neue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Insumos.Location = new System.Drawing.Point(258, 41);
            this.rb_Insumos.Name = "rb_Insumos";
            this.rb_Insumos.Size = new System.Drawing.Size(80, 21);
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
            this.rb_Herreria.Font = new System.Drawing.Font("Helvetica Neue", 10F);
            this.rb_Herreria.Location = new System.Drawing.Point(150, 41);
            this.rb_Herreria.Name = "rb_Herreria";
            this.rb_Herreria.Size = new System.Drawing.Size(78, 21);
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
            this.rb_Herramienta.Font = new System.Drawing.Font("Helvetica Neue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Herramienta.Location = new System.Drawing.Point(20, 41);
            this.rb_Herramienta.Name = "rb_Herramienta";
            this.rb_Herramienta.Size = new System.Drawing.Size(105, 21);
            this.rb_Herramienta.TabIndex = 0;
            this.rb_Herramienta.TabStop = true;
            this.rb_Herramienta.Text = "Herramienta";
            this.rb_Herramienta.UseVisualStyleBackColor = true;
            this.rb_Herramienta.CheckedChanged += new System.EventHandler(this.rb_Herramienta_CheckedChanged);
            // 
            // tb_codigoProducto
            // 
            this.tb_codigoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.tb_codigoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_codigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codigoProducto.ForeColor = System.Drawing.Color.White;
            this.tb_codigoProducto.Location = new System.Drawing.Point(196, 125);
            this.tb_codigoProducto.Name = "tb_codigoProducto";
            this.tb_codigoProducto.Size = new System.Drawing.Size(178, 23);
            this.tb_codigoProducto.TabIndex = 34;
            // 
            // lbcodigoProducto
            // 
            this.lbcodigoProducto.AutoSize = true;
            this.lbcodigoProducto.Font = new System.Drawing.Font("Helvetica Neue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcodigoProducto.ForeColor = System.Drawing.Color.White;
            this.lbcodigoProducto.Location = new System.Drawing.Point(193, 105);
            this.lbcodigoProducto.Name = "lbcodigoProducto";
            this.lbcodigoProducto.Size = new System.Drawing.Size(119, 17);
            this.lbcodigoProducto.TabIndex = 33;
            this.lbcodigoProducto.Text = "Codigo Producto:";
            // 
            // lb_colorHerra
            // 
            this.lb_colorHerra.AutoSize = true;
            this.lb_colorHerra.Font = new System.Drawing.Font("Helvetica Neue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_colorHerra.ForeColor = System.Drawing.Color.White;
            this.lb_colorHerra.Location = new System.Drawing.Point(8, 197);
            this.lb_colorHerra.Name = "lb_colorHerra";
            this.lb_colorHerra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_colorHerra.Size = new System.Drawing.Size(127, 17);
            this.lb_colorHerra.TabIndex = 32;
            this.lb_colorHerra.Text = "Color herramienta:";
            // 
            // tb_colorHerra
            // 
            this.tb_colorHerra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.tb_colorHerra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_colorHerra.Font = new System.Drawing.Font("Helvetica Neue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_colorHerra.ForeColor = System.Drawing.Color.White;
            this.tb_colorHerra.Location = new System.Drawing.Point(11, 217);
            this.tb_colorHerra.Name = "tb_colorHerra";
            this.tb_colorHerra.Size = new System.Drawing.Size(363, 23);
            this.tb_colorHerra.TabIndex = 31;
            // 
            // tb_precProducto
            // 
            this.tb_precProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.tb_precProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_precProducto.Font = new System.Drawing.Font("Helvetica Neue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_precProducto.ForeColor = System.Drawing.Color.White;
            this.tb_precProducto.Location = new System.Drawing.Point(11, 171);
            this.tb_precProducto.Name = "tb_precProducto";
            this.tb_precProducto.Size = new System.Drawing.Size(169, 23);
            this.tb_precProducto.TabIndex = 30;
            // 
            // lb_precProducto
            // 
            this.lb_precProducto.AutoSize = true;
            this.lb_precProducto.Font = new System.Drawing.Font("Helvetica Neue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_precProducto.ForeColor = System.Drawing.Color.White;
            this.lb_precProducto.Location = new System.Drawing.Point(7, 151);
            this.lb_precProducto.Name = "lb_precProducto";
            this.lb_precProducto.Size = new System.Drawing.Size(114, 17);
            this.lb_precProducto.TabIndex = 29;
            this.lb_precProducto.Text = "Precio producto:";
            // 
            // lb_cantProducto
            // 
            this.lb_cantProducto.AutoSize = true;
            this.lb_cantProducto.Font = new System.Drawing.Font("Helvetica Neue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cantProducto.ForeColor = System.Drawing.Color.White;
            this.lb_cantProducto.Location = new System.Drawing.Point(193, 151);
            this.lb_cantProducto.Name = "lb_cantProducto";
            this.lb_cantProducto.Size = new System.Drawing.Size(181, 17);
            this.lb_cantProducto.TabIndex = 28;
            this.lb_cantProducto.Text = "Cantidad: (Herreria en grs.)";
            // 
            // lb_Nombre
            // 
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Font = new System.Drawing.Font("Helvetica Neue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nombre.ForeColor = System.Drawing.Color.White;
            this.lb_Nombre.Location = new System.Drawing.Point(8, 105);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(124, 17);
            this.lb_Nombre.TabIndex = 27;
            this.lb_Nombre.Text = "Nombre producto:";
            // 
            // tb_cantProducto
            // 
            this.tb_cantProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.tb_cantProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_cantProducto.Font = new System.Drawing.Font("Helvetica Neue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cantProducto.ForeColor = System.Drawing.Color.White;
            this.tb_cantProducto.Location = new System.Drawing.Point(194, 171);
            this.tb_cantProducto.Name = "tb_cantProducto";
            this.tb_cantProducto.Size = new System.Drawing.Size(180, 23);
            this.tb_cantProducto.TabIndex = 26;
            // 
            // tb_nombreProducto
            // 
            this.tb_nombreProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.tb_nombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_nombreProducto.Font = new System.Drawing.Font("Helvetica Neue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nombreProducto.ForeColor = System.Drawing.Color.White;
            this.tb_nombreProducto.Location = new System.Drawing.Point(11, 125);
            this.tb_nombreProducto.Name = "tb_nombreProducto";
            this.tb_nombreProducto.Size = new System.Drawing.Size(169, 23);
            this.tb_nombreProducto.TabIndex = 25;
            // 
            // descuento_producto
            // 
            this.descuento_producto.HeaderText = "Descuento Aplicado";
            this.descuento_producto.Name = "descuento_producto";
            this.descuento_producto.Width = 130;
            // 
            // precio_final
            // 
            this.precio_final.HeaderText = "Precio Final";
            this.precio_final.Name = "precio_final";
            // 
            // cantidad_producto
            // 
            this.cantidad_producto.HeaderText = "Cantidad";
            this.cantidad_producto.Name = "cantidad_producto";
            // 
            // nombre_producto
            // 
            this.nombre_producto.HeaderText = "Nombre";
            this.nombre_producto.Name = "nombre_producto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre_producto,
            this.cantidad_producto,
            this.precio_final,
            this.descuento_producto});
            this.dataGridView1.Location = new System.Drawing.Point(380, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(473, 310);
            this.dataGridView1.TabIndex = 38;
            // 
            // lb_agregarProducto
            // 
            this.lb_agregarProducto.AutoSize = true;
            this.lb_agregarProducto.Font = new System.Drawing.Font("Helvetica Neue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_agregarProducto.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_agregarProducto.Location = new System.Drawing.Point(405, 337);
            this.lb_agregarProducto.Name = "lb_agregarProducto";
            this.lb_agregarProducto.Size = new System.Drawing.Size(0, 17);
            this.lb_agregarProducto.TabIndex = 39;
            this.lb_agregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(865, 363);
            this.Controls.Add(this.lb_agregarProducto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_codigoProducto);
            this.Controls.Add(this.lbcodigoProducto);
            this.Controls.Add(this.lb_colorHerra);
            this.Controls.Add(this.tb_colorHerra);
            this.Controls.Add(this.tb_precProducto);
            this.Controls.Add(this.lb_precProducto);
            this.Controls.Add(this.lb_cantProducto);
            this.Controls.Add(this.lb_Nombre);
            this.Controls.Add(this.tb_cantProducto);
            this.Controls.Add(this.tb_nombreProducto);
            this.Controls.Add(this.gb_grupo);
            this.Controls.Add(this.but_borrarCart);
            this.Controls.Add(this.but_lista);
            this.Controls.Add(this.but_agregar);
            this.Name = "FormCliente";
            this.Text = "Cliente - Ferreteria Los Hermanos";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.gb_grupo.ResumeLayout(false);
            this.gb_grupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_borrarCart;
        private System.Windows.Forms.Button but_lista;
        private System.Windows.Forms.Button but_agregar;
        private System.Windows.Forms.GroupBox gb_grupo;
        private System.Windows.Forms.RadioButton rb_Insumos;
        private System.Windows.Forms.RadioButton rb_Herreria;
        private System.Windows.Forms.RadioButton rb_Herramienta;
        private System.Windows.Forms.TextBox tb_codigoProducto;
        private System.Windows.Forms.Label lbcodigoProducto;
        private System.Windows.Forms.Label lb_colorHerra;
        private System.Windows.Forms.TextBox tb_colorHerra;
        private System.Windows.Forms.TextBox tb_precProducto;
        private System.Windows.Forms.Label lb_precProducto;
        private System.Windows.Forms.Label lb_cantProducto;
        private System.Windows.Forms.Label lb_Nombre;
        private System.Windows.Forms.TextBox tb_cantProducto;
        private System.Windows.Forms.TextBox tb_nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_final;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_producto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_agregarProducto;
    }
}