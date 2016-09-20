using Ingres.Client;
using MetroFramework;
using MetroFramework.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Login : Form
    {
        public Login()
        {
            this.InitializeComponent();
            this.pass.UseSystemPasswordChar = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            Login.username = this.name.Text;
            string password = this.pass.Text;
            Login.myConnectionString = "host=(local);port=II7;database=proyecto;dbms_user=" + Login.username + ";dbms_password=" + password;
            IngresConnection conn = new IngresConnection(Login.myConnectionString);
            try
            {
                conn.Open();
                conn.Close();
                Menu menu = new Menu();
                this.Hide();
                menu.Show();
            }
            catch (Exception a_68)
            {
                System.Windows.Forms.MessageBox.Show("Error al conectarse");
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
