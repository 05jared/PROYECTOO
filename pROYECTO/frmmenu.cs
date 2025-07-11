using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pROYECTO
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void FrmRegistro_pacientes_Load(object sender, EventArgs e)
        {

        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            FrmRegistro_pacientes registro = new FrmRegistro_pacientes();
            registro.Owner = this;
            this.Hide();
            registro.Show();
        }
    }
}
