using NUnit.Framework;
using System;
namespace PxtlCa.XmlCommentMarkDownGenerator.Test
{
	[TestFixture]
	public class SamplesTest
	{
		[Test]
		public void ToMarkDown_BuildronModSdk_Loaded()
		{
			var inputResourceName = "Samples.Buildron.ModSdk.xml";
			var outputResourceName = "RegressionBigVariant_output.md";
			var testInput = TestUtil.FetchResourceAsString(inputResourceName);

			var expectedOutput = TestUtil.NormalizeSpace(TestUtil.FetchResourceAsString(outputResourceName));
			Assert.IsNotNull(expectedOutput);
		}
	}
}

