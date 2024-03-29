﻿using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.Resolution;
using Unity.Lifetime;
using YumiChanDBCore.Storage;
using YumiChanDBCore.Storage.Implementations;
using Discord.WebSocket;
using Unity.Injection;
using YumiChanDBCore.Discord;

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

            _container.RegisterSingleton<IDataStorage, InMemoryStorage>();
            _container.RegisterSingleton<ILogger, Logger>();
            _container.RegisterType<DiscordSocketConfig>(new InjectionFactory(i => SocketConfig.GetDefault()));
            _container.RegisterSingleton<DiscordSocketClient>(new InjectionConstructor(typeof(DiscordSocketConfig)));
            _container.RegisterSingleton<Discord.Connection>();
        }

        public static T Resolve<T>()
        {
            return (T)Container.Resolve(typeof(T), string.Empty, new CompositeResolverOverride());
        }
    }
}
