using TopDown.Comercial.Repository.Domain.Core.Entities.Campanha;
using TopDown.Comercial.Repository.DTO.Campanha;

namespace TopDown.Comercial.Repository.Infra.CrossCutting.IoC.Profile
{
    internal class PlanosCampanhaEntityToPlanosCampanhaDTO : AutoMapper.Profile
    {
        public PlanosCampanhaEntityToPlanosCampanhaDTO()
        {
            CreateMap<PlanosEntity, PlanosCampanhaDTO>().ReverseMap();
        }
    }
}
