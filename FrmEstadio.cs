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
    public partial class FrmEstadio : Form
    {
        public FrmEstadio()
        {
            InitializeComponent();
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
            INSERT INTO Estadio
            (
                nombre,
                ciudad,
                capacidad_total,
                id_usuario
            )
            VALUES
            (
                @nombre,
                @ciudad,
                @capacidad,
                1
            )";

                    SqlCommand cmd = new SqlCommand(sql, cn);

                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@ciudad", txtCiudad.Text);
                    cmd.Parameters.AddWithValue("@capacidad",
                        Convert.ToInt32(txtCapacidad.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Estadio registrado correctamente");

                    txtNombre.Clear();
                    txtCiudad.Clear();
                    txtCapacidad.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerEstadios_Click(object sender, EventArgs e)
        {
            ListaEstadios frm = new ListaEstadios();
            frm.ShowDialog();
        }
    }
}
