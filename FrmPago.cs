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
    public partial class FrmPago : Form
    {
        public FrmPago()
        {
            InitializeComponent();
        }

        private void btnVerPagos_Click(object sender, EventArgs e)
        {
            ListaPagos frm = new ListaPagos();
            frm.ShowDialog();
        }

        private void cboVenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmPago_Load(object sender, EventArgs e)
        {
            try
            {
                cboMetodo.Items.Add("Credito");
                cboMetodo.Items.Add("Debito");
                cboMetodo.Items.Add("Efectivo");

                cboMetodo.SelectedIndex = 0;

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string sql = @"
            INSERT INTO Pago
            (
                metodo_pago,
                monto,
                nombre_titular,
                ultimos_digitos,
                fecha_expiracion,
                id_venta
            )
            VALUES
            (
                @metodo,
                @monto,
                @titular,
                @digitos,
                @fechaExpiracion,
                @idVenta
            )";

                    SqlCommand cmd =
                        new SqlCommand(sql, cn);

                    cmd.Parameters.AddWithValue(
                        "@metodo",
                        cboMetodo.Text);

                    cmd.Parameters.AddWithValue(
                        "@monto",
                        Convert.ToDecimal(txtMonto.Text));

                    cmd.Parameters.AddWithValue(
                        "@titular",
                        txtTitular.Text);

                    cmd.Parameters.AddWithValue(
                        "@digitos",
                        txtDigitos.Text);

                    cmd.Parameters.AddWithValue(
                        "@fechaExpiracion",
                        dtpExpiracion.Value);

                    cmd.Parameters.AddWithValue(
                        "@idVenta",
                        cboVenta.SelectedValue);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Pago registrado correctamente");

                    txtMonto.Clear();
                    txtTitular.Clear();
                    txtDigitos.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
