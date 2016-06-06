using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebAPI.DAO
{
    interface ClienteDAOInterface
    {
        Models.Cliente buscaCliente();

        Models.Cliente buscaClienteCod(string cod);

        Models.Cliente BuscaClienteRazao(String razao);

    }
}
