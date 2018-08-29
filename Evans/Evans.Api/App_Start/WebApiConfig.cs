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

		public static void Register(HttpConfiguration config)
		{
			// Set up the DI container
			SimpleInjectorWebApiInitializer.Initialize(config);

			// Configure Web API routes
			config.MapHttpAttributeRoutes();
			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}"
			);

			RegisterFormatters(config);
		}

		public static void RegisterFormatters(HttpConfiguration config)
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

		#endregion Public Methods
	}
}