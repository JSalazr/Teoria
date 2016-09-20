using MetroFramework;
using MetroFramework.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication3.Properties;

namespace WindowsFormsApplication3
{
    partial class Menu
    {
        private IContainer components = null;

        private MetroTile metroTile1;

        private MetroTile metroTile2;

        private MetroTile metroTile3;

        private MetroTile metroTile4;

        private MetroTile metroTile5;

        private MetroTile metroTile6;

        private MetroTile metroTile7;

        private MetroTile metroTile8;

        private MetroTile metroTile9;

        private MetroTile metroTile10;

        private MetroTile metroTile11;

        private MetroTile metroTile12;

        private MetroTile metroTile13;

        private MetroTile metroTile14;

        private MetroTile metroTile15;

        private MetroTile metroTile19;

        private MetroTile metroTile25;

        private MetroLabel metroLabel1;

        private MetroLabel metroLabel2;

        private MetroLabel metroLabel3;

        private MetroLabel metroLabel4;

        private void InitializeComponent()
        {
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.metroTile8 = new MetroFramework.Controls.MetroTile();
            this.metroTile9 = new MetroFramework.Controls.MetroTile();
            this.metroTile10 = new MetroFramework.Controls.MetroTile();
            this.metroTile11 = new MetroFramework.Controls.MetroTile();
            this.metroTile12 = new MetroFramework.Controls.MetroTile();
            this.metroTile13 = new MetroFramework.Controls.MetroTile();
            this.metroTile14 = new MetroFramework.Controls.MetroTile();
            this.metroTile15 = new MetroFramework.Controls.MetroTile();
            this.metroTile19 = new MetroFramework.Controls.MetroTile();
            this.metroTile25 = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.logout = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(199, 179);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(88, 83);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Abonos";
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile1.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(25, 179);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(168, 83);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "Cuentas";
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(25, 91);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(262, 82);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "Empleado Afiliado";
            this.metroTile3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(25, 268);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(88, 83);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroTile4.TabIndex = 3;
            this.metroTile4.Text = "Pagos";
            this.metroTile4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile4.UseSelectable = true;
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(325, 91);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(128, 82);
            this.metroTile5.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile5.TabIndex = 4;
            this.metroTile5.Text = "Per. Emp. Pres.";
            this.metroTile5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile5.UseSelectable = true;
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Location = new System.Drawing.Point(25, 357);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(262, 83);
            this.metroTile6.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile6.TabIndex = 9;
            this.metroTile6.Text = "Persona Externa";
            this.metroTile6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile6.UseSelectable = true;
            // 
            // metroTile7
            // 
            this.metroTile7.ActiveControl = null;
            this.metroTile7.Location = new System.Drawing.Point(325, 268);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(128, 83);
            this.metroTile7.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroTile7.TabIndex = 8;
            this.metroTile7.Text = "Rol Privilegio";
            this.metroTile7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile7.UseSelectable = true;
            // 
            // metroTile8
            // 
            this.metroTile8.ActiveControl = null;
            this.metroTile8.Location = new System.Drawing.Point(795, 91);
            this.metroTile8.Name = "metroTile8";
            this.metroTile8.Size = new System.Drawing.Size(87, 82);
            this.metroTile8.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile8.TabIndex = 7;
            this.metroTile8.Text = "Privilegios";
            this.metroTile8.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile8.UseSelectable = true;
            // 
            // metroTile9
            // 
            this.metroTile9.ActiveControl = null;
            this.metroTile9.Location = new System.Drawing.Point(119, 268);
            this.metroTile9.Name = "metroTile9";
            this.metroTile9.Size = new System.Drawing.Size(168, 83);
            this.metroTile9.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile9.TabIndex = 6;
            this.metroTile9.Text = "Prestamos";
            this.metroTile9.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile9.UseSelectable = true;
            // 
            // metroTile10
            // 
            this.metroTile10.ActiveControl = null;
            this.metroTile10.Location = new System.Drawing.Point(459, 91);
            this.metroTile10.Name = "metroTile10";
            this.metroTile10.Size = new System.Drawing.Size(128, 82);
            this.metroTile10.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile10.TabIndex = 5;
            this.metroTile10.Text = "Pres. Empleado";
            this.metroTile10.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile10.UseSelectable = true;
            // 
            // metroTile11
            // 
            this.metroTile11.ActiveControl = null;
            this.metroTile11.Location = new System.Drawing.Point(620, 302);
            this.metroTile11.Name = "metroTile11";
            this.metroTile11.Size = new System.Drawing.Size(128, 82);
            this.metroTile11.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile11.TabIndex = 14;
            this.metroTile11.Text = "Reporte Anual";
            this.metroTile11.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile11.UseSelectable = true;
            // 
            // metroTile12
            // 
            this.metroTile12.ActiveControl = null;
            this.metroTile12.Location = new System.Drawing.Point(620, 91);
            this.metroTile12.Name = "metroTile12";
            this.metroTile12.Size = new System.Drawing.Size(169, 82);
            this.metroTile12.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroTile12.TabIndex = 13;
            this.metroTile12.Text = "Usuarios";
            this.metroTile12.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile12.UseSelectable = true;
            // 
            // metroTile13
            // 
            this.metroTile13.ActiveControl = null;
            this.metroTile13.Location = new System.Drawing.Point(325, 179);
            this.metroTile13.Name = "metroTile13";
            this.metroTile13.Size = new System.Drawing.Size(128, 83);
            this.metroTile13.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile13.TabIndex = 12;
            this.metroTile13.Text = "Tel. Personas";
            this.metroTile13.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile13.UseSelectable = true;
            // 
            // metroTile14
            // 
            this.metroTile14.ActiveControl = null;
            this.metroTile14.Location = new System.Drawing.Point(459, 179);
            this.metroTile14.Name = "metroTile14";
            this.metroTile14.Size = new System.Drawing.Size(128, 83);
            this.metroTile14.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile14.TabIndex = 11;
            this.metroTile14.Text = "Tel. Empleados";
            this.metroTile14.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile14.UseSelectable = true;
            // 
            // metroTile15
            // 
            this.metroTile15.ActiveControl = null;
            this.metroTile15.Location = new System.Drawing.Point(459, 268);
            this.metroTile15.Name = "metroTile15";
            this.metroTile15.Size = new System.Drawing.Size(128, 83);
            this.metroTile15.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile15.TabIndex = 10;
            this.metroTile15.Text = "Rol Usuario";
            this.metroTile15.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile15.UseSelectable = true;
            // 
            // metroTile19
            // 
            this.metroTile19.ActiveControl = null;
            this.metroTile19.Location = new System.Drawing.Point(754, 302);
            this.metroTile19.Name = "metroTile19";
            this.metroTile19.Size = new System.Drawing.Size(128, 82);
            this.metroTile19.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile19.TabIndex = 16;
            this.metroTile19.Text = "Reporte Mensual";
            this.metroTile19.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile19.UseSelectable = true;
            // 
            // metroTile25
            // 
            this.metroTile25.ActiveControl = null;
            this.metroTile25.Location = new System.Drawing.Point(620, 179);
            this.metroTile25.Name = "metroTile25";
            this.metroTile25.Size = new System.Drawing.Size(87, 83);
            this.metroTile25.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile25.TabIndex = 20;
            this.metroTile25.Text = "Roles";
            this.metroTile25.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile25.UseSelectable = true;
            this.metroTile25.Click += new System.EventHandler(this.metroTile25_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(25, 47);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel1.TabIndex = 21;
            this.metroLabel1.Text = "Datos";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(325, 47);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(72, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "Relaciones";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(620, 269);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel3.TabIndex = 23;
            this.metroLabel3.Text = "Reportes";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(620, 47);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Seguridad";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseStyleColors = true;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(419, 393);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 25;
            this.logout.Text = "Cerrar Sesion";
            this.logout.UseSelectable = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(25, 9);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(57, 25);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "Menu";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseStyleColors = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(928, 465);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTile25);
            this.Controls.Add(this.metroTile19);
            this.Controls.Add(this.metroTile11);
            this.Controls.Add(this.metroTile12);
            this.Controls.Add(this.metroTile13);
            this.Controls.Add(this.metroTile14);
            this.Controls.Add(this.metroTile15);
            this.Controls.Add(this.metroTile6);
            this.Controls.Add(this.metroTile7);
            this.Controls.Add(this.metroTile8);
            this.Controls.Add(this.metroTile9);
            this.Controls.Add(this.metroTile10);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private MetroButton logout;
        private MetroLabel metroLabel5;

    }
}
