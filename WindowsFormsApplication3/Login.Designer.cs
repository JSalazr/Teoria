using MetroFramework;
using MetroFramework.Controls;
using System;
using System.ComponentModel;
namespace WindowsFormsApplication3
{
    partial class Login
    {
        public static string myConnectionString;

        public static string username;

        private IContainer components = null;

        private MetroTextBox name;

        private MetroTextBox pass;

        private MetroButton metroButton1;

        private MetroLabel metroLabel1;

        private MetroLabel metroLabel2;

        private void InitializeComponent()
        {
            this.name = new MetroFramework.Controls.MetroTextBox();
            this.pass = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // name
            // 
            // 
            // 
            // 
            this.name.CustomButton.Image = null;
            this.name.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.name.CustomButton.Name = "";
            this.name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.name.CustomButton.TabIndex = 1;
            this.name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.name.CustomButton.UseSelectable = true;
            this.name.CustomButton.Visible = false;
            this.name.Lines = new string[0];
            this.name.Location = new System.Drawing.Point(116, 70);
            this.name.MaxLength = 32767;
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.name.SelectedText = "";
            this.name.SelectionLength = 0;
            this.name.SelectionStart = 0;
            this.name.ShortcutsEnabled = true;
            this.name.Size = new System.Drawing.Size(121, 23);
            this.name.TabIndex = 0;
            this.name.UseSelectable = true;
            this.name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pass
            // 
            // 
            // 
            // 
            this.pass.CustomButton.Image = null;
            this.pass.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.pass.CustomButton.Name = "";
            this.pass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.pass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pass.CustomButton.TabIndex = 1;
            this.pass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pass.CustomButton.UseSelectable = true;
            this.pass.CustomButton.Visible = false;
            this.pass.Lines = new string[0];
            this.pass.Location = new System.Drawing.Point(116, 115);
            this.pass.MaxLength = 32767;
            this.pass.Name = "pass";
            this.pass.PasswordChar = '\0';
            this.pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pass.SelectedText = "";
            this.pass.SelectionLength = 0;
            this.pass.SelectionStart = 0;
            this.pass.ShortcutsEnabled = true;
            this.pass.Size = new System.Drawing.Size(121, 23);
            this.pass.TabIndex = 1;
            this.pass.UseSelectable = true;
            this.pass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(96, 190);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Login";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(33, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Username";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(33, 115);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Password";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // Login
            // 
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.name);
            this.Name = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}


