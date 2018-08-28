using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Evans.Core.Repository;
using Evans.Core.Service;

namespace Evans.Service
{
	public class Service<TModel> : IService<TModel>
		where TModel : class
	{
		#region Private Fields

		private readonly IRepository<TModel> _repository;

		#endregion Private Fields

		#region Public Constructors

		public Service(IRepository<TModel> repository)
		{
			_repository = repository;
		}

		#endregion Public Constructors

		#region Public Methods

		public void Add(TModel model)
		{
			_repository.Add(model);
			_repository.SaveChanges();
		}

		public void Delete(object id)
		{
			_repository.Delete(id);
			_repository.SaveChanges();
		}

		public IEnumerable<TModel> GetAll() => _repository.GetAll().ToList();

		public TModel GetById(object id) => _repository.GetById(id);

		public void Update(object id, TModel model)
		{
			_repository.Update(id, model);
			_repository.SaveChanges();
		}

		#endregion Public Methods
	}
}