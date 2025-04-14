using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria_UNAPEC
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Mostrar el formulario de login nuevamente
            login login = new login();
            login.Show();

            // Cerrar el formulario actual
            this.Close(); // O puedes usar this.Hide(); si quieres mantenerlo en segundo plano
        }

        private void Control_Load(object sender, EventArgs e)
        {

        }

        private void btnGUsuarios_Click(object sender, EventArgs e)
        {
            CrUsuarios fUsuarios = new CrUsuarios();
            fUsuarios.Show();
        }
    }
}
