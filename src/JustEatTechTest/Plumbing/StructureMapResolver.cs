using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Dependencies;
using StructureMap;

namespace JustEatTechTest.Web.Plumbing
{
    public class StructureMapResolver : IDependencyResolver
    {
        private readonly IContainer _container;

        public StructureMapResolver(IContainer container)
        {
            _container = container;
        }

        public void Dispose()
        {
            _container.Dispose();
        }

        public object GetService(Type serviceType)
        {
            try
            {
                return _container.GetInstance(serviceType);
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _container.GetAllInstances(serviceType).OfType<object>();
            }
            catch
            {
                return null;
            }
        }

        public IDependencyScope BeginScope()
        {
            var child = _container.CreateChildContainer();
            return new StructureMapResolver(child);
        }


    }
}