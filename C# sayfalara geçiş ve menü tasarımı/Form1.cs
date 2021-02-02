using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace müzik2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomizeDesing();
        }
        private void CustomizeDesing()
        {
            panelMediaSubmenu.Visible = false;
            panelPlaylistMenu.Visible = false;
            panelToolsSbuMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelMediaSubmenu.Visible == true)
                panelMediaSubmenu.Visible = false;
            if (panelPlaylistMenu.Visible == true)
                panelPlaylistMenu.Visible = false;
            if (panelToolsSbuMenu.Visible == true)
                panelToolsSbuMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubmenu);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            hideSubMenu();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistMenu);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            hideSubMenu();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSbuMenu);
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }

}
