using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;
using Evans.Core.Models;

namespace Evans.Core
{
	/// <summary>
	/// Allows subscribing to changes affecting <see cref="IDomainEntity"/> objects.
	/// </summary>
	public interface IChangeSubscriber
	{
		#region Methods

		void OnCreated<T>(IEnumerable<T> entities) where T : IDomainEntity;

		void OnDeleted<T>(IEnumerable<T> entities) where T : IDomainEntity;

		void OnUpdated<T>(IEnumerable<T> entities) where T : IDomainEntity;

		#endregion Methods
	}
}