using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public class DetranSCVerificadorPontosCarteiraRepository : IDetranVerificadorPontosCarteiraRepository
    {
        private readonly ILogger _Logger;

        public DetranSCVerificadorPontosCarteiraRepository(ILogger<DetranSCVerificadorPontosCarteiraRepository> logger)
        {
            _Logger = logger;
        }

        public Task<IEnumerable<PontosCarteira>> ConsultarPontosCarteira(Carteira carteira)
        {
            _Logger.LogDebug($"Consultando débitos da carteira nr {carteira.NrCNH} para o estado de SC.");
            return Task.FromResult<IEnumerable<PontosCarteira>>(new List<PontosCarteira>() { new PontosCarteira() });
        }
    }
}
