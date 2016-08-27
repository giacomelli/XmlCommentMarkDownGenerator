﻿using System.Text.RegularExpressions;
using NUnit.Framework;

namespace PxtlCa.XmlCommentMarkDownGenerator.Test
{
    [TestFixture]
    public class Regression
    {
        [Test]
        public void TestBigVariantXml()
        {
            var inputResourceName = "PxtlCa.XmlCommentMarkDownGenerator.Test.RegressionBigVariant_input.xml";
            var outputResourceName = "PxtlCa.XmlCommentMarkDownGenerator.Test.RegressionBigVariant_output.md";
            Regex normalizeSpace = new Regex(@"\s+", RegexOptions.Compiled);
            var testInput = TestUtil.FetchResourceAsString(inputResourceName);

            var expectedOutput = normalizeSpace.Replace(TestUtil.FetchResourceAsString(outputResourceName), " ");
            var actualOutput = normalizeSpace.Replace(testInput.ToMarkDown(), " ");
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        [ExpectedException(typeof(System.Xml.XmlException))]
        public void TestUnexpectedElement()
        {
            var inputResourceName = "PxtlCa.XmlCommentMarkDownGenerator.Test.UnexpectedElement_input.xml";
            Regex normalizeSpace = new Regex(@"\s+", RegexOptions.Compiled);
            var testInput = TestUtil.FetchResourceAsString(inputResourceName);
            
            //exception thrown below
            var testOutput = normalizeSpace.Replace(testInput.ToMarkDown(), " ");
        }
    }
}
