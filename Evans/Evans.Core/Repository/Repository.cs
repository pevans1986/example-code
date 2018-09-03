using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Evans.Core.Models;

namespace Evans.Core.Repository
{
	public abstract class Repository<TModel>
		where TModel : class, IDomainEntity
	{

	}
}
