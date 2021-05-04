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
    public class #NOMEIMPLEMENTACAOQUERY : #NOMEINTERFACEQUERY
    {
        private readonly IMapper _mapper;
        private readonly ILogger<#NOMEIMPLEMENTACAOQUERY> _logger;
        private readonly #NOMEINTERFACEREPOSITORY _repository;

        public #NOMEIMPLEMENTACAOQUERY(
            IMapper mapper,
            ILogger<#NOMEIMPLEMENTACAOQUERY> logger,
            #NOMEINTERFACEREPOSITORY #NOMEVARIAVELREPOSITORY
            )
        {
            _mapper = mapper;
            _logger = logger;
            _repository = #NOMEVARIAVELREPOSITORY;
        }

#METODOS

    }
}
