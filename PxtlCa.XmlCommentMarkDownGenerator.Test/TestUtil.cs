using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

namespace PxtlCa.XmlCommentMarkDownGenerator.Test
{
	internal static class TestUtil
    {
		private static string s_resourceFullNameTemplate;
		private static Assembly s_assembly;
		private static Regex s_normalizeSpaceRegex = new Regex(@"\s+", RegexOptions.Compiled);

		static TestUtil()
		{
			s_resourceFullNameTemplate = string.Format(CultureInfo.InvariantCulture, "{0}.Resources.", typeof(TestUtil).Namespace);
			s_assembly = Assembly.GetExecutingAssembly();
		}

        internal static string FetchResourceAsString(string resourceName)
        {
			var resourceFullName = s_resourceFullNameTemplate + resourceName;
         
			using (Stream stream = s_assembly.GetManifestResourceStream(resourceFullName))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

		internal static string NormalizeSpace(string input)
		{
			return s_normalizeSpaceRegex.Replace(input, " ");
		}
    }
}
