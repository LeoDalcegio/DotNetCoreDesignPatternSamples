using AutoMapper;
using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Services;
using DesignPatternSamples.WebAPI.Models;
using DesignPatternSamples.WebAPI.Models.Detran;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.WebAPI.Controllers.Detran
{
    [Route("api/Detran/[controller]")]
    [ApiController]
    public class PontosCarteiraController : ControllerBase
    {
        private readonly IMapper _Mapper;
        private readonly IDetranVerificadorPontosCarteiraService _DetranVerificadorPontosCarteiraServices;

        public PontosCarteiraController(IMapper mapper, IDetranVerificadorPontosCarteiraService detranVerificadorPontosCarteiraService)
        {
            _Mapper = mapper;
            _DetranVerificadorPontosCarteiraServices = detranVerificadorPontosCarteiraService;
        }

        [HttpGet()]
        [ProducesResponseType(typeof(SuccessResultModel<IEnumerable<PontosCarteiraModel>>), StatusCodes.Status200OK)]
        public async Task<ActionResult> Get([FromQuery] CarteiraModel model)
        {
            var pontosCarteiras = await _DetranVerificadorPontosCarteiraServices.ConsultarPontosCarteira(_Mapper.Map<Carteira>(model));

            var result = new SuccessResultModel<IEnumerable<PontosCarteiraModel>>(_Mapper.Map<IEnumerable<PontosCarteiraModel>>(pontosCarteiras));

            return Ok(result);
        }
    }
}