using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MyWebAPI.Interfaces;
using MyWebAPI.Models;

namespace MyWebAPI.DAO
{
    public class ClienteDAO : ClienteDAOInterface
    {
        public Cliente buscaCliente()
        {
            Cliente cliente = new Cliente();

            Connection conn = new Connection();
            conn.criaConexao();
            IDataReader reader = conn.executaSQL("SELECT TOP 1 CdCliente FROM CLIENTE");
            cliente.Cod = (reader.GetString(reader.GetOrdinal("CdCliente"))).Trim();
            cliente.Razao = "Richard Teste";

            return cliente;
        }

        public Cliente buscaClienteCod(string cod)
        {
            throw new System.NotImplementedException();
        }

        public Cliente BuscaClienteRazao(string razao)
        {
            throw new System.NotImplementedException();
        }

    }
}