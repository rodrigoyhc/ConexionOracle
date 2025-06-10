using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionOracle
{
    public partial class FRMInicioSesion : Form
    {
        Conexion dt;
        public FRMInicioSesion()
        {
            InitializeComponent();
            TXTContraseña.PasswordChar = '*';
        }

        private void PBOcultar_Click(object sender, EventArgs e)
        {
            PBMostrar.BringToFront();
            TXTContraseña.PasswordChar = '\0';
        }

        private void PBMostrar_Click(object sender, EventArgs e)
        {
            PBOcultar.BringToFront();
            TXTContraseña.PasswordChar = '*';

        }

        private void BTNInicio_Click(object sender, EventArgs e)
        {
            dt = new Conexion();
            dt.conexion(TXTUsuario.Text, TXTContraseña.Text);
            if (dt.conexion(TXTUsuario.Text, TXTContraseña.Text) == null)
            {
                MessageBox.Show("Error al conectar");
            }
            else
            {
                Form1 frm1 = new Form1(TXTUsuario.Text, TXTContraseña.Text);
                frm1.Show();
                this.Hide();
            }
            

        }

        private void PBOcultar_Click_1(object sender, EventArgs e)
        {
            PBMostrar.BringToFront();
            TXTContraseña.PasswordChar = '\0';
        }

        private void FRMInicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
