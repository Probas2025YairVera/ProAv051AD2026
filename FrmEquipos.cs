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
    public partial class FrmEquipos : Form
    {
        public FrmEquipos()
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
            INSERT INTO Equipo
            (
                nombre_equipo
            )
            VALUES
            (
                @nombre
            )";

                    SqlCommand cmd = new SqlCommand(sql, cn);

                    cmd.Parameters.AddWithValue(
                        "@nombre",
                        txtNombreEquipo.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Equipo registrado correctamente");

                    txtNombreEquipo.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerEquipos_Click(object sender, EventArgs e)
        {
            ListaEquipos frm = new ListaEquipos();
            frm.ShowDialog();
        }
    }
}
