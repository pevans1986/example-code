using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Evans.Core.Models;

namespace Evans.Models
{
	public abstract class Model : IDomainEntity
	{
		#region Public Properties

		public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }

		public DateTime LastModifiedDate { get; set; } = DateTime.UtcNow;

		#endregion Public Properties
	}
}