using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                // Domain To Dto
                cfg.CreateMap<Customer, CustomerDto>();
                cfg.CreateMap<Movie, MovieDto>();

                // Dto To Domain
                cfg.CreateMap<CustomerDto, Customer>()
                    .ForMember(c => c.Id, opt => opt.Ignore());
                cfg.CreateMap<MovieDto, Movie>()
                    .ForMember(m => m.Id, opt => opt.Ignore());
            });

            configuration.CreateMapper();

        }
    }
}