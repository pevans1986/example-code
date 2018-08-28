using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Evans.Core.Repository;

namespace Evans.Repository.Ef
{
	public class EfRepository<TEntity> : IRepository<TEntity>, IDisposable
		where TEntity : class
	{
		#region Private Fields

		private readonly DbContext _context;

		private bool _isDisposed;

		#endregion Private Fields

		#region Public Constructors

		public EfRepository(DbContext context)
		{
			_context = context;
		}

		#endregion Public Constructors

		#region Protected Properties

		protected DbSet<TEntity> EntityDbSet => _context.Set<TEntity>();

		#endregion Protected Properties

		#region Public Methods

		public void Add(TEntity entity)
		{
			EntityDbSet.Add(entity);
		}

		public void Add(IEnumerable<TEntity> entities)
		{
			EntityDbSet.AddRange(entities);
		}

		public void Delete(TEntity entity)
		{
			EntityDbSet.Remove(entity);
		}

		public void Delete(IEnumerable<TEntity> entities)
		{
			EntityDbSet.RemoveRange(entities);
		}

		public void Delete(object id)
		{
			var entity = EntityDbSet.Find(id);
			Delete(entity);
		}

		public void Delete(Expression<Func<TEntity, bool>> predicate)
		{
			var entities = EntityDbSet.Where(predicate);
			Delete(entities);
		}

		public void Dispose()
		{
			Dispose(true);
		}

		public bool Exists(object id) => GetById(id) != null;

		public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate) => EntityDbSet.Where(predicate);

		public TEntity GetById(object id) => EntityDbSet.Find(id);

		public void SaveChanges() => _context.SaveChanges();

		#endregion Public Methods

		#region Protected Methods

		protected virtual void Dispose(bool disposing)
		{
			if (!_isDisposed)
			{
				if (disposing)
				{
					_context?.Dispose();
				}
				_isDisposed = true;
			}
		}

		#endregion Protected Methods
	}
}