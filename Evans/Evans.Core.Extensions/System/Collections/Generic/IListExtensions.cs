using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evans.Core.Extensions.System.Collections.Generic
{
	public static class IListExtensions
	{
		#region Public Methods

		/// <summary>
		/// Adds the given item to this list if it is unique (not already contained in 
		/// the list).
		/// </summary>
		/// <param name="self"></param>
		/// <param name="item"></param>
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
