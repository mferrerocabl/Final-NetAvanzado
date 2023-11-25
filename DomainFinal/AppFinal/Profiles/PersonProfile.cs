using AppFinal.Models;
using AutoMapper;
using DomainFinal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFinal.Profiles
{
    public class PersonProfile : Profile
    {
        public PersonProfile() 
        {
            CreateMap<Person, PersonDto>();
        }
    }
}

