using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

using Evans.Core.Extensions.System;
using Evans.Core.Logging;
using Evans.Core.Models;
using Evans.Core.Service;

namespace Evans.Core.Web.Mvc.Controllers
{
	/// <summary>
	/// Base class for ASP.Net MVC controllers.
	/// </summary>
	/// <remarks>This class extends <see cref="Controller" /> and provides basic CRUD operations.</remarks>
	public class MvcController<TModel> : Controller
		where TModel : class, IDomainEntity
	{
		#region Public Constructors

		/// <summary>
		/// Uses the given <see cref="IService{TModel}" /> to perform operations on the model.
		/// </summary>
		/// <param name="service"></param>
		/// <param name="logger"></param>
		/// <returns></returns>
		public MvcController(IService<TModel> service, ILogger logger)
		{
			Service = service;
			Log = logger;
		}

		#endregion Public Constructors

		#region Protected Properties

		protected ILogger Log { get; }

		/// <summary>
		/// The business logic class for performing actions on the model.
		/// </summary>
		protected IService<TModel> Service { get; }

		#endregion Protected Properties

		#region Public Methods

		/// <summary>
		/// Returns the default view for creating a new record.
		/// </summary>
		/// <remarks>Serves HTTP GET requests to [Area]/[Controller]/Create</remarks>
		/// <returns></returns>
		[HttpGet]
		public virtual ActionResult Create()
		{
			return View(ControllerActions.CREATE, typeof(TModel).New());
		}

		/// <summary>
		/// Handles POST requests to create a new record using the given model created from form data.
		/// </summary>
		/// <remarks>Serves HTTP POST requests to [Area]/[Controller]/Create</remarks>
		/// <param name="entity"></param>
		/// <returns></returns>
		[HttpPost]
		[ValidateAntiForgeryToken]
		public virtual ActionResult Create(TModel entity)
		{
			try
			{
				Service.Add(entity);
				return RedirectToAction(ControllerActions.INDEX);
			}
			catch
			{
				return View();
			}
		}

		// GET: [Area]/[Controller]/Delete/{id}
		[HttpGet]
		public virtual ActionResult Delete(object id)
		{
			return View();
		}

		// POST: [Area]/[Controller]/Delete/{id}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public virtual ActionResult Delete(object id, FormCollection collection)
		{
			try
			{
				var guidId = Guid.Parse(id.ToString());
				Service.Delete(guidId);

				return RedirectToAction(ControllerActions.INDEX);
			}
			catch
			{
				return View();
			}
		}

		// GET: [Area]/[Controller]/Details/{id}
		[HttpGet]
		public virtual ActionResult Details(object id)
		{
			Guid.TryParse(id.ToString(), out Guid guidId);
			var model = Service.GetById(guidId);

			return View(model);
		}

		// GET: [Area]/[Controller]/Edit/{id}
		[HttpGet]
		public virtual ActionResult Edit(object id)
		{
			Guid.TryParse(id.ToString(), out Guid guidId);
			var model = Service.GetById(guidId);

			return View(model);
		}

		// POST: [Area]/[Controller]/Edit/
		[HttpPost]
		[ValidateAntiForgeryToken]
		public virtual ActionResult Edit(TModel entity)
		{
			try
			{
				Service.Update(entity);
				return RedirectToAction(ControllerActions.INDEX);
			}
			catch
			{
				return View();
			}
		}

		// GET: [Area]/[Controller]
		[HttpGet]
		public virtual ActionResult Index()
		{
			var models = Service.GetAll();
			return View(models);
		}

		#endregion Public Methods
	}
}