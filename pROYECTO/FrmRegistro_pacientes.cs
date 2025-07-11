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
    public partial class FrmRegistro_pacientes : Form
    {
        Clsconeccion connecion = new Clsconeccion();
        MySqlConnection con;
        public FrmRegistro_pacientes()
        {
            InitializeComponent();
        }

        private void FrmRegistro_pacientes_Load(object sender, EventArgs e)
        {
            connecion = new Clsconeccion();
            con = connecion.GetConnection();
            CargarTiposPaciente();
            con.Close();
        }

        private void CargarTiposPaciente()
        {
            try
            {
               
                string query = "SELECT idtipopacientes, descripcion FROM tipopacientes";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbTipopaciente.DataSource = dt;
                cmbTipopaciente.DisplayMember = "descripcion";      // Lo que se ve
                cmbTipopaciente.ValueMember = "idtipopacientes";    // Lo que se guarda
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tipos de paciente: " + ex.Message);
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();//
            string apellidoP = txtApellidoP.Text.Trim();
            string apellidoM = txtApellidoMa.Text.Trim();
            int tipoPaciente = Convert.ToInt32(cmbTipopaciente.SelectedValue);
            string matricula = txtnum_Matricula.Text.Trim();
            DateTime fechaNacimiento = dtpFecha.Value.Date;
            string sexo = cmbsexo.Text.Trim();
            string correo = txtcorreo.Text.Trim();
            string telefono = txttelefono.Text.Trim();
            string direccion = txtdireccion.Text.Trim();
            
            if (nombre == "" || apellidoP == "" || apellidoM == "" || matricula == "" || sexo == "" || correo == "" || telefono == "" || direccion == "")
            {
                MessageBox.Show("Por favor, completa todos los campos antes de registrar al paciente.", "Campos vacíos");
                return;
            }


            try
            {
                
                con.Open();

                string consulta = @"INSERT INTO pacientess (nombre, apellido_materno, apellido_paterno, tipopaciente, matricula_o_numero_trabajador, fecha_nacimiento, sexo, correo, telefono, direccion)
                    VALUES(@nombre, @apellidom, @apellidop, @tipopaciente, @matricula, @fecha, @sexo, @correo, @telefono, @direccion)";


                MySqlCommand command = new MySqlCommand(consulta, con);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellidop", apellidoP);
                command.Parameters.AddWithValue("@apellidom", apellidoM);
                command.Parameters.AddWithValue("@tipopaciente", tipoPaciente);
                command.Parameters.AddWithValue("@matricula", matricula);
                command.Parameters.AddWithValue("@fecha", fechaNacimiento);
                command.Parameters.AddWithValue("@sexo", sexo);
                command.Parameters.AddWithValue("@correo", correo);
                command.Parameters.AddWithValue("@telefono", telefono);
                command.Parameters.AddWithValue("@direccion", direccion);

                command.ExecuteNonQuery();

                MessageBox.Show("Paciente registrado exitosamente.");
                txtNombre.Text = "";
                txtApellidoP.Text = "";
                txtApellidoMa.Text = "";
                txtnum_Matricula.Text = "";
                cmbTipopaciente.SelectedIndex = -1;
                dtpFecha.Value = DateTime.Now;
                cmbsexo.SelectedIndex = -1;
                txtcorreo.Text = "";
                txttelefono.Text = "";
                txtdireccion.Text = "";



                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar paciente: " + ex.Message);
                con.Close();
            }
        }
    }
}
