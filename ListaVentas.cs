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
    public partial class ListaVentas : Form
    {
        public ListaVentas()
        {
            InitializeComponent();
        }

        private void ListaVentas_Load(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string sql = @"
            SELECT
                v.id_venta,
                c.nombre_completo,
                v.subtotal,
                v.IVA,
                v.total,
                v.fecha_venta
            FROM Venta v
            INNER JOIN Cliente c
                ON v.id_cliente = c.id_cliente
            ORDER BY v.fecha_venta DESC";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, cn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
