﻿namespace Particular.ServiceInsight.Desktop.Modules
{
    using System;
    using Autofac;
    using Castle.DynamicProxy;
    using Core.Infrastructure;
    using Startup;

    public class InterfacesModule : Module
    {
        private readonly ProxyGenerator _generator;

        public InterfacesModule()
        {
            _generator = new ProxyGenerator();
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterInstance(GenerateInterfaceProxyForType<IEnvironment>(typeof (Environment))).As<IEnvironment>();
        }

        private object GenerateInterfaceProxyForInstance<T>(object classToProxy) where T : class
        {
            return _generator.CreateInterfaceProxyWithoutTarget<T>(new CallForwarderInterceptor(classToProxy));
        }

        private object GenerateInterfaceProxyForType<T>(Type type) where T : class
        {
            return _generator.CreateInterfaceProxyWithoutTarget<T>(new CallForwarderInterceptor(type));
        }
    }
}