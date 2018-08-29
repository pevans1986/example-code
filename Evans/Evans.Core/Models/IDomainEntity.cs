using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evans.Core.Models
{
	public interface IDomainEntity
	{
		#region Public Properties

		Guid Id { get; set; }

		#endregion Public Properties
	}
}