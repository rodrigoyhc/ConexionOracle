using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ConexionOracle
{
    public partial class InsAtleta : Form
    {
        int id = 0;
        bool bandera = false;
        Conexion dt;
        string user;
        string password;

        public InsAtleta(string usuario, string contraseña)
        {
            InitializeComponent();
            
            user = usuario;
            password = contraseña;
            CargarEntrenadores();
        }

        public InsAtleta(string usuario, string contraseña, int Id, int idEntrenador, string Nombre, string Apellido, string fechaNacimiento,
                        string genero, string direccion, string pais, int creditos)
        {
            InitializeComponent();
            
            user = usuario;
            password = contraseña;

            id = Id;

            cmbEntrenador.SelectedValue = idEntrenador;
            
            TXTNombre.Text = Nombre;
            TXTApellido.Text = Apellido;
            DTMFecNac.Text = fechaNacimiento;
            contCreditos.Text = creditos.ToString();

            if (genero == "Masculino")
                radioMasculino.Checked = true;
            else if (genero == "Femenino")
                radioFemenino.Checked = true;

            TXTDireccion.Text = direccion;
            TXTPais.Text = pais;
            bandera = true;
            CargarEntrenadores();
        }

        private void BTNInsertar_Click(object sender, EventArgs e)
        {
            dt = new Conexion();
            string genero = radioMasculino.Checked ? "Masculino" :
                radioFemenino.Checked ? "Femenino" : "";

            if (bandera == true) // Actualizar
            {
                string Nombre = TXTNombre.Text;
                string Apellido = TXTApellido.Text;
                DateTime fechaNacimiento = DTMFecNac.Value;
                string direccion = TXTDireccion.Text;
                string pais = TXTPais.Text;
                int creditos = Convert.ToInt32(contCreditos.Text);

                using (OracleConnection conn = dt.conexion(user, password))
                {
                    using (OracleCommand cmd = new OracleCommand(
                        "UPDATE Atletas SET " +
                        "id_entrenador = :idEntrenador, " +
                        "nombre = :nombre, " +
                        "apellido = :apellido, " +
                        "fecha_nacimiento = :fecha, " +
                        "genero = :genero, " +
                        "direccion = :direccion, " +
                        "pais = :pais, " +
                        "creditos = :creditos " +
                        "WHERE id_atleta = :id", conn))
                    {
                        cmd.Parameters.Add(":idEntrenador", OracleDbType.Int32).Value = cmbEntrenador.SelectedValue;
                        cmd.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = Nombre;
                        cmd.Parameters.Add(":apellido", OracleDbType.Varchar2).Value = Apellido;
                        cmd.Parameters.Add(":fecha", OracleDbType.Date).Value = fechaNacimiento;
                        cmd.Parameters.Add(":genero", OracleDbType.Varchar2).Value = genero;
                        cmd.Parameters.Add(":direccion", OracleDbType.Varchar2).Value = direccion;
                        cmd.Parameters.Add(":pais", OracleDbType.Varchar2).Value = pais;
                        cmd.Parameters.Add(":creditos", OracleDbType.Int32).Value = creditos;
                        cmd.Parameters.Add(":id", OracleDbType.Int32).Value = id;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Atleta actualizado correctamente");
                this.Close();
            }
            else if (bandera == false) // Insertar
            {
                int creditos = Convert.ToInt32(contCreditos.Text);
                try
                {
                    using (OracleConnection conn = dt.conexion(user, password))
                    {

                        using (OracleCommand cmd = new OracleCommand(
                            "INSERT INTO Atletas " +
                            "(id_entrenador, nombre, apellido, fecha_nacimiento, genero, direccion, pais, creditos) " +
                            "VALUES (:idEntrenador, :nombre, :apellido, :fecha, :genero, :direccion, :pais, :creditos)", conn))
                        {
                            cmd.Parameters.Add(":idEntrenador", OracleDbType.Int32).Value = cmbEntrenador.SelectedValue;
                            cmd.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = TXTNombre.Text;
                            cmd.Parameters.Add(":apellido", OracleDbType.Varchar2).Value = TXTApellido.Text;
                            cmd.Parameters.Add(":fecha", OracleDbType.Date).Value = DTMFecNac.Value;
                            cmd.Parameters.Add(":genero", OracleDbType.Varchar2).Value = genero;
                            cmd.Parameters.Add(":direccion", OracleDbType.Varchar2).Value = TXTDireccion.Text;
                            cmd.Parameters.Add(":pais", OracleDbType.Varchar2).Value = TXTPais.Text;
                            cmd.Parameters.Add(":creditos", OracleDbType.Int32).Value = creditos;

                            cmd.ExecuteNonQuery();
                        }
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show(ex + "");
                }

                //MessageBox.Show("Atleta registrado correctamente");
                this.Close();
            }
        }


        private void CargarEntrenadores()
        {
            dt = new Conexion();
            using (OracleConnection conn = dt.conexion(user, password))
            {
                try
                {

                    string query = "SELECT id_entrenador, nombre || ' ' || apellido AS nombre_completo FROM Entrenador";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            cmbEntrenador.DataSource = dataTable;
                            cmbEntrenador.DisplayMember = "nombre_completo";
                            cmbEntrenador.ValueMember = "id_entrenador";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar entrenadores: " + ex.Message);
                }
            }
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            if (bandera && MessageBox.Show("¿Eliminar este atleta?", "Confirmar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dt = new Conexion();
                using (OracleConnection conn = dt.conexion(user, password))
                {
                    using (OracleCommand cmd = new OracleCommand(
                        "DELETE FROM Atletas WHERE id_atleta = :id", conn))
                    {
                        cmd.Parameters.Add(":id", OracleDbType.Int32).Value = id;
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Atleta eliminado correctamente");
                this.Close();
            }
        }
    }
}