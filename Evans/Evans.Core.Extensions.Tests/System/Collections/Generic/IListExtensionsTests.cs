using NUnit.Framework;
using Evans.Core.Extensions.System.Collections.Generic;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evans.Core.Extensions.System.Collections.Generic.Tests
{
	[TestFixture()]
	public class IListExtensionsTests
	{
		[Test()]
		[TestCase("string1")]
		[TestCase("String2")]
		public void AddIfUnique_ExistingShouldNotChangeList(string item)
		{
			List<string> list = new List<string>();
			list.Add("string1");
			list.Add("String2");

			int originalCount = list.Count;

			list.AddIfUnique(item);

			Assert.IsTrue(list.Contains(item));
			Assert.AreEqual(originalCount, list.Count);
		}

		[Test()]
		[TestCase("string 1")]
		[TestCase("string2")]
		public void AddIfUnique_UniqueShouldChangeList(string item)
		{
			List<string> list = new List<string>();
			list.Add("string1");
			list.Add("String2");

			int originalCount = list.Count;

			list.AddIfUnique(item);

			Assert.IsTrue(list.Contains(item));
			Assert.AreNotEqual(originalCount, list.Count);
		}
	}
}