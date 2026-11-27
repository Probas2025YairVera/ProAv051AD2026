using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string sql = @"
            SELECT id_rol
            FROM Usuario
            WHERE correo_electronico = @correo
            AND contrasena = @contrasena";

                    SqlCommand cmd =
                        new SqlCommand(sql, cn);

                    cmd.Parameters.AddWithValue(
                        "@correo",
                        txtCorreo.Text);

                    cmd.Parameters.AddWithValue(
                        "@contrasena",
                        txtContrasena.Text);

                    object resultado =
                        cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        int rol =
                            Convert.ToInt32(resultado);

                        Menuprincipal frm =
                            new Menuprincipal(rol);

                        frm.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Usuario o contraseña incorrectos");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
