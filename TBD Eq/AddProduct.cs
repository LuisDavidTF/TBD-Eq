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
    public partial class AddProduct : Form
    {
        private string tallas="a";
        private string colores="a";
        private int IDUser=FormHub.idUser;
        private List<byte[]> imagenesBytes = new List<byte[]>();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            if (imagenesBytes.Count >= 3)
            {
                MessageBox.Show("Ya has seleccionado las 3 imágenes permitidas.", "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Validar cuántas imágenes se pueden agregar
                    int disponibles = 3 - imagenesBytes.Count;
                    if (openFileDialog.FileNames.Length > disponibles)
                    {
                        MessageBox.Show($"Solo puedes agregar {disponibles} imagen(es) más.", "Límite de imágenes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    foreach (string filePath in openFileDialog.FileNames)
                    {
                        // Convertir la imagen a bytes
                        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                        {
                            byte[] imageBytes = new byte[fs.Length];
                            fs.Read(imageBytes, 0, imageBytes.Length);
                            imagenesBytes.Add(imageBytes);
                        }

                        // Mostrar vista previa en un FlowLayoutPanel
                        PictureBox pictureBox = new PictureBox
                        {
                            Image = Image.FromFile(filePath),
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Height = 100,
                            Width = 100,
                            Margin = new Padding(5)
                        };
                        flowLayoutPanel1.Controls.Add(pictureBox);
                    }
                }
            }
        }
        private byte[] ConvertirImagenABinario(string rutaArchivo)
        {
            return File.ReadAllBytes(rutaArchivo);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AgregarProductoConImagenes(txtNameProduct.Text, decimal.Parse(txtPrice.Text),rtxtDescripcion.Text,tallas,Int16.Parse(numCantidad.Value.ToString()),colores,IDUser,imagenesBytes);
        }
        private void AgregarProductoConImagenes(string nombre, decimal precio, string descripcion, string tallas, int cantidad, string colores, int usuarioID, List<byte[]> rutasImagenes)
        {
            using (SqlConnection con = new SqlConnection("Data Source = localhost; Integrated Security = SSPI; Initial Catalog = Velonia"))
            {
                SqlCommand cmd = new SqlCommand("AgregarProducto", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.Parameters.AddWithValue("@TallasDisponibles", tallas);
                cmd.Parameters.AddWithValue("@ColoresDisponibles", colores);
                cmd.Parameters.AddWithValue("@CantidadDisponible", cantidad);
                cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);

                con.Open();

                // Ejecutar el procedimiento y obtener el ID del producto
                object resultado = cmd.ExecuteScalar();

                if (resultado != null && int.TryParse(resultado.ToString(), out int productoID))
                {
                    // Guardar las imágenes asociadas al producto
                    foreach (var imagen in rutasImagenes)
                    {
                        SqlCommand cmdImagen = new SqlCommand("InsertarImagenProducto", con);
                        cmdImagen.CommandType = CommandType.StoredProcedure;

                        cmdImagen.Parameters.AddWithValue("@ProductoID", productoID);
                        cmdImagen.Parameters.AddWithValue("@Imagen", imagen);

                        cmdImagen.ExecuteNonQuery();
                    }

                    MessageBox.Show("Producto agregado correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al obtener el ID del producto.");
                }
            }
        }

    }
}
