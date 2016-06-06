using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebAPI.DAO
{
    public class ClienteDAO : ClienteDAOInterface
    {
        public Cliente buscaCliente()
        {
            Cliente cliente = new Cliente();

            Connection conn = new Connection();
            conn.criaConexao();
            cliente.Cod = (conn.executaSQL("SELECT TOP 1 CdCliente FROM CLIENTE")).GetString(0);
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