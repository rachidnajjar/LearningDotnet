

namespace HelloUnitTest
{
    public class Fibonacci
    {
        public int GetNthTerm(int n)
        {
            Math math = new Math();
            int nMinusTwoTerm = 1;
            int nMinusOneTerm = 1;
            int newTerm = 0;
            for (int i = 2; i < n; i++)
            {
                newTerm = math.Add(nMinusOneTerm, nMinusTwoTerm);
                nMinusTwoTerm = nMinusOneTerm;
                nMinusOneTerm = newTerm;
            }
            return newTerm;
        }        
    }
}
