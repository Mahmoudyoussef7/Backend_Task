using AutoMapper;
using BL.DTO;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Profiler
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductVM>().ForMember(des=>des.Description,p=>p.Ignore()).ReverseMap();
        }
    }
}
