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
    public partial class FormInicio : Form
    {
        public bool categoryMenu;
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnCategorys_Click(object sender, EventArgs e)
        {
            EnableMenuCategory();
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
    }
}
