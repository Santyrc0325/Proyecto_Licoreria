namespace licores
{
    partial class FormsCliente
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
            dgvTablaCliente = new DataGridView();
            groupBox1 = new GroupBox();
            txtId = new TextBox();
            lblId = new Label();
            btnEliminarClient = new Button();
            btnModificarClient = new Button();
            btnGuardarClient = new Button();
            txtTelefonoClient = new TextBox();
            txtCorreoClient = new TextBox();
            txtCedulaClient = new TextBox();
            txtApellidoClient = new TextBox();
            txtNombreClient = new TextBox();
            lblTelefClient = new Label();
            lblCorreoClient = new Label();
            lblCedulaClient = new Label();
            lblApellClient = new Label();
            lblNomClient = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnCargar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTablaCliente).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTablaCliente
            // 
            dgvTablaCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaCliente.Location = new Point(249, 85);
            dgvTablaCliente.Name = "dgvTablaCliente";
            dgvTablaCliente.Size = new Size(642, 345);
            dgvTablaCliente.TabIndex = 3;
            dgvTablaCliente.CellDoubleClick += dgvTablaCliente_CellDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(lblId);
            groupBox1.Controls.Add(btnEliminarClient);
            groupBox1.Controls.Add(btnModificarClient);
            groupBox1.Controls.Add(btnGuardarClient);
            groupBox1.Controls.Add(txtTelefonoClient);
            groupBox1.Controls.Add(txtCorreoClient);
            groupBox1.Controls.Add(txtCedulaClient);
            groupBox1.Controls.Add(txtApellidoClient);
            groupBox1.Controls.Add(txtNombreClient);
            groupBox1.Controls.Add(lblTelefClient);
            groupBox1.Controls.Add(lblCorreoClient);
            groupBox1.Controls.Add(lblCedulaClient);
            groupBox1.Controls.Add(lblApellClient);
            groupBox1.Controls.Add(lblNomClient);
            groupBox1.Location = new Point(23, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 361);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Cliente";
            // 
            // txtId
            // 
            txtId.Location = new Point(77, 26);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(134, 23);
            txtId.TabIndex = 14;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(12, 34);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 13;
            lblId.Text = "Id:";
            // 
            // btnEliminarClient
            // 
            btnEliminarClient.Location = new Point(119, 297);
            btnEliminarClient.Name = "btnEliminarClient";
            btnEliminarClient.Size = new Size(95, 32);
            btnEliminarClient.TabIndex = 12;
            btnEliminarClient.Text = "Eliminar";
            btnEliminarClient.UseVisualStyleBackColor = true;
            btnEliminarClient.Click += btnEliminarClient_Click;
            // 
            // btnModificarClient
            // 
            btnModificarClient.Location = new Point(12, 297);
            btnModificarClient.Name = "btnModificarClient";
            btnModificarClient.Size = new Size(101, 32);
            btnModificarClient.TabIndex = 11;
            btnModificarClient.Text = "Modificar";
            btnModificarClient.UseVisualStyleBackColor = true;
            btnModificarClient.Click += btnModificarClient_Click;
            // 
            // btnGuardarClient
            // 
            btnGuardarClient.Location = new Point(12, 258);
            btnGuardarClient.Name = "btnGuardarClient";
            btnGuardarClient.Size = new Size(202, 33);
            btnGuardarClient.TabIndex = 10;
            btnGuardarClient.Text = "Guardar";
            btnGuardarClient.UseVisualStyleBackColor = true;
            btnGuardarClient.Click += btnGuardarClient_Click;
            // 
            // txtTelefonoClient
            // 
            txtTelefonoClient.Location = new Point(77, 218);
            txtTelefonoClient.Name = "txtTelefonoClient";
            txtTelefonoClient.Size = new Size(134, 23);
            txtTelefonoClient.TabIndex = 9;
            // 
            // txtCorreoClient
            // 
            txtCorreoClient.Location = new Point(77, 180);
            txtCorreoClient.Name = "txtCorreoClient";
            txtCorreoClient.Size = new Size(134, 23);
            txtCorreoClient.TabIndex = 8;
            // 
            // txtCedulaClient
            // 
            txtCedulaClient.Location = new Point(77, 138);
            txtCedulaClient.Name = "txtCedulaClient";
            txtCedulaClient.Size = new Size(134, 23);
            txtCedulaClient.TabIndex = 7;
            // 
            // txtApellidoClient
            // 
            txtApellidoClient.Location = new Point(77, 100);
            txtApellidoClient.Name = "txtApellidoClient";
            txtApellidoClient.Size = new Size(134, 23);
            txtApellidoClient.TabIndex = 6;
            // 
            // txtNombreClient
            // 
            txtNombreClient.Location = new Point(77, 62);
            txtNombreClient.Name = "txtNombreClient";
            txtNombreClient.Size = new Size(134, 23);
            txtNombreClient.TabIndex = 5;
            // 
            // lblTelefClient
            // 
            lblTelefClient.AutoSize = true;
            lblTelefClient.Location = new Point(12, 226);
            lblTelefClient.Name = "lblTelefClient";
            lblTelefClient.Size = new Size(55, 15);
            lblTelefClient.TabIndex = 4;
            lblTelefClient.Text = "Telefono:";
            // 
            // lblCorreoClient
            // 
            lblCorreoClient.AutoSize = true;
            lblCorreoClient.Location = new Point(12, 188);
            lblCorreoClient.Name = "lblCorreoClient";
            lblCorreoClient.Size = new Size(46, 15);
            lblCorreoClient.TabIndex = 3;
            lblCorreoClient.Text = "Correo:";
            // 
            // lblCedulaClient
            // 
            lblCedulaClient.AutoSize = true;
            lblCedulaClient.Location = new Point(12, 146);
            lblCedulaClient.Name = "lblCedulaClient";
            lblCedulaClient.Size = new Size(47, 15);
            lblCedulaClient.TabIndex = 2;
            lblCedulaClient.Text = "Cedula:";
            // 
            // lblApellClient
            // 
            lblApellClient.AutoSize = true;
            lblApellClient.Location = new Point(12, 108);
            lblApellClient.Name = "lblApellClient";
            lblApellClient.Size = new Size(59, 15);
            lblApellClient.TabIndex = 1;
            lblApellClient.Text = "Apellidos:";
            // 
            // lblNomClient
            // 
            lblNomClient.AutoSize = true;
            lblNomClient.Location = new Point(12, 70);
            lblNomClient.Name = "lblNomClient";
            lblNomClient.Size = new Size(59, 15);
            lblNomClient.TabIndex = 0;
            lblNomClient.Text = "Nombres:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(249, 56);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar cliente por cédula";
            txtBuscar.Size = new Size(555, 23);
            txtBuscar.TabIndex = 4;
            // 
            // btnBuscar
            // 
            btnBuscar.Image = Properties.Resources.lupa;
            btnBuscar.Location = new Point(808, 56);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(27, 23);
            btnBuscar.TabIndex = 5;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCargar
            // 
            btnCargar.Image = Properties.Resources.actualizar;
            btnCargar.Location = new Point(841, 56);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(27, 23);
            btnCargar.TabIndex = 6;
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // FormsCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 522);
            Controls.Add(btnCargar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(dgvTablaCliente);
            Controls.Add(groupBox1);
            Name = "FormsCliente";
            Text = "        ";
            ((System.ComponentModel.ISupportInitialize)dgvTablaCliente).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTablaCliente;
        private GroupBox groupBox1;
        private Button btnEliminarClient;
        private Button btnModificarClient;
        private Button btnGuardarClient;
        private TextBox txtTelefonoClient;
        private TextBox txtCorreoClient;
        private TextBox txtCedulaClient;
        private TextBox txtApellidoClient;
        private TextBox txtNombreClient;
        private Label lblTelefClient;
        private Label lblCorreoClient;
        private Label lblCedulaClient;
        private Label lblApellClient;
        private Label lblNomClient;
        private TextBox txtId;
        private Label lblId;
        private TextBox txtBuscar;
        private Button button1;
        private Button btnBuscar;
        private Button button2;
        private Button btnCargar;
    }
}