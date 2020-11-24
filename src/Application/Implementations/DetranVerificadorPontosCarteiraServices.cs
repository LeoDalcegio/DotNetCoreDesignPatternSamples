using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using DesignPatternSamples.Application.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Implementations
{
    public class DetranVerificadorPontosCarteiraServices : IDetranVerificadorPontosCarteiraService
    {
        private readonly IDetranVerificadorPontosCarteiraFactory _Factory;

        public DetranVerificadorPontosCarteiraServices(IDetranVerificadorPontosCarteiraFactory factory)
        {
            _Factory = factory;
        }
        public Task<IEnumerable<PontosCarteira>> ConsultarPontosCarteira(Carteira carteira)
        {
            IDetranVerificadorPontosCarteiraRepository repository = _Factory.Create(carteira.UF);
            return repository.ConsultarPontosCarteira(carteira);
        }
    }
}
