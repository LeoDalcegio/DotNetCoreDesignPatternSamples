using DesignPatternSamples.Application.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Services
{
    public interface IDetranVerificadorPontosCarteiraService
    {
        Task<IEnumerable<PontosCarteira>> ConsultarPontosCarteira(Carteira carteira);
    }
}
