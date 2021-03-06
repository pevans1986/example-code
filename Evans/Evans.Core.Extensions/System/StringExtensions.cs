﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

using Evans.Core.Constants;

namespace System
{
	public static class StringExtensions
	{
		#region Public Methods

		/// <summary>
		/// Replaces any occurrences of multiple consecutive spaces with a single space.
		/// </summary>
		/// <param name="self"></param>
		/// <returns></returns>
		public static string CollapseSpaces(this string self)
		{
			if (self == null)
			{
				return self;
			}

			return Regex.Replace(self, @"\s+", " ");
		}

		/// <summary>
		/// Compares this string to the given value and returns the result of an equality check
		/// using <see cref="StringComparison.CurrentCultureIgnoreCase" />.
		/// </summary>
		/// <param name="self"></param>
		/// <param name="compValue"></param>
		/// <returns></returns>
		public static bool EqualsIgnoreCase(this string self, string compValue)
		{
			if (self == null)
			{
				return compValue == null;
			}

			if (compValue == null)
			{
				return false;
			}

			return self.Equals(compValue, StringComparison.CurrentCultureIgnoreCase);
		}

		/// <summary>
		/// If the string is null, empty, or whitespace, returns <paramref name="otherText" />.
		/// </summary>
		/// <param name="self"></param>
		/// <param name="otherText">
		/// The value returned if this string is null, empty, or whitespace only.
		/// </param>
		public static string IfBlankThen(this string self, string otherText) => self.IsBlank() ? otherText : self;

		/// <summary>
		/// Returns <c>true</c> if string is <c>null</c>, empty, or contains only whitespace.
		/// </summary>
		/// <param name="self"></param>
		public static bool IsBlank(this string self) => string.IsNullOrWhiteSpace(self);

		/// <summary>
		/// Returns whether or not the length of this string is greater than the given length. This
		/// method handles checking for null, blank, and empty values. Blank values are treated as a
		/// length of 0.
		/// </summary>
		/// <param name="self"></param>
		/// <param name="length"></param>
		/// <returns></returns>
		public static bool IsLongerThan(this string self, int length)
		{
			if (self.IsBlank())
			{
				return false;
			}

			return (self.Length > length);
		}

		/// <summary>
		/// Return TRUE if string contains non-whitespace characters.
		/// </summary>
		/// <param name="self"></param>
		public static bool IsNonBlank(this string self) => !string.IsNullOrWhiteSpace(self);

		/// <summary>
		/// Returns whether or not the length of this string is shorter than the given length. This
		/// method handles checking for null, blank, and empty values. Blank values are treated as a
		/// length of 0.
		/// </summary>
		/// <param name="self"></param>
		/// <param name="length"></param>
		/// <returns></returns>
		public static bool IsShorterThan(this string self, int length)
		{
			if (self.IsBlank())
			{
				return true;
			}

			return self.Length < length;
		}

		/// <summary>
		/// Checks if the value matches the format of a valid email address.
		/// </summary>
		/// <remarks>
		/// The email address is not verified in any way other than confirming it is of the correct format.
		/// </remarks>
		/// <param name="self"></param>
		/// <returns></returns>
		public static bool IsValidEmailAddress(this string self)
		{
			return Regex.IsMatch(self, RegexPatterns.EMAIL_ADDRESS, RegexOptions.Compiled);
		}

		/// <summary>
		/// Checks if the value is a valid IPv4 address.
		/// </summary>
		/// <param name="self"></param>
		/// <returns></returns>
		public static bool IsValidIpv4Address(this string self)
		{
			return Regex.IsMatch(self, RegexPatterns.IP_ADDRESS, RegexOptions.Compiled);
		}

		public static bool IsValidUrl(this string self)
		{
			return Regex.IsMatch(self, RegexPatterns.URL, RegexOptions.Compiled);
		}

		public static string RemoveSpecialCharacters(this string self)
		{
			string result = null;

			if (self != null)
			{
				result = string.Join(string.Empty, self.Where(c => char.IsLetterOrDigit(c) || c.Equals(' ')));
			}

			return result;
		}

		/// <summary>
		/// Checks if this <c>string</c> starts with the given value, ignoring case.
		/// </summary>
		/// <param name="self"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		/// <seealso cref="string.StartsWith(string)" />
		/// <seealso cref="StringComparison.CurrentCultureIgnoreCase" />
		public static bool StartsWithIgnoreCase(this string self, string value)
		{
			if (self == null || value == null)
			{
				return false;
			}

			return self.StartsWith(value, StringComparison.CurrentCultureIgnoreCase);
		}

		/// <summary>
		/// Converts the <c>string</c> value to a <c>Boolean</c>.
		/// </summary>
		/// <param name="self"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException">
		/// If the string is not a known value that has a corresponding Boolean value.
		/// </exception>
		public static Boolean ToBoolean(this String self)
		{
			var value = self.ToLower(CultureInfo.CurrentCulture).Trim();

			switch (value)
			{
				case "true":
					return true;

				case "false":
					return false;

				case "t":
					return true;

				case "f":
					return false;

				case "yes":
					return true;

				case "no":
					return false;

				case "y":
					return true;

				case "n":
					return false;

				case "1":
					return true;

				case "0":
					return false;

				default:
					break;
			}

			throw new ArgumentException("Input is not a boolean value.");
		}

		/// <summary>
		/// Converts strings to separate words based on capitalization.
		/// </summary>
		/// <param name="self"></param>
		public static string ToSeparateWords(this string self)
		{
			if (self.IsBlank())
			{
				return self;
			}

			// TODO Include options for patterns - capitalization, camelCase, underline, etc
			return Regex.Replace(self, RegexPatterns.WORD_SEPARATION_CASE, " $1").Trim();
		}

		/// <summary>
		/// If the value of this <see cref="string" /> is longer than the given maximum number of
		/// characters, the value will be truncated to the maximum length.
		/// </summary>
		/// <param name="self"></param>
		/// <param name="maxLength"></param>
		/// <returns></returns>
		public static string Truncate(this string self, int maxLength)
		{
			if (self == null || maxLength <= 0)
			{
				return self;
			}

			if (self.IsLongerThan(maxLength))
			{
				return self.Substring(0, maxLength);
			}

			return self;
		}

		#endregion Public Methods
	}
}