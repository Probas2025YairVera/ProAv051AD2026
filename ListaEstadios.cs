using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;

namespace WinFormsApp4
{
    public partial class ListaEstadios : Form
    {
        public ListaEstadios()
        {
            InitializeComponent();
        }

        private void ListaEstadios_Load(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();

            try
            {
                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string sql = "SELECT * FROM Estadio";

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}