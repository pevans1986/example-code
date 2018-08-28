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
	}
}