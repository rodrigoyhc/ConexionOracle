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
    public partial class InsDisciplina : Form
    {
        int id = 0;
        bool bandera = false;
        Conexion dt;
        string user;
        string password;

        public InsDisciplina(string usuario, string contraseña)
        {
            InitializeComponent();
            user = usuario;
            password = contraseña;
            CargarEntrenadores();
        }

        public InsDisciplina(string usuario, string contraseña, int Id,string nombre_disciplina,int creditos,
                             int horasMinimas, string descripcion, int idEntrenador)
        {
            InitializeComponent();
            user = usuario;
            password = contraseña;
            TXTNombre.Text = nombre_disciplina;
            id = Id;
            disCreditos.Text = creditos.ToString();
            disHoras.Text = horasMinimas.ToString();
            disDescricion.Text = descripcion;
            cmbEntrenador.SelectedValue = idEntrenador;
            bandera = true;
            CargarEntrenadores();
        }

        private void BTNInsertar_Click_1(object sender, EventArgs e)
        {
            dt = new Conexion();

            if (bandera == true) // Actualizar
            {
                string nombre = TXTNombre.Text;
                int creditos = Convert.ToInt32(disCreditos.Text);
                int horasMinimas = Convert.ToInt32(disHoras.Text);
                string descripcion = disDescricion.Text;
                int idEntrenador = Convert.ToInt32(cmbEntrenador.SelectedValue);

                using (OracleConnection conn = dt.conexion(user, password))
                {
                    using (OracleCommand cmd = new OracleCommand(
                        "UPDATE Disciplinas SET " +
                        "nombre_disciplina = :nombre, " +
                        "creditos = :creditos, " +
                        "horas_minimas = :horasMinimas, " +
                        "descripcion = :descripcion, " +
                        "id_entrenador = :idEntrenador " +
                        "WHERE id_disciplina = :id", conn))
                    {
                        cmd.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = nombre;
                        cmd.Parameters.Add(":creditos", OracleDbType.Int32).Value = creditos;
                        cmd.Parameters.Add(":horasMinimas", OracleDbType.Int32).Value = horasMinimas;
                        cmd.Parameters.Add(":descripcion", OracleDbType.Varchar2).Value = descripcion;
                        cmd.Parameters.Add(":idEntrenador", OracleDbType.Int32).Value = idEntrenador;
                        cmd.Parameters.Add(":id", OracleDbType.Int32).Value = id;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Disciplina actualizada correctamente");
                this.Close();
            }
            else // Insertar
            {
                string nombre = TXTNombre.Text;
                int creditos = Convert.ToInt32(disCreditos.Text);
                int horasMinimas = Convert.ToInt32(disHoras.Text);
                string descripcion = disDescricion.Text;
                int idEntrenador = Convert.ToInt32(cmbEntrenador.SelectedValue);

                using (OracleConnection conn = dt.conexion(user, password))
                {
                    using (OracleCommand cmd = new OracleCommand(
                        "INSERT INTO Disciplinas " +
                        "(nombre_disciplina, creditos, horas_minimas, descripcion, id_entrenador) " +
                        "VALUES (:nombre, :creditos, :horasMinimas, :descripcion, :idEntrenador)", conn))
                    {
                        cmd.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = nombre;
                        cmd.Parameters.Add(":creditos", OracleDbType.Int32).Value = creditos;
                        cmd.Parameters.Add(":horasMinimas", OracleDbType.Int32).Value = horasMinimas;
                        cmd.Parameters.Add(":descripcion", OracleDbType.Varchar2).Value = descripcion;
                        cmd.Parameters.Add(":idEntrenador", OracleDbType.Int32).Value = idEntrenador;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Disciplina registrada correctamente");
                this.Close();
            }

        }

        private void CargarEntrenadores()
        {
            dt = new Conexion();
            using (OracleConnection conn = dt.conexion(user, password))
            {
                string query = "SELECT id_entrenador, nombre || ' ' || " +
                "apellido as nombre_completo FROM Entrenador";

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
        }

     

        private void BTNEliminar_Click_1(object sender, EventArgs e)
        {
            if (bandera && MessageBox.Show("¿Eliminar esta disciplina?", "Confirmar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dt = new Conexion();
                using (OracleConnection conn = dt.conexion(user, password))
                {
                    using (OracleCommand cmd = new OracleCommand(
                        "DELETE FROM Disciplinas WHERE id_disciplina = :id", conn))
                    {
                        cmd.Parameters.Add(":id", OracleDbType.Int32).Value = id;
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Disciplina eliminada correctamente");
                this.Close();
            }
        }
    }
}

   
