using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Evans.Core.IoC;
using Evans.Core.Logging;
using Evans.Core.Repository;
using Evans.Core.Service;
using Evans.Service;

using SimpleInjector;

namespace Evans.IoC.SimpleInjector
{
	public class SimpleInjectorContainer : Container, IContainer
	{
		#region Methods

		public IContainer AutoRegisterRepositories()
		{
			RegisterConditional(
				typeof(IRepository<>),
				typeof(Repository<>),
				Lifestyle.Scoped,
				context => !context.Handled);

			return this;
		}

		public IContainer AutoRegisterServiceClasses()
		{
			RegisterConditional(
				typeof(IService<>),
				typeof(Service<>),
				Lifestyle.Scoped,
				context => !context.Handled);

			return this;
		}

		public IContainer AutoRegisterServices()
		{
			// TODO Implement auto-registration
			return this;
		}

		public IContainer RegisterConcreteType<TService>() where TService : class
		{
			// TODO Implement concrete type registration
			throw new NotImplementedException();
		}

		public IContainer RegisterLogger(ILogger logger)
		{
			RegisterSingleton(logger);
			return this;
		}

		public IContainer RegisterServiceType<TService, TImplementation>()
			where TService : class
			where TImplementation : class, TService
		{
			Register<TService, TImplementation>();
			return this;
		}

		public IContainer RegisterServiceType(Type serviceType, Type implementationType)
		{
			Register(serviceType, implementationType);
			return this;
		}

		public IContainer RegisterSingleton<TSingleton>(TSingleton instance)
			where TSingleton : class
		{
			RegisterInstance(instance);
			return this;
		}

		public TService Resolve<TService>() where TService : class => GetInstance<TService>();

		public object Resolve(Type serviceType) => GetInstance(serviceType);

		public virtual bool Validate()
		{
			Verify();

			// Successful if this is reached - Verify() throws exceptions
			return true;
		}

		#endregion Methods
	}
}