using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaHPMiAlegria
{
    public partial class FormChangePassword : Form
    {
        public FormChangePassword()
        {
            InitializeComponent();
        }

        public int Id { get; set; }
        public string Password { get; set; }
        private bool exist = false;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Global.close = true;
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text)){
                MessageBox.Show("Ingrese una contraseña", "Inicio Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Id = int.Parse(txtUser.Text);
            }
            catch (Exception) { }
            checkIsUser();
            if (exist)
            {
                Password = encryptPass();
                this.Close();
            }
            else
            {
                MessageBox.Show("ID inválido", "Inicio Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string encryptPass()
        {
            string encrypted = Convert.ToBase64String(Encoding.UTF8.GetBytes(txtPassword.Text));
            return encrypted;
        }

        private void checkIsUser()
        {
            string select = "SELECT (id) FROM usuarios";
            SqlCommand cmd = new SqlCommand(select, Global.conexion);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if(Id == reader.GetInt32(0))
                {
                    exist = true;
                    reader.Close();
                    return;
                }
            }
            reader.Close();
        }
    }
}
