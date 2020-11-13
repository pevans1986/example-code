using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evans.Core.Constants
{
	public class RegexPatterns
	{
		/// <summary>
		/// Regex pattern for validating an input string as an email address.
		/// </summary>
		public const string EMAIL_ADDRESS = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";

		/// <summary>
		/// Regex pattern for validating an input string as an IP address.
		/// </summary>
		public const string IP_ADDRESS = @"\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";

		/// <summary>
		/// Regex pattern for validating an input string as a URL.
		/// </summary>
		public const string URL = @"http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?";

		/// <summary>
		/// Regex pattern for identifying separate words within a string based on case 
		/// ("theseAreSeparateWords" -> "these Are Separate Words").
		/// </summary>
		public const string WORD_SEPARATION_CASE = "([A-Z][a-z])";
	}
}
