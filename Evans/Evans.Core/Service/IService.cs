using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Evans.Core.Models;

namespace Evans.Core.Service
{
	public interface IService<TModel> 
		where TModel : class, IDomainEntity
	{
		void Add(TModel model);

		void Delete(Guid id);

		IEnumerable<TModel> GetAll();

		TModel GetById(Guid id);

		void Update(Guid id, TModel model);
	}
}