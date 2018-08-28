using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evans.Models
{
	public class Contact : Model
	{
		#region Public Properties

		public virtual ICollection<EmailAddress> EmailAddresses { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		#endregion Public Properties
	}
}