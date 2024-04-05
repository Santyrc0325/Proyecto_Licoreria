using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using Label = System.Windows.Forms.Label;
using TextBox = System.Windows.Forms.TextBox;

namespace licores
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            txtUsuario = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            txtContra = new TextBox();
            label1 = new Label();
            button1 = new Button();
            lblError = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(72, 21, 30);
            pictureBox2.Image = Properties.Resources.logo_trial;
            pictureBox2.Location = new Point(31, 68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(197, 185);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(15, 15, 15);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 15F);
            txtUsuario.ForeColor = SystemColors.Window;
            txtUsuario.Location = new Point(342, 102);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Cedula";
            txtUsuario.Size = new Size(368, 27);
            txtUsuario.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Location = new Point(342, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(368, 3);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.Location = new Point(342, 188);
            panel3.Name = "panel3";
            panel3.Size = new Size(368, 3);
            panel3.TabIndex = 4;
            // 
            // txtContra
            // 
            txtContra.BackColor = Color.FromArgb(15, 15, 15);
            txtContra.BorderStyle = BorderStyle.None;
            txtContra.Font = new Font("Segoe UI", 15F);
            txtContra.ForeColor = SystemColors.Window;
            txtContra.Location = new Point(342, 161);
            txtContra.Name = "txtContra";
            txtContra.PasswordChar = '*';
            txtContra.PlaceholderText = "Contraseña";
            txtContra.Size = new Size(368, 27);
            txtContra.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(430, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 37);
            label1.TabIndex = 5;
            label1.Text = "INICIAR SESIÓN";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 40, 40);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.DimGray;
            button1.Location = new Point(342, 240);
            button1.Name = "button1";
            button1.Size = new Size(368, 28);
            button1.TabIndex = 7;
            button1.Text = "ACCEDER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.DarkGray;
            lblError.Image = Properties.Resources.cerrar__2_;
            lblError.ImageAlign = ContentAlignment.MiddleLeft;
            lblError.Location = new Point(342, 206);
            lblError.Name = "lblError";
            lblError.Size = new Size(116, 19);
            lblError.TabIndex = 8;
            lblError.Text = "Message Error";
            lblError.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 330);
            Controls.Add(lblError);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(txtContra);
            Controls.Add(panel2);
            Controls.Add(txtUsuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Opacity = 0.98D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private TextBox txtUsuario;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtContra;
        private PictureBox pictureBox2;
        private Label label1;
        private Button button1;
        private Label lblError;
    }
}
