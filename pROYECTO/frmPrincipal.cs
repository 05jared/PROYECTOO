using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace pROYECTO
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            Frminiciar_sesion inicio = new Frminiciar_sesion();
            inicio.Owner = this;
            this.Hide();
            inicio.Show();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            Frmregistro registro = new Frmregistro();
            registro.Owner = this;
            this.Hide();
            registro.Show();
        }
    }
}
