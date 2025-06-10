using Oracle.ManagedDataAccess.Client;
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

namespace ConexionOracle
{
    public partial class Form1 : Form
    {
        private string ultimaTablaMostrada = "";
        string user;
        string password;


        Conexion dt;
        public Form1(string usuario, string contraseña)
        {
            InitializeComponent();
            user = usuario;
            password = contraseña;
            
        }

// ------------- ENTRENADOR -----------------------------------------------------------------------------------
        private void entrenadorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InsEntrenador ent = new InsEntrenador(user, password);
            ent.Show();
        }

        private void entrenadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt = new Conexion();
            DataSet ds = dt.comandoDS("SELECT * FROM Entrenador", user, password);

            if (ds != null && ds.Tables.Count > 0)
            {
                DataTable tabla = ds.Tables[0];

                // Limpia las filas y columnas existentes del DataGridView
                DGVDatos.Rows.Clear();
                DGVDatos.Columns.Clear();

                // Asegúrate de que las columnas estén configuradas correctamente antes de agregar filas
                if (DGVDatos.Columns.Count == 0)
                {
                    foreach (DataColumn col in tabla.Columns)
                    {
                        DGVDatos.Columns.Add(col.ColumnName, col.ColumnName);
                    }
                }

                // Agrega las filas manualmente
                foreach (DataRow row in tabla.Rows)
                {
                    DGVDatos.Rows.Add(row.ItemArray);
                }
            }

