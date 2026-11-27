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
    public partial class ListasZonas : Form
    {
        public ListasZonas()
        {
            InitializeComponent();
        }

        private void ListaZonas_Load(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string sql = @"
            SELECT
                z.id_zona,
                z.nombre_zona,
                z.precio_base,
                z.cupo,
                e.nombre AS estadio
            FROM Zona z
            INNER JOIN Estadio e
                ON z.id_estadio = e.id_estadio";

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
