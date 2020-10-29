using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Http;

using Evans.Core.Models;
using Evans.Core.Service;

namespace Evans.Core.Api
{
	/// <summary>
	/// Base web API controller object that implements some default functionality like HTTP method
	/// handlers (delete / get / post / put).
	/// </summary>
	public class WebApiController<TModel> : ApiController
		where TModel : class, IDomainEntity
	{
		#region Public Constructors

		public WebApiController(IService<TModel> service)
		{
			Service = service;
		}

		#endregion Public Constructors

		#region Protected Properties

		protected IService<TModel> Service { get; }

		#endregion Protected Properties

		#region Public Methods

		[HttpDelete]
		public virtual IHttpActionResult Delete(Guid id)
		{
			Service.Delete(id);
			return Ok();
		}

		[HttpGet]
		public virtual IHttpActionResult Get()
		{
			var models = Service.GetAll();
			return Ok(models);
		}

		[HttpGet]
		public virtual IHttpActionResult Get(Guid id)
		{
			var model = Service.GetById(id);
			return Ok(model);
		}

		[HttpPost]
		public virtual IHttpActionResult Post(TModel model)
		{
			Service.Add(model);
			return Ok();
		}

		[HttpPut]
		public virtual IHttpActionResult Put(Guid id, TModel model)
		{
			Service.Update(id, model);
			return Ok();
		}

		#endregion Public Methods
	}
}