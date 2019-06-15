using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.Resolution;
using Unity.Lifetime;
using YumiChanDBCore.Storage;
using YumiChanDBCore.Storage.Implementations;

namespace YumiChanDBCore
{
    public static class Unity
    {
        private static UnityContainer _container;

        public static UnityContainer Container
        {
            get
            {
                if (_container == null)
                {
                    RegisterTypes();
                }

                return _container;
            }
        }

        public static void RegisterTypes()
        {
            _container = new UnityContainer();
            _container.RegisterType<IDataStorage, InMemoryStorage>(new ContainerControlledLifetimeManager());
        }

        public static T Resolve<T>()
        {
            return (T)Container.Resolve(typeof(T), string.Empty, new CompositeResolverOverride());
        }
    }
}
