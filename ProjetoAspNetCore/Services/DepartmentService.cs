using ProjetoAspNetCore.Models;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoAspNetCore.Services
{
    public class DepartmentService
    {
        private readonly ProjetoAspNetCoreContext _context;

        public DepartmentService(ProjetoAspNetCoreContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
