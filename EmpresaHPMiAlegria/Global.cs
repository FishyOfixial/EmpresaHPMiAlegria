using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaHPMiAlegria
{
    public static class Global
    {
        public static SqlConnection conexion;
        public static Usuario usuario;
        public static bool close;
        public static string name;

        public static void GenerateCSV()
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(@"C:\Users\ivanr\OneDrive\Escritorio\Preparatoria\Semestre 5\Tony\UsuarioComprasHP.csv");
                string ss = "SELECT * FROM productos";
                SqlCommand cmd = new SqlCommand(ss, conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string line = $"{reader.GetString(0)},{reader.GetInt32(1)},{reader.GetInt32(2)}";
                    streamWriter.WriteLine(line);
                }
                MessageBox.Show($"Archivo generado:\n{((FileStream)(streamWriter.BaseStream)).Name}", "Comprador/a", MessageBoxButtons.OK, MessageBoxIcon.Information);
                streamWriter.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Archivo CSV", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static (string,int,int) item(int index)
        {
            String prod = "";
            int id = 0, cantDis = 0;
            string select = $"SELECT TOP {index + 1} * FROM productos";
            SqlCommand cmd = new SqlCommand(select, Global.conexion);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                prod = reader.GetString(0);
                id = reader.GetInt32(1);
                cantDis = reader.GetInt32(2);
            }
            reader.Close();
            return (prod, id, cantDis);
        }
    }
}
