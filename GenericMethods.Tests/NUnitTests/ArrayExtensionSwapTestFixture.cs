using System;
using NUnit.Framework;
using static GenericMethods.ArrayExtension;

namespace GenericMethods.Tests.NUnitTests
{
    [TestFixture(12, 13, TypeArgs = new Type[] { typeof(int) })]
    [TestFixture("12", "2", TypeArgs = new Type[] { typeof(string) })]
    [TestFixture(-123.543, 13.56, TypeArgs = new Type[] { typeof(double) })]
    [TestFixture(true, false, TypeArgs = new Type[] { typeof(bool) })]
    [TestFixture('a', 'A', TypeArgs = new Type[] { typeof(char) })]
    internal class ArrayExtensionSwapTestFixture<T>
    {
        private T left;
        private T right;

        public ArrayExtensionSwapTestFixture(T left, T right) => (this.left, this.right) = (left, right);

        [Test]
        public void SwapTest()
        {
            T expectedLeft = this.right;
            T expectedRight = this.left;
            Swap(ref this.left, ref this.right);
            Assert.That(this.left.Equals(expectedLeft) && this.right.Equals(expectedRight));
        }
    }
}
