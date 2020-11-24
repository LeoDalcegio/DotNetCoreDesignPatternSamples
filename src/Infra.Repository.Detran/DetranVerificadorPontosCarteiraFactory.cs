using DesignPatternSamples.Application.Repository;
using System;
using System.Collections.Generic;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public class DetranVerificadorPontosCarteiraFactory : IDetranVerificadorPontosCarteiraFactory
    {
        private readonly IServiceProvider _ServiceProvider;
        private readonly IDictionary<string, Type> _Repositories = new Dictionary<string, Type>();

        public DetranVerificadorPontosCarteiraFactory(IServiceProvider serviceProvider)
        {
            _ServiceProvider = serviceProvider;
        }


        public IDetranVerificadorPontosCarteiraRepository Create(string UF)
        {
            IDetranVerificadorPontosCarteiraRepository result = null;

            if (_Repositories.TryGetValue(UF, out Type type))
            {
                result = _ServiceProvider.GetService(type) as IDetranVerificadorPontosCarteiraRepository;
            }

            return result;
        }

        public IDetranVerificadorPontosCarteiraFactory Register(string UF, Type repository)
        {
            if (!_Repositories.TryAdd(UF, repository))
            {
                _Repositories[UF] = repository;
            }

            return this;
        }
    }
}
