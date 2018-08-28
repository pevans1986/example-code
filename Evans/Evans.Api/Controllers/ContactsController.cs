using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Evans.Core.Api;
using Evans.Models;

using Microsoft.AspNetCore.Mvc;

namespace Evans.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContactsController : WebApiController<Contact>
	{
		#region Public Constructors

		public ContactsController(Core.Service.IService<Contact> service) : base(service)
		{
		}

		#endregion Public Constructors
	}
}