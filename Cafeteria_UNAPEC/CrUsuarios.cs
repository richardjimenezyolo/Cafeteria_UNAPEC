﻿using System;
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
    public partial class CrUsuarios : Form
    {
        public CrUsuarios()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Registro_Usuarios rUsuarios = new Registro_Usuarios();
            rUsuarios.Show();
        }
    }
}
