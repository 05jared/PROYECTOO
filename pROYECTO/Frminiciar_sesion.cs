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
    public partial class Frminiciar_sesion : Form
    {
        private static FrmRegistro_pacientes registroInstancia; //Sirve para controlar la instancia abierta
        private static string correoActivo = "";
        Clsconeccion coneccion;
        MySqlConnection con;
        public Frminiciar_sesion()
        {
            InitializeComponent();
        }


        private void Frminiciar_sesion_Load(object sender, EventArgs e)
        {
            coneccion = new Clsconeccion();
            con = coneccion.GetConnection();
            con.Close();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            string correo = txtcorreo.Text.Trim();
            string contrasena = txtcontraseña.Text.Trim();

            if (correo == "" || contrasena == "")
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return; // Salir si falta info
            }

            try
            {
                con.Open();

                string consulta = "SELECT * FROM usuarios WHERE correo = @correo";
                MySqlCommand command = new MySqlCommand(consulta, con);
                command.Parameters.AddWithValue("@correo", correo);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string passBD = reader["contrasena"].ToString();

                    if (contrasena == passBD) // comparación simple
                    {
                        string nombre = reader["nombre"].ToString();
                        MessageBox.Show("Acceso correcto \nBienvenido " + nombre);

                        if (registroInstancia == null || registroInstancia.IsDisposed || correoActivo != correo)
                        {
                            registroInstancia = new FrmRegistro_pacientes();
                            correoActivo = correo;

                            registroInstancia.Show();

                        }
                        else
                        {
                            // Ya está abierto, solo mostrarlo
                            registroInstancia.BringToFront();
                            registroInstancia.WindowState = FormWindowState.Normal;
                            registroInstancia.Activate();
                        }
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta");
                    }
                }
                else
                {
                    MessageBox.Show("Correo no encontrado");
                }

                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}
