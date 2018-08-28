using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Evans.Core.Repository
{
	public interface IRepository<TModel> where TModel : class
	{
		#region Public Methods

		void Add(TModel entity);

		void Add(IEnumerable<TModel> entities);

		void Delete(object id);

		void Delete(TModel entity);

		void Delete(IEnumerable<TModel> entities);

		void Delete(Expression<Func<TModel, bool>> predicate);

		bool Exists(object id);

		IQueryable<TModel> GetAll();

		TModel GetById(object id);

		IQueryable<TModel> Get(Expression<Func<TModel, bool>> predicate);

		void SaveChanges();

		void Update(object id, TModel model);

		#endregion Public Methods
	}
}