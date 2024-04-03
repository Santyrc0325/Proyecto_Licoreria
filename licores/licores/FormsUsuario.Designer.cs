namespace licores
{
    partial class FormsUsuario
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
            dgvTablaUsers = new DataGridView();
            groupBox1 = new GroupBox();
            label6 = new Label();
            txtidUser = new TextBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            txtTelefonoUser = new TextBox();
            txtCorreoUser = new TextBox();
            txtCedulaUser = new TextBox();
            txtApellidoUser = new TextBox();
            txtNombreUser = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnCargarUsuario = new Button();
            btnBuscarUsuario = new Button();
            txtBuscarUsuario = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTablaUsers).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTablaUsers
            // 
            dgvTablaUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTablaUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTablaUsers.BackgroundColor = Color.White;
            dgvTablaUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaUsers.Location = new Point(239, 60);
            dgvTablaUsers.Name = "dgvTablaUsers";
            dgvTablaUsers.Size = new Size(642, 338);
            dgvTablaUsers.TabIndex = 3;
            dgvTablaUsers.CellMouseClick += dgvTablaUsers_CellMouseClick;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtidUser);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(txtTelefonoUser);
            groupBox1.Controls.Add(txtCorreoUser);
            groupBox1.Controls.Add(txtCedulaUser);
            groupBox1.Controls.Add(txtApellidoUser);
            groupBox1.Controls.Add(txtNombreUser);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(221, 360);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Usuario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 30);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 14;
            label6.Text = "Id Usuario";
            label6.Click += label6_Click;
            // 
            // txtidUser
            // 
            txtidUser.Location = new Point(80, 22);
            txtidUser.Name = "txtidUser";
            txtidUser.ReadOnly = true;
            txtidUser.ShortcutsEnabled = false;
            txtidUser.Size = new Size(134, 23);
            txtidUser.TabIndex = 13;
            txtidUser.TextChanged += textBox1_TextChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(119, 297);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(95, 32);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(12, 297);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(101, 32);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Location = new Point(12, 258);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(202, 33);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // txtTelefonoUser
            // 
            txtTelefonoUser.Location = new Point(80, 211);
            txtTelefonoUser.Name = "txtTelefonoUser";
            txtTelefonoUser.Size = new Size(134, 23);
            txtTelefonoUser.TabIndex = 9;
            // 
            // txtCorreoUser
            // 
            txtCorreoUser.Location = new Point(80, 173);
            txtCorreoUser.Name = "txtCorreoUser";
            txtCorreoUser.Size = new Size(134, 23);
            txtCorreoUser.TabIndex = 8;
            // 
            // txtCedulaUser
            // 
            txtCedulaUser.Location = new Point(80, 131);
            txtCedulaUser.Name = "txtCedulaUser";
            txtCedulaUser.Size = new Size(134, 23);
            txtCedulaUser.TabIndex = 7;
            // 
            // txtApellidoUser
            // 
            txtApellidoUser.Location = new Point(80, 93);
            txtApellidoUser.Name = "txtApellidoUser";
            txtApellidoUser.Size = new Size(134, 23);
            txtApellidoUser.TabIndex = 6;
            // 
            // txtNombreUser
            // 
            txtNombreUser.Location = new Point(80, 55);
            txtNombreUser.Name = "txtNombreUser";
            txtNombreUser.Size = new Size(134, 23);
            txtNombreUser.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 219);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 4;
            label5.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 181);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 3;
            label4.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 139);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "Cedula:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 101);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellidos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 63);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombres:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(72, 21, 30);
            panel1.Controls.Add(btnCargarUsuario);
            panel1.Controls.Add(btnBuscarUsuario);
            panel1.Controls.Add(txtBuscarUsuario);
            panel1.Controls.Add(dgvTablaUsers);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(893, 481);
            panel1.TabIndex = 4;
            // 
            // btnCargarUsuario
            // 
            btnCargarUsuario.Image = Properties.Resources.actualizar;
            btnCargarUsuario.Location = new Point(239, 32);
            btnCargarUsuario.Name = "btnCargarUsuario";
            btnCargarUsuario.Size = new Size(27, 23);
            btnCargarUsuario.TabIndex = 14;
            btnCargarUsuario.UseVisualStyleBackColor = true;
            btnCargarUsuario.Click += btnCargarProductos_Click;
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.Image = Properties.Resources.lupa;
            btnBuscarUsuario.Location = new Point(272, 32);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(27, 23);
            btnBuscarUsuario.TabIndex = 13;
            btnBuscarUsuario.UseVisualStyleBackColor = true;
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarUsuario.Location = new Point(305, 31);
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.PlaceholderText = "Buscar usuario por cedula";
            txtBuscarUsuario.Size = new Size(576, 23);
            txtBuscarUsuario.TabIndex = 12;
            // 
            // FormsUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 481);
            Controls.Add(panel1);
            Name = "FormsUsuario";
            Text = "Form3";
            Load += FormsUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTablaUsers).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTablaUsers;
        private GroupBox groupBox1;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private TextBox txtTelefonoUser;
        private TextBox txtCorreoUser;
        private TextBox txtCedulaUser;
        private TextBox txtApellidoUser;
        private TextBox txtNombreUser;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private TextBox txtidUser;
        private Panel panel1;
        private Button btnCargarProducto;
        private Button btnBuscarProducto;
        private TextBox txtBuscarProducto;
        private Button btnCargarUsuario;
        private Button btnBuscarUsuario;
        private TextBox txtBuscarUsuario;
    }
}