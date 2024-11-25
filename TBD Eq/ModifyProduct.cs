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

namespace TBD_Eq
{
    public partial class ModifyProduct : Form
    {
        private string connectionString = "Data Source=localhost;Integrated Security=SSPI;Initial Catalog=Velonia";

        private int IDProduct;
        List<PictureBox> colores = new List<PictureBox>();
        Button[] tallas = new Button[3];
        private List<byte[]> imagenesBytes = new List<byte[]>();
        public ModifyProduct()
        {
            InitializeComponent();
            colores.Add(pbFirstColor);
            colores.Add(pbSecondColor);
            colores.Add(pbThirdColor);
            tallas[0] = btnL;
            tallas[1] = btnM;
            tallas[2] = btnS;
            LlenarComboBox(comboBox1, "Select Nombre,ProductoID from Productos where UsuarioID =" + FormHub.idUser);
        }


        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            EliminarProducto(IDProduct);
        }
        private void EliminarProducto(int productoID)
        {
            using (SqlConnection con = new SqlConnection("Data Source = localhost; Integrated Security = SSPI; Initial Catalog = Velonia"))
            {
                SqlCommand cmd = new SqlCommand("EliminarProducto", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProductoID", productoID);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto eliminado correctamente.");
                this.Close();
                this.Dispose();
            }
        }

        public void LlenarComboBox(ComboBox comboBox, string query)
        {
            try
            {
                // Conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader["Nombre"].ToString());

                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al llenar el ComboBox: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("Select ProductoID from Productos where Nombre='"+comboBox1.SelectedItem.ToString()+"'", connection);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                            IDProduct = Int16.Parse(reader["ProductoID"].ToString());
                        
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar Producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarDetalleProducto(IDProduct, txtName, txtPrice, rtxtDescripcion, pbCarousel, colores, tallas);
        }

        private void CargarDetalleProducto(int productoID, TextBox lblNombre,TextBox lblPrecio, RichTextBox rtbDescripcion, PictureBox pictureBox, List<PictureBox> colores, Button[] tallas)
        {
            using (SqlConnection con = new SqlConnection("Data Source = localhost; Integrated Security = SSPI; Initial Catalog = Velonia"))
            {
                SqlCommand cmd = new SqlCommand("ObtenerDetalleProducto", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProductoID", productoID);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblNombre.Text = reader["Nombre"].ToString();
                        lblPrecio.Text = reader["Precio"].ToString();
                        rtbDescripcion.Text = reader["Descripcion"].ToString();
                        numCantidad.Value = Int16.Parse(reader["CantidadDisponible"].ToString());
                        // Configurar colores
                        string coloresDisponibles = reader["ColoresDisponibles"].ToString();
                        for (int i = 0; i < colores.Count; i++)
                        {
                            colores[i].Enabled = coloresDisponibles.Contains(colores[i].Name);
                        }

                        // Configurar tallas
                        string tallasDisponibles = reader["TallasDisponibles"].ToString();
                        foreach (Button btn in tallas)
                        {
                            btn.Enabled = tallasDisponibles.Contains(btn.Text);
                        }

                    }

                    if (reader.NextResult())
                    {
                        List<Image> imagenes = new List<Image>();
                        while (reader.Read())
                        {
                            byte[] imagenBinaria = (byte[])reader["Imagen"];
                            using (MemoryStream ms = new MemoryStream(imagenBinaria))
                            {
                                imagenes.Add(Image.FromStream(ms));
                            }
                        }

                        // Mostrar primera imagen
                        if (imagenes.Count > 0)
                        {
                            pictureBox.Image = imagenes[0];
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                }
            }
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
