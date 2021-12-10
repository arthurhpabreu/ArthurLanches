using ArthurLanches.Models;

namespace ArthurLanches.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> categorias { get; }
    }
}
