using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos_Numericos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private void hideSubMenu() 
        {
            panelUnidades.Visible = false;
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

        private void btnTemas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelUnidades);
        }

        private void btnBiseccion_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            hideSubMenu();
        }

        private void btnSimpson_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSimpson());
            hideSubMenu();
        }

        private void btnEuler_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            hideSubMenu();
        }
        private Form activeForm = null;
        private void openChildForm(Form hijo) 
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = hijo;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            panelFormHijo.Controls.Add(hijo);
            panelFormHijo.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
        }
    }
}
