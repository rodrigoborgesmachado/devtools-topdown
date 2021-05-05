using Gndi.Gerenciador.Portais.Comercial.Service.Api.DTO.Campanhas;
using Gndi.Gerenciador.Portais.Comercial.Service.Api.Model.Campanha;
using System.Collections.Generic;
using TopDown.Core.Domain.DTO;

namespace Gndi.Gerenciador.Portais.Comercial.Service.Api.Profile
{
    public class ResponseDTO#CLASSERETORNOREPOSIROTYTo#CLASSERETORNOMODEL : AutoMapper.Profile
    {
        public ResponseDTO#CLASSERETORNOREPOSIROTYTo#CLASSERETORNOMODEL()
        {
            CreateMap<ResponseDTO<#CLASSERETORNOREPOSIROTY>, #CLASSERETORNOMODEL>()
#MEMBROS
               .ForAllOtherMembers(opt => opt.Ignore());
        }
    }
}
