﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evans.Core.Extensions.System.Collections.Generic
{
	public static class IListExtensions
	{
		#region Public Methods

		public static void AddIfUnique<T>(this IList<T> self, T item)
		{
			if (!self.Contains(item))
			{
				self.Add(item);
			}
		}

		#endregion Public Methods
	}
}
