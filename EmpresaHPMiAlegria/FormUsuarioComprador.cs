using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaHPMiAlegria
{
    public partial class FormUsuarioComprador : Form
    {
        public FormUsuarioComprador()
        {
            InitializeComponent();
        }

        bool allGood = true, somethingSelected;
        int id, cantDis;
        string msj = "";

        private void FormUsuarioComprador_Load(object sender, EventArgs e)
        {
            fullListView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            checkEntries();
            string prod = txtProd.Text;
            if (allGood && !somethingSelected)
            {
                int cant = int.Parse(txtQuan.Text);
                string add = $"INSERT INTO productos(descripcion,cantidad) VALUES" +
                    $"('{prod}', {cant})";
                SqlCommand cmd = new SqlCommand(add, Global.conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto Agregado", "Comprador/a", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fullListView();
            }
            else if(allGood && somethingSelected)
            {
                int cant = int.Parse(txtQuan.Text);
                string update = $"UPDATE productos SET descripcion='{prod}', cantidad={cant+cantDis} WHERE id={id}";
                SqlCommand cmd = new SqlCommand(update, Global.conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto Actualizado", "Comprador/a", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnUnselect.PerformClick();
                fullListView();
            }
            else
            {
                allGood = true;
                MessageBox.Show(msj, "Comprador/a", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msj = "";
            }
        }

        private void btnGenerateCSV_Click(object sender, EventArgs e)
        {
            Global.GenerateCSV();
        }

        private void btnUnselect_Click(object sender, EventArgs e)
        {
            id = 0;
            txtProd.Text = txtQuan.Text = "";
            somethingSelected = btnUnselect.Enabled = false;
            lblShowCant.Visible = false;
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            somethingSelected = btnUnselect.Enabled = true;
            lblShowCant.Visible = true;
            txtQuan.Text = "0";
            int index = listView1.FocusedItem.Index;
            (txtProd.Text, id, cantDis) = Global.item(index);
            lblShowCant.Text = "Cantidad disponible: " + cantDis;
        }

        private void checkEntries()
        {
            if(string.IsNullOrEmpty(txtProd.Text) || string.IsNullOrEmpty(txtQuan.Text))
            {
                msj += "Completa los campos\n";
                allGood = false;
            }
            try
            {
                int.Parse(txtQuan.Text);
                if(int.Parse(txtQuan.Text) < 0)
                {
                    msj += "Ingresa un número positivo";
                    allGood = false;
                }
            }
            catch (Exception ex)
            {
                msj += ex.Message;
                allGood = false;
            }
        }

        private void fullListView()
        {
            listView1.Items.Clear();
            string getProd = "SELECT (descripcion) FROM productos";
            SqlCommand cmd = new SqlCommand(getProd, Global.conexion);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string nombre = reader.GetString(0);
                listView1.Items.Add(nombre);
            }
            reader.Close();
        }
    }
}
