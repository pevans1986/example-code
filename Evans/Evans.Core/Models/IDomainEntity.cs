using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evans.Core.Models
{
	/// <summary>
	/// To be implemented by data-backed models with a <see cref="Guid"/> identifier named <c>Id</c>.
	/// </summary>
	public interface IDomainEntity
	{
		#region Public Properties

		/// <summary>
		/// Record's unique identifier.
		/// </summary>
		Guid Id { get; set; }

		#endregion Public Properties
	}
}