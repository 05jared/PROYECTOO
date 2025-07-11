namespace pROYECTO
{
    partial class Frmregistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmregistro));
            lblNombre = new Label();
            lblcorreoelectronico = new Label();
            lblcontraseña = new Label();
            lblRol = new Label();
            btnRegistrar = new Button();
            txtnombre = new TextBox();
            txtCorreo = new TextBox();
            txtcontraseña = new TextBox();
            cmbrol = new ComboBox();
            btnregresar = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(429, 491);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(162, 22);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre completo:";
            // 
            // lblcorreoelectronico
            // 
            lblcorreoelectronico.AutoSize = true;
            lblcorreoelectronico.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcorreoelectronico.Location = new Point(429, 554);
            lblcorreoelectronico.Margin = new Padding(2, 0, 2, 0);
            lblcorreoelectronico.Name = "lblcorreoelectronico";
            lblcorreoelectronico.Size = new Size(169, 22);
            lblcorreoelectronico.TabIndex = 1;
            lblcorreoelectronico.Text = "correo electronico:";
            // 
            // lblcontraseña
            // 
            lblcontraseña.AutoSize = true;
            lblcontraseña.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcontraseña.Location = new Point(429, 606);
            lblcontraseña.Margin = new Padding(2, 0, 2, 0);
            lblcontraseña.Name = "lblcontraseña";
            lblcontraseña.Size = new Size(105, 22);
            lblcontraseña.TabIndex = 2;
            lblcontraseña.Text = "Contraseña";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRol.Location = new Point(429, 680);
            lblRol.Margin = new Padding(2, 0, 2, 0);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(42, 22);
            lblRol.TabIndex = 3;
            lblRol.Text = "Rol:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.ForestGreen;
            btnRegistrar.Location = new Point(627, 822);
            btnRegistrar.Margin = new Padding(2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(168, 58);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(649, 492);
            txtnombre.Margin = new Padding(2);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(251, 27);
            txtnombre.TabIndex = 5;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(649, 554);
            txtCorreo.Margin = new Padding(2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(251, 27);
            txtCorreo.TabIndex = 6;
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(649, 620);
            txtcontraseña.Margin = new Padding(2);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.Size = new Size(251, 27);
            txtcontraseña.TabIndex = 7;
            // 
            // cmbrol
            // 
            cmbrol.FormattingEnabled = true;
            cmbrol.Items.AddRange(new object[] { "Administrador", "Doctora", "Recepcionista" });
            cmbrol.Location = new Point(649, 680);
            cmbrol.Margin = new Padding(2);
            cmbrol.Name = "cmbrol";
            cmbrol.Size = new Size(251, 28);
            cmbrol.TabIndex = 8;
            // 
            // btnregresar
            // 
            btnregresar.BackColor = Color.ForestGreen;
            btnregresar.Location = new Point(40, 834);
            btnregresar.Margin = new Padding(2);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(130, 46);
            btnregresar.TabIndex = 9;
            btnregresar.Text = "Regresar";
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += btnregresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(196, 208);
            label1.Name = "label1";
            label1.Size = new Size(799, 42);
            label1.TabIndex = 11;
            label1.Text = "Bienvenidos al Sistema de Control de Pacientes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1170, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cuenta;
            pictureBox2.Location = new Point(429, 315);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(144, 123);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // Frmregistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1197, 925);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnregresar);
            Controls.Add(cmbrol);
            Controls.Add(txtcontraseña);
            Controls.Add(txtCorreo);
            Controls.Add(txtnombre);
            Controls.Add(btnRegistrar);
            Controls.Add(lblRol);
            Controls.Add(lblcontraseña);
            Controls.Add(lblcorreoelectronico);
            Controls.Add(lblNombre);
            Margin = new Padding(2);
            Name = "Frmregistro";
            Text = "Frmregistro";
            Load += Frmregistro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblcorreoelectronico;
        private Label lblcontraseña;
        private Label lblRol;
        private Button btnRegistrar;
        private TextBox txtnombre;
        private TextBox txtCorreo;
        private TextBox txtcontraseña;
        private ComboBox cmbrol;
        private Button btnregresar;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}