
using System;
using NUnit.Framework;
using Phoneword_iOS;

namespace Phoneword_test
{
    [TestFixture]
    public class PhoneTranslatorTest
    {
        [Test]
        public void ContainsReturnsTrueIfFound()
        {
            Assert.True(PhoneTranslator.Contains("something", 's'));
        }

        [Test]
        public void ContainsReturnsFalseIfNotFound()
        {
            Assert.False(PhoneTranslator.Contains("something", 'z'));
        }

        [Test]
        public void ContainsReturnsFalseIfBlank()
        {
            Assert.False(PhoneTranslator.Contains("something",' '));
        }

        [Test]
        public void TranslateReturnsBlankIfNull()
        {
            Assert.AreSame("", PhoneTranslator.ToNumber(null));
        }

		[Test]
		public void TranslateReturnsRightNumberForLowerCase()
		{
            Assert.AreEqual("2", PhoneTranslator.ToNumber("a"));
		}

		[Test]
		public void TranslateIgnoresNonAlphanumeric()
		{
            Assert.AreSame("", PhoneTranslator.ToNumber(";"));
		}

    }
}
