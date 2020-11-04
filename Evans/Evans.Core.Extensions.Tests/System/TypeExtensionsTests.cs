using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Evans.Core.Extensions.System;

using NUnit.Framework;

namespace Evans.Core.Extensions.System.Tests
{
	[TestFixture()]
	public class TypeExtensionsTests
	{
		[Test]
		[TestCase(typeof(TestClass1), typeof(TestInterface1), ExpectedResult = true)]
		[TestCase(typeof(TestClass1), typeof(TestInterface2), ExpectedResult = false)]
		[TestCase(typeof(TestClass2), typeof(TestInterface1), ExpectedResult = true)]
		[TestCase(typeof(TestClass2), typeof(TestInterface2), ExpectedResult = true)]
		public bool ImplementsTest(Type type, Type interfaceType)
		{
			return type.Implements(interfaceType);
		}

		[Test]
		public void Implements_T_Test()
		{
			Assert.IsTrue(typeof(TestClass1).Implements<TestInterface1>());
			Assert.IsFalse(typeof(TestClass1).Implements<TestInterface2>());
			Assert.IsTrue(typeof(TestClass2).Implements<TestInterface1>());
			Assert.IsTrue(typeof(TestClass2).Implements<TestInterface2>());
		}

		[Test]
		public void NewTest()
		{
			var obj = typeof(TestClass1).New();
			Assert.IsNotNull(obj);
			Assert.IsTrue(obj is TestClass1);
		}
	}

	interface TestInterface1
	{

	}

	interface TestInterface2
	{

	}

	class TestClass1 : TestInterface1
	{

	}

	class TestClass2 : TestInterface1, TestInterface2
	{

	}
}