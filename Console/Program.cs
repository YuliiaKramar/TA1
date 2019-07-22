using System;


namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            flag = Functions.Functions.IsSorted(new int[] { 10, 20, 30 }, Functions.SortOrder.Ascending);
            flag = Functions.Functions.IsSorted(new int[] { 30, 20, 10 }, Functions.SortOrder.Descending);
            flag = Functions.Functions.IsSorted(new int[] { 30, 30, 30 }, Functions.SortOrder.Ascending);
            flag = Functions.Functions.IsSorted(new int[] { 30, 30, 30 }, Functions.SortOrder.Descending);

            flag = Functions.Functions.IsSorted(new int[] { 10, 20, 30 }, Functions.SortOrder.Descending);
            flag = Functions.Functions.IsSorted(new int[] { 30, 20, 10 }, Functions.SortOrder.Ascending);
            flag = Functions.Functions.IsSorted(new int[] { 30, -7, 30 }, Functions.SortOrder.Ascending);
            flag = Functions.Functions.IsSorted(new int[] { 90, 30, 100 }, Functions.SortOrder.Descending);

        //    [TestCase(new int[] { 10, 20, 30 }, Functions.SortOrder.Ascending, ExpectedResult = true)]
        //[TestCase(new int[] { 30, 20, 10 }, Functions.SortOrder.Descending, ExpectedResult = true)]
        //[TestCase(new int[] { 30, 30, 30 }, Functions.SortOrder.Ascending, ExpectedResult = true)]
        //[TestCase(new int[] { 30, 30, 30 }, Functions.SortOrder.Descending, ExpectedResult = true)]
        //[TestCase(new int[] { 10, 20, 30 }, Functions.SortOrder.Descending, ExpectedResult = false)]
        //[TestCase(new int[] { 30, 20, 10 }, Functions.SortOrder.Ascending, ExpectedResult = false)]
        //[TestCase(new int[] { 30, -7, 30 }, Functions.SortOrder.Ascending, ExpectedResult = false)]
        //[TestCase(new int[] { 90, 30, 100 }, Functions.SortOrder.Descending, ExpectedResult = false)]
        //public void IsSorted_NotNullArraySorted_ResultReturned(int[] array, SortOrder order) =>
        //    Functions.Functions.IsSorted(array, order);
    }
    }
}
