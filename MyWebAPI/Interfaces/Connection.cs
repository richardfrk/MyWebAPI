using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MyWebAPI.Interfaces
{
    public class Connection : ConnectionInterface
    {

        SqlConnection connection;

        public void criaConexao()
        {

            string connetionString = "Data Source=SPT-RICHARD;Initial Catalog=DbTESTE;User ID=sa;Password=dp";

            connection = new SqlConnection(connetionString);

            try
            {
                connection.Open();
            }

            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("HOUVERAM PROBLEMAS NA CONEXÃO. VERIFIQUE.", ex);
            }
        }

        public void finalizaConexao()
        {
            connection.Close();
        }

        public IDataReader executaSQL(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);

            IDataReader reader = command.ExecuteReader();
            reader.Read();
            
            //System.Diagnostics.Debug.WriteLine(reader.GetString(0));

            return reader;
        }

    }
}