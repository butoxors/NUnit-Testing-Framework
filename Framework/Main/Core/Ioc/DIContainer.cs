using System;
using System.Collections.Generic;
using System.Linq;

namespace Framework.Main.Core.Ioc
{
    public static class DIContainer
    {
        private static List<ServiceDescriptor> serviceDescriptors = new List<ServiceDescriptor>();

        public static object GetService(Type serviceType)
        {
            var descriptor = serviceDescriptors.SingleOrDefault(x => x.ServiceType == serviceType);

            if (descriptor == null)
                throw new System.Exception($"Service of type {serviceType.Name} is not registered");

            if (descriptor.Implementation != null)
                return descriptor.Implementation;

            var actualType = descriptor.ImplementationType ?? descriptor.ServiceType;

            if (actualType.IsAbstract || actualType.IsInterface)
                throw new Exception("Cannot instantiate abstract classes or interfaces");

            var constructorInfo = actualType.GetConstructors().First();

            var parameters = constructorInfo.GetParameters()
                .Select(x => GetService(x.ParameterType)).ToArray();

            var implementation = Activator.CreateInstance(actualType, parameters);

            if (descriptor.LifeTime == ServiceLifeTime.Singleton)
                descriptor.Implementation = implementation;

            return implementation;
        }

        public static T GetService<T>()
        {
            return (T)GetService(typeof(T));
        }

        public static void Register<TService>(ServiceLifeTime lifeTime)
        {
            serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), lifeTime));
        }

        public static void Register<TService, TImplementation>(ServiceLifeTime lifeTime) where TImplementation : TService
        {
            serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), typeof(TImplementation), lifeTime));
        }

        public static void Register<TService>(TService implementation, ServiceLifeTime lifeTime)
        {
            serviceDescriptors.Add(new ServiceDescriptor(implementation, lifeTime));
        }
    }
}
