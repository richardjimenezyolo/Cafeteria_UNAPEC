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
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Crear una instancia del segundo formulario
            Control form2 = new Control();

            // Cerrar el Form1
            //this.Close();

            if (txtUsername.Text != "admin" || txtPassword.Text != "password")
            {
                MessageBox.Show("Usiario o contraseña incorrecta");
                return;
            }

            // Mostrar el segundo formulario
            form2.Show();
        }
    }
}
