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
            CreateMap<ProductVM, Product>().ForMember(des=>des.Quantity,p=>p.Ignore()).ReverseMap();
        }
    }
}
