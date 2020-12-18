using System;
using System.Linq;
using System.Reflection;

namespace P2k7.Api.Core.Extension
{
    static class IServiceCollectionExtension
    {
        public static void RegisterTransientNamespace(this IServiceCollection services, string[] Assemblies, string[] NameSpaces)
        {

            foreach (var a in Assemblies)
            {
                Assembly loadedAss = Assembly.Load(a);
                var q = from t in loadedAss.GetTypes()
                        where t.IsClass 
                        && !t.Name.Contains("<")
                        && !t.Name.Equals("Program")
                        && NameSpaces.Contains(t.Namespace)
                        select t;

                foreach (var t in q.ToList())
                {
                    Type.GetType(t.Name);
                    services.AddTransient(Type.GetType(t.FullName), Type.GetType(t.FullName));
                }
            }
        }
       public static void RegisterSingletonNamespace(this IServiceCollection services, string[] Assemblies, string[] NameSpaces)
        {

            foreach (var a in Assemblies)
            {
                Assembly loadedAss = Assembly.Load(a);
                var q = from t in loadedAss.GetTypes()
                        where t.IsClass 
                        && !t.Name.Contains("<")
                        && !t.Name.Equals("Program")
                        && NameSpaces.Contains(t.Namespace)
                        select t;

                foreach (var t in q.ToList())
                {
                    Type.GetType(t.Name);
                    services.AddSingleton(Type.GetType(t.FullName), Type.GetType(t.FullName));
                }
            }
        }
    }
}
