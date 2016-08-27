using System.Text.RegularExpressions;
using NUnit.Framework;
using PxtlCa.XmlCommentMarkDownGenerator;

namespace PxtlCa.XmlCommentMarkDownGenerator.Test
{
	[TestFixture]
    public class ElementTests
    {
        [Test]
        public void ElementPara()
        {
            var inputResourceName = "ElementPara_input.xml";
            Regex normalizeSpace = new Regex(@"\s+", RegexOptions.Compiled);
            var testInput = TestUtil.FetchResourceAsString(inputResourceName);

            var testOutput = normalizeSpace.Replace(testInput.ToMarkDown(), " ");
            //TODO: better test here
        }

        [Test]
        public void ElementC()
        {
            var inputResourceName = "ElementC_input.xml";
            Regex normalizeSpace = new Regex(@"\s+", RegexOptions.Compiled);
            var testInput = TestUtil.FetchResourceAsString(inputResourceName);

            var testOutput = normalizeSpace.Replace(testInput.ToMarkDown(), " ");
            Assert.IsTrue(testOutput.Contains("`code tag c`"));
        }

        [Test]
        public void ElementParam()
        {
            var inputResourceName = "ElementParam_input.xml";
            Regex normalizeSpace = new Regex(@"\s+", RegexOptions.Compiled);
            var testInput = TestUtil.FetchResourceAsString(inputResourceName);

            var testOutput = normalizeSpace.Replace(testInput.ToMarkDown(), " ");
        }
    }
}
