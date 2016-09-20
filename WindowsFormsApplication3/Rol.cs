using Ingres.Client;
using MetroFramework;
using MetroFramework.Controls;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication3.proyectoDataSetTableAdapters;

namespace WindowsFormsApplication3
{
    public partial class Rol : Form
    {
        public Rol()
        {
            this.InitializeComponent();
            this.read();
        }

        private void read()
        {
            this.dt = new System.Data.DataTable();
            IngresConnection con = new IngresConnection(Login.myConnectionString);
            string query = "select * from read_rol";
            IngresCommand comm = new IngresCommand(query, con);
            con.Open();
            IngresDataAdapter adapt = new IngresDataAdapter(comm);
            adapt.Fill(this.dt);
            con.Close();
            this.metroGrid1.DataSource = this.dt;
            adapt.Dispose();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            IngresConnection con = new IngresConnection(Login.myConnectionString);
            con.Open();
            IngresCommand cmd = new IngresCommand();
            cmd.Connection = con;
            cmd.CommandText = "rol_create";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new IngresParameter("t_id_rol", IngresType.Decimal));
            cmd.Parameters.Add(new IngresParameter("t_nombre", IngresType.VarChar));
            cmd.Parameters["t_id_rol"].Value = 0;
            cmd.Parameters["t_nombre"].Value = this.nombre.Text;
            try
            {
                cmd.ExecuteNonQuery();
                MetroMessageBox.Show(this, "Elemento creado correctamente.", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (IngresException c)
            {
                MetroMessageBox.Show(this, c.ErrorCode + c.Message, "Error");
            }
            con.Close();
            this.read();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            IngresConnection con = new IngresConnection(Login.myConnectionString);
            con.Open();
            IngresCommand cmd = new IngresCommand();
            cmd.Connection = con;
            cmd.CommandText = "rol_update";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new IngresParameter("t_id_rol", IngresType.Decimal));
            cmd.Parameters.Add(new IngresParameter("t_nombre", IngresType.VarChar));
            cmd.Parameters["t_id_rol"].Value = int.Parse(this.metroTextBox1.Text);
            cmd.Parameters["t_nombre"].Value = this.nombre.Text;
            try
            {
                cmd.ExecuteNonQuery();
                MetroMessageBox.Show(this, "Elemento actualizado correctamente.", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (IngresException c)
            {
                MetroMessageBox.Show(this, c.ErrorCode + c.Message, "Error");
            }
            con.Close();
            this.read();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            IngresConnection con = new IngresConnection(Login.myConnectionString);
            con.Open();
            IngresCommand cmd = new IngresCommand();
            cmd.Connection = con;
            cmd.CommandText = "rol_delete";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new IngresParameter("t_id_rol", IngresType.Decimal));
            cmd.Parameters["t_id_rol"].Value = int.Parse(this.metroTextBox1.Text);
            IngresTransaction trans = con.BeginTransaction();
            cmd.Transaction = trans;
            try
            {
                cmd.ExecuteNonQuery();
                trans.Commit();
                MetroMessageBox.Show(this, "Elemento eliminado correctamente.", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (IngresException c)
            {
                MetroMessageBox.Show(this, c.ErrorCode + c.Message, "Error");
            }
            con.Close();
            this.read();
        }

        private void Rol_Load(object sender, EventArgs e)
        {
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
