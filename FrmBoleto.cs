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
    public partial class FrmBoleto : Form
    {
        public FrmBoleto()
        {
            InitializeComponent();
        }

        private void btnVerBoletos_Click(object sender, EventArgs e)
        {
            ListaBoletos frm = new ListaBoletos();
            frm.ShowDialog();
        }

        private void FrmBoleto_Load(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    // Ventas
                    SqlDataAdapter daVentas =
                        new SqlDataAdapter(
                        "SELECT id_venta FROM Venta",
                        cn);

                    DataTable dtVentas = new DataTable();

                    daVentas.Fill(dtVentas);

                    cboVenta.DataSource = dtVentas;
                    cboVenta.DisplayMember = "id_venta";
                    cboVenta.ValueMember = "id_venta";

                    // Partidos
                    SqlDataAdapter daPartidos =
                        new SqlDataAdapter(
                        "SELECT id_partido FROM Partido",
                        cn);

                    DataTable dtPartidos = new DataTable();

                    daPartidos.Fill(dtPartidos);

                    cboPartido.DataSource = dtPartidos;
                    cboPartido.DisplayMember = "id_partido";
                    cboPartido.ValueMember = "id_partido";

                    // Asientos
                    SqlDataAdapter daAsientos =
                        new SqlDataAdapter(
                        @"SELECT id_asiento,
                         CONCAT(fila,'-',numero_asiento) AS asiento
                  FROM Asiento",
                        cn);

                    DataTable dtAsientos = new DataTable();

                    daAsientos.Fill(dtAsientos);

                    cboAsiento.DataSource = dtAsientos;
                    cboAsiento.DisplayMember = "asiento";
                    cboAsiento.ValueMember = "id_asiento";
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
            INSERT INTO Boleto
            (
                precio_unitario,
                estado_boleto,
                id_venta,
                id_partido,
                id_asiento
            )
            VALUES
            (
                @precio,
                'Vendido',
                @idVenta,
                @idPartido,
                @idAsiento
            )";

                    SqlCommand cmd =
                        new SqlCommand(sql, cn);

                    cmd.Parameters.AddWithValue(
                        "@precio",
                        Convert.ToDecimal(txtPrecio.Text));

                    cmd.Parameters.AddWithValue(
                        "@idVenta",
                        cboVenta.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@idPartido",
                        cboPartido.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@idAsiento",
                        cboAsiento.SelectedValue);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Boleto registrado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboAsiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string sql = @"
            SELECT z.precio_base
            FROM Asiento a
            INNER JOIN Zona z
                ON a.id_zona = z.id_zona
            WHERE a.id_asiento = @idAsiento";

                    SqlCommand cmd = new SqlCommand(sql, cn);

                    cmd.Parameters.AddWithValue(
                        "@idAsiento",
                        cboAsiento.SelectedValue);

                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        txtPrecio.Text =
                            Convert.ToDecimal(resultado).ToString("0.00");
                    }
                }
            }
            catch
            {
            }

        }

    }
}
