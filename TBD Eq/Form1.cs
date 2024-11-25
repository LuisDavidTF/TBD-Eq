using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBD_Eq
{
    public partial class FormHub : Form
    {
        public static int idUser;
        public static bool loged = false;
        private bool menuActive = false;
        private const string Filename = "C:/Users/luis_/source/repos/TBD Eq/TBD Eq/Resources/GridEj.jpg";
        public bool categoryMenu;
        public static Form active;
        public FormHub()
        {
            InitializeComponent();
            FormInicio inicio = new FormInicio(this);
            inicio.TopLevel = false;
            pnlFormsCenter.Controls.Add(inicio);
            inicio.Show();
            active = inicio;
            pnlMenu.Visible = false;
            //RefillingGrid();

        }
        public void PaintForms(Form abre, Form cierra)
        {
            cierra.Close();
            cierra.Dispose();
            abre.TopLevel = false;
            pnlFormsCenter.Controls.Add(abre);
            abre.Show();
            active = abre;
        }

        /*
                private void RefillingGrid() {
                    for (int row = 0; row < tableLayoutPanel1.RowCount; row++)
                    {
                        for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
                        {
                            // Crear un PictureBox
                            PictureBox pictureBox = new PictureBox
                            {
                                SizeMode = PictureBoxSizeMode.StretchImage, // Ajusta la imagen a la celda
                                Dock = DockStyle.Fill, // Llena completamente la celda
                                Image = Image.FromFile(Filename) // Cargar una imagen (cambia esta ruta)
                            };

                            // Añadir el PictureBox a la celda
                            tableLayoutPanel1.Controls.Add(pictureBox, col, row);
                        }
                    }
                }*/


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            loged = false;
            menuActive = false;
            pnlMenu.Visible = false;
            PaintForms(new FormInicio(this), active);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            PaintForms(new AddProduct(), active);
            pnlMenu.Visible = false;
            menuActive = false;
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            PaintForms(new ModifyProduct(), active);
            pnlMenu.Visible = false;
            menuActive = false;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            PaintForms(new Profile(),active);
            pnlMenu.Visible = false;
            menuActive = false;
        }

        private void pbHead_Click(object sender, EventArgs e)
        {
            PaintForms(new FormInicio(this),active);
        }

        private void pbUser_Click(object sender, EventArgs e)
        {
            if (!loged)
            {
                Login login = new Login();
                login.Show();
            }
            else
            {
                if (!menuActive)
                {
                    pnlMenu.Visible = true;
                    menuActive = true;
                }
                else
                {
                    pnlMenu.Visible = false;
                    menuActive = false;
                }
            }
        }

        private void pbShoppingCart_Click(object sender, EventArgs e)
        {
            PaintForms(new ShoppingCar(),active);
        }
    }
}
