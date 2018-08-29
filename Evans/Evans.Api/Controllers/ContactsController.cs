using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Evans.Core.Api;
using Evans.Core.Service;
using Evans.Models;

namespace Evans.Api.Controllers
{
	public class ContactsController : WebApiController<Contact>
	{
		public ContactsController(IService<Contact> service) : base(service)
		{
		}
	}
}
