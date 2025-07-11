namespace pROYECTO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnusuarios = new Button();
            btnadmin = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnusuarios
            // 
            btnusuarios.BackColor = Color.ForestGreen;
            btnusuarios.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnusuarios.Location = new Point(536, 456);
            btnusuarios.Margin = new Padding(2);
            btnusuarios.Name = "btnusuarios";
            btnusuarios.Size = new Size(168, 49);
            btnusuarios.TabIndex = 0;
            btnusuarios.Text = "Iniciar sesion";
            btnusuarios.UseVisualStyleBackColor = false;
            btnusuarios.Click += btnusuarios_Click;
            // 
            // btnadmin
            // 
            btnadmin.BackColor = Color.ForestGreen;
            btnadmin.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnadmin.Location = new Point(536, 559);
            btnadmin.Margin = new Padding(2);
            btnadmin.Name = "btnadmin";
            btnadmin.Size = new Size(168, 50);
            btnadmin.TabIndex = 1;
            btnadmin.Text = "Registrarse";
            btnadmin.UseVisualStyleBackColor = false;
            btnadmin.Click += btnadmin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1170, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 201);
            label1.Name = "label1";
            label1.Size = new Size(799, 42);
            label1.TabIndex = 3;
            label1.Text = "Bienvenidos al Sistema de Control de Pacientes";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cuenta;
            pictureBox2.Location = new Point(548, 284);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(144, 123);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1194, 688);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnadmin);
            Controls.Add(btnusuarios);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvregistro;
        private Button btnusuarios;
        private Button btnadmin;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
    }
}
