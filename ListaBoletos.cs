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
    public partial class ListaBoletos : Form
    {
        public ListaBoletos()
        {
            InitializeComponent();
        }

        private void ListaBoletos_Load(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string sql = @"
            SELECT
                b.id_boleto,
                b.precio_unitario,
                b.estado_boleto,
                a.fila,
                a.numero_asiento
            FROM Boleto b
            INNER JOIN Asiento a
                ON b.id_asiento = a.id_asiento";

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
