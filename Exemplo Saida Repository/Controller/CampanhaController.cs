using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using TopDown.Comercial.Repository.Domain.Core.Commands;
using TopDown.Comercial.Repository.Domain.Core.Interfaces;
using TopDown.Comercial.Repository.DTO;
using TopDown.Core.Cache.Redis;
using TopDown.Core.Domain.BaseController.API.Controller;
using TopDown.Core.Domain.DTO;
using TopDown.Core.Infra.MemoryBus;

namespace TopDown.Comercial.Repository.Service.API.Controllers
{
    /// <summary>
    /// Gerenciar transações de Campanha
    /// </summary>
    [Produces("application/json", "application/xml")]
    [Route(#ROTAAPI)]
    [ApiController]
    public class #NOMECLASSEController : BaseController
    {
        private readonly #NOMEINTERFACEQUERYQuery #NOMEVARIAVELINTERFACEQUERYQuery;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="mapper">Instância de mapper</param>
        /// <param name="cache">Instância de cache</param>
        /// <param name="logger">Instância de log</param>
        /// <param name="mediator">Instância de mediator</param>
        public #NOMECLASSEController(
            IMapper mapper,
            IDistributedCache cache,
            ILogger<#NOMECLASSEController> logger,
            IMediatorHandler mediator,
            #NOMEINTERFACEQUERYQuery #NOMEVARIAVELINTERFACEQUERYQuery) : base(mapper, cache, logger, mediator)
        {
            #NOMEVARIAVELINTERFACEQUERYQuery = #NOMEVARIAVELINTERFACEQUERYQuery;
        }

        #METODOS

    }
}
