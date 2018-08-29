using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

using Newtonsoft.Json;

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

			RegisterFormatters(config);
		}

		#endregion Public Methods

		#region Private Methods

		private static void RegisterFormatters(HttpConfiguration config)
		{
			config.Formatters.Clear();

			var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().FirstOrDefault();
			if (jsonFormatter == null)
			{
				jsonFormatter = new JsonMediaTypeFormatter();
			}

			jsonFormatter.Indent = true;
			jsonFormatter.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
			config.Formatters.Add(jsonFormatter);
		}

		#endregion Private Methods
	}
}