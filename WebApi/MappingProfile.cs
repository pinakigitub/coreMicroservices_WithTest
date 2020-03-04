using AutoMapper;
using Domain.Models;
using Persistance.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi
{
    public class MappingProfile: Profile
    {
        
        public MappingProfile()
        {

            CreateMap<Productinfos, ProductInfos>().ReverseMap();


        }
    }
}
