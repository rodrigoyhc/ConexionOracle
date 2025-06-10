using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ConexionOracle
{
    public partial class InsEntrenador : Form
    {
        int id = 0;
        bool bandera = false;
        Conexion dt;
        string user;
        string password;
        public InsEntrenador(string usuario, string contraseña)
        {
            InitializeComponent();
            user = usuario;
            password = contraseña;

        }

        public InsEntrenador(string usuario, string contraseña, int Id, string Nombre, string Apellido, string fechaNacimiento, string direccion,
            string telefono, string correo, string pais)
        {
            InitializeComponent();
            user = usuario;
            password = contraseña;
            id = Id;
            TXTNombre.Text = Nombre;
            TXTApellido.Text = Apellido;
            DTMFecNac.Text = fechaNacimiento;
            TXTDireccion.Text = direccion;
            TXTTelefono.Text = telefono;
            TXTCorreo.Text = correo;
            TXTPais.Text = pais;
            bandera = true;
        }

     

        private void BTNInsertar_Click(object sender, EventArgs e)
        {
            dt = new Conexion();
            if (bandera == true)
            {
                //Actualizar
                string Nombre = TXTNombre.Text;
                string Apellido = TXTApellido.Text;
                DateTime fechaNacimiento = DTMFecNac.Value;
                string direccion = TXTDireccion.Text;
                string telefono = TXTTelefono.Text;
                string correo = TXTCorreo.Text;
                string pais = TXTPais.Text;

                using (OracleConnection conn = dt.conexion(user, password)) // Asume que tienes un método para obtener la conexión
                {

                    using (OracleCommand cmd = new OracleCommand("UPDATE Entrenador SET nombre = :nombre, apellido = :apellido," +
                        " fecha_nacimiento = :fecha, direccion= :direccion, telefono= :telefono, correo_electronico=:correo," +
                        " pais=:pais WHERE id_entrenador = :id", conn))
                    {
                        cmd.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = Nombre;
                        cmd.Parameters.Add(":apellido", OracleDbType.Varchar2).Value = Apellido;
                        cmd.Parameters.Add(":fecha", OracleDbType.Date).Value = fechaNacimiento;
                        cmd.Parameters.Add(":direccion", OracleDbType.Varchar2).Value = direccion;
                        cmd.Parameters.Add(":telefono", OracleDbType.Varchar2).Value = telefono;
                        cmd.Parameters.Add(":correo", OracleDbType.Varchar2).Value = correo;
                        cmd.Parameters.Add(":pais", OracleDbType.Varchar2).Value = pais;
                        cmd.Parameters.Add(":id", OracleDbType.Varchar2).Value = id;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Tabla Actualizada");
            }
            else if(bandera == false)
            {
                //Insertar
                string Nombre = TXTNombre.Text;
                string Apellido = TXTApellido.Text;
                DateTime fechaNacimiento = DTMFecNac.Value;
                string direccion = TXTDireccion.Text;
                string telefono = TXTTelefono.Text;
                string correo = TXTCorreo.Text;
                string pais = TXTPais.Text;

                using (OracleConnection conn = dt.conexion(user, password)) // Asume que tienes un método para obtener la conexión
                {

                    using (OracleCommand cmd = new OracleCommand("INSERT INTO Entrenador (nombre, apellido, fecha_nacimiento, direccion, telefono, correo_electronico, pais) " +
                                                                 "VALUES (:nombre, :apellido, :fecha, :direccion, :telefono, :correo, :pais)", conn))
                    {
                        cmd.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = Nombre;
                        cmd.Parameters.Add(":apellido", OracleDbType.Varchar2).Value = Apellido;
                        cmd.Parameters.Add(":fecha", OracleDbType.Date).Value = fechaNacimiento;
                        cmd.Parameters.Add(":direccion", OracleDbType.Varchar2).Value = direccion;
                        cmd.Parameters.Add(":telefono", OracleDbType.Varchar2).Value = telefono;
                        cmd.Parameters.Add(":correo", OracleDbType.Varchar2).Value = correo;
                        cmd.Parameters.Add(":pais", OracleDbType.Varchar2).Value = pais;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Tabla Actualizada");
            }

            this.Close();
        }

        private void TXTNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TXTDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
