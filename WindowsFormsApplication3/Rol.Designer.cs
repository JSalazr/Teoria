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
    partial class Rol
    {
        private System.Data.DataTable dt;

        private System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();

        private IContainer components = null;

        private MetroTextBox metroTextBox1;

        private MetroTextBox nombre;

        private MetroButton Create;

        private new MetroButton Update;

        private MetroButton Delete;

        private MetroLabel metroLabel1;

        private MetroLabel metroLabel2;

        private proyectoDataSet proyectoDataSet;

        private System.Windows.Forms.BindingSource readrolBindingSource;

        private read_rolTableAdapter read_rolTableAdapter;

        private MetroGrid metroGrid1;

        private MetroLabel metroLabel12;

        private void InitializeComponent()
        {
            this.components = new Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTextBox1 = new MetroTextBox();
            this.nombre = new MetroTextBox();
            this.Create = new MetroButton();
            this.Update = new MetroButton();
            this.Delete = new MetroButton();
            this.metroLabel1 = new MetroLabel();
            this.metroLabel2 = new MetroLabel();
            this.readrolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet = new proyectoDataSet();
            this.read_rolTableAdapter = new read_rolTableAdapter();
            this.metroGrid1 = new MetroGrid();
            this.metroLabel12 = new MetroLabel();
            ((ISupportInitialize)this.readrolBindingSource).BeginInit();
            ((ISupportInitialize)this.proyectoDataSet).BeginInit();
            ((ISupportInitialize)this.metroGrid1).BeginInit();
            base.SuspendLayout();
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(341, 59);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(131, 23);
            this.metroTextBox1.Style = MetroColorStyle.Blue;
            this.metroTextBox1.TabIndex = 8;
            this.metroTextBox1.Theme = MetroThemeStyle.Light;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(109, 109, 109);
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.nombre.CustomButton.Image = null;
            this.nombre.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.nombre.CustomButton.Name = "";
            this.nombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nombre.CustomButton.Style = MetroColorStyle.Blue;
            this.nombre.CustomButton.TabIndex = 1;
            this.nombre.CustomButton.Theme = MetroThemeStyle.Light;
            this.nombre.CustomButton.UseSelectable = true;
            this.nombre.CustomButton.Visible = false;
            this.nombre.Lines = new string[0];
            this.nombre.Location = new System.Drawing.Point(341, 99);
            this.nombre.MaxLength = 32767;
            this.nombre.Name = "nombre";
            this.nombre.PasswordChar = '\0';
            this.nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nombre.SelectedText = "";
            this.nombre.SelectionLength = 0;
            this.nombre.SelectionStart = 0;
            this.nombre.ShortcutsEnabled = true;
            this.nombre.Size = new System.Drawing.Size(131, 23);
            this.nombre.Style = MetroColorStyle.Blue;
            this.nombre.TabIndex = 9;
            this.nombre.Theme = MetroThemeStyle.Light;
            this.nombre.UseSelectable = true;
            this.nombre.WaterMarkColor = System.Drawing.Color.FromArgb(109, 109, 109);
            this.nombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Create.Location = new System.Drawing.Point(250, 155);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.Style = MetroColorStyle.Blue;
            this.Create.TabIndex = 10;
            this.Create.Text = "Create";
            this.Create.Theme = MetroThemeStyle.Light;
            this.Create.UseSelectable = true;
            this.Create.Click += new EventHandler(this.metroButton1_Click);
            this.Update.Location = new System.Drawing.Point(369, 155);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.Style = MetroColorStyle.Blue;
            this.Update.TabIndex = 11;
            this.Update.Text = "Update";
            this.Update.Theme = MetroThemeStyle.Light;
            this.Update.UseSelectable = true;
            this.Update.Click += new EventHandler(this.Update_Click);
            this.Delete.Location = new System.Drawing.Point(490, 155);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.Style = MetroColorStyle.Orange;
            this.Delete.TabIndex = 12;
            this.Delete.Text = "Delete";
            this.Delete.Theme = MetroThemeStyle.Light;
            this.Delete.UseSelectable = true;
            this.Delete.Click += new EventHandler(this.Delete_Click);
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Teal;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(292, 59);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.Style = MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Id Rol";
            this.metroLabel1.Theme = MetroThemeStyle.Light;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Teal;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(276, 99);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.Style = MetroColorStyle.Teal;
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Nombre";
            this.metroLabel2.Theme = MetroThemeStyle.Light;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.readrolBindingSource.DataMember = "read_rol";
            this.readrolBindingSource.DataSource = this.proyectoDataSet;
            this.proyectoDataSet.DataSetName = "proyectoDataSet";
            this.proyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.read_rolTableAdapter.ClearBeforeFill = true;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 170, 173);
            dataGridViewCellStyle.Font = new System.Drawing.Font("Segoe UI", 11f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 201, 206);
            dataGridViewCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(0, 201, 206);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.metroGrid1.Location = new System.Drawing.Point(42, 205);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(0, 170, 173);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(0, 201, 206);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(712, 232);
            this.metroGrid1.Style = MetroColorStyle.Teal;
            this.metroGrid1.TabIndex = 15;
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.Teal;
            this.metroLabel12.FontSize = MetroLabelSize.Tall;
            this.metroLabel12.FontWeight = MetroLabelWeight.Regular;
            this.metroLabel12.ForeColor = System.Drawing.Color.White;
            this.metroLabel12.Location = new System.Drawing.Point(42, 9);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(55, 25);
            this.metroLabel12.Style = MetroColorStyle.Blue;
            this.metroLabel12.TabIndex = 49;
            this.metroLabel12.Text = "Roles";
            this.metroLabel12.Theme = MetroThemeStyle.Light;
            this.metroLabel12.UseCustomBackColor = true;
            this.metroLabel12.UseCustomForeColor = true;
            base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            base.ClientSize = new System.Drawing.Size(798, 449);
            base.Controls.Add(this.metroLabel12);
            base.Controls.Add(this.metroGrid1);
            base.Controls.Add(this.metroLabel2);
            base.Controls.Add(this.metroLabel1);
            base.Controls.Add(this.Delete);
            base.Controls.Add(this.Update);
            base.Controls.Add(this.Create);
            base.Controls.Add(this.nombre);
            base.Controls.Add(this.metroTextBox1);
            this.ForeColor = System.Drawing.Color.Black;
            base.Name = "Rol";
            this.Text = "Form1";
            base.Load += new EventHandler(this.Rol_Load);
            ((ISupportInitialize)this.readrolBindingSource).EndInit();
            ((ISupportInitialize)this.proyectoDataSet).EndInit();
            ((ISupportInitialize)this.metroGrid1).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}