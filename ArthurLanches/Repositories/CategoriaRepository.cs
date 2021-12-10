using ArthurLanches.Context;
using ArthurLanches.Models;
using ArthurLanches.Repositories.Interfaces;

namespace ArthurLanches.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> categorias => _context.Categorias;
    }
}
