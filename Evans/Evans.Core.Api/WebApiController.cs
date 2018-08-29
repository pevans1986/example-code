using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Http;

using Evans.Core.Service;

namespace Evans.Core.Api
{
	public class WebApiController<TModel> : ApiController
		where TModel : class
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

		// DELETE api/values/5
		[HttpDelete]
		public virtual IHttpActionResult Delete(object id)
		{
			Service.Delete(id);
			return Ok();
		}

		// GET api/values
		[HttpGet]
		public virtual IHttpActionResult Get()
		{
			var models = Service.GetAll();
			return Ok(models);
		}

		// GET api/values/5
		[HttpGet]
		public virtual IHttpActionResult Get(object id)
		{
			var model = Service.GetById(id);
			return Ok(model);
		}

		// POST api/values
		[HttpPost]
		public virtual IHttpActionResult Post(TModel model)
		{
			Service.Add(model);
			return Ok();
		}

		// PUT api/values/5
		[HttpPut]
		public virtual IHttpActionResult Put(object id, TModel model)
		{
			Service.Update(id, model);
			return Ok();
		}

		#endregion Public Methods
	}
}