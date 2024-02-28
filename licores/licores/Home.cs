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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panel1.Visible == true)
                panel1.Visible = false;

            if (panel2.Visible == true)
                panel2.Visible = false;
        }


        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        #region subMenus

        private void button1_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panel1);
        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormsUsuario());
            hideSubMenu();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormsCliente());
            hideSubMenu();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panel2);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm == null)
                activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForms.Controls.Add(childForm);
            panelChildForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }



    }


}
