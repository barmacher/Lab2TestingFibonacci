namespace Fibonacci
{
    public class FibonacciCalculator
    {

        public string GetFibonacci(int n)
        {
            int result = 0;
            int b = 1;
            int tmp;

            if (n > 45)
            {
                return "Ответ не действительный";

            }

            for (int i = 0; i < n; i++)
            {
                tmp = result;
                result = b;
                b += tmp;
            }

            return result.ToString();
        }


    }
}