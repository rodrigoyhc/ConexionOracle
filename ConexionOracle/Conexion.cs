using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ConexionOracle
{
    public class Conexion
    {
        string walletLocation = @"C:\Users\rodri\Desktop\Wallet_TBDEJ2025";
        string connectionStringT = @"User Id = {0};Password={1};Data Source=(description= (retry_count=20)(retry_delay=3)(address=(protocol=tcps)(port=1522)(host=adb.us-ashburn-1.oraclecloud.com))(connect_data=(service_name=gb6234d5cff4813_tbdej2025_high.adb.oraclecloud.com))(security=(ssl_server_dn_match=yes)))";

        //OracleConnection connection = null;

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // String walletLocation = @"C:\Users\Francisco Marroquin\Downloads\Wallet_TBDEJ2025a";

        // //Cadena de conexión básica para Oracle local
        //String connectionStringT = "User Id = ADMIN;Password=Terremoto16$;Data Source=(description= (retry_count=20)(retry_delay=3)(address=(protocol=tcps)(port=1522)(host=adb.us-phoenix-1.oraclecloud.com))(connect_data=(service_name=g5bc74aced8d2d8_tbdej2025a_high.adb.oraclecloud.com))(security=(ssl_server_dn_match=yes)))";
        OracleConnection connection = null;




        public OracleConnection conexion(string usuario, string clave)
        {
            Environment.SetEnvironmentVariable("TNS_ADMIN", walletLocation);
            string connectionString = string.Format(connectionStringT, usuario, clave);

            try
            {
                connection = new OracleConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        private void cerrarConexion()
        {
            try
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    connection.Dispose(); // Libera recursos
                    connection = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public bool EjecutarComando(string cmd, string usuario, string clave)
        {
            try
            {
                OracleCommand comando = new OracleCommand(cmd, conexion(usuario, clave));
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                cerrarConexion();
            }
        }

        public DataSet comandoDS(string cmd, string usuario, string clave)
        {
            try
            {
                DataSet ds = new DataSet();
                OracleDataAdapter comando = new OracleDataAdapter(cmd, conexion(usuario, clave));
                comando.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                cerrarConexion();
            }
        }

    }   
}
