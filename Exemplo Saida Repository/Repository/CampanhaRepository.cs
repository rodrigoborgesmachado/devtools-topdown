using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TopDown.Comercial.Repository.Domain.Core.Entities;
using TopDown.Core.Data;
using TopDown.Core.Data.Encrypt;
using TopDown.Core.Data.Oracle;
using System.Collections;

namespace TopDown.Comercial.Repository.Infra.Data.Campanha
{
    public class #NOMEREPOSITORYRepository : OracleData, #NOMEINTERFACEREPOSITORYRepository
    {
        public #NOMEREPOSITORYRepository(IOptions<ProviderConnector> optionProviderConnector,
           ILogger<#NOMEREPOSITORYRepository> logger,
           IHttpContextAccessor httpContextAccessor,
           IEncryptConnectionString encryptConnectionString) : base(optionProviderConnector, logger, httpContextAccessor, encryptConnectionString)
        {
        }

		#METODOREPOSITORY
        
    }
}
