namespace pROYECTO
{
    partial class FrmBuscarPacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblbuscar = new Label();
            txtBusqueda = new TextBox();
            btnBuscar = new Button();
            btnSeleccionar = new Button();
            btncancelar = new Button();
            dgvPacientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // lblbuscar
            // 
            lblbuscar.AutoSize = true;
            lblbuscar.Location = new Point(119, 219);
            lblbuscar.Name = "lblbuscar";
            lblbuscar.Size = new Size(284, 25);
            lblbuscar.TabIndex = 0;
            lblbuscar.Text = "Busca por nombre o por matricula";
            lblbuscar.Click += label1_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(427, 213);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(217, 31);
            txtBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(737, 210);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(198, 725);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(112, 34);
            btnSeleccionar.TabIndex = 3;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(952, 725);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(112, 34);
            btncancelar.TabIndex = 4;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            // 
            // dgvPacientes
            // 
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(219, 367);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.RowHeadersWidth = 62;
            dgvPacientes.Size = new Size(895, 296);
            dgvPacientes.TabIndex = 5;
            // 
            // FrmBuscarPacientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1515, 825);
            Controls.Add(dgvPacientes);
            Controls.Add(btncancelar);
            Controls.Add(btnSeleccionar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBusqueda);
            Controls.Add(lblbuscar);
            Name = "FrmBuscarPacientes";
            Text = "FrmBuscarPacientes";
            Load += FrmBuscarPacientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblbuscar;
        private TextBox txtBusqueda;
        private Button btnBuscar;
        private Button btnSeleccionar;
        private Button btncancelar;
        private DataGridView dgvPacientes;
    }
}