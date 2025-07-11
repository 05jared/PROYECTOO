namespace pROYECTO
{
    partial class Frminiciar_sesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frminiciar_sesion));
            lblcorreo = new Label();
            label2 = new Label();
            txtcorreo = new TextBox();
            txtcontraseña = new TextBox();
            btniniciar = new Button();
            btnregresar = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblcorreo
            // 
            lblcorreo.AutoSize = true;
            lblcorreo.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcorreo.Location = new Point(227, 395);
            lblcorreo.Margin = new Padding(2, 0, 2, 0);
            lblcorreo.Name = "lblcorreo";
            lblcorreo.Size = new Size(257, 22);
            lblcorreo.TabIndex = 0;
            lblcorreo.Text = "ingresa tu correo electronico ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(227, 487);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(191, 22);
            label2.TabIndex = 1;
            label2.Text = "ingresa tu contraseña";
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(501, 393);
            txtcorreo.Margin = new Padding(2);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(297, 27);
            txtcorreo.TabIndex = 2;
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(501, 482);
            txtcontraseña.Margin = new Padding(2);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.Size = new Size(297, 27);
            txtcontraseña.TabIndex = 3;
            // 
            // btniniciar
            // 
            btniniciar.BackColor = Color.ForestGreen;
            btniniciar.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btniniciar.Location = new Point(581, 577);
            btniniciar.Margin = new Padding(2);
            btniniciar.Name = "btniniciar";
            btniniciar.Size = new Size(125, 36);
            btniniciar.TabIndex = 4;
            btniniciar.Text = "Iniciar ";
            btniniciar.UseVisualStyleBackColor = false;
            btniniciar.Click += btniniciar_Click;
            // 
            // btnregresar
            // 
            btnregresar.BackColor = Color.ForestGreen;
            btnregresar.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnregresar.Location = new Point(27, 592);
            btnregresar.Margin = new Padding(2);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(131, 40);
            btnregresar.TabIndex = 5;
            btnregresar.Text = "Regresar";
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += btnregresar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cuenta;
            pictureBox2.Location = new Point(241, 247);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(144, 123);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(227, 167);
            label1.Name = "label1";
            label1.Size = new Size(799, 42);
            label1.TabIndex = 13;
            label1.Text = "Bienvenidos al Sistema de Control de Pacientes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1170, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Frminiciar_sesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1197, 657);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(btnregresar);
            Controls.Add(btniniciar);
            Controls.Add(txtcontraseña);
            Controls.Add(txtcorreo);
            Controls.Add(label2);
            Controls.Add(lblcorreo);
            Margin = new Padding(2);
            Name = "Frminiciar_sesion";
            Text = "Frminiciar_sesion";
            Load += Frminiciar_sesion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcorreo;
        private Label label2;
        private TextBox txtcorreo;
        private TextBox txtcontraseña;
        private Button btniniciar;
        private Button btnregresar;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}