

namespace HelloUnitTest
{
    public class Fibonacci
    {
        private IMath _math;
        public Fibonacci(IMath math)
        {
            _math = math;
        }


        public int GetTerm(int n)
        {
            int f0 = 0; // Terme 0
            if (n == 0)
                return f0;

            int f1 = 1; // Terme 1
            if (n == 1)
                return f1;

            // Calcule les termes suivants
            int fnMoins2 = f0;
            int fnMoins1 = f1;
            int fn = 0;
            for (int i = 2; i < n + 1; i++)
            {
                fn = _math.Add(fnMoins1, fnMoins2);
                fnMoins2 = fnMoins1;
                fnMoins1 = fn;
            }
            return fn;
        }        

    }
}
