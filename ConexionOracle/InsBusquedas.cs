using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ConexionOracle
{
    public partial class InsBusquedas : Form
    {
        Conexion dt;
        string user;
        string password;

        public InsBusquedas(string usuario, string contraseña)
        {
            InitializeComponent();
            user = usuario;
            password = contraseña;
            dt = new Conexion();
        }

        // BOTÓN 1: Mostrar atletas que completaron los créditos
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM vw_reporte_horas_creditos WHERE estado = 'CUMPLE'";
                DataSet ds = dt.comandoDS(query, user, password);

                if (ds != null && ds.Tables.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("No se encontraron atletas con créditos completos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar créditos: " + ex.Message);
            }
        }

        // BOTÓN 2: Mostrar atletas con calificación menor a 7
        private void button2_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = dt.conexion(user, password))
            {
                if (conn == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión.");
                    return;
                }

                try
                {
                    using (OracleCommand cmd = new OracleCommand("admin.sp_atletas_calif_baja", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        OracleDataAdapter da = new OracleDataAdapter(cmd);
                        DataTable dtResultado = new DataTable();
                        da.Fill(dtResultado);

                        dataGridView1.DataSource = dtResultado;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener atletas con calificación baja: " + ex.Message);
                }
            }
        }

        // BOTÓN 7: Asignar créditos a atletas que cumplieron con las horas mínimas
        private void button7_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = dt.conexion(user, password))
            {
                if (conn == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión.");
                    return;
                }

                try
                {
                    List<int> ids = new List<int>();
                    string query = "SELECT DISTINCT id_atleta FROM Atleta_Disciplina";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ids.Add(reader.GetInt32(0));
                        }
                    }

                    foreach (int id in ids)
                    {
                        using (OracleCommand proc = new OracleCommand("asignar_creditos_atleta", conn))
                        {
                            proc.CommandType = CommandType.StoredProcedure;
                            proc.Parameters.Add("p_id_atleta", OracleDbType.Int32).Value = id;
                            proc.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Créditos asignados correctamente a quienes cumplieron las horas mínimas.");
                    button1_Click(sender, e); // Refrescar vista con los que cumplieron
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al asignar créditos: " + ex.Message);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Aquí obtén el id_atleta (ejemplo: del textbox txtIdAtleta)
            if (!int.TryParse(txtIdAtleta.Text, out int idAtleta))
            {
                MessageBox.Show("Por favor ingrese un ID de atleta válido.");
                return;
            }

            using (OracleConnection conn = dt.conexion(user, password))
            {
                if (conn == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión.");
                    return;
                }

                try
                {
                    // Habilitar DBMS_OUTPUT
                    using (OracleCommand cmdEnable = new OracleCommand("BEGIN DBMS_OUTPUT.ENABLE(NULL); END;", conn))
                    {
                        cmdEnable.ExecuteNonQuery();
                    }

                    // Ejecutar procedimiento
                    using (OracleCommand cmd = new OracleCommand("admin.generar_reporte_detallado_atleta", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_id_atleta", OracleDbType.Int32).Value = idAtleta;
                        cmd.ExecuteNonQuery();
                    }

                    // Leer DBMS_OUTPUT
                    List<string> lineas = new List<string>();
                    bool done = false;

                    while (!done)
                    {
                        using (OracleCommand cmdGetLine = new OracleCommand("BEGIN DBMS_OUTPUT.GET_LINE(:line, :status); END;", conn))
                        {
                            var lineParam = new Oracle.ManagedDataAccess.Client.OracleParameter("line", OracleDbType.Varchar2, 32767, null, ParameterDirection.Output);
                            var statusParam = new Oracle.ManagedDataAccess.Client.OracleParameter("status", OracleDbType.Int32, ParameterDirection.Output);

                            cmdGetLine.Parameters.Add(lineParam);
                            cmdGetLine.Parameters.Add(statusParam);

                            cmdGetLine.ExecuteNonQuery();

                            int status = Convert.ToInt32(statusParam.Value.ToString());

                            if (status == 1) // No más líneas
                            {
                                done = true;
                            }
                            else
                            {
                                string line = lineParam.Value.ToString();
                                lineas.Add(line);
                            }
                        }
                    }

                    // Mostrar resultado en un MessageBox o TextBox multilinea
                    string resultado = string.Join(Environment.NewLine, lineas);
                    MessageBox.Show(resultado, "Reporte detallado atleta");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar reporte detallado: " + ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BTNEntCons_Click(object sender, EventArgs e)
        {
            // Validar input
            if (!int.TryParse(TXTIdEntrenador.Text.Trim(), out int idEntrenador))
            {
                MessageBox.Show("Ingresa un ID de entrenador válido.");
                return;
            }

            try
            {
                using (OracleConnection conn = dt.conexion(user, password))
                {
                    using (OracleCommand cmd = new OracleCommand("admin.ObtenerDisciplinaPorEntrenador", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // ❶ Que ODP use los nombres y no el orden
                        cmd.BindByName = true;

                        // ❷ PRIMERO el parámetro de retorno
                        cmd.Parameters.Add("RETURN_VALUE", OracleDbType.Varchar2, 100)
                                       .Direction = ParameterDirection.ReturnValue;

                        // ❸ Después los parámetros de entrada
                        cmd.Parameters.Add("p_id_entrenador", OracleDbType.Int32)
                                       .Value = idEntrenador;

                        cmd.ExecuteNonQuery();

                        string disciplina = cmd.Parameters["RETURN_VALUE"].Value.ToString();

                        MessageBox.Show($"Disciplina asignada: {disciplina}",
                                        "Resultado",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener disciplina: {ex.Message}");
            }
        }

        private void BTNView_Click(object sender, EventArgs e)
        {
            dt = new Conexion();
            DataSet ds = dt.comandoDS("SELECT * FROM admin.vw_atletas_completos", user, password);

            if (ds != null && ds.Tables.Count > 0)
            {
                DataTable tabla = ds.Tables[0];

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                if (dataGridView1.Columns.Count == 0)
                {
                    foreach (DataColumn col in tabla.Columns)
                    {
                        dataGridView1.Columns.Add(col.ColumnName, col.ColumnName);
                    }
                }

                foreach (DataRow row in tabla.Rows)
                {
                    dataGridView1.Rows.Add(row.ItemArray);
                }
            }
            dataGridView1.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dt = new Conexion();
            DataSet ds = dt.comandoDS("SELECT * FROM admin.vw_disciplinas_completas", user, password);

            if (ds != null && ds.Tables.Count > 0)
            {
                DataTable tabla = ds.Tables[0];

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                if (dataGridView1.Columns.Count == 0)
                {
                    foreach (DataColumn col in tabla.Columns)
                    {
                        dataGridView1.Columns.Add(col.ColumnName, col.ColumnName);
                    }
                }

                foreach (DataRow row in tabla.Rows)
                {
                    dataGridView1.Rows.Add(row.ItemArray);
                }
            }
            dataGridView1.Enabled = true;
        }
    }
}
