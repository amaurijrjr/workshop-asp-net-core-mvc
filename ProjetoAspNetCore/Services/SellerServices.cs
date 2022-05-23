using ProjetoAspNetCore.Models;
using System.Collections.Generic;
using System.Linq;

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

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
