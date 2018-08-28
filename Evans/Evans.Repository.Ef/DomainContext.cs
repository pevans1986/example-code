using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Evans.Models;

namespace Evans.Repository.Ef
{
	public class DomainContext : DbContext
	{
		#region Public Constructors

		public DomainContext() : base("name=DomainContext")
		{
		}

		#endregion Public Constructors

		#region Public Properties

		public virtual DbSet<Contact> Contacts { get; set; }

		public virtual DbSet<EmailAddress> EmailAddresses { get; set; }

		#endregion Public Properties
	}
}