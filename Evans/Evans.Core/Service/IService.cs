using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evans.Core.Service
{
	public interface IService<TModel>
		where TModel : class
	{
		void Add(TModel model);

		void Delete(object id);

		IEnumerable<TModel> GetAll();

		TModel GetById(object id);

		void Update(object id, TModel model);
	}
}