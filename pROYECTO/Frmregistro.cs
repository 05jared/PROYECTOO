using System;
using System.Collections;
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
    public partial class Frmregistro : Form
    {
        Clsconeccion connecion = new Clsconeccion();
        MySqlConnection con;

        public Frmregistro()
        {
            InitializeComponent();
        }
        private void Frmregistro_Load(object sender, EventArgs e)
        {
            connecion = new Clsconeccion();
            con = connecion.GetConnection();
            con.Close();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            string nombre = txtnombre.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string contrasena = txtcontraseña.Text.Trim();
            string rol = cmbrol.SelectedItem != null ? cmbrol.SelectedItem.ToString() : "";

            if (nombre == "" || correo == "" || contrasena == "" || rol == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();

                string consulta = "INSERT INTO usuarios (nombre, correo, contrasena, rol) VALUES (@nombre, @correo, @contrasena, @rol)";
                MySqlCommand cmd = new MySqlCommand(consulta, con);

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);
                cmd.Parameters.AddWithValue("@rol", rol);

                int resultado = cmd.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Registro exitoso.", "Correcto");
                    txtnombre.Clear();
                    txtCorreo.Clear();
                    txtcontraseña.Clear();
                    cmbrol.SelectedIndex = -1;
                    con.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el usuario.", "Error");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: ");
                con.Close();
            }




        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}

