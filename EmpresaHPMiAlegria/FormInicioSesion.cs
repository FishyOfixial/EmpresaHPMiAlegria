using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace EmpresaHPMiAlegria
{
    public partial class FormInicioSesion : Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void FormInicioSesion_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            checkIfIsUser();
            if (Global.usuario != null)
            {
                Console.WriteLine("Entro");
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormChangePassword form = new FormChangePassword();
            form.ShowDialog();
            if (!Global.close)
            {
                string password = form.Password;
                int id = form.Id;
                string update = $"UPDATE usuarios SET pass='{password}' WHERE id={id}";
                SqlCommand cmd = new SqlCommand(update, Global.conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Contraseña actualizada", "Inicio Sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Global.close = true;
            Application.Exit();
        }

        private void checkIfIsUser()
        {
            Global.name = txtUser.Text;
            string pass = txtPassword.Text;

            string select = "SELECT nombre,pass,isOperator,isBuyer,isSystem FROM usuarios";
            SqlCommand cmd = new SqlCommand(select, Global.conexion);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                if (Global.name.Equals(reader.GetString(0)) && pass.Equals(unencryptPass(reader.GetString(1)))){
                    Global.usuario = new Usuario(reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4));
                    reader.Close();
                    return;
                }
            }
            reader.Close();
        }

        private string unencryptPass(string pass)
        {

            byte[] bytes = Convert.FromBase64String(pass);
            string desencriptado = Encoding.UTF8.GetString(bytes);
            return desencriptado;
        }

        private void btnSeePass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnSeePass_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
