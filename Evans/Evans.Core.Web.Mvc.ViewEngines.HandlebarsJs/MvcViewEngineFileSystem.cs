using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HandlebarsDotNet;

namespace Evans.Core.Web.Mvc.ViewEngines.HandlebarsJs
{
	public class MvcViewEngineFileSystem : ViewEngineFileSystem
	{
		public override bool FileExists(string filePath)
		{
			return File.Exists(filePath);
		}

		public override string GetFileContent(string filename)
		{
			return File.ReadAllText(filename);
		}

		protected override string CombinePath(string dir, string otherFileName)
		{
			return $"{dir}\\{otherFileName}";
		}
	}
}
