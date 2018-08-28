﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evans.Models
{
	public class EmailAddress : Model
	{
		#region Public Properties

		public Contact Contact { get; set; }

		public string Email { get; set; }

		public bool IsPrimary { get; set; }

		#endregion Public Properties
	}
}