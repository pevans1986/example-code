using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Evans.Core.Extensions.System;

using NUnit.Framework;

namespace Evans.Core.Extensions.System.Tests
{
	[TestFixture]
	public class ObjectExtensionsTests
	{
		[Test]
		public void GetPropertyValueTest()
		{
			var obj = new
			{
				StringProperty1 = "String1",
				IntProperty1 = 10
			};

			Assert.AreEqual(obj.StringProperty1, obj.GetPropertyValue(nameof(obj.StringProperty1)));
			Assert.AreEqual(obj.IntProperty1, obj.GetPropertyValue(nameof(obj.IntProperty1)));
		}

		[Test]
		public void GetPropertyValueTest_T()
		{
			object obj = new ObjectTestClass
			{
				StringProperty1 = "String1",
				IntProperty1 = 10
			};

			string stringValue = obj.GetPropertyValue<string>(nameof(ObjectTestClass.StringProperty1));
			int intValue = obj.GetPropertyValue<int>(nameof(ObjectTestClass.IntProperty1));

			Assert.AreEqual("String1", stringValue);
			Assert.AreEqual(10, intValue);

			object obj2 = new 
			{
				StringProperty1 = "String1",
				IntProperty1 = 10
			};

			stringValue = obj2.GetPropertyValue<string>(nameof(ObjectTestClass.StringProperty1));
			intValue = obj2.GetPropertyValue<int>(nameof(ObjectTestClass.IntProperty1));

			Assert.AreEqual("String1", stringValue);
			Assert.AreEqual(10, intValue);
		}

		[Test]
		public void ToArrayTest()
		{
			var array = "String1".ToArray();

			Assert.IsTrue(array is string[]);
			Assert.IsTrue(array.Length == 1);
			Assert.AreEqual("String1", array[0]);
		}
	}

	class ObjectTestClass
	{
		public string StringProperty1 { get; set; }	

		public int IntProperty1 { get; set; }
	}
}