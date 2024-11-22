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
    public partial class FormControlesUsuario : Form
    {
        public FormControlesUsuario()
        {
            InitializeComponent();
        }

        private void FormControlesUsuario_Load(object sender, EventArgs e)
        {
            OpenConnection();
            btnChangeUser.PerformClick();
        }

        private void OpenConnection()
        {
            SqlConnectionStringBuilder con = new SqlConnectionStringBuilder();
            con.DataSource = "(local)\\SqlExpress";
            con.InitialCatalog = "EmpresaHPMiAlegria";
            con.IntegratedSecurity = true;
            Global.conexion = new SqlConnection(con.ConnectionString);
            Global.conexion.Open();
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            new FormUsuarioOperador().ShowDialog();
        }

        private void btnBuyer_Click(object sender, EventArgs e)
        {
            new FormUsuarioComprador().ShowDialog();
        }

        private void btnSystem_Click(object sender, EventArgs e)
        {
            new FormUsuarioSistema().ShowDialog();
        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            Global.usuario = null;
            new FormInicioSesion().ShowDialog();
            if (!Global.close){
                enableButtons();
            }
        }

        private void enableButtons()
        {
            label2.Text = "Usuario: " + Global.name;
            btnOperator.Enabled = btnBuyer.Enabled = btnSystem.Enabled = false;
            if (Global.usuario.IsOp == 1){ btnOperator.Enabled = true; }
            if(Global.usuario.IsBuy == 1){ btnBuyer.Enabled = true; }
            if(Global.usuario.IsSys == 1){ btnSystem.Enabled = true; }
        }
    }
}
