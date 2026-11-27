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
    public partial class FrmPartido : Form
    {
        public FrmPartido()
        {
            InitializeComponent();
        }

        private void FrmPartido_Load(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();

            try
            {
                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    // Estadios
                    SqlDataAdapter daEstadios =
                        new SqlDataAdapter(
                        "SELECT id_estadio, nombre FROM Estadio",
                        cn);

                    DataTable dtEstadios = new DataTable();

                    daEstadios.Fill(dtEstadios);

                    cboEstadio.DataSource = dtEstadios;
                    cboEstadio.DisplayMember = "nombre";
                    cboEstadio.ValueMember = "id_estadio";

                    // Equipos
                    SqlDataAdapter daEquipos =
                        new SqlDataAdapter(
                        "SELECT id_equipo, nombre_equipo FROM Equipo",
                        cn);

                    DataTable dtEquipos = new DataTable();

                    daEquipos.Fill(dtEquipos);

                    cboLocal.DataSource = dtEquipos.Copy();
                    cboLocal.DisplayMember = "nombre_equipo";
                    cboLocal.ValueMember = "id_equipo";

                    cboVisitante.DataSource = dtEquipos;
                    cboVisitante.DisplayMember = "nombre_equipo";
                    cboVisitante.ValueMember = "id_equipo";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboEstadio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int idEstadio = Convert.ToInt32(cboEstadio.SelectedValue);
                int idLocal = Convert.ToInt32(cboLocal.SelectedValue);
                int idVisitante = Convert.ToInt32(cboVisitante.SelectedValue);

                if (idLocal == idVisitante)
                {
                    MessageBox.Show(
                        "El equipo local y visitante no pueden ser iguales");

                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string sqlPartido = @"
            INSERT INTO Partido
            (
                fecha_hora,
                id_estadio,
                id_usuario
            )
            VALUES
            (
                @fecha,
                @idEstadio,
                1
            );

            SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd =
                        new SqlCommand(sqlPartido, cn);

                    cmd.Parameters.AddWithValue(
                        "@fecha",
                        dtpFecha.Value);

                    cmd.Parameters.AddWithValue(
                        "@idEstadio",
                        idEstadio);

                    int idPartido =
                        Convert.ToInt32(cmd.ExecuteScalar());

                    string sqlLocal = @"
            INSERT INTO Partido_Equipo
            (
                id_partido,
                id_equipo,
                condicion
            )
            VALUES
            (
                @idPartido,
                @idEquipo,
                'Local'
            )";

                    SqlCommand cmdLocal =
                        new SqlCommand(sqlLocal, cn);

                    cmdLocal.Parameters.AddWithValue(
                        "@idPartido",
                        idPartido);

                    cmdLocal.Parameters.AddWithValue(
                        "@idEquipo",
                        idLocal);

                    cmdLocal.ExecuteNonQuery();

                    string sqlVisitante = @"
            INSERT INTO Partido_Equipo
            (
                id_partido,
                id_equipo,
                condicion
            )
            VALUES
            (
                @idPartido,
                @idEquipo,
                'Visitante'
            )";

                    SqlCommand cmdVisitante =
                        new SqlCommand(sqlVisitante, cn);

                    cmdVisitante.Parameters.AddWithValue(
                        "@idPartido",
                        idPartido);

                    cmdVisitante.Parameters.AddWithValue(
                        "@idEquipo",
                        idVisitante);

                    cmdVisitante.ExecuteNonQuery();

                    MessageBox.Show(
                        "Partido registrado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerPartidos_Click(object sender, EventArgs e)
        {
            ListaPartidos frm = new ListaPartidos();
            frm.ShowDialog();
        }
    }
}
