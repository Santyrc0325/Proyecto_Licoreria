using licores.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace licores
{
    public partial class FormsProductos : Form
    {
        private Button btnCargarProducto;
        private Button btnBuscarProducto;
        private TextBox txtBuscarProducto;
        private DataGridView dgvTablaProducto;
        private GroupBox groupBox1Producto;
        private TextBox txtIdProducto;
        private Label lblIdProducto;
        private Button btnEliminarProducto;
        private Button btnModificarProducto;
        private Button btnGuardarProducto;
        private TextBox txtIvaProducto;
        private TextBox txtPrecioProducto;
        private TextBox txtCantProducto;
        private TextBox txtNombreProducto;
        private TextBox txtRefProducto;
        private Label lblIVAProducto;
        private Label lblPrecioProducto;
        private Label lblCantProducto;
        private Label lblNomProducto;
        private Label lblRefProducto;

        public FormsProductos()
        {
            InitializeComponent();
            Producto producto = new Producto();
            producto.MostrarProductos(dgvTablaProducto);
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            // Cargar cualquier configuración inicial o datos necesarios al cargar el formulario
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.GuardarProducto(txtRefProducto.Text, txtNombreProducto.Text, int.Parse(txtCantProducto.Text), int.Parse(txtPrecioProducto.Text), int.Parse(txtIvaProducto.Text));
            producto.MostrarProductos(dgvTablaProducto);
        }

        private void dgvTablaProducto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Producto producto = new Producto();
            producto.SeleccionarProducto(dgvTablaProducto, txtIdProducto, txtRefProducto, txtNombreProducto, txtCantProducto, txtPrecioProducto, txtIvaProducto);
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.ModificarProducto(int.Parse(txtIdProducto.Text), txtRefProducto.Text, txtNombreProducto.Text, int.Parse(txtCantProducto.Text), int.Parse(txtPrecioProducto.Text), int.Parse(txtIvaProducto.Text));
            producto.MostrarProductos(dgvTablaProducto);
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.EliminarProducto(int.Parse(txtIdProducto.Text));
            producto.MostrarProductos(dgvTablaProducto);
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.MostrarProductos(dgvTablaProducto, txtBuscarProducto.Text);
        }

        private void btnCargarProductos_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.MostrarProductos(dgvTablaProducto);
            txtBuscarProducto.Text = "";
        }


        private void InitializeComponent()
        {
            btnCargarProducto = new Button();
            btnBuscarProducto = new Button();
            txtBuscarProducto = new TextBox();
            dgvTablaProducto = new DataGridView();
            groupBox1Producto = new GroupBox();
            txtIdProducto = new TextBox();
            lblIdProducto = new Label();
            btnEliminarProducto = new Button();
            btnModificarProducto = new Button();
            btnGuardarProducto = new Button();
            txtIvaProducto = new TextBox();
            txtPrecioProducto = new TextBox();
            txtCantProducto = new TextBox();
            txtNombreProducto = new TextBox();
            txtRefProducto = new TextBox();
            lblIVAProducto = new Label();
            lblPrecioProducto = new Label();
            lblCantProducto = new Label();
            lblNomProducto = new Label();
            lblRefProducto = new Label();
            ((ISupportInitialize)dgvTablaProducto).BeginInit();
            groupBox1Producto.SuspendLayout();
            SuspendLayout();
            // 
            // btnCargarProducto
            // 
            btnCargarProducto.Image = Properties.Resources.actualizar;
            btnCargarProducto.Location = new Point(827, 28);
            btnCargarProducto.Name = "btnCargarProducto";
            btnCargarProducto.Size = new Size(27, 23);
            btnCargarProducto.TabIndex = 11;
            btnCargarProducto.UseVisualStyleBackColor = true;
            btnCargarProducto.Click += btnCargarProductos_Click;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Image = Properties.Resources.lupa;
            btnBuscarProducto.Location = new Point(794, 28);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(27, 23);
            btnBuscarProducto.TabIndex = 10;
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(235, 28);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.PlaceholderText = "Buscar producto por nombre";
            txtBuscarProducto.Size = new Size(555, 23);
            txtBuscarProducto.TabIndex = 9;
            // 
            // dgvTablaProducto
            // 
            dgvTablaProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaProducto.Location = new Point(235, 57);
            dgvTablaProducto.Name = "dgvTablaProducto";
            dgvTablaProducto.Size = new Size(642, 345);
            dgvTablaProducto.TabIndex = 8;
            dgvTablaProducto.CellMouseClick += dgvTablaProducto_CellMouseClick;
            // 
            // groupBox1Producto
            // 
            groupBox1Producto.Controls.Add(txtIdProducto);
            groupBox1Producto.Controls.Add(lblIdProducto);
            groupBox1Producto.Controls.Add(btnEliminarProducto);
            groupBox1Producto.Controls.Add(btnModificarProducto);
            groupBox1Producto.Controls.Add(btnGuardarProducto);
            groupBox1Producto.Controls.Add(txtIvaProducto);
            groupBox1Producto.Controls.Add(txtPrecioProducto);
            groupBox1Producto.Controls.Add(txtCantProducto);
            groupBox1Producto.Controls.Add(txtNombreProducto);
            groupBox1Producto.Controls.Add(txtRefProducto);
            groupBox1Producto.Controls.Add(lblIVAProducto);
            groupBox1Producto.Controls.Add(lblPrecioProducto);
            groupBox1Producto.Controls.Add(lblCantProducto);
            groupBox1Producto.Controls.Add(lblNomProducto);
            groupBox1Producto.Controls.Add(lblRefProducto);
            groupBox1Producto.Location = new Point(9, 41);
            groupBox1Producto.Name = "groupBox1Producto";
            groupBox1Producto.Size = new Size(220, 361);
            groupBox1Producto.TabIndex = 7;
            groupBox1Producto.TabStop = false;
            groupBox1Producto.Text = "Datos Producto";
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(77, 26);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.ReadOnly = true;
            txtIdProducto.Size = new Size(134, 23);
            txtIdProducto.TabIndex = 14;
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.Location = new Point(12, 34);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(20, 15);
            lblIdProducto.TabIndex = 13;
            lblIdProducto.Text = "Id:";
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(119, 297);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(95, 32);
            btnEliminarProducto.TabIndex = 12;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Location = new Point(12, 297);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(101, 32);
            btnModificarProducto.TabIndex = 11;
            btnModificarProducto.Text = "Modificar";
            btnModificarProducto.UseVisualStyleBackColor = true;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.Location = new Point(12, 258);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(202, 33);
            btnGuardarProducto.TabIndex = 10;
            btnGuardarProducto.Text = "Guardar";
            btnGuardarProducto.UseVisualStyleBackColor = true;
            btnGuardarProducto.Click += btnGuardarProducto_Click;
            // 
            // txtIvaProducto
            // 
            txtIvaProducto.Location = new Point(77, 218);
            txtIvaProducto.Name = "txtIvaProducto";
            txtIvaProducto.Size = new Size(134, 23);
            txtIvaProducto.TabIndex = 9;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(77, 180);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(134, 23);
            txtPrecioProducto.TabIndex = 8;
            // 
            // txtCantProducto
            // 
            txtCantProducto.Location = new Point(77, 138);
            txtCantProducto.Name = "txtCantProducto";
            txtCantProducto.Size = new Size(134, 23);
            txtCantProducto.TabIndex = 7;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(77, 100);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(134, 23);
            txtNombreProducto.TabIndex = 6;
            // 
            // txtRefProducto
            // 
            txtRefProducto.Location = new Point(77, 62);
            txtRefProducto.Name = "txtRefProducto";
            txtRefProducto.Size = new Size(134, 23);
            txtRefProducto.TabIndex = 5;
            // 
            // lblIVAProducto
            // 
            lblIVAProducto.AutoSize = true;
            lblIVAProducto.Location = new Point(12, 226);
            lblIVAProducto.Name = "lblIVAProducto";
            lblIVAProducto.Size = new Size(25, 15);
            lblIVAProducto.TabIndex = 4;
            lblIVAProducto.Text = "Iva:";
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.AutoSize = true;
            lblPrecioProducto.Location = new Point(12, 188);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(43, 15);
            lblPrecioProducto.TabIndex = 3;
            lblPrecioProducto.Text = "Precio:";
            // 
            // lblCantProducto
            // 
            lblCantProducto.AutoSize = true;
            lblCantProducto.Location = new Point(12, 146);
            lblCantProducto.Name = "lblCantProducto";
            lblCantProducto.Size = new Size(58, 15);
            lblCantProducto.TabIndex = 2;
            lblCantProducto.Text = "Cantidad:";
            // 
            // lblNomProducto
            // 
            lblNomProducto.AutoSize = true;
            lblNomProducto.Location = new Point(12, 108);
            lblNomProducto.Name = "lblNomProducto";
            lblNomProducto.Size = new Size(54, 15);
            lblNomProducto.TabIndex = 1;
            lblNomProducto.Text = "Nombre:";
            // 
            // lblRefProducto
            // 
            lblRefProducto.AutoSize = true;
            lblRefProducto.Location = new Point(12, 70);
            lblRefProducto.Name = "lblRefProducto";
            lblRefProducto.Size = new Size(65, 15);
            lblRefProducto.TabIndex = 0;
            lblRefProducto.Text = "Referencia:";
            // 
            // FormsProductos
            // 
            ClientSize = new Size(894, 481);
            Controls.Add(btnCargarProducto);
            Controls.Add(btnBuscarProducto);
            Controls.Add(txtBuscarProducto);
            Controls.Add(dgvTablaProducto);
            Controls.Add(groupBox1Producto);
            Name = "FormsProductos";
            ((ISupportInitialize)dgvTablaProducto).EndInit();
            groupBox1Producto.ResumeLayout(false);
            groupBox1Producto.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}