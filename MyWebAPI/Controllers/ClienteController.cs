using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyWebAPI.DAO;
using MyWebAPI.Models;

namespace MyWebAPI.Controllers
{
    public class ClienteController : ApiController
    {
        ClienteDAO cliente = new ClienteDAO();

        // GET: api/Cliente
        public Cliente Get()
        {
            return cliente.buscaCliente();
        }

        // GET: api/Cliente/5
        public string Get(int id)
        {
            return "";
        }

        // POST: api/Cliente
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Cliente/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cliente/5
        public void Delete(int id)
        {
        }

    }
}
