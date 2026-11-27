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
    public partial class FrmCancelacion : Form
    {
        public FrmCancelacion()
        {
            InitializeComponent();
        }

        private void FrmCancelacion_Load(object sender, EventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string sqlVenta = @"
            UPDATE Venta
            SET estado_venta = 'Cancelada'
            WHERE id_venta = @idVenta";

                    SqlCommand cmdVenta =
                        new SqlCommand(sqlVenta, cn);

                    cmdVenta.Parameters.AddWithValue(
                        "@idVenta",
                        cboVenta.SelectedValue);

                    cmdVenta.ExecuteNonQuery();

                    string sqlBoletos = @"
            UPDATE Boleto
            SET estado_boleto = 'Cancelado'
            WHERE id_venta = @idVenta";

                    SqlCommand cmdBoletos =
                        new SqlCommand(sqlBoletos, cn);

                    cmdBoletos.Parameters.AddWithValue(
                        "@idVenta",
                        cboVenta.SelectedValue);

                    cmdBoletos.ExecuteNonQuery();

                    string sqlCancelacion = @"
            INSERT INTO Cancelacion
            (
                motivo,
                id_venta,
                id_usuario
            )
            VALUES
            (
                @motivo,
                @idVenta,
                1
            )";

                    SqlCommand cmdCancelacion =
                        new SqlCommand(sqlCancelacion, cn);

                    cmdCancelacion.Parameters.AddWithValue(
                        "@motivo",
                        txtMotivo.Text);

                    cmdCancelacion.Parameters.AddWithValue(
                        "@idVenta",
                        cboVenta.SelectedValue);

                    cmdCancelacion.ExecuteNonQuery();

                    MessageBox.Show(
                        "Venta cancelada correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerCancelaciones_Click(object sender, EventArgs e)
        {
            ListaCancelaciones frm =
                new ListaCancelaciones();

            frm.ShowDialog();
        }
    }
}
