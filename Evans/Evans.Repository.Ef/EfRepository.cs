using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Evans.Core.Models;
using Evans.Core.Repository;

namespace Evans.Repository.Ef
{
	public class EfRepository<TEntity> : IRepository<TEntity>, IDisposable
		where TEntity : class, IDomainEntity
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

		public void Delete(Guid id)
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

		public bool Exists(Guid id) => GetById(id) != null;

		public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate) => EntityDbSet.Where(predicate);

		public IQueryable<TEntity> GetAll() => EntityDbSet;

		public TEntity GetById(Guid id) => EntityDbSet.Find(id);

		public void SaveChanges() => _context.SaveChanges();

		public void Update(Guid id, TEntity model)
		{
			bool _valuesAreUpdated = false;
			var entry = _context.Entry(model);

			// If the entry is detached, get the attached entity represented by the model and update
			// its values instead of changing the EntityState. Otherwise, a duplicate key exception
			// will be thrown if the entity represented by the model is attached.
			if (entry.State == EntityState.Detached)
			{
				var attachedEntity = GetById(id);
				if (attachedEntity != null)
				{
					_context.Entry(attachedEntity).CurrentValues.SetValues(model);
					_valuesAreUpdated = true;
				}
			}

			if (!_valuesAreUpdated)
			{
				entry.State = EntityState.Modified;
			}
		}

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