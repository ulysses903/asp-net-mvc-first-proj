using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class ClienteService
    {
        private readonly SalesWebMvcContext _context;

        public ClienteService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Cliente> FindAll()
        {
            return _context.Cliente.ToList();
        }
    }
}
