using ProjetoAspNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAspNetCore.Services
{
    public class SellerServices
    {
        private readonly ProjetoAspNetCoreContext _context;

        public SellerServices(ProjetoAspNetCoreContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
