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
    public partial class Articulo : Form
    {
        public Articulo()
        {
            InitializeComponent();
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
    }
}