            ultimaTablaMostrada = "Entrenador";
            TXTNombre.Enabled = true;

        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(ultimaTablaMostrada))
            {
                int i = DGVDatos.CurrentRow.Index;

                switch (ultimaTablaMostrada)
                {
                    case "Entrenador":
                        InsEntrenador insEnt = new InsEntrenador(user, password,
                            Convert.ToInt32(DGVDatos.Rows[i].Cells[0].Value),
                            DGVDatos.Rows[i].Cells[1].Value.ToString(),
                            DGVDatos.Rows[i].Cells[2].Value.ToString(),
                            DGVDatos.Rows[i].Cells[3].Value.ToString(),
                            DGVDatos.Rows[i].Cells[4].Value.ToString(),
                            DGVDatos.Rows[i].Cells[5].Value.ToString(),
                            DGVDatos.Rows[i].Cells[6].Value.ToString(),
                            DGVDatos.Rows[i].Cells[7].Value.ToString());
                        insEnt.Show();
                        break;

                    case "Atleta":
                        InsAtleta insAtleta = new InsAtleta(user, password,
                            Convert.ToInt32(DGVDatos.Rows[i].Cells[0].Value),      
                            Convert.ToInt32(DGVDatos.Rows[i].Cells[1].Value),       
                            DGVDatos.Rows[i].Cells[2].Value.ToString(),              
                            DGVDatos.Rows[i].Cells[3].Value.ToString(),             
                            Convert.ToDateTime(DGVDatos.Rows[i].Cells[4].Value).ToString("yyyy-MM-dd"), 
                            DGVDatos.Rows[i].Cells[5].Value.ToString(),            
                            DGVDatos.Rows[i].Cells[6].Value.ToString(),             
                            DGVDatos.Rows[i].Cells[7].Value.ToString(),             
                            Convert.ToInt32(DGVDatos.Rows[i].Cells[8].Value)        
                        );
                        insAtleta.Show();
                        break;

                    case "Disciplina":
                        InsDisciplina insDisc = new InsDisciplina(user, password,
                            Convert.ToInt32(DGVDatos.Rows[i].Cells[0].Value),  
                            DGVDatos.Rows[i].Cells[1].Value.ToString(),        
                            Convert.ToInt32(DGVDatos.Rows[i].Cells[2].Value),  
                            Convert.ToInt32(DGVDatos.Rows[i].Cells[3].Value),  
                            DGVDatos.Rows[i].Cells[4].Value.ToString(),        
                            Convert.ToInt32(DGVDatos.Rows[i].Cells[5].Value)   
                        );
                        insDisc.Show();
                        break;

                    case "Calificacion":
                        try
                        {
                            int idCalif = Convert.ToInt32(DGVDatos.Rows[i].Cells[0].Value);
                            int idAtleta = Convert.ToInt32(DGVDatos.Rows[i].Cells[1].Value);
                            int idDisc = Convert.ToInt32(DGVDatos.Rows[i].Cells[2].Value);
                            decimal calif = Convert.ToDecimal(DGVDatos.Rows[i].Cells[3].Value);
                            DateTime fecha = Convert.ToDateTime(DGVDatos.Rows[i].Cells[4].Value);

                            InsCalificaciones insCalifi = new InsCalificaciones(user, password,
                            idCalif, DGVDatos.Rows[i].Cells[1].Value.ToString(), DGVDatos.Rows[i].Cells[2].Value.ToString(), calif, fecha);
                            insCalifi.Show();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al cargar datos de la calificación: " + ex.Message);
                        }
                        break;


                    case "AtletaDisciplina":
                        try
                        {
                            int idAtleta = Convert.ToInt32(DGVDatos.Rows[i].Cells[0].Value);
                            int idDisciplina = Convert.ToInt32(DGVDatos.Rows[i].Cells[1].Value);
                            // Llamamos al constructor de actualización
                            Form2 formAD = new Form2(user, password, idAtleta, idDisciplina);
                            formAD.ShowDialog(); // Se recomienda ShowDialog para formularios modales
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al cargar datos de Atleta_Disciplina: " + ex.Message);
                        }
                        break;


                    case "AtletaDisciplinaHoras":
                        try
                        {
                            int idAtleta = Convert.ToInt32(DGVDatos.Rows[i].Cells[0].Value);     
                            int idDisciplina = Convert.ToInt32(DGVDatos.Rows[i].Cells[1].Value); 
                            DateTime fecha = Convert.ToDateTime(DGVDatos.Rows[i].Cells[2].Value); 

                            // Constructor aún es solo para insertar, no actualizar:
                            InsTriple formTriple = new InsTriple(user, password);
                            formTriple.ShowDialog();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al cargar datos de Atleta_Disciplina_Horas: " + ex.Message);
                        }
                        break;




                    // Agrega más casos si implementas formularios para otras tablas
                    default:
                        MessageBox.Show("No se puede actualizar esta tabla aún.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("No hay una tabla seleccionada para actualizar.");
            }

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ultimaTablaMostrada))
            {
                try
                {
                    dt = new Conexion();
                    int i = DGVDatos.CurrentRow.Index;

                    using (OracleConnection conn = dt.conexion(user, password))
                    {
                        OracleCommand cmd = null;
                        int id;
                        int filas = 0;

                        switch (ultimaTablaMostrada)
                        {
                            case "Entrenador":
                                id = Convert.ToInt32(DGVDatos.Rows[i].Cells[0].Value);
                                cmd = new OracleCommand("DELETE FROM Entrenador WHERE id_entrenador = :id", conn);
                                cmd.Parameters.Add(":id", OracleDbType.Int32).Value = id;
                                break;

                            case "Atleta":
                                id = Convert.ToInt32(DGVDatos.Rows[i].Cells[0].Value);
                                cmd = new OracleCommand("DELETE FROM Atletas WHERE id_atleta = :id", conn);
                                cmd.Parameters.Add(":id", OracleDbType.Int32).Value = id;
                                break;

                            case "Disciplina":
                                id = Convert.ToInt32(DGVDatos.Rows[i].Cells[0].Value);
                                cmd = new OracleCommand("DELETE FROM Disciplinas WHERE id_disciplina = :id", conn);
                                cmd.Parameters.Add(":id", OracleDbType.Int32).Value = id;
                                break;

                            case "Calificacion":
                                id = Convert.ToInt32(DGVDatos.Rows[i].Cells[0].Value);
                                cmd = new OracleCommand("DELETE FROM Calificaciones WHERE id_calificacion = :id", conn);
                                cmd.Parameters.Add(":id", OracleDbType.Int32).Value = id;
                                break;

                            case "AtletaDisciplina":
                                int idAtleta = Convert.ToInt32(DGVDatos.Rows[i].Cells[0].Value);
                                int idDisciplina = Convert.ToInt32(DGVDatos.Rows[i].Cells[1].Value);
                                cmd = new OracleCommand(
                                    "DELETE FROM Atleta_Disciplina WHERE id_atleta = :idAtleta AND id_disciplina = :idDisciplina", conn);
                                cmd.Parameters.Add(":idAtleta", OracleDbType.Int32).Value = idAtleta;
                                cmd.Parameters.Add(":idDisciplina", OracleDbType.Int32).Value = idDisciplina;
                                break;
                                ;

                            case "AtletaDisciplinaHoras":
                                int idAtletaH = Convert.ToInt32(DGVDatos.Rows[i].Cells[0].Value);
                                int idDisciplinaH = Convert.ToInt32(DGVDatos.Rows[i].Cells[2].Value);
                                DateTime fechaH = Convert.ToDateTime(DGVDatos.Rows[i].Cells[4].Value);

                                cmd = new OracleCommand("DELETE FROM Atleta_Disciplina_Horas WHERE id_atleta = :idAtleta AND id_disciplina = :idDisciplina AND fecha_registro = :fecha", conn);
                                cmd.Parameters.Add(":idAtleta", OracleDbType.Int32).Value = idAtletaH;
                                cmd.Parameters.Add(":idDisciplina", OracleDbType.Int32).Value = idDisciplinaH;
                                cmd.Parameters.Add(":fecha", OracleDbType.Date).Value = fechaH;
                                break;


                            default:
                                MessageBox.Show("No se puede eliminar esta tabla aún.");
                                return;
                        }

                        if (cmd != null)
                        {
                            filas = cmd.ExecuteNonQuery();
                            MessageBox.Show(filas > 0 ? "Registro eliminado correctamente" : "No se eliminó ningún registro");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No hay una tabla cargada para eliminar registros.");
            }
        }



        private void TXTNombre_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ultimaTablaMostrada))
            {
                MessageBox.Show("Primero debes seleccionar una tabla.");
                return;
            }

            dt = new Conexion();
            using (OracleConnection conn = dt.conexion(user, password))
            {
                OracleCommand cmd = null;

                switch (ultimaTablaMostrada)
                {
                    case "Entrenador":
                        cmd = new OracleCommand("SELECT * FROM Entrenador WHERE nombre LIKE :nombre", conn);
                        cmd.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = TXTNombre.Text + "%";
                        break;

                    case "Atleta":
                        cmd = new OracleCommand("SELECT * FROM Atletas WHERE nombre LIKE :nombre", conn);
                        cmd.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = TXTNombre.Text + "%";
                        break;

                    case "Disciplina":
                        cmd = new OracleCommand(
                        "SELECT id_disciplina, nombre_disciplina, creditos, horas_minimas, descripcion, id_entrenador " +
                        "FROM Disciplinas WHERE nombre_disciplina LIKE :nombre", conn);
                        cmd.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = TXTNombre.Text + "%";
                        break;


                    case "Calificacion":
                        cmd = new OracleCommand(@"SELECT id_calificacion, a.nombre, nd.nombre_disciplina, calificacion, fecha_evaluacion 
                        FROM Calificaciones cali JOIN Atletas a ON(a.id_atleta = cali.id_atleta) JOIN 
                        Disciplinas nd ON(nd.id_disciplina = cali.id_disciplina) WHERE a.nombre LIKE :nombre OR a.apellido
                        LIKE :nombre", conn);
                        cmd.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = TXTNombre.Text + "%";
                        break;

                    case "AtletaDisciplina":
                        cmd = new OracleCommand(@"
                        SELECT ad.id_atleta, a.nombre || ' ' || a.apellido AS nombre_atleta, 
                               ad.id_disciplina, d.nombre_disciplina
                        FROM Atleta_Disciplina ad
                        JOIN Atletas a ON ad.id_atleta = a.id_atleta
                        JOIN Disciplinas d ON ad.id_disciplina = d.id_disciplina
                        WHERE a.nombre LIKE :nombre OR a.apellido LIKE :nombre OR d.nombre_disciplina LIKE :nombre", conn);

                        cmd.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = TXTNombre.Text + "%";
                        break;


                    case "Atleta_Disciplina_Horas":
                                        cmd = new OracleCommand(@"
                        SELECT adh.id_atleta, a.nombre || ' ' || a.apellido AS nombre_atleta,
                               adh.id_disciplina, d.nombre_disciplina,
                               adh.fecha_registro, adh.horas_realizadas, adh.observaciones
                        FROM Atleta_Disciplina_Horas adh
                        JOIN Atletas a ON adh.id_atleta = a.id_atleta
                        JOIN Disciplinas d ON adh.id_disciplina = d.id_disciplina
                        WHERE a.nombre LIKE :nombre OR a.apellido LIKE :nombre OR d.nombre_disciplina LIKE :nombre", conn);
                                        cmd.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = TXTNombre.Text + "%";
                        break;


                    default:
                        MessageBox.Show("Búsqueda no implementada para esta tabla.");
                        return;
                }

                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    DGVDatos.Rows.Clear();
                    DGVDatos.Columns.Clear();

                    if (reader.HasRows)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            DGVDatos.Columns.Add(reader.GetName(i), reader.GetName(i));
                        }

                        while (reader.Read())
                        {
                            object[] fila = new object[reader.FieldCount];
                            reader.GetValues(fila);
                            DGVDatos.Rows.Add(fila);
                        }
                    }
                }
            }
        }

        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //-----------  ATLETA  ----------------------------------------------------------------------------------------------------------------------
        private void atletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsAtleta atletaForm = new InsAtleta(user, password);
            atletaForm.Show();
            ultimaTablaMostrada = "Atleta";
        }

        private void atletasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt = new Conexion();
            DataSet ds = dt.comandoDS("SELECT * FROM Atletas", user, password);

            if (ds != null && ds.Tables.Count > 0)
            {
                DataTable tabla = ds.Tables[0];

                DGVDatos.Rows.Clear();
                DGVDatos.Columns.Clear();

                if (DGVDatos.Columns.Count == 0)
                {
                    foreach (DataColumn col in tabla.Columns)
                    {
                        DGVDatos.Columns.Add(col.ColumnName, col.ColumnName);
                    }
                }

                foreach (DataRow row in tabla.Rows)
                {
                    DGVDatos.Rows.Add(row.ItemArray);
                }
            }

            ultimaTablaMostrada = "Atleta";
            TXTNombre.Enabled = true;
        }


        

        private void buscarAtletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ultimaTablaMostrada == "Atleta")
            {
             
                TXTNombre.Enabled = true;
                TXTNombre.Text = "";
                TXTNombre.Focus();
            }
        }

