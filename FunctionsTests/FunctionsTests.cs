using System;
using NUnit.Framework;
using Functions;

namespace CustomBoundariesArrayTests {

    [TestFixture]
    public class FunctionsTests {

        [TestCase(null, Functions.SortOrder.Ascending)]
        public void IsSorted_NullArgumentArrayAscendingSort_ThrowArgumentException(int[] array, SortOrder order)
        {
            Assert.Throws<ArgumentNullException>(() =>
                    Functions.Functions.IsSorted(array, order));
        }

        [TestCase(new int[] { 10, 20, 30 }, Functions.SortOrder.Ascending, ExpectedResult = true)]
        [TestCase(new int[] { 30, 20, 10 }, Functions.SortOrder.Descending, ExpectedResult = true)]
        [TestCase(new int[] { 30, 30, 30 }, Functions.SortOrder.Ascending, ExpectedResult = true)]
        [TestCase(new int[] { 30, 30, 30 }, Functions.SortOrder.Descending, ExpectedResult = true)]
        [TestCase(new int[] {10, 20, 30}, Functions.SortOrder.Descending, ExpectedResult = false)]
        [TestCase(new int[] { 30, 20, 10 }, Functions.SortOrder.Ascending, ExpectedResult = false)]
        [TestCase(new int[] { 30, -7, 30 }, Functions.SortOrder.Ascending, ExpectedResult = false)]
        [TestCase(new int[] { 90, 30, 100 }, Functions.SortOrder.Descending, ExpectedResult = false)]
        public bool IsSorted_NotNullArraySorted_ResultReturned(int[] array, SortOrder order) =>
            Functions.Functions.IsSorted(array, order);
    }
}
