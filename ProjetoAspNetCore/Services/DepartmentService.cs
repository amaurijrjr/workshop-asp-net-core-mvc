using ProjetoAspNetCore.Models;
using System.Linq;
using System.Collections.Generic;

namespace ProjetoAspNetCore.Services
{
    public class DepartmentService
    {
        private readonly ProjetoAspNetCoreContext _context;

        public DepartmentService(ProjetoAspNetCoreContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
