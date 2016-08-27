using System.Text.RegularExpressions;
using NUnit.Framework;

namespace PxtlCa.XmlCommentMarkDownGenerator.Test
{
    [TestFixture]
    public class Regression
    {
        [Test]
        public void TestBigVariantXml()
        {
            var inputResourceName = "RegressionBigVariant_input.xml";
            var outputResourceName = "RegressionBigVariant_output.md";
            var testInput = TestUtil.FetchResourceAsString(inputResourceName);

            var expectedOutput = TestUtil.NormalizeSpace(TestUtil.FetchResourceAsString(outputResourceName));
			var actualOutput = TestUtil.NormalizeSpace(testInput.ToMarkDown());
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        [ExpectedException(typeof(System.Xml.XmlException))]
        public void TestUnexpectedElement()
        {
            var inputResourceName = "UnexpectedElement_input.xml";
            Regex normalizeSpace = new Regex(@"\s+", RegexOptions.Compiled);
            var testInput = TestUtil.FetchResourceAsString(inputResourceName);
            
            //exception thrown below
            var testOutput = normalizeSpace.Replace(testInput.ToMarkDown(), " ");
        }
    }
}
