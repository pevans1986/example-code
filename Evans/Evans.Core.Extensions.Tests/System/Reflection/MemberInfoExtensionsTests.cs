using NUnit.Framework;
using Evans.Core.Extensions.System.Reflection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Evans.Core.Extensions.System.Reflection.Tests
{
	[TestFixture]
	public class MemberInfoExtensionsTests
	{

		[Test]
		public void GetAttributeTest()
		{
			var memberInfo = typeof(AttributeTestClass);
			Assert.IsNotNull(memberInfo.GetAttribute<Attribute1>());
			Assert.IsNull(memberInfo.GetAttribute<Attribute2>());

			var memberInfo2 = typeof(AttributeTestSubClass);
			Assert.IsNotNull(memberInfo2.GetAttribute<Attribute2>());
			Assert.IsNull(memberInfo2.GetAttribute<Attribute1>());
			Assert.IsNotNull(memberInfo2.GetAttribute<Attribute1>(true));
		}

		//[Test]
		//public void GetAttributeOrDefaultTest()
		//{
		//	Assert.Fail();
		//}

		//[Test]
		//public void GetAttributesTest()
		//{
		//	Assert.Fail();
		//}

		//[Test]
		//public void HasAttributeTest()
		//{
		//	Assert.Fail();
		//}

		//[Test]
		//public void HasAttributeTest1()
		//{
		//	Assert.Fail();
		//}
	}

	class Attribute1 : Attribute
	{

	}

	class Attribute2 : Attribute
	{

	}

	[Attribute1]
	class AttributeTestClass
	{
		[Attribute2]
		void TestMethod1()
		{

		}

		[Attribute1]
		[Attribute2]
		void TestMethod2()
		{

		}

		void TestMethod3()
		{

		}
	}

	[Attribute2]
	class AttributeTestSubClass : AttributeTestClass
	{

	}
}