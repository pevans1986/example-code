namespace Evans.Api
{
	using System.Data.Entity;
	using System.Web.Http;

	using Evans.Core.Repository;
	using Evans.Core.Service;
	using Evans.Repository.Ef;
	using Evans.Service;

	using SimpleInjector;
	using SimpleInjector.Integration.WebApi;
	using SimpleInjector.Lifestyles;

	public static class SimpleInjectorWebApiInitializer
	{
		#region Public Methods

		/// <summary>
		/// Initialize the container and register it as Web API Dependency Resolver.
		/// </summary>
		/// <param name="config"></param>
		public static void Initialize(HttpConfiguration config)
		{
			var container = new Container();
			container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
			RegisterServicesAndComponents(container);
			container.RegisterWebApiControllers(config);
			container.Verify();

			GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
		}

		#endregion Public Methods

		#region Private Methods

		private static void RegisterServicesAndComponents(Container container)
		{
			container.Register<DbContext, DomainContext>(Lifestyle.Scoped);
			container.Register(typeof(IRepository<>), typeof(EfRepository<>), Lifestyle.Scoped);
			container.Register(typeof(IService<>), typeof(Service<>), Lifestyle.Scoped);
		}

		#endregion Private Methods
	}
}