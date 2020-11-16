using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Evans.Core.Web.Mvc
{
	public interface IMvcRouter
	{
		#region Properties

		IDictionary<string, Type> DataModelCache { get; }

		#endregion Properties

		#region Methods

		ActionResult RouteDynamicRequest(RouteInfo routeInfo);

		#endregion Methods
	}
}
