using AutoMapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using TopDown.Comercial.Repository.Domain.Core.Validations;
using TopDown.Comercial.Repository.DTO;
using TopDown.Core.Domain.DTO;

namespace TopDown.Comercial.Repository.Domain.Queries
{
    public class #NOMEIMPLEMENTACAOQUERYQuery : #NOMEINTERFACEQUERYQuery
    {
        private readonly IMapper _mapper;
        private readonly ILogger<#NOMEIMPLEMENTACAOQUERYQuery> _logger;
        private readonly #NOMEINTERFACEREPOSITORYRepository _repository;

        public #NOMEIMPLEMENTACAOQUERYQuery(
            IMapper mapper,
            ILogger<#NOMEIMPLEMENTACAOQUERYQuery> logger,
            #NOMEINTERFACEREPOSITORYRepository #NOMEVARIAVELREPOSITORYRepository
            )
        {
            _mapper = mapper;
            _logger = logger;
            _repository = #NOMEVARIAVELREPOSITORYRepository;
        }

        #METODOS

    }
}
