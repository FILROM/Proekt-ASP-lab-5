using System;
using System.Linq;
using System.Reflection;
using AutoMapper;

namespace Notes.Application.Common.Mappings
{
    public class AssamblyMappingProfile : Profile
    {
        public AssamblyMappingProfile(Assembly assembly) =>
            ApplyMappingsFromAssambly(assembly);

        private void ApplyMappingsFromAssambly(Assembly assembly)
        {
            var types = assembly.GetExportedTypes()
                .Where(type => type.GetInterfaces()
                .Any(i => i.IsGenericType &&
                i.GetGenericTypeDefinition() == typeof(IMapWith<>)))
                .ToList();

            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);
                var methodInfo = type.GetMethod("Mapping");
                    methodInfo?.Invoke(instance, new object[] { this });
            }
        }
    }
}
