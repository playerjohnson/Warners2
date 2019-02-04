using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warners.Common.Extensions
{
    public static class AutoMapperExtensions
    {
        public static TDestination Map<TSource, TDestination>(this TDestination destination, TSource source)
            => Mapper.Map(source, destination);
    }
}
