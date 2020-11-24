﻿using DesignPatternSamples.Application.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Repository
{
    public interface IDetranVerificadorPontosCarteiraRepository
    {
        Task<IEnumerable<PontosCarteira>> ConsultarPontosCarteira(Carteira carteira);
    }
}
