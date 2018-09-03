using System;
using System.Collections.Generic;
using System.Linq;

using Evans.Core.Api;
using Evans.Core.Service;
using Evans.Models;

namespace Evans.Api.Controllers
{
	public class EmailAddressesController : WebApiController<EmailAddress>
	{
		#region Public Constructors

		public EmailAddressesController(IService<EmailAddress> service) : base(service)
		{
		}

		#endregion Public Constructors
	}
}