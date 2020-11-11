using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evans.Core.IoC
{
	public interface IContainer
	{
		#region Public Methods

		/// <summary>
		/// Perform auto-registration of service types to minimize the number of explicit registrations.
		/// </summary>
		/// <returns></returns>
		IContainer AutoRegisterServices();

		IContainer RegisterConcreteType<TService>() where TService : class;

		//IContainer RegisterLogger(ILogger logger);

		// TODO RegisterMapper(IMapper mapper)

		IContainer RegisterServiceType<TService, TImplementation>()
			where TService : class
			where TImplementation : class;

		IContainer RegisterServiceType(Type serviceType, Type implementationType);

		/// <summary>
		/// Registers a single instance of an object of type <typeparamref name="TSingleton"/>.  When 
		/// the container resolves an object of that type, the same instance will always be returned.
		/// </summary>
		/// <typeparam name="TSingleton"></typeparam>
		/// <param name="instance"></param>
		/// <returns></returns>
		IContainer RegisterSingleton<TSingleton>(TSingleton instance)
							where TSingleton : class;

		/// <summary>
		/// Returns an instance of type <typeparamref name="TService"/> from the container.
		/// </summary>
		/// <typeparam name="TService">The object type</typeparam>
		/// <returns></returns>
		TService Resolve<TService>()
			where TService : class;

		/// <summary>
		/// Returns an instance of type <paramref name="serviceType"/> from the container.
		/// </summary>
		/// <param name="serviceType">The object type</param>
		/// <returns></returns>
		object Resolve(Type serviceType);

		/// <summary>
		/// Perform validation to verify container configuration.
		/// </summary>
		/// <returns></returns>
		bool Validate();

		#endregion Public Methods
	}
}
