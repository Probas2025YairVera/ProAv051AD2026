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
    public partial class ListaCancelaciones : Form
    {
        public ListaCancelaciones()
        {
            InitializeComponent();
        }

        private void ListaCancelaciones_Load(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string sql = @"
            SELECT
                id_cancelacion,
                fecha_cancelacion,
                motivo,
                id_venta
            FROM Cancelacion";

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
