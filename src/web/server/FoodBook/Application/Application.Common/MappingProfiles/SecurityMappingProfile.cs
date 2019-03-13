using System;
using AutoMapper;
using FoodBook.Application.Common.Security.Authenticate;
using FoodBook.Application.Common.Security.SignIn;
using FoodBook.Application.Common.Security.SignUp;
using FoodBook.Domain.Entities;
using FoodBook.Infrastructure.Common.Services;
using FoodBook.Infrastructure.Services.Security;
using JetBrains.Annotations;

namespace FoodBook.Application.Common.MappingProfiles
{
    [UsedImplicitly]
    internal class SecurityMappingProfile : Profile
    {
        public SecurityMappingProfile()
        {
            CreateMap<UserAccount, AuthenticateResponse>();

            CreateMap<SignInRequest, AuthenticationData>();
            
            CreateMap<SignUpRequest, UserAccount>()
                .ForMember(d => d.Email, o => o.MapFrom(s => s.Email))
                .ForMember(d => d.Login, o => o.MapFrom(s => s.UserName))
                .ForAllOtherMembers(o => o.Ignore());
            
            CreateMap<CryptographicData, UserAccount>()
                .ForMember(d => d.Salt, o => o.MapFrom(s => Convert.ToBase64String(s.Salt)))
                .ForMember(d => d.SecurityStamp, o => o.MapFrom(s => Convert.ToBase64String(s.HashKey)))
                .ForAllOtherMembers(o => o.Ignore());
        }
    }
}