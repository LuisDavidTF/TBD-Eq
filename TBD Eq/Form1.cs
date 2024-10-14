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
    public partial class Form1 : Form
    {
        private const string Filename = "C:/Users/luis_/source/repos/TBD Eq/TBD Eq/Resources/GridEj.jpg";
        public bool categoryMenu;
        public Form1()
        {
            InitializeComponent();
            RefillingGrid();

        }
        public void EnableMenuCategory() 
        {
            if (!categoryMenu)
            {
                categoryMenu = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                panel5.Height = 98;
            }
            else
            {
                categoryMenu = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                panel5.Height = 30;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EnableMenuCategory();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EnableMenuCategory();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EnableMenuCategory();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EnableMenuCategory();
        }
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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
