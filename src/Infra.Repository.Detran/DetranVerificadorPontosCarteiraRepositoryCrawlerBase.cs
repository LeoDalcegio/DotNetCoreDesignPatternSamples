﻿using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public abstract class DetranVerificadorPontosCarteiraRepositoryCrawlerBase : IDetranVerificadorPontosCarteiraRepository
    {
        public async Task<IEnumerable<PontosCarteira>> ConsultarPontosCarteira(Carteira carteira)
        {
            var html = await RealizarAcesso(carteira);
            return await PadronizarResultado(html);
        }

        protected abstract Task<string> RealizarAcesso(Carteira carteira);
        protected abstract Task<IEnumerable<PontosCarteira>> PadronizarResultado(string html);
    }
}
