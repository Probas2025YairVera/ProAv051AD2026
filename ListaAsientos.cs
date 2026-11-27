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
    public partial class ListaAsientos : Form
    {
        public ListaAsientos()
        {
            InitializeComponent();
        }

        private void ListaAsientos_Load(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string sql = @"
                    SELECT
                     a.id_asiento,
                     a.fila,
                     a.numero_asiento,
                     z.nombre_zona
                     FROM Asiento a
                     INNER JOIN Zona z
                     ON a.id_zona = z.id_zona
                     ORDER BY a.id_asiento";

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
