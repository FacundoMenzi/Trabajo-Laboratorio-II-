using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Lab_Consultas
{
    internal class DBHelper
    {
        private static DBHelper instance;
        private SqlConnection conn;
        private SqlCommand cmd = new SqlCommand();
        public DBHelper()
        {
            conn =new SqlConnection(Properties.Resources.cnnString);
        }
        public static DBHelper ObtenerInstancia()
        {
            if(instance == null)
            {
                instance = new DBHelper();
            }
            return instance;
        }
        public DataTable Sentencia(string SP,List<Parametro> values)
        {
            
            DataTable dt = new DataTable();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = SP;
            cmd.CommandType = CommandType.StoredProcedure;
            if (values != null)
            {
                foreach (Parametro oParametro in values)
                {
                    cmd.Parameters.AddWithValue(oParametro.Clave, oParametro.Valor);
                }
            }
            dt.Load(cmd.ExecuteReader());
            cmd.Parameters.Clear();
            conn.Close();
            return dt;
        }
    
    
    }
}
