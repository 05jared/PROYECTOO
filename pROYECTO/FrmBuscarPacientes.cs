using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace pROYECTO
{
    public partial class FrmBuscarPacientes : Form
    {
        Clsconeccion connecion = new Clsconeccion();
        MySqlConnection con;
        public FrmBuscarPacientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmBuscarPacientes_Load(object sender, EventArgs e)
        {
            connecion = new Clsconeccion();
            con = connecion.GetConnection();
            CargarPacientes("");
            con.Close();
        }

        private void CargarPacientes(string filtro)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                string consulta = @"SELECT id_paciente AS ID, nombre AS Nombre, apellido_paterno AS Apellido, matricula_o_numero_trabajador AS Matrícula 
                              FROM pacientess WHERE nombre LIKE @filtro OR apellido_paterno LIKE @filtro OR matricula_o_numero_trabajador LIKE @filtro";

                MySqlCommand cmd = new MySqlCommand(consulta, con);
                cmd.Parameters.AddWithValue("@filtro", $"%{filtro}%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvPacientes.DataSource = dt;

                if (dgvPacientes.Columns.Contains("ID"))
                {
                    dgvPacientes.Columns["ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pacientes: " + ex.Message,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
