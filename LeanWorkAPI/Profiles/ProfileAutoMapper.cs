using System;
using AutoMapper;
using LeanWorkAPI.DTO;
using LeanWorkAPI.Models;

namespace LeanWorkAPI.Profiles;

public class ProfileAutoMapper : Profile
{
    public ProfileAutoMapper()
    {
        CreateMap<ItemCarrinhoModel, ResponseAdicionarItemDTO>().ReverseMap();
    }
}
