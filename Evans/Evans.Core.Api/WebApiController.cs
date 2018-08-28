using System;
using System.Collections.Generic;
using System.Text;

using Evans.Core.Service;

using Microsoft.AspNetCore.Mvc;

namespace Evans.Core.Api
{
	public class WebApiController<TModel> : ControllerBase
		where TModel : class
	{
		#region Private Fields

		private readonly IService<TModel> _service;

		#endregion Private Fields

		#region Public Constructors

		public WebApiController(IService<TModel> service)
		{
			_service = service;
		}

		#endregion Public Constructors

		#region Protected Properties

		protected IService<TModel> Service => _service;

		#endregion Protected Properties

		#region Public Methods

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public ActionResult Delete(object id)
		{
			_service.Delete(id);
			return Ok();
		}

		// GET api/values
		[HttpGet]
		public virtual ActionResult<IEnumerable<TModel>> Get()
		{
			var models = _service.GetAll();
			return Ok(models);
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public ActionResult<TModel> Get(object id)
		{
			var model = _service.GetById(id);
			return Ok(model);
		}

		// POST api/values
		[HttpPost]
		public ActionResult Post(TModel model)
		{
			_service.Add(model);
			return Ok();
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public ActionResult Put(object id, TModel model)
		{
			_service.Update(id, model);
			return Ok();
		}

		#endregion Public Methods
	}
}