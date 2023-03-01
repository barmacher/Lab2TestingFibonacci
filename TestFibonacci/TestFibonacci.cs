using Fibonacci;

namespace TestFibonacci
{
    [TestClass]
    public class TestFibonacci
    {
        [TestMethod]
        public void TestMethod1()
        {
            Fibonacci.FibonacciCalculator fibonacci = new Fibonacci.FibonacciCalculator();
            string received = fibonacci.GetFibonacci(0);
            string expected = "0";

            Assert.AreEqual(expected, received);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Fibonacci.FibonacciCalculator fibonacci = new Fibonacci.FibonacciCalculator();
            string received = fibonacci.GetFibonacci(1);
            string expected = "1";

            Assert.AreEqual(expected, received);
        }


        [TestMethod]
        public void TestMethod3()
        {
            Fibonacci.FibonacciCalculator fibonacci = new Fibonacci.FibonacciCalculator();
            string received = fibonacci.GetFibonacci(39);
            string expected = "63245986";

            Assert.AreEqual(expected, received);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Fibonacci.FibonacciCalculator fibonacci = new Fibonacci.FibonacciCalculator();
            string received = fibonacci.GetFibonacci(70);
            string expected = "Ответ не действительный";

            Assert.AreEqual(expected, received);
        }


        [TestMethod]
        public void TestMethod5()
        {
            Fibonacci.FibonacciCalculator fibonacci = new Fibonacci.FibonacciCalculator();
            string received = fibonacci.GetFibonacci(-5);
            string expected = "0";

            Assert.AreEqual(expected, received);
        }


        [TestMethod]
        public void TestMethod6()
        {
            Fibonacci.FibonacciCalculator fibonacci = new Fibonacci.FibonacciCalculator();
            string received = fibonacci.GetFibonacci(10);
            string expected = "55";

            Assert.AreEqual(expected, received);
        }


    }
}