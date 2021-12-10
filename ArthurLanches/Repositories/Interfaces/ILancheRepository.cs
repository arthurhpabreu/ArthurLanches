using ArthurLanches.Models;

namespace ArthurLanches.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPeferidos { get; }
        Lanche GetLancheById(int lancheId);   
    }
}