// -----  DISCIPLINAS---------------------------------------------------------------------------------------------------------------------
        private void disciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsDisciplina discp = new InsDisciplina(user, password);
            discp.Show();
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt = new Conexion();
            DataSet ds = dt.comandoDS("SELECT * FROM Disciplinas", user, password);

            if (ds != null && ds.Tables.Count > 0)
            {
                DataTable tabla = ds.Tables[0];

                DGVDatos.Rows.Clear();
                DGVDatos.Columns.Clear();

                if (DGVDatos.Columns.Count == 0)
                {
                    foreach (DataColumn col in tabla.Columns)
                    {
                        DGVDatos.Columns.Add(col.ColumnName, col.ColumnName);
                    }
                }

                foreach (DataRow row in tabla.Rows)
                {
                    DGVDatos.Rows.Add(row.ItemArray);
                }
            }

            ultimaTablaMostrada = "Disciplina";
            TXTNombre.Enabled = true;
        }

        //------------ CALIFICACIONES --------------------------------------------------------------------------------------------------------------------

        private void calificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsCalificaciones InsCalifi = new InsCalificaciones(user, password);
            InsCalifi.Show();
            ultimaTablaMostrada = "Calificacion";
   
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
            dt = new Conexion();
            DataSet ds = dt.comandoDS(
                "SELECT id_calificacion, id_atleta, id_disciplina, calificacion, " +
                "TO_CHAR(fecha_evaluacion, 'DD/MM/YYYY') AS fecha_evaluacion " +
                "FROM Calificaciones ORDER BY id_calificacion",
                user, password);

            if (ds != null && ds.Tables.Count > 0)
            {
                DataTable tabla = ds.Tables[0];

                DGVDatos.Rows.Clear();
                DGVDatos.Columns.Clear();


                DGVDatos.Columns.Add("id_calificacion", "ID Calificación");
                DGVDatos.Columns.Add("id_atleta", "ID Atleta");
                DGVDatos.Columns.Add("id_disciplina", "ID Disciplina");
                DGVDatos.Columns.Add("calificacion", "Calificación");
                DGVDatos.Columns.Add("fecha_evaluacion", "Fecha Evaluación");

                foreach (DataRow row in tabla.Rows)
                {
                    DGVDatos.Rows.Add(
                        row["id_calificacion"],
                        row["id_atleta"],
                        row["id_disciplina"],
                        row["calificacion"],
                        row["fecha_evaluacion"]);
                }
            }

            ultimaTablaMostrada = "Calificacion";
            TXTNombre.Enabled = true;

        }

        //---------------  ATLETA_DISCIPLINA ----------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void atletaDisciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 atl_dis = new Form2(user, password);
            atl_dis.Show();
            ultimaTablaMostrada = "AtletaDisciplina";
        }

        private void atletasDisciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt = new Conexion();
            // Consulta que solo recupera los IDs (sin nombres descriptivos)
            DataSet ds = dt.comandoDS(@"
        SELECT 
            atld.id_atleta,
            atld.id_disciplina
        FROM Atleta_Disciplina atld",
                user, password);

            if (ds != null && ds.Tables.Count > 0)
            {
                DataTable tabla = ds.Tables[0];

                DGVDatos.Rows.Clear();
                DGVDatos.Columns.Clear();

                // Configuración mínima de columnas (solo IDs)
                DGVDatos.Columns.Add("id_atleta", "ID Atleta");
                DGVDatos.Columns.Add("id_disciplina", "ID Disciplina");

                // Llenado de datos
                foreach (DataRow row in tabla.Rows)
                {
                    DGVDatos.Rows.Add(
                        row["id_atleta"],
                        row["id_disciplina"]
                    );
                }
            }
           
            ultimaTablaMostrada = "AtletaDisciplina";
        }


        //---------- ATLETAS_DISCIPLINAS_HORAS --------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            InsTriple atl_dis_hor = new InsTriple(user, password);
            atl_dis_hor.Show();
            ultimaTablaMostrada = "AtletaDisciplinaHoras";
        }


        private void atleDiscHorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt = new Conexion();

            // Consulta modificada para obtener solo IDs (sin nombres descriptivos)
            string consulta = @"
            SELECT 
                adh.id_atleta,
                adh.id_disciplina,
                TO_CHAR(adh.fecha_registro, 'YYYY-MM-DD') AS Fecha,
                adh.horas_realizadas AS Horas,
                adh.observaciones AS Observaciones
            FROM 
                Atleta_Disciplina_Horas adh
            ORDER BY 
                adh.fecha_registro DESC";

            DataSet ds = dt.comandoDS(consulta, user, password);

            if (ds != null && ds.Tables.Count > 0)
            {
                DataTable tabla = ds.Tables[0];

                DGVDatos.Rows.Clear();
                DGVDatos.Columns.Clear();

                // Configuración manual de columnas (opcionalmente puedes ocultar algunas)
                DGVDatos.Columns.Add("id_atleta", "ID Atleta");
                DGVDatos.Columns.Add("id_disciplina", "ID Disciplina");
                DGVDatos.Columns.Add("Fecha", "Fecha");
                DGVDatos.Columns.Add("Horas", "Horas Realizadas");
                DGVDatos.Columns.Add("Observaciones", "Observaciones");

                foreach (DataRow row in tabla.Rows)
                {
                    DGVDatos.Rows.Add(
                        row["id_atleta"],
                        row["id_disciplina"],
                        row["Fecha"],
                        row["Horas"],
                        row["Observaciones"]
                    );
                }
            }

            ultimaTablaMostrada = "AtletaDisciplinaHoras";
        }



        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void refresh_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ultimaTablaMostrada))
            {
                switch (ultimaTablaMostrada)
                {
                    case "Entrenador":
                        entrenadorToolStripMenuItem_Click(null, null);
                        break;
                    case "Atleta":
                        atletasToolStripMenuItem_Click(null, null);
                        break;
                    case "Calificacion":
                        calificacionesToolStripMenuItem_Click(null, null);
                        break;
                    case "Disciplina":
                        disciplinasToolStripMenuItem_Click(null, null);
                        break;
                    case "AtletaDisciplina":
                        atletasDisciplinasToolStripMenuItem_Click(null, null);
                        break;
                    case "AtletaDisciplinaHoras":
                        atleDiscHorasToolStripMenuItem_Click(null,null);
                        break;
                    default:
                        MessageBox.Show("No hay tabla seleccionada para refrescar");
                        break;
                }
            }
            else
            {
                MessageBox.Show("No se ha cargado ninguna tabla aún");
            }
        }

        public void CargarDatosDesdeBusqueda(DataTable datos)
        {
            DGVDatos.DataSource = datos;
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            InsBusquedas busqueda = new InsBusquedas(user, password);
            busqueda.Show();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      
    }
}
