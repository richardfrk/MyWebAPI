using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebAPI.Interfaces
{
    interface ConnectionInterface
    {
        void criaConexao();
        void finalizaConexao();
        IDataReader executaSQL(string sql);
    }
}
