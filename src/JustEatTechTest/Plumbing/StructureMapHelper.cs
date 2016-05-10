using StructureMap;
using StructureMap.Graph;

namespace JustEatTechTest.Web.Plumbing
{
    public class StructureMapHelper
    {
        private const string NamespacePrefix = "JustEatTechTest";

        public static IContainer CreateContainer()
        {
            IContainer container = new Container(config => config.Scan(scan =>
            {
                scan.TheCallingAssembly();
                scan.AssembliesFromApplicationBaseDirectory(filter => filter.FullName.StartsWith(NamespacePrefix));
                scan.LookForRegistries();
                scan.WithDefaultConventions();
            }));


            return container;
        }
    }
}