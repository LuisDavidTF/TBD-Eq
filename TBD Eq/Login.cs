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
    public partial class Login : Form
    {
        private Font defaultFont;
        
        
        public Login()
        {
            InitializeComponent();
            
            InitializePanels();
        }
        private void InitializePanels()
        {

            //Panel para el usuario registro
            pnlUsername.Click += PnlUsername_Click;
            pnlUsername.BorderStyle = BorderStyle.None; // No mostrar el borde predeterminado

            txtUsername.Enter += TextBox_Enter;
            txtUsername.Leave += TextBox_Leave;
            txtUsername.BorderStyle = BorderStyle.None; // No mostrar el borde predeterminado

            defaultFont = lblUsernameR.Font;
            lblUsernameR.Click += Label_Click;


            // Panel para la Contraseña Registro
            pnlPassword.Click += PnlPassword_Click;
            pnlPassword.BorderStyle = BorderStyle.None; // No mostrar el borde predeterminado

            txtPassword.UseSystemPasswordChar = true; // Mostrar asteriscos en lugar de caracteres reales
            txtPassword.Enter += TextBox_Enter;
            txtPassword.Leave += TextBox_Leave;
            txtPassword.BorderStyle = BorderStyle.None; // No mostrar el borde predeterminado

            lblPasswordR.Click += Label_Click;

        }


        private void PnlUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void PnlPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }


        private async void TextBox_Enter(object sender, EventArgs e)
        {
            Panel panel = (Panel)((TextBox)sender).Parent;
            TextBox textBox = (TextBox)sender;

            panel.BackColor = Color.White; // Cambia el color de fondo del panel a blanco

            textBox.BackColor = Color.White;
            panel.BorderStyle = BorderStyle.FixedSingle; // Muestra el borde negro
            await AnimateLabelUp(panel);
        }

        private async void TextBox_Leave(object sender, EventArgs e)
        {
            Panel panel = (Panel)((TextBox)sender).Parent;

            panel.BackColor = Color.FromArgb(224, 224, 224); // Cambia el color de fondo del panel a grisaceo transparente
            panel.BorderStyle = BorderStyle.None; // Oculta el borde
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.FromArgb(224, 224, 224);
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                await AnimateLabelDown(panel);
                ConfigureTextBox(textBox);
            }
        }

        private async Task AnimateLabelUp(Panel panel)
        {
            Label label = panel.Controls.OfType<Label>().FirstOrDefault();
            while (label.Location.Y > 0)
            {
                label.Location = new Point(label.Location.X, label.Location.Y - 1);
                label.Font = new Font(defaultFont.FontFamily, label.Font.Size - 0.1f, FontStyle.Regular);
                await Task.Delay(1);
            }
        }

        private async Task AnimateLabelDown(Panel panel)
        {
            Label label = panel.Controls.OfType<Label>().FirstOrDefault();
            while (label.Location.Y < 18)
            {
                label.Location = new Point(label.Location.X, label.Location.Y + 1);
                label.Font = new Font(defaultFont.FontFamily, label.Font.Size + 0.1f, FontStyle.Regular);
                await Task.Delay(1);
            }
        }

        private void ConfigureTextBox(TextBox textBox)
        {
            textBox.Text = "";
            textBox.ForeColor = SystemColors.WindowText;
        }

        private void Label_Click(object sender, EventArgs e)
        {
            TextBox textBox = ((Label)sender).Parent.Controls.OfType<TextBox>().FirstOrDefault();
            textBox.Focus();
        }

        private void pnlUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void pnlPassword_Click(object sender, EventArgs e)
        {

            txtPassword.Focus();
        }
        private int IniciarSesion(string nombreUsuario, string contraseña)
        {

            using (SqlConnection con = new SqlConnection("Data Source=localhost;Integrated Security=SSPI;Initial Catalog=Velonia"))
            {
                SqlCommand cmd = new SqlCommand("IniciarSesion", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                con.Open();
                var resultado = cmd.ExecuteScalar();
                return resultado != null ? Convert.ToInt32(resultado) : -1;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            FormHub.idUser= IniciarSesion(txtUsername.Text, txtPassword.Text);
            if (FormHub.idUser == -1)
            {
                MessageBox.Show("Error al iniciar sesión: Usuario y/o contraseña incorrecta");
            }
            else 
            {
                MessageBox.Show("Inicio de sesión exitoso.");
                this.TopLevel = false;
                this.Close();
                this.Dispose();
                FormHub.loged = true;
            }
            /*string connectionString = $"Data Source=localhost;Initial Catalog=empresaGIC;User Id={txtUsername.Text};Password={txtPassword.Text}";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Intenta abrir la conexión

                    // Si se llega aquí, la conexión fue exitosa
                    MessageBox.Show("Inicio de sesión exitoso.");

                    this.Visible = false;
                    FormHub.loged = true;
                    connection.Close(); // Cerrar la conexión
                }
            }
            catch (SqlException ex)
            {
                // Si hay un error, esto indica que el login o contraseña son incorrectos
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }
            */
        }

        private void lblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignUp signUp = new FormSignUp();
            signUp.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            btnLogin.Focus();
        }
    }
}
