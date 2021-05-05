using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Gndi.Gerenciador.Portais.Comercial.Service.Api.Configuration;
using Gndi.Gerenciador.Portais.Comercial.Service.Api.Extensions;
using Gndi.Gerenciador.Portais.Comercial.Service.Api.Model;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TopDown.Core.Domain.DTO;
using TopDown.Core.Facade.Rest.Request.Web.Cliente;
using Gndi.Gerenciador.Portais.Comercial.Service.Api.DTO;
using Gndi.Gerenciador.Portais.Comercial.Service.Api.Model.Enums;
using Gndi.Gerenciador.Portais.Comercial.Service.Api.Model.Campanha;
using Gndi.Gerenciador.Portais.Comercial.Service.Api.DTO.Campanhas;

namespace Gndi.Gerenciador.Portais.Comercial.Service.Api.Controllers
{
    [Produces("application/json", "application/xml")]
    [Route("#ROTA")]
    [ApiController]
    public class #NOMECLASSE : BaseController
    {
        private readonly #CONFIGURATION #VARIAVELCONFIGURATION;

        public #NOMECLASSE(
            ILogger<BaseController> logger,
            IRestClientFactory restClientFactory,
            IMapper mapper,
            IOptions<#CONFIGURATION> options,
            IConfiguration configuration) : base(logger, restClientFactory, mapper, configuration)
        {
            #VARIAVELCONFIGURATION = options.Value;
        }

#METODOS

    }
}
