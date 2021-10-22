using System;

namespace Presents.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class PresentsTests
    {
        private Present present;
        private Bag presentsBag;

        [SetUp]
        public void Setup()
        {
            this.presentsBag = new Bag();
            this.present = new Present("podarak", 1.1);
        }

        [Test]

        public void ThrowsExeption_IfNull()
        {
            present = null;
            presentsBag.Create(present);
            Assert.Throws<ArgumentNullException>(() => this.presentsBag.Create(present));
        }

        [Test]
        public void ThrowsExeption_IfExists()
        {
            presentsBag.Create(present);

            Assert.Throws<InvalidOperationException>(() => presentsBag.Create(present));
        }
        [Test]
        public void CorrectOutput_WhenPresentAdded()
        {
            string actual = this.presentsBag.Create(present);
            string expected = $"Successfully added present {present.Name}.";

            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void Removed_Correctly()
        {
            presentsBag.Create(present);
            presentsBag.Remove(present);

            var actual = presentsBag.GetPresent("podarak");

            Assert.That(actual, Is.EqualTo(null));
        }

        [Test]
        public void Gets_Present()
        {
            presentsBag.Create(present);
            var expectedPresent = presentsBag.GetPresent("podarak");

            var currPresent = presentsBag.GetPresent("podarak");

            Assert.That(expectedPresent, Is.EqualTo(currPresent));
        }

        [Test]
        public void Gets_Presents()
        {
            presentsBag.Create(present);
            var actualPresents = presentsBag;
            var expectedPresent = presentsBag;

            Assert.That(expectedPresent, Is.EqualTo(actualPresents));
        }

    }
}
