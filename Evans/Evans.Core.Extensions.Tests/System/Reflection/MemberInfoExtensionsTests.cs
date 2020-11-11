using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

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

		[Test]
		public void GetAttributeOrDefaultTest()
		{
			var memberInfo = typeof(AttributeTestSubClass);
			var attribute = memberInfo.GetAttributeOrDefault<Attribute1>();

			Assert.IsNotNull(attribute);

			var attribute2 = memberInfo.GetAttributeOrDefault<Attribute2>();
			Assert.IsNotNull(attribute2);
		}

		[Test]
		public void GetAttributesTest()
		{
			var attributes = typeof(AttributeTestClass).GetAttributes<AttributeMulti>();
			int attributesCount = attributes.Count();
			Assert.AreEqual(1, attributesCount);

			var attributes2 = typeof(AttributeTestSubClass).GetAttributes<AttributeMulti>(inherit: false);
			int attributesCount2 = attributes2.Count();
			Assert.AreEqual(2, attributesCount2);

			var attributes3 = typeof(AttributeTestSubClass).GetAttributes<AttributeMulti>(inherit: true);
			Assert.AreEqual(attributesCount + attributesCount2, attributes3.Count());
		}

		[Test]
		public void HasAttribute_T_Test()
		{
			var memberInfo = typeof(AttributeTestSubClass);
			Assert.IsTrue(memberInfo.HasAttribute<Attribute2>());
			Assert.IsFalse(memberInfo.HasAttribute<Attribute1>(inherit: false));
			Assert.IsTrue(memberInfo.HasAttribute<Attribute1>(inherit: true));
		}

		[Test]
		public void HasAttributeTest()
		{
			var memberInfo = typeof(AttributeTestSubClass);
			Assert.IsTrue(memberInfo.HasAttribute(typeof(Attribute2)));
			Assert.IsFalse(memberInfo.HasAttribute(typeof(Attribute1), inherit: false));
			Assert.IsTrue(memberInfo.HasAttribute(typeof(Attribute1), inherit: true));
		}
	}

	class Attribute1 : Attribute
	{
		string Property1 { get; set; } = string.Empty;
	}

	class Attribute2 : Attribute
	{

	}

	[AttributeUsage(validOn: AttributeTargets.Class, AllowMultiple = true)]
	class AttributeMulti : Attribute
	{
		public string TextProperty { get; set; }
	}

	[Attribute1]
	[AttributeMulti(TextProperty = "Test1")]
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
	[AttributeMulti(TextProperty = "Test2")]
	[AttributeMulti(TextProperty = "Test3")]
	class AttributeTestSubClass : AttributeTestClass
	{

	}
}