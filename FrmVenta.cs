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
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    // Clientes
                    SqlDataAdapter daClientes =
                        new SqlDataAdapter(
                        "SELECT id_cliente, nombre_completo FROM Cliente",
                        cn);

                    DataTable dtClientes = new DataTable();

                    daClientes.Fill(dtClientes);

                    cboCliente.DataSource = dtClientes;
                    cboCliente.DisplayMember = "nombre_completo";
                    cboCliente.ValueMember = "id_cliente";

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

                    // Zonas
                    SqlDataAdapter daZonas =
                        new SqlDataAdapter(
                        "SELECT id_zona, nombre_zona FROM Zona",
                        cn);

                    DataTable dtZonas = new DataTable();

                    daZonas.Fill(dtZonas);

                    cboZona.DataSource = dtZonas;
                    cboZona.DisplayMember = "nombre_zona";
                    cboZona.ValueMember = "id_zona";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerVentas_Click(object sender, EventArgs e)
        {
            ListaVentas frm = new ListaVentas();
            frm.ShowDialog();
        }

        private void cboZona_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboZona.SelectedValue == null)
                    return;

                Conexion conexion = new Conexion();

                using (SqlConnection cn =
                       conexion.ObtenerConexion())
                {
                    cn.Open();

                    string sql =
                        "SELECT precio_base FROM Zona WHERE id_zona=@id";

                    SqlCommand cmd =
                        new SqlCommand(sql, cn);

                    cmd.Parameters.AddWithValue(
                        "@id",
                        cboZona.SelectedValue);

                    decimal subtotal =
                        Convert.ToDecimal(cmd.ExecuteScalar());

                    decimal iva = subtotal * 0.16m;

                    decimal total = subtotal + iva;

                    txtSubtotal.Text = subtotal.ToString();
                    txtIVA.Text = iva.ToString();
                    txtTotal.Text = total.ToString();
                }
            }
            catch
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn =
                      conexion.ObtenerConexion())
                {
                    cn.Open();

                    string sql = @"
            INSERT INTO Venta
            (
                subtotal,
                IVA,
                total,
                id_cliente,
                id_usuario,
                id_partido
            )
            VALUES
            (
                @subtotal,
                @iva,
                @total,
                @cliente,
                1,
                @partido
            )";

                    SqlCommand cmd =
                        new SqlCommand(sql, cn);

                    cmd.Parameters.AddWithValue(
                        "@subtotal",
                        Convert.ToDecimal(txtSubtotal.Text));

                    cmd.Parameters.AddWithValue(
                        "@iva",
                        Convert.ToDecimal(txtIVA.Text));

                    cmd.Parameters.AddWithValue(
                        "@total",
                        Convert.ToDecimal(txtTotal.Text));

                    cmd.Parameters.AddWithValue(
                        "@cliente",
                        cboCliente.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@partido",
                        cboPartido.SelectedValue);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Venta registrada correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
