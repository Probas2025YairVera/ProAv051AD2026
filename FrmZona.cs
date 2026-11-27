using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace WinFormsApp4
{
    public partial class FrmZona : Form
    {
        public FrmZona()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreZona_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmZona_Load(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    SqlDataAdapter da =
                        new SqlDataAdapter(
                        "SELECT id_estadio, nombre FROM Estadio",
                        cn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    cboEstadio.DataSource = dt;

                    cboEstadio.DisplayMember = "nombre";
                    cboEstadio.ValueMember = "id_estadio";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            INSERT INTO Zona
            (
                nombre_zona,
                precio_base,
                cupo,
                id_estadio
            )
            VALUES
            (
                @nombreZona,
                @precio,
                @cupo,
                @idEstadio
            )";

                    SqlCommand cmd =
                        new SqlCommand(sql, cn);

                    cmd.Parameters.AddWithValue(
                        "@nombreZona",
                        txtNombreZona.Text);

                    cmd.Parameters.AddWithValue(
                        "@precio",
                        Convert.ToDecimal(txtPrecio.Text));

                    cmd.Parameters.AddWithValue(
                        "@cupo",
                        Convert.ToInt32(txtCupo.Text));

                    cmd.Parameters.AddWithValue(
                        "@idEstadio",
                        cboEstadio.SelectedValue);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Zona registrada correctamente");

                    txtNombreZona.Clear();
                    txtPrecio.Clear();
                    txtCupo.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerZonas_Click(object sender, EventArgs e)
        {
            ListasZonas frm = new ListasZonas();
            frm.ShowDialog();
        }
    }
}
