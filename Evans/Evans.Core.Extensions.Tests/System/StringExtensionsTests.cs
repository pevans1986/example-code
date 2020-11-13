using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace System.Tests
{
	[TestFixture()]
	public class StringExtensionsTests
	{
		#region Methods

		[TestCase(null)]
		[TestCase("")]
		[TestCase(" ")]
		[TestCase("    ")]
		public static void IfBlankThen_ShouldHandleNullString(string value)
		{
			string result = value.IfBlankThen("otherString");
			Assert.AreEqual("otherString", result);
		}

		[Test()]
		[TestCase(null, ExpectedResult = null)]
		[TestCase(" ", ExpectedResult = " ")]
		[TestCase("  ", ExpectedResult = " ")]
		[TestCase("   ", ExpectedResult = " ")]
		[TestCase("A  test  ", ExpectedResult = "A test ")]
		[TestCase(" this is  A   test  ", ExpectedResult = " this is A test ")]
		public string CollapseSpacesTest(string value)
		{
			return value.CollapseSpaces();
		}

		[Test()]
		[TestCase("A value", "a value")]
		[TestCase("ATES T valuE ", "aTES T valuE ")]
		[TestCase(null, null)]
		[TestCase("", "")]
		[TestCase(" ", " ")]
		public void EqualsIgnoreCaseTest(string value1, string value2)
		{
			Assert.IsTrue(value1.EqualsIgnoreCase(value2));
		}

		[Test()]
		[TestCase(" ")]
		[TestCase("   ")]
		[TestCase("")]
		[TestCase(null)]
		public void IsBlankTest(string value)
		{
			Assert.IsTrue(value.IsBlank());
		}

		[Test()]
		[TestCase("123456", 5)]
		[TestCase(" ", 0)]
		[TestCase(" 2", 1)]
		public void IsLongerThanTest(string value, int length)
		{
			Assert.Greater(value.Length, length);
		}

		[Test()]
		[TestCase("a")]
		[TestCase("   a")]
		public void IsNonBlankTest(string value)
		{
			Assert.IsTrue(value.IsNonBlank());
		}

		[Test()]
		[TestCase("123456", 7, ExpectedResult = true)]
		[TestCase(" ", 2, ExpectedResult = true)]
		[TestCase(" 2", 5, ExpectedResult = true)]
		[TestCase("", 0, ExpectedResult = false)]
		[TestCase("1234", 4, ExpectedResult = false)]
		[TestCase("12345", 4, ExpectedResult = false)]
		public bool IsShorterThanTest(string value, int length)
		{
			return value.Length < length;
		}

		[Test]
		[TestCase("$Spec!i@al Ch@ar@acter$s", ExpectedResult = "Special Characters")]
		[TestCase("$Sp3c1@al Ch@ar@act3r$s", ExpectedResult = "Sp3c1al Charact3rs")]
		[TestCase(null, ExpectedResult = null)]
		public string RemoveSpecialCharactersTest(string input)
		{
			return input.RemoveSpecialCharacters();
		}

		[Test()]
		[TestCase("and", "a", ExpectedResult = true)]
		[TestCase("and", "an", ExpectedResult = true)]
		[TestCase(" and", " ", ExpectedResult = true)]
		[TestCase(null, null, ExpectedResult = false)]
		[TestCase(null, "", ExpectedResult = false)]
		[TestCase("", null, ExpectedResult = false)]
		[TestCase("and", "", ExpectedResult = true)]
		public bool StartsWithIgnoreCaseTest(string value, string beginning)
		{
			return value.StartsWithIgnoreCase(beginning);
		}

		[Test()]
		[TestCase(null, ExpectedResult = null)]
		[TestCase(" ", ExpectedResult = " ")]
		[TestCase("", ExpectedResult = "")]
		[TestCase("ToSeparateWords", ExpectedResult = "To Separate Words")]
		[TestCase("toSeparateWords", ExpectedResult = "to Separate Words")]
		public string ToSeparateWordsTest(string value)
		{
			return value.ToSeparateWords();
		}

		[Test()]
		[TestCase("1234567", 5, ExpectedResult = "12345")]
		[TestCase("1234567", 3, ExpectedResult = "123")]
		[TestCase("1234567", 9, ExpectedResult = "1234567")]
		[TestCase("1234567", -1, ExpectedResult = "1234567")]
		[TestCase("1234567", 0, ExpectedResult = "1234567")]
		[TestCase(null, 2, ExpectedResult = null)]
		public string TruncateTest(string value, int maxLength)
		{
			return value.Truncate(maxLength);
		}

		#endregion Methods
	}
}