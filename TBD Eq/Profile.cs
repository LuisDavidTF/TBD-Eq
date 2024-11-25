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

namespace TBD_Eq
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            CargarPerfilUsuario(FormHub.idUser, lblFirstName, lblIDUser, dataGridView1);
        }
        private void CargarPerfilUsuario(int usuarioID, Label lblNombre, Label lblID, DataGridView dgvCompras)
        {
            using (SqlConnection con = new SqlConnection("Data Source = localhost; Integrated Security = SSPI; Initial Catalog = Velonia"))
            {
                SqlCommand cmd = new SqlCommand("ObtenerPerfilUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblID.Text = "ID: " + reader["UsuarioID"].ToString();
                        lblNombre.Text = "Usuario: " + reader["NombreUsuario"].ToString();
                    }

                    if (reader.NextResult())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dgvCompras.DataSource = dt;
                    }
                }
            }
        }

    }
}
