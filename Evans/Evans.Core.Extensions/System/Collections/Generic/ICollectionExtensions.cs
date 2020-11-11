using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evans.Core.Extensions.System.Collections.Generic
{
	public static class ICollectionExtensions
	{
		/// <summary>
		/// Adds the given item to this collection if it is unique (not already contained in 
		/// the list).
		/// </summary>
		/// <param name="self"></param>
		/// <param name="item"></param>
		public static bool AddIfUnique<T>(this ICollection<T> self, T item)
		{
			if (!self.Contains(item))
			{
				self.Add(item);
				return true;
			}

			return false;
		}
	}
}
