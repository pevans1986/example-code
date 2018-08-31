using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Evans.Api
{
	public static class WebApiConfig
	{
		#region Public Methods

		/// <summary>
		/// Initializes the web API routes, IoC container, and response formatters.
		/// </summary>
		/// <param name="config"></param>
		public static void Register(HttpConfiguration config)
		{
			// Set up the DI container
			SimpleInjectorWebApiInitializer.Initialize(config);

			// Configure Web API routes
			config.MapHttpAttributeRoutes();
			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);

			// Register media-type formatters
			config.Formatters.Clear();
			config.RegisterDefaultJsonFormatter();

			// Register Swagger UI for API documentation
			SwaggerConfig.Register(config);
		}

		#endregion Public Methods
	}
}