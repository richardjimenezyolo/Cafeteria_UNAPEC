namespace Cafeteria_UNAPEC
{
    partial class Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control));
            btnGCafeteria = new PictureBox();
            btnGCampus = new PictureBox();
            btnGUsuarios = new PictureBox();
            btnGProveedores = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnLogout = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnGCafeteria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnGCampus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnGUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnGProveedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLogout).BeginInit();
            SuspendLayout();
            // 
            // btnGCafeteria
            // 
            btnGCafeteria.Cursor = Cursors.Hand;
            btnGCafeteria.Image = (Image)resources.GetObject("btnGCafeteria.Image");
            btnGCafeteria.Location = new Point(26, 72);
            btnGCafeteria.Name = "btnGCafeteria";
            btnGCafeteria.Size = new Size(172, 162);
            btnGCafeteria.SizeMode = PictureBoxSizeMode.StretchImage;
            btnGCafeteria.TabIndex = 0;
            btnGCafeteria.TabStop = false;
            // 
            // btnGCampus
            // 
            btnGCampus.Cursor = Cursors.Hand;
            btnGCampus.Image = Properties.Resources.colegio;
            btnGCampus.Location = new Point(238, 72);
            btnGCampus.Name = "btnGCampus";
            btnGCampus.Size = new Size(172, 162);
            btnGCampus.SizeMode = PictureBoxSizeMode.StretchImage;
            btnGCampus.TabIndex = 1;
            btnGCampus.TabStop = false;
            // 
            // btnGUsuarios
            // 
            btnGUsuarios.Cursor = Cursors.Hand;
            btnGUsuarios.Image = Properties.Resources.usuario;
            btnGUsuarios.Location = new Point(238, 262);
            btnGUsuarios.Name = "btnGUsuarios";
            btnGUsuarios.Size = new Size(172, 162);
            btnGUsuarios.SizeMode = PictureBoxSizeMode.StretchImage;
            btnGUsuarios.TabIndex = 2;
            btnGUsuarios.TabStop = false;
            btnGUsuarios.Click += btnGUsuarios_Click;
            // 
            // btnGProveedores
            // 
            btnGProveedores.Cursor = Cursors.Hand;
            btnGProveedores.Image = Properties.Resources.cadena_de_suministro;
            btnGProveedores.Location = new Point(26, 262);
            btnGProveedores.Name = "btnGProveedores";
            btnGProveedores.Size = new Size(172, 162);
            btnGProveedores.SizeMode = PictureBoxSizeMode.StretchImage;
            btnGProveedores.TabIndex = 3;
            btnGProveedores.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ActiveCaption;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = Properties.Resources.button;
            pictureBox5.Location = new Point(749, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(39, 38);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.ActiveCaption;
            pictureBox6.Location = new Point(-5, -9);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(822, 73);
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 237);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 9;
            label1.Text = "Gestión Cafeteria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 237);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 10;
            label2.Text = "Campus";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(298, 426);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 12;
            label4.Text = "Usuarios";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 427);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 13;
            label3.Text = "Proveedores";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Image = Properties.Resources.logout;
            btnLogout.Location = new Point(749, 398);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(39, 38);
            btnLogout.SizeMode = PictureBoxSizeMode.Zoom;
            btnLogout.TabIndex = 14;
            btnLogout.TabStop = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 448);
            Controls.Add(btnLogout);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(btnGProveedores);
            Controls.Add(btnGUsuarios);
            Controls.Add(btnGCampus);
            Controls.Add(btnGCafeteria);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Control";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control";
            Load += Control_Load;
            ((System.ComponentModel.ISupportInitialize)btnGCafeteria).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnGCampus).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnGUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnGProveedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLogout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnGCafeteria;
        private PictureBox btnGCampus;
        private PictureBox btnGUsuarios;
        private PictureBox btnGProveedores;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private PictureBox btnLogout;
    }
}