using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace SistemasUsuarios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
           {
            if (string.IsNullOrWhiteSpace(txtUsuarioLogin.Text) ||
                string.IsNullOrWhiteSpace(txtClaveLogin.Text))
            {
                MessageBox.Show("Ingresa tu usuario y contraseña.");
                return;
            }

            try
            {
                string conexion =
                    @"Server=FREDY\SQLEXPRESS04;Database=SistemaUsuariosDB;Trusted_Connection=True;TrustServerCertificate=True;";

                string sql = @"
            SELECT COUNT(*)
            FROM dbo.Usuarios_Usss039026
            WHERE usuario = @usuario AND clave = @clave";

                using (SqlConnection cn = new SqlConnection(conexion))
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue(
                        "@usuario", txtUsuarioLogin.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@clave", txtClaveLogin.Text);

                    cn.Open();

                    int existe = Convert.ToInt32(cmd.ExecuteScalar());
                        if (existe > 0)
                        {
                            Form1 principal = new Form1();
                            this.Hide();

                            principal.FormClosed += (s, args) => this.Close();
                            principal.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                        txtClaveLogin.Clear();
                        txtClaveLogin.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }
        }
    }
    }
}
