using System;

namespace DesignPatternSamples.Application.Repository
{
    public interface IDetranVerificadorPontosCarteiraFactory
    {
        public IDetranVerificadorPontosCarteiraFactory Register(string UF, Type repository);
        public IDetranVerificadorPontosCarteiraRepository Create(string UF);
    }
}
