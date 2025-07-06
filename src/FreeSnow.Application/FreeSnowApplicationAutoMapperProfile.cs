using AutoMapper;
using FreeSnow.Dtos;
using FreeSnow.Entities;

namespace FreeSnow;

public class FreeSnowApplicationAutoMapperProfile : Profile
{
    public FreeSnowApplicationAutoMapperProfile()
    {
        CreateMap<GroupPurchase, GroupPurchaseDto>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
