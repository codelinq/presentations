
using System.Data.Objects;
using SolidApp.Domain;
using SolidApp.Implementation;
using SolidApp.Infrastructure.Data;
using StructureMap.Configuration.DSL;

namespace SolidApp.Config
{
    public class AppRegistry : Registry
    {
        public AppRegistry()
        {
            Scan(x =>
                 {
                     x.TheCallingAssembly();
                     x.WithDefaultConventions();
                 });

            For(typeof (IRepository<>)).Use(typeof(Repository<>));

            For<ObjectContext>().Use(() => new Model1Container("myConnectionString"));
            
            For<IDataContext>().Use<EFDataContext>();
        }
    }
}
