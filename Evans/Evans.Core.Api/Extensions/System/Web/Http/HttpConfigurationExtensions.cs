using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace System.Web.Http
{
	public static class HttpConfigurationExtensions
	{
		#region Public Methods

		/// <summary>
		/// Convenience method for registering default <see cref="JsonMediaTypeFormatter"/> settings.
		/// </summary>
		/// <param name="self">The self.</param>
		public static void RegisterDefaultJsonFormatter(this HttpConfiguration self)
		{
			var jsonFormatter = 
				self.Formatters.OfType<JsonMediaTypeFormatter>().FirstOrDefault()
				?? new JsonMediaTypeFormatter();

			jsonFormatter.Indent = true;
			jsonFormatter.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
			self.Formatters.Add(jsonFormatter);
		}

		#endregion Public Methods
	}
}