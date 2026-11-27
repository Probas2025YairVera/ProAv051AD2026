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
    public partial class FrmAsiento : Form
    {
        public FrmAsiento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAsiento_Load(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    SqlDataAdapter da =
                        new SqlDataAdapter(
                        "SELECT id_zona, nombre_zona FROM Zona",
                        cn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    cboZona.DataSource = dt;
                    cboZona.DisplayMember = "nombre_zona";
                    cboZona.ValueMember = "id_zona";
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
            INSERT INTO Asiento
            (
                fila,
                numero_asiento,
                id_zona
            )
            VALUES
            (
                @fila,
                @numero,
                @idZona
            )";

                    SqlCommand cmd =
                        new SqlCommand(sql, cn);

                    cmd.Parameters.AddWithValue(
                        "@fila",
                        txtFila.Text);

                    cmd.Parameters.AddWithValue(
                        "@numero",
                        Convert.ToInt32(txtNumeroAsiento.Text));

                    cmd.Parameters.AddWithValue(
                        "@idZona",
                        cboZona.SelectedValue);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Asiento registrado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerAsientos_Click(object sender, EventArgs e)
        {
            ListaAsientos frm = new ListaAsientos();
            frm.ShowDialog();
        }
    }
}
