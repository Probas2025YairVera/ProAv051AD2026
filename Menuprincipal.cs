namespace WinFormsApp4
{
    public partial class Menuprincipal : Form
    {
        private int idRol;

        public Menuprincipal()
        {
            InitializeComponent();
        }

        public Menuprincipal(int rol)
        {
            InitializeComponent();
            idRol = rol;
        }

        private void Menuprincipal_Load(object sender, EventArgs e)
        {
            if (idRol == 2)
            {
                button1.Visible = false;   // Estadios
                button3.Visible = false;   // Partidos

                btnEquipos.Visible = false;
                btnZonas.Visible = false;
                btnAsientos.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEstadio frm = new FrmEstadio();
            frm.ShowDialog();
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            FrmEquipos frm = new FrmEquipos();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmEquipos frm = new FrmEquipos();
            frm.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.ShowDialog();
        }

        private void btnPartidos_Click(object sender, EventArgs e)
        {
            FrmPartido frm = new FrmPartido();
            frm.ShowDialog();
        }

        private void btnZonas_Click(object sender, EventArgs e)
        {
            FrmZona frm = new FrmZona();
            frm.ShowDialog();
        }

        private void btnAsientos_Click(object sender, EventArgs e)
        {
            FrmAsiento frm = new FrmAsiento();
            frm.ShowDialog();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            FrmVenta frm = new FrmVenta();
            frm.ShowDialog();
        }
        private void btnBoletos_Click(object sender, EventArgs e)
        {
            FrmBoleto frm = new FrmBoleto();
            frm.ShowDialog();
        }
        private void btnPagos_Click(object sender, EventArgs e)
        {
            FrmPago frm = new FrmPago();
            frm.ShowDialog();
        }
        private void tnFacturas_Click(object sender, EventArgs e)
        {
            FrmFacturas frm = new FrmFacturas();
            frm.ShowDialog();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}