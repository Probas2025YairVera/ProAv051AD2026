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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string sql = @"
            INSERT INTO Cliente
            (
                nombre_completo,
                domicilio,
                RFC,
                correo_electronico,
                telefono_casa,
                telefono_celular,
                fecha_nacimiento,
                id_usuario
            )
            VALUES
            (
                @nombre,
                @domicilio,
                @rfc,
                @correo,
                @telefonoCasa,
                @telefonoCelular,
                @fechaNacimiento,
                1
            )";

                    SqlCommand cmd = new SqlCommand(sql, cn);

                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@domicilio", txtDomicilio.Text);
                    cmd.Parameters.AddWithValue("@rfc", txtRFC.Text);
                    cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@telefonoCasa", txtTelefonoCasa.Text);
                    cmd.Parameters.AddWithValue("@telefonoCelular", txtTelefono.Text);
                    cmd.Parameters.AddWithValue(
                        "@fechaNacimiento",
                        Convert.ToDateTime(txtFecha.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Cliente registrado correctamente",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    txtNombre.Clear();
                    txtDomicilio.Clear();
                    txtRFC.Clear();
                    txtCorreo.Clear();
                    txtTelefonoCasa.Clear();
                    txtTelefono.Clear();
                    txtFecha.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            ListaClientes frm = new ListaClientes();
            frm.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
