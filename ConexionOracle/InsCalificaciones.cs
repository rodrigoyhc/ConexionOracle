using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ConexionOracle
{
    public partial class InsCalificaciones : Form
    {
        int idCalificacion = 0;
        bool bandera = false; // false = insertar, true = actualizar
        Conexion dt;
        DataSet ds;
        string user;
        string password;

        public InsCalificaciones(string usuario, string contraseña)
        {
            InitializeComponent();
            user = usuario;
            password = contraseña;
            CargarAtletas();
            CargarDisciplinas();
        }

     
        public InsCalificaciones(string usuario, string contraseña, int id_calificacion, string id_atleta,
                         string id_disciplina, decimal calificacion, DateTime fecha_evaluacion)
        {
            InitializeComponent();
            user = usuario;
            password = contraseña;
            cmbAtleta.ValueMember = "id_atleta";
            cmbDisciplina.ValueMember = "id_disciplina";

            CargarAtletas();
            CargarDisciplinas();

            numCalificacion.Value = calificacion;
            dtpFechaEvaluacion.Value = fecha_evaluacion;
            idCalificacion = id_calificacion;
            bandera = true;
        }



        private void CargarAtletas()
        {
            dt = new Conexion();
            using (OracleConnection conn = dt.conexion(user, password))
            {
                string query = "SELECT id_atleta, nombre || ' ' || apellido AS nombre_completo FROM Atletas";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dtAtletas = new DataTable();
                        adapter.Fill(dtAtletas);

                        cmbAtleta.DataSource = dtAtletas;
                        cmbAtleta.DisplayMember = "nombre_completo";
                        cmbAtleta.ValueMember = "id_atleta";
                    }
                }
            }
        }

        private void CargarDisciplinas()
        {
            dt = new Conexion();
            using (OracleConnection conn = dt.conexion(user, password))
            {
                string query = "SELECT id_disciplina, nombre_disciplina FROM Disciplinas"; // CAMBIADO
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dtDisciplinas = new DataTable();
                        adapter.Fill(dtDisciplinas);

                        cmbDisciplina.DataSource = dtDisciplinas;
                        cmbDisciplina.DisplayMember = "nombre_disciplina"; // CAMBIADO
                        cmbDisciplina.ValueMember = "id_disciplina";
                    }
                }
            }
        }

 
        private void BTNInsertar_Click(object sender, EventArgs e)
        {
            dt = new Conexion();

            int idAtleta = Convert.ToInt32(cmbAtleta.SelectedValue);
            int idDisciplina = Convert.ToInt32(cmbDisciplina.SelectedValue);
            decimal calificacion = numCalificacion.Value;
            DateTime fechaEvaluacion = dtpFechaEvaluacion.Value;

            using (OracleConnection conn = dt.conexion(user, password))
            {
                OracleCommand cmd;

                if (bandera) // Actualizar
                {
                    // CORRECCIÓN: Usar directamente los SelectedValue ya convertidos
                    cmd = new OracleCommand(
                        "UPDATE Calificaciones SET " +
                        "id_atleta = :idAtleta, " +
                        "id_disciplina = :idDisciplina, " +
                        "calificacion = :calificacion, " +
                        "fecha_evaluacion = :fechaEval " +
                        "WHERE id_calificacion = :idCalificacion", conn);

                    cmd.Parameters.Add(":idAtleta", OracleDbType.Int32).Value = idAtleta;
                    cmd.Parameters.Add(":idDisciplina", OracleDbType.Int32).Value = idDisciplina;
                    cmd.Parameters.Add(":calificacion", OracleDbType.Decimal).Value = calificacion;
                    cmd.Parameters.Add(":fechaEval", OracleDbType.Date).Value = fechaEvaluacion;
                    cmd.Parameters.Add(":idCalificacion", OracleDbType.Int32).Value = idCalificacion;
                }
                else // Insertar (esta parte está correcta)
                {
                    cmd = new OracleCommand(
                        "INSERT INTO Calificaciones" +
                        "(id_atleta, id_disciplina, calificacion, fecha_evaluacion) " +
                        "VALUES (:idAtleta, :idDisciplina, :calificacion, :fechaEval)", conn);

                    cmd.Parameters.Add(":idAtleta", OracleDbType.Int32).Value = idAtleta;
                    cmd.Parameters.Add(":idDisciplina", OracleDbType.Int32).Value = idDisciplina;
                    cmd.Parameters.Add(":calificacion", OracleDbType.Decimal).Value = calificacion;
                    cmd.Parameters.Add(":fechaEval", OracleDbType.Date).Value = fechaEvaluacion;
                }

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(bandera ? "Calificación actualizada correctamente" : "Calificación registrada correctamente");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void BTNEliminar_Click_1(object sender, EventArgs e)
        {
            if (bandera && MessageBox.Show("¿Eliminar esta calificación?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dt = new Conexion();
                using (OracleConnection conn = dt.conexion(user, password))
                {
                    using (OracleCommand cmd = new OracleCommand("DELETE FROM Calificaciones WHERE id_calificacion = :idCalificacion", conn))
                    {
                        cmd.Parameters.Add(":idCalificacion", OracleDbType.Int32).Value = idCalificacion;
                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Calificación eliminada correctamente");
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
        }
    }
}