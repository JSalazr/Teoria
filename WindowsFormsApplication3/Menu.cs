using MetroFramework;
using MetroFramework.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication3.Properties;

namespace WindowsFormsApplication3
{
    public partial class Menu : Form
    {

        public Menu()
        {
            this.InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        private void metroTile25_Click(object sender, EventArgs e)
        {
            Rol rol = new Rol();
            rol.Show();
        }

        private void metroTile16_Click(object sender, EventArgs e)
        {
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Show();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

    }
}
