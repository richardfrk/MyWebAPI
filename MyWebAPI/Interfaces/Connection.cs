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
        string connetionString = null;
        SqlConnection connection;
        SqlCommand command;
        string sql = null;

        public void criaConexao()
        {

            connetionString = "Data Source=SPT-RICHARD;Initial Catalog=DbTESTE;User ID=sa;Password=dp";

            connection = new SqlConnection(connetionString);

            try
            {
                connection.Open();
                //command = new SqlCommand(sql, connection);
                //command.ExecuteNonQuery();
                //command.Dispose();
                System.Diagnostics.Debug.WriteLine("CONECTADO DO SUCESSO.");
            }

            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("HOUVERAM PROBLEMAS NA CONEXÃO.", ex);
            }
        }

        public void finalizaConexao()
        {
            connection.Close();
        }

        public IDataReader executaSQL(string sql)
        {
            command = new SqlCommand(sql, connection);

            //System.Diagnostics.Debug.WriteLine(sql);

            //command.ExecuteNonQuery();
            //command.Dispose();

            //SqlCommand command = new SqlCommand();
            //command.Connection = connection;
            //command.CommandText = sql;
            IDataReader reader = command.ExecuteReader();
            reader.Read();
            //System.Diagnostics.Debug.WriteLine(reader.GetOrdinal("CdCliente"));
            //System.Diagnostics.Debug.WriteLine(reader.GetString(0));

            return reader;
        }

    }
}