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
    public partial class FrmFacturas : Form
    {
        public FrmFacturas()
        {
            InitializeComponent();
        }

        private void cboVenta_Click(object sender, EventArgs e)
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

                    // Obtener datos de la venta
                    string consultaVenta = @"
            SELECT subtotal, IVA, total
            FROM Venta
            WHERE id_venta = @idVenta";

                    SqlCommand cmdVenta =
                        new SqlCommand(consultaVenta, cn);

                    cmdVenta.Parameters.AddWithValue(
                        "@idVenta",
                        cboVenta.SelectedValue);

                    SqlDataReader lector =
                        cmdVenta.ExecuteReader();

                    if (!lector.Read())
                    {
                        MessageBox.Show("Venta no encontrada.");
                        return;
                    }

                    decimal subtotal =
                        Convert.ToDecimal(lector["subtotal"]);

                    decimal iva =
                        Convert.ToDecimal(lector["IVA"]);

                    decimal total =
                        Convert.ToDecimal(lector["total"]);

                    lector.Close();

                    string folio =
                        "FAC-" + DateTime.Now.ToString("yyyyMMddHHmmss");

                    string sql = @"
            INSERT INTO Factura
            (
                folio_factura,
                metodo_pago,
                subtotal,
                IVA,
                total,
                nombre_receptor,
                RFC_receptor,
                domicilio_receptor,
                id_venta,
                id_emisor
            )
            VALUES
            (
                @folio,
                'Efectivo',
                @subtotal,
                @iva,
                @total,
                @nombre,
                @rfc,
                @domicilio,
                @idVenta,
                1
            )";

                    SqlCommand cmdFactura =
                        new SqlCommand(sql, cn);

                    cmdFactura.Parameters.AddWithValue("@folio", folio);
                    cmdFactura.Parameters.AddWithValue("@subtotal", subtotal);
                    cmdFactura.Parameters.AddWithValue("@iva", iva);
                    cmdFactura.Parameters.AddWithValue("@total", total);
                    cmdFactura.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmdFactura.Parameters.AddWithValue("@rfc", txtRFC.Text);
                    cmdFactura.Parameters.AddWithValue("@domicilio", txtDomicilio.Text);
                    cmdFactura.Parameters.AddWithValue("@idVenta", cboVenta.SelectedValue);

                    cmdFactura.ExecuteNonQuery();

                    MessageBox.Show(
                        "Factura generada correctamente\nFolio: " + folio);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FrmFacturas_Load(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    SqlDataAdapter da =
                        new SqlDataAdapter(
                        "SELECT id_venta FROM Venta",
                        cn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    cboVenta.DataSource = dt;
                    cboVenta.DisplayMember = "id_venta";
                    cboVenta.ValueMember = "id_venta";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerFacturas_Click(object sender, EventArgs e)
        {
            ListaFacturas frm = new ListaFacturas();
            frm.ShowDialog();
        }
    }
}
