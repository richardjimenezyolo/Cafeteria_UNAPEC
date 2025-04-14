namespace Cafeteria_UNAPEC
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            IniciarSesionConProgreso();
            btnLogin.BackColor = Color.FromArgb(46, 204, 113); // Es un verde "moderno", tipo Bootstrap "success"
            btnLogin.ForeColor = Color.White;

            btnLogin.Enabled = false; // Desactiva el bot�n para evitar m�ltiples clics
            btnLogin.Text = "Verificando...";

            // Simula un proceso que toma 2 segundos
            await Task.Delay(2000);

            string usuario = txtUsername.Text.Trim();
            string contrasena = txtPassword.Text;

            // Aqu� podr�as conectarte a una base de datos en el futuro.
            // Por ahora, usamos usuarios predefinidos
            if (usuario == "admin" && contrasena == "1234")
            {
                // Abrir otro formulario, por ejemplo:
                new Control().Show();
                this.Hide();
            }
            else
            {
                btnLogin.BackColor = Color.FromArgb(52, 152, 219); // Azul moderno
                btnLogin.ForeColor = Color.White;
                // Simula un proceso que toma 2 segundos
                await Task.Delay(2000);
                btnLogin.Text = "Verificando...";
                MessageBox.Show("Usuario o contrase�a incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtUsername.Focus();
            }

            btnLogin.Enabled = true;
            btnLogin.Text = "Iniciar";
        }

        private void chkMostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {

        }

        private bool mostrarContrasena = false; // estado inicial

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            mostrarContrasena = !mostrarContrasena;

            txtPassword.UseSystemPasswordChar = !mostrarContrasena;

            // Cambiar imagen si tienes dos �conos diferentes (opcional)
            if (mostrarContrasena)
            {
                pictureBox4.Image = Properties.Resources.ver; // cambia por tu imagen
            }
            else
            {
                pictureBox4.Image = Properties.Resources.esconder; // cambia por tu imagen
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true; // Para ocultar la contrase�a al inicio
            btnLogin.BackColor = Color.FromArgb(52, 152, 219); // Azul moderno
            btnLogin.ForeColor = Color.White;

            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Visible = false; // Opcional: ocultarla hasta que inicie

        }


        public async void IniciarSesionConProgreso()
        {
            btnLogin.Enabled = false;
            progressBar1.Value = 0;
            progressBar1.Visible = true;

            int tiempoTotal = 2000; // Total del delay (2 segundos)
            int pasos = 100; // Cantidad de pasos de la barra
            int delayPorPaso = tiempoTotal / pasos;

            for (int i = 0; i <= pasos; i++)
            {
                progressBar1.Value = i;
                await Task.Delay(delayPorPaso);
            }

            // Verificaci�n de usuario y contrase�a
            string usuario = txtUsername.Text.Trim();
            string contrasena = txtPassword.Text;

            progressBar1.Visible = false;
            progressBar1.Value = 0;
            btnLogin.Enabled = true;
        }

    }
}
