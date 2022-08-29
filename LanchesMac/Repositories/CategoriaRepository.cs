using LanchesMac.Data;
using LanchesMac.Models;
using LanchesMac.Repository.Interface;

namespace LanchesMac.Repository
{
    public class CategoryRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}