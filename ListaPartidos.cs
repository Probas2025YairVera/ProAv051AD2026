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
    public partial class ListaPartidos : Form
    {
        public ListaPartidos()
        {
            InitializeComponent();
        }

        private void ListaPartidos_Load(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string sql = @"
            SELECT
                p.id_partido,
                e.nombre AS estadio,
                p.fecha_hora,
                local.nombre_equipo AS equipo_local,
                visitante.nombre_equipo AS equipo_visitante
            FROM Partido p

            INNER JOIN Estadio e
                ON p.id_estadio = e.id_estadio

            INNER JOIN Partido_Equipo peLocal
                ON p.id_partido = peLocal.id_partido
               AND peLocal.condicion = 'Local'

            INNER JOIN Equipo local
                ON peLocal.id_equipo = local.id_equipo

            INNER JOIN Partido_Equipo peVisitante
                ON p.id_partido = peVisitante.id_partido
               AND peVisitante.condicion = 'Visitante'

            INNER JOIN Equipo visitante
                ON peVisitante.id_equipo = visitante.id_equipo

            ORDER BY p.fecha_hora";

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
