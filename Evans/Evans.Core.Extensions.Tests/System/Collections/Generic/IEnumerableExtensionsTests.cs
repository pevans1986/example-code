using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evans.Core.Extensions.System.Collections.Generic;

using Moq;

using NUnit.Framework;

namespace Evans.Core.Extensions.System.Collections.Generic.Tests
{
	[TestFixture]
	public class IEnumerableExtensionsTests
	{
		[Test]
		public void ForEachTest()
		{
			var mock = new Mock<ICollection<string>>();

			var strings = new string[] { "1", "2", "3" };
			strings.ForEach(s => mock.Object.Add(s));

			mock.Verify(s => s.Add(It.IsAny<string>()), Times.Exactly(strings.Length));
		}
	}
}