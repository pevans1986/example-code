using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;
using Evans.Core.Models;

using System.Collections.Generic;

namespace Evans.Core
{
	public interface IChangeSubscriber
	{
		#region Methods

		void OnCreated<T>(IEnumerable<T> entities) where T : IDomainEntity;

		void OnDeleted<T>(IEnumerable<T> entities) where T : IDomainEntity;

		void OnUpdated<T>(IEnumerable<T> entities) where T : IDomainEntity;

		#endregion Methods
	}
}