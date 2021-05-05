using Gndi.Gerenciador.Portais.Comercial.Service.Api.DTO.Campanhas;
using Gndi.Gerenciador.Portais.Comercial.Service.Api.Model.Campanha;

namespace Gndi.Gerenciador.Portais.Comercial.Service.Api.Profile
{
    public class #CLASSEDTOTo#CLASSEMODEL : AutoMapper.Profile
    {
        public #CLASSEDTOTo#CLASSEMODEL()
        {
            CreateMap<#CLASSEDTO, #CLASSEMODEL>()
#MEMBROS                
                .ReverseMap()
                .ForAllOtherMembers(opt => opt.Ignore());
        }
    }
}
