using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Evans.Models;
using Evans.Models.Northwind;
using Evans.Repository.Ef.Northwind;

namespace Evans.Repository.Ef
{
	public class UnitOfWorkEf
	{
		#region Private Fields

		private readonly DomainContext _domainContext;
		private readonly NorthwindContext _northwindContext;

		#endregion Private Fields

		#region Public Constructors

		public UnitOfWorkEf(DomainContext domainContext, NorthwindContext northwindContext)
		{
			_domainContext = domainContext;
			_northwindContext = northwindContext;
		}

		#endregion Public Constructors

		#region Public Properties

		public IQueryable<Contact> Contacts => _domainContext.Contacts;

		public IQueryable<EmailAddress> EmailAddresses => _domainContext.EmailAddresses;

		public IQueryable<Employee> Employees => _northwindContext.Employees;

		#endregion Public Properties
	}
}