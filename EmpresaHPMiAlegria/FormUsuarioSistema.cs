using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Diagnostics.Eventing.Reader;
using System.Data.SqlClient;

namespace EmpresaHPMiAlegria
{
    public partial class FormUsuarioSistema : Form
    {
        public FormUsuarioSistema()
        {
            InitializeComponent();
        }

        bool allGood = true;
        string msj = "";
        int isOp, isBuy, isSys, id;
        bool somethingSelected;

        private void FormUsuarioSistema_Load(object sender, EventArgs e)
        {
            fullListView();
            btnDelete.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            checkEntries();
            string user = txtUser.Text;
            string pass = encryptPass();
            isOp = (chkIsOp.Checked) ? 1 : 0;
            isBuy = (chkBuy.Checked) ? 1 : 0;
            isSys = (chkSystem.Checked) ? 1 : 0;

            if (allGood && !somethingSelected)
            {
                string insert = "INSERT INTO usuarios(nombre,pass,isOperator,isBuyer,isSystem) VALUES" +
                    $"('{user}', '{pass}', {isOp}, {isBuy}, {isSys})";
                SqlCommand cmd = new SqlCommand(insert, Global.conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario agregado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fullListView();
            }
            else if(allGood && somethingSelected)
            {
                string update = $"UPDATE usuarios SET nombre='{user}', pass='{pass}', isOperator={isOp}," +
                    $"isBuyer={isBuy}, isSystem={isSys} WHERE id={id}";
                SqlCommand cmd = new SqlCommand(update, Global.conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario actualizado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msj = "";
                allGood = true;
            }
            btnUnselect.PerformClick();
        }

        private string encryptPass()
        {
            string encrypted = Convert.ToBase64String(Encoding.UTF8.GetBytes(txtPassword.Text));
            return encrypted;
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            int index = listView1.FocusedItem.Index;
            string select = $"SELECT TOP {index+1} * FROM usuarios";
            SqlCommand cmd = new SqlCommand(@select, Global.conexion);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtUser.Text = reader.GetString(0);
                id = reader.GetInt32(1);
                txtPassword.Text = unencryptPass(reader.GetString(2));
                chkIsOp.Checked = (reader.GetInt32(3) == 1) ? true : false;
                chkBuy.Checked = (reader.GetInt32(4) == 1) ? true : false;
                chkSystem.Checked = (reader.GetInt32(5) == 1) ? true : false;
            }
            reader.Close();
            somethingSelected = btnDelete.Enabled = btnUnselect.Enabled = true;
        }

        private void checkEntries()
        {
            if(string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUser.Text))
            {
                allGood = false;
                msj += "Completa los campos\n";
            }
            if(chkIsOp.Checked == false && chkBuy.Checked == false && chkSystem.Checked == false && !somethingSelected)
            {
                allGood = false;
                msj += "Ingresa al menos un rol";
            }
        }

        private void btnUnselect_Click(object sender, EventArgs e)
        {
            id = 0;
            txtUser.Text = txtPassword.Text = "";
            chkIsOp.Checked = chkSystem.Checked = chkBuy.Checked = btnDelete.Enabled = false;
            somethingSelected = btnUnselect.Enabled = false;
        }

        private void btnSeePass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnSeePass_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea eliminar al usuario", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string del = $"DELETE FROM usuarios WHERE id={id}";
                SqlCommand cmd = new SqlCommand(del, Global.conexion);
                cmd.ExecuteNonQuery();
                fullListView();
                MessageBox.Show("Usuario eliminado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnUnselect.PerformClick();
        }

        private void fullListView()
        {
            listView1.Items.Clear();
            string getUsers = "SELECT (nombre) FROM usuarios";
            SqlCommand cmd = new SqlCommand(getUsers, Global.conexion);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string nombre = reader.GetString(0);
                listView1.Items.Add(nombre);
            }
            reader.Close();
        }

        private string unencryptPass(string pass)
        {

            byte[] bytes = Convert.FromBase64String(pass);
            string desencriptado = Encoding.UTF8.GetString(bytes);
            return desencriptado;
        }
    }
}
