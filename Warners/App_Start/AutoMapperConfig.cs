using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Warners.Data.Models;
using Warners.Models;

namespace Warners.App_Start
{
    public static class AutoMapperConfig
    {
        public static void ConfigureMapping()
        {
            Mapper.Initialize(qaf =>
            {
                qaf.CreateMap<FoodItem, SelectListItem>(memberList: MemberList.None)
                    .ForMember(d => d.Value, o => o.MapFrom(s => s.ID))
                    .ForMember(d => d.Text, o => o.MapFrom(s => s.Name))
                    .ReverseMap();                
            });
        }
    }
}