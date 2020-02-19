using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssessmentTest03
{
    [TestClass]
    public class Level1CSharpTest
    {
        /*
         Create the method "SumEdges" so the following tests will pass.

         The method should add the first and last number in the array

         If add10000 is true then the method should add 10000 to the result
             
         (you don't need to take care of edge cases like null or arrays with 0 or 1 elements)

         */

        [TestMethod]
        public void test1()
        {
            var arr = new[] { 4, 11, 15 };
            bool add10000 = false;
            int expected = 19; // 4+15
            int result = CSharpMethods.SumEdges(arr, add10000);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void test2()
        {
            var arr = new[] { 4, 11, 15 };
            bool add10000 = true;
            int expected = 10019; // 4+15+10000
            int result = CSharpMethods.SumEdges(arr, add10000);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void test3()
        {
            var arr = new[] { 6, 2 };
            bool add10000 = false;
            int expected = 8; // 6+2
            int result = CSharpMethods.SumEdges(arr, add10000);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void test4()
        {
            var arr = new[] { 6, 2 };
            bool add10000 = true;
            int expected = 10008; // 6+2+10000
            int result = CSharpMethods.SumEdges(arr, add10000);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void test5()
        {
            var arr = new[] { 100, 200, 500, 77 };
            bool add10000 = false;
            int expected = 177; // 100+77
            int result = CSharpMethods.SumEdges(arr, add10000);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void test6()
        {
            var arr = new[] { 100, 200, 500, 77 };
            bool add10000 = true;
            int expected = 10177; // 100+77+10000
            int result = CSharpMethods.SumEdges(arr, add10000);
            Assert.AreEqual(expected, result);
        }
    }
}
