using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Evans.Core.Models;

namespace Evans.Core.Repository
{
	public interface IRepository<TModel> 
		where TModel : class, IDomainEntity
	{
		#region Public Methods

		void Add(TModel entity);

		void Add(IEnumerable<TModel> entities);

		void Delete(Guid id);

		void Delete(TModel entity);

		void Delete(IEnumerable<TModel> entities);

		void Delete(Expression<Func<TModel, bool>> predicate);

		bool Exists(Guid id);

		IQueryable<TModel> GetAll();

		TModel GetById(Guid id);

		IQueryable<TModel> Get(Expression<Func<TModel, bool>> predicate);

		void SaveChanges();

		void Update(Guid id, TModel model);

		#endregion Public Methods
	}
}