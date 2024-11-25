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
    public partial class Articulo : Form
    {
        List<PictureBox> colores=new List<PictureBox>();
        Button[] tallas=new Button[3];
        public Articulo(int id)
        {
            InitializeComponent();
            colores.Add(pbFirstColor);
            colores.Add(pbSecondColor);
            colores.Add(pbThirdColor);
            tallas[0] = btnL;
            tallas[1] = btnM;
            tallas[2] = btnS;
            CargarDetalleProducto(id, txtNombre, lblPrice, rtxtDescripcion, pbCarousel, colores, tallas);
            Console.WriteLine(id);
            int n=Int16.Parse(numCantidad.Value.ToString());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btnXS_Click(object sender, EventArgs e)
        {
            btnXS.Enabled = false;

        }

        private void btnS_Click(object sender, EventArgs e)
        {
            btnS.Enabled = false;
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            btnM.Enabled = false;
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            btnL.Enabled = false;
        }

        private void btnXL_Click(object sender, EventArgs e)
        {
            btnXL.Enabled = false;
        }

        private void btnShop_Click(object sender, EventArgs e)
        {

        }
        private void CargarDetalleProducto(int productoID, Label lblNombre, Label lblPrecio, RichTextBox rtbDescripcion, PictureBox pictureBox, List<PictureBox> colores, Button[] tallas)
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
                        lblPrecio.Text = $"Precio: ${reader["Precio"]}";
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
    }
}
