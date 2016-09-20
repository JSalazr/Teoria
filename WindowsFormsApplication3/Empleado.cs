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
    public partial class Empleado : Form
    {

        public Empleado()
        {
            this.InitializeComponent();
            this.read();
        }

        private void read()
        {
            this.dt = new System.Data.DataTable();
            IngresConnection con = new IngresConnection(Login.myConnectionString);
            string query = "select * from read_empleados";
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
            cmd.CommandText = "empleado_create";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new IngresParameter("t_id_empleado", IngresType.Decimal));
            cmd.Parameters.Add(new IngresParameter("t_primer_nombre", IngresType.VarChar));
            cmd.Parameters.Add(new IngresParameter("t_segundo_nombre", IngresType.VarChar));
            cmd.Parameters.Add(new IngresParameter("t_primer_apellido", IngresType.VarChar));
            cmd.Parameters.Add(new IngresParameter("t_segundo_apellido", IngresType.VarChar));
            cmd.Parameters.Add(new IngresParameter("t_calle", IngresType.VarChar));
            cmd.Parameters.Add(new IngresParameter("t_avenida", IngresType.VarChar));
            cmd.Parameters.Add(new IngresParameter("t_num_casa", IngresType.VarChar));
            cmd.Parameters.Add(new IngresParameter("t_ciudad", IngresType.VarChar));
            cmd.Parameters.Add(new IngresParameter("t_departamento", IngresType.VarChar));
            cmd.Parameters.Add(new IngresParameter("t_referencia", IngresType.VarChar));
            cmd.Parameters.Add(new IngresParameter("t_correo_primario", IngresType.VarChar));
            cmd.Parameters.Add(new IngresParameter("t_correo_secundario", IngresType.VarChar));
            cmd.Parameters.Add(new IngresParameter("t_fecha_nacimiento", IngresType.Date));
            cmd.Parameters.Add(new IngresParameter("t_fecha_inicio", IngresType.Date));
            cmd.Parameters["t_id_empleado"].Value = 0;
            cmd.Parameters["t_primer_nombre"].Value = this.prinom.Text;
            cmd.Parameters["t_segundo_nombre"].Value = this.senom.Text;
            cmd.Parameters["t_primer_apellido"].Value = this.priape.Text;
            cmd.Parameters["t_segundo_apellido"].Value = this.seape.Text;
            cmd.Parameters["t_calle"].Value = this.ca.Text;
            cmd.Parameters["t_avenida"].Value = this.avenida.Text;
            cmd.Parameters["t_num_casa"].Value = this.numcasa.Text;
            cmd.Parameters["t_ciudad"].Value = this.ciudad.Text;
            cmd.Parameters["t_departamento"].Value = this.departamento.Text;
            cmd.Parameters["t_referencia"].Value = this.referencia.Text;
            cmd.Parameters["t_correo_primario"].Value = this.pricorreo.Text;
            cmd.Parameters["t_correo_secundario"].Value = this.secorreo.Text;
            cmd.Parameters["t_fecha_nacimiento"].Value = this.metroDateTime1.Value.ToString("yyyy-MM-dd");
            cmd.Parameters["t_fecha_inicio"].Value = this.metroDateTime2.Value.ToString("yyyy-MM-dd");
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
            cmd.CommandText = "empleado_update";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new IngresParameter("t_id_empleado", IngresType.Decimal));
            cmd.Parameters.Add(new IngresParameter("t_primer_nombre", IngresType.VarChar));
            cmd.Parameters.Add(new IngresParameter("t_segundo_nombre", IngresType.VarChar));
            cmd.Parameters.Add(new IngresParameter("t_primer_apellido", IngresType.VarChar));
            cmd.Parameters.Add(new IngresParameter("t_segundo_apellido", IngresType.VarChar));
            cmd.Parameters.Add(new IngresParameter("t_calle", IngresType.VarChar));
            cmd.Parameters.Add(new IngresParameter("t_avenida", IngresType.VarChar));
            cmd.Parameters.Add(new IngresParameter("t_num_casa", IngresType.VarChar));
            cmd.Parameters.Add(new IngresParameter("t_ciudad", IngresType.VarChar));
            cmd.Parameters.Add(new IngresParameter("t_departamento", IngresType.VarChar));
            cmd.Parameters.Add(new IngresParameter("t_referencia", IngresType.VarChar));
            cmd.Parameters.Add(new IngresParameter("t_correo_primario", IngresType.VarChar));
            cmd.Parameters.Add(new IngresParameter("t_correo_secundario", IngresType.VarChar));
            cmd.Parameters.Add(new IngresParameter("t_fecha_nacimiento", IngresType.Date));
            cmd.Parameters.Add(new IngresParameter("t_fecha_inicio", IngresType.Date));
            cmd.Parameters["t_id_empleado"].Value = int.Parse(this.id.Text);
            cmd.Parameters["t_primer_nombre"].Value = this.prinom.Text;
            cmd.Parameters["t_segundo_nombre"].Value = this.senom.Text;
            cmd.Parameters["t_primer_apellido"].Value = this.priape.Text;
            cmd.Parameters["t_segundo_apellido"].Value = this.seape.Text;
            cmd.Parameters["t_calle"].Value = this.ca.Text;
            cmd.Parameters["t_avenida"].Value = this.avenida.Text;
            cmd.Parameters["t_num_casa"].Value = this.numcasa.Text;
            cmd.Parameters["t_ciudad"].Value = this.ciudad.Text;
            cmd.Parameters["t_departamento"].Value = this.departamento.Text;
            cmd.Parameters["t_referencia"].Value = this.referencia.Text;
            cmd.Parameters["t_correo_primario"].Value = this.pricorreo.Text;
            cmd.Parameters["t_correo_secundario"].Value = this.secorreo.Text;
            cmd.Parameters["t_fecha_nacimiento"].Value = this.metroDateTime1.Value.ToString("yyyy-MM-dd");
            cmd.Parameters["t_fecha_inicio"].Value = this.metroDateTime2.Value.ToString("yyyy-MM-dd");
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
            cmd.CommandText = "empleado_delete";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new IngresParameter("t_codigo_empleado", IngresType.Decimal));
            cmd.Parameters["t_codigo_empleado"].Value = int.Parse(this.id.Text);
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

        private void metroLabel1_Click(object sender, EventArgs e)
        {
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
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
