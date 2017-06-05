﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EESLP.Services.Scripts.API.Entities;
using EESLP.Services.Scripts.API.ViewModels;

namespace EESLP.Services.Scripts.API.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ScriptAddModel, Script>();
            CreateMap<Script, ScriptViewModel>();
            CreateMap<ScriptUpdateModel, Script>()
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => (sourceMember != null)));
            CreateMap<Host, HostViewModel>();
            CreateMap<HostAddModel, Host>();
            CreateMap<HostUpdateModel, Host>()
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => (sourceMember != null)));
        }
    }
}