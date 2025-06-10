using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace ConexionOracle
{
    public partial class Form2 : Form
    {
        Conexion dt;
        string user;
        string password;

        int idAtleta = 0;
        int idDisciplina = 0;
        bool bandera = false;

        public Form2(string usuario, string contraseña)
        {
            InitializeComponent();
            user = usuario;
            password = contraseña;
            CargarAtletas();
            CargarDisciplinas();
        }

        public Form2(string usuario, string contraseña, int atleta, int disciplina)
        {
            InitializeComponent();
            user = usuario;
            password = contraseña;

            idAtleta = atleta;
            idDisciplina = disciplina;
            bandera = true;

            CargarAtletas();
            CargarDisciplinas();
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
                        DataTable data = new DataTable();
                        adapter.Fill(data);
                        cmbAtleta.DataSource = data;
                        cmbAtleta.DisplayMember = "nombre_completo";
                        cmbAtleta.ValueMember = "id_atleta";

                        // Selecciona el atleta actual si estamos en modo actualización
                        if (bandera)
                            cmbAtleta.SelectedValue = idAtleta;
                    }
                }
            }
        }

        private void CargarDisciplinas()
        {
            dt = new Conexion();
            using (OracleConnection conn = dt.conexion(user, password))
            {
                string query = "SELECT id_disciplina, nombre_disciplina FROM Disciplinas";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable data = new DataTable();
                        adapter.Fill(data);
                        cmbDisciplina.DataSource = data;
                        cmbDisciplina.DisplayMember = "nombre_disciplina";
                        cmbDisciplina.ValueMember = "id_disciplina";

                        // Selecciona la disciplina actual si estamos en modo actualización
                        if (bandera)
                            cmbDisciplina.SelectedValue = idDisciplina;
                    }
                }
            }
        }

        private void BTNInsertar_Click(object sender, EventArgs e)
        {
          
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            dt = new Conexion();
            int nuevoIdAtleta = Convert.ToInt32(cmbAtleta.SelectedValue);
            int nuevoIdDisciplina = Convert.ToInt32(cmbDisciplina.SelectedValue);

            using (OracleConnection conn = dt.conexion(user, password))
            {
                if (bandera) // ACTUALIZAR
                {
                    using (OracleCommand cmd = new OracleCommand(
                        "UPDATE Atleta_Disciplina SET id_atleta = :nuevoAtleta, id_disciplina = :nuevaDisciplina " +
                        "WHERE id_atleta = :viejoAtleta AND id_disciplina = :viejaDisciplina", conn))
                    {
                        cmd.Parameters.Add(":nuevoAtleta", OracleDbType.Int32).Value = nuevoIdAtleta;
                        cmd.Parameters.Add(":nuevaDisciplina", OracleDbType.Int32).Value = nuevoIdDisciplina;
                        cmd.Parameters.Add(":viejoAtleta", OracleDbType.Int32).Value = idAtleta;
                        cmd.Parameters.Add(":viejaDisciplina", OracleDbType.Int32).Value = idDisciplina;

                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Relación actualizada correctamente.");
                        }
                        catch (OracleException ex)
                        {
                            MessageBox.Show("Error al actualizar: " + ex.Message);
                        }
                    }
                }
                else // INSERTAR
                {
                    using (OracleCommand cmd = new OracleCommand(
                        "INSERT INTO Atleta_Disciplina (id_atleta, id_disciplina) VALUES (:idA, :idD)", conn))
                    {
                        cmd.Parameters.Add(":idA", OracleDbType.Int32).Value = nuevoIdAtleta;
                        cmd.Parameters.Add(":idD", OracleDbType.Int32).Value = nuevoIdDisciplina;

                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Relación insertada correctamente.");
                        }
                        catch (OracleException ex)
                        {
                            MessageBox.Show("Error al insertar: " + ex.Message);
                        }
                    }
                }
            }

            this.Close();
        }

        private void BTNInsertar_Click_1(object sender, EventArgs e)
        {
            int idAtletaSel = Convert.ToInt32(cmbAtleta.SelectedValue);
            int idDisciplinaSel = Convert.ToInt32(cmbDisciplina.SelectedValue);

            dt = new Conexion();
            using (OracleConnection conn = dt.conexion(user, password))
            {
                using (OracleCommand cmd = new OracleCommand(
                    "DELETE FROM Atleta_Disciplina WHERE id_atleta = :idA AND id_disciplina = :idD", conn))
                {
                    cmd.Parameters.Add(":idA", OracleDbType.Int32).Value = idAtletaSel;
                    cmd.Parameters.Add(":idD", OracleDbType.Int32).Value = idDisciplinaSel;

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Relación eliminada correctamente.");
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