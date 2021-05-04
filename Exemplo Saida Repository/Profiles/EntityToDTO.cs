using TopDown.Comercial.Repository.Domain.Core.Entities;
using TopDown.Comercial.Repository.DTO;

namespace TopDown.Comercial.Repository.Infra.CrossCutting.IoC.Profile
{
    internal class #NOMEPROFILE : AutoMapper.Profile
    {
        public #NOMEPROFILE()
        {
            CreateMap<#CLASSEENTITY, #CLASSEDTO>().ReverseMap();
        }
    }
}
