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
    public partial class FormInicio : Form
    {
        private int idProdCarousel;
        List<int> productoIDs;
        private List<Image> imagenesss;
        public bool categoryMenu;
        private int c=0;
        private FormHub formPrincipal;
        public FormInicio(FormHub formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            imagenesss = ObtenerProductosMasVendidos();
            RefillingGrid();
            if (imagenesss.Count == 0)
            {
                imagenesss.Add(Image.FromFile("C:/Users/luis_/source/repos/TBD Eq/TBD Eq/Resources/mayores ventas.jpg"));
            }
            pbCarouselMSales.Image = imagenesss[c];
        }
        private void RefillingGrid()
        {
            int i = 0;
            for (int row = 0; row < tbGridProductsCustom.RowCount && i < imagenesss.Count; row++)
            {
                for (int col = 0; col < tbGridProductsCustom.ColumnCount && i < imagenesss.Count; col++)
                {
                    // Crear un PictureBox
                    PictureBox pictureBox = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.StretchImage, // Ajusta la imagen a la celda
                        Dock = DockStyle.Fill, // Llena completamente la celda
                        Image = imagenesss[i] // Cargar una imagen (cambia esta ruta)
                    };
                    int index = i;
                    pictureBox.Click += (sender, e) => PictureBox_Click(sender, e, index);
                    i++;
                    // Añadir el PictureBox a la celda
                    tbGridProductsCustom.Controls.Add(pictureBox, col, row);
                }
            }
            
        }

        private void PictureBox_Click(object sender, EventArgs e, int i)
        {

            formPrincipal.PaintForms(new Articulo(productoIDs[i]),this);
        }

        private void btnCategorys_Click(object sender, EventArgs e)
        {
            EnableMenuCategory();
        }
        private List<Image> ObtenerProductosMasVendidos()
        {
            List<Image> imagenes = new List<Image>();

            using (SqlConnection con = new SqlConnection("Data Source = localhost; Integrated Security = SSPI; Initial Catalog = Velonia"))
            {
                SqlCommand cmd = new SqlCommand("ObtenerProductosMasVendidos", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                productoIDs = new List<int>();

                // Recoger todos los ProductoID primero
                while (reader.Read())
                {
                    int productoID = reader.GetInt32(0);
                    productoIDs.Add(productoID);
                }

                // Cerrar el primer DataReader
                reader.Close();

                // Ahora recorrer la lista de ProductoIDs y obtener sus imágenes
                foreach (int productoID in productoIDs)
                {
                    using (SqlCommand cmdImagen = new SqlCommand("ObtenerImagenesProducto", con))
                    {
                        cmdImagen.CommandType = CommandType.StoredProcedure;
                        cmdImagen.Parameters.AddWithValue("@ProductoID", productoID);
                        using (SqlDataReader imagenReader = cmdImagen.ExecuteReader())
                        {
                            while (imagenReader.Read())
                            {
                                byte[] datosImagen = (byte[])imagenReader["Imagen"];
                                using (MemoryStream ms = new MemoryStream(datosImagen))
                                {
                                    imagenes.Add(Image.FromStream(ms));
                                }
                            }
                        }
                    }
                }
            }
            return imagenes;
        }



        public void EnableMenuCategory()
        {
            if (!categoryMenu)
            {
                categoryMenu = true;
                btnWoman.Visible = true;
                btnMen.Visible = true;
                btnKids.Visible = true;
                pnlBtnsCategorys.Height = 98;
            }
            else
            {
                categoryMenu = false;
                btnWoman.Visible = false;
                btnMen.Visible = false;
                btnKids.Visible = false;
                pnlBtnsCategorys.Height = 30;
            }
        }

        private void btnWoman_Click(object sender, EventArgs e)
        {
            EnableMenuCategory();
        }

        private void btnMen_Click(object sender, EventArgs e)
        {
            EnableMenuCategory();
        }

        private void btnKids_Click(object sender, EventArgs e)
        {
            EnableMenuCategory();
        }


        private void pbLeftMSales_Click(object sender, EventArgs e)
        {
            if (c > 0 )
            {
                c--; 
                pbCarouselMSales.Image = imagenesss[c];
            }
            else
            {
                c = imagenesss.Count-1;
                pbCarouselMSales.Image = imagenesss[c];
            }
        }

        private void pbRigthMSales_Click_1(object sender, EventArgs e)
        {
            if (c < 10 && c < imagenesss.Count-1) 
            {
                c++;
            }
            else 
            {
                c = 0;
            }
            pbCarouselMSales.Image = imagenesss[c];
        }

        private void pbCarouselMSales_Click(object sender, EventArgs e)
        {
        }
    }
}
