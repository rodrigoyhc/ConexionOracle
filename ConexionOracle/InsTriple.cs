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
    public partial class InsTriple : Form
    {
        Conexion dt;
        string user;
        string password;

        public InsTriple(string usuario, string contraseña)
        {
            InitializeComponent();
            user = usuario;
            password = contraseña;
            CargarAtletas();
            CargarDisciplinas();
        }

        private void CargarAtletas()
        {
            dt = new Conexion();
            using (OracleConnection conn = dt.conexion(user, password))
            {
                string query = "SELECT id_atleta, nombre || ' ' || apellido AS nombre_completo FROM Atletas";
                using (OracleDataAdapter adapter = new OracleDataAdapter(query, conn))
                {
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    cmbAtleta.DataSource = data;
                    cmbAtleta.DisplayMember = "nombre_completo";
                    cmbAtleta.ValueMember = "id_atleta";
                }
            }
        }

        private void CargarDisciplinas()
        {
            dt = new Conexion();
            using (OracleConnection conn = dt.conexion(user, password))
            {
                string query = "SELECT id_disciplina, nombre_disciplina FROM Disciplinas";
                using (OracleDataAdapter adapter = new OracleDataAdapter(query, conn))
                {
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    cmbDisciplina.DataSource = data;
                    cmbDisciplina.DisplayMember = "nombre_disciplina";
                    cmbDisciplina.ValueMember = "id_disciplina";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idAtleta = Convert.ToInt32(cmbAtleta.SelectedValue);
            int idDisciplina = Convert.ToInt32(cmbDisciplina.SelectedValue);
            DateTime fecha = dtpFecha.Value;
            string horasStr = txtHoras.Text.Trim();
            string observaciones = txtObs.Text.Trim();

            if (!decimal.TryParse(horasStr, out decimal horas) || horas < 0)
            {
                MessageBox.Show("Horas no válidas.");
                return;
            }

            dt = new Conexion();
            using (OracleConnection conn = dt.conexion(user, password))
            {
                using (OracleCommand cmd = new OracleCommand(
                    "INSERT INTO Atleta_Disciplina_Horas (id_atleta, id_disciplina, fecha_registro, horas_realizadas, observaciones) " +
                    "VALUES (:idA, :idD, :fecha, :horas, :obs)", conn))
                {
                    cmd.Parameters.Add(":idA", OracleDbType.Int32).Value = idAtleta;
                    cmd.Parameters.Add(":idD", OracleDbType.Int32).Value = idDisciplina;
                    cmd.Parameters.Add(":fecha", OracleDbType.Date).Value = fecha;
                    cmd.Parameters.Add(":horas", OracleDbType.Decimal).Value = horas;
                    cmd.Parameters.Add(":obs", OracleDbType.Varchar2).Value = observaciones;

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro insertado correctamente.");
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show("Error al insertar: " + ex.Message);
                    }
                }
            }
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idAtleta = Convert.ToInt32(cmbAtleta.SelectedValue);
            int idDisciplina = Convert.ToInt32(cmbDisciplina.SelectedValue);
            DateTime fecha = dtpFecha.Value;


            dt = new Conexion();
            using (OracleConnection conn = dt.conexion(user, password))
            {
                using (OracleCommand cmd = new OracleCommand(
                    "DELETE FROM Atleta_Disciplina_Horas " +
                    "WHERE id_atleta = :idA AND id_disciplina = :idD AND fecha_registro = :fecha", conn))
                {
                    cmd.Parameters.Add(":idA", OracleDbType.Int32).Value = idAtleta;
                    cmd.Parameters.Add(":idD", OracleDbType.Int32).Value = idDisciplina;
                    cmd.Parameters.Add(":fecha", OracleDbType.Date).Value = fecha;

                    try
                    {
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Registro eliminado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró un registro con los datos proporcionados.");
                        }
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message);
                    }
                }
            }
            this.Close();
        }
    }
}
