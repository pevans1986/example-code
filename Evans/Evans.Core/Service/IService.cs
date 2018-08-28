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
	}
}