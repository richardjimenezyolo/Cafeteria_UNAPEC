namespace Cafeteria_UNAPEC
{
    partial class CrUsuarios
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnEliminar = new Button();
            btnCrear = new Button();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox6 = new PictureBox();
            txtUsername = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 296);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(61, 76);
            label1.Name = "label1";
            label1.Size = new Size(27, 21);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Brown;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.Transparent;
            btnEliminar.Location = new Point(696, 92);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(93, 44);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.ForestGreen;
            btnCrear.Cursor = Cursors.Hand;
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCrear.ForeColor = Color.Transparent;
            btnCrear.Location = new Point(597, 92);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(93, 44);
            btnCrear.TabIndex = 21;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Sienna;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(264, 92);
            button1.Name = "button1";
            button1.Size = new Size(76, 44);
            button1.TabIndex = 22;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.buscar;
            pictureBox3.Location = new Point(12, 95);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.ActiveCaption;
            pictureBox6.Location = new Point(0, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(800, 62);
            pictureBox6.TabIndex = 24;
            pictureBox6.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtUsername.Location = new Point(61, 100);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Usuario";
            txtUsername.RightToLeft = RightToLeft.No;
            txtUsername.Size = new Size(197, 29);
            txtUsername.TabIndex = 25;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.button;
            pictureBox1.Location = new Point(749, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // CrUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox3);
            Controls.Add(button1);
            Controls.Add(btnCrear);
            Controls.Add(btnEliminar);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CrUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrUsuarios";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnEliminar;
        private Button btnCrear;
        private Button button1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private TextBox txtUsername;
        private PictureBox pictureBox1;
    }
}