using System.Threading.Tasks;

namespace DesignPatternSamples.Domain.Repository.Detran
{
    public interface IDetranVerificadorPontosCarteira
    {
        Task<PontosCarteira> ConsultarPontosCarteira(Carteira carteira);
    }
}
