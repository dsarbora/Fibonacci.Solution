using System;

namespace Fibonacci.Models
{
    public class Counter
    {
        private int a=0;
        private int b=1;
        private int c;
        private int NthTerm;

        public Counter(int n)
        {
            NthTerm = n;
        }
        public int GetN()
        {
            return NthTerm;
        }
        public int SetNumbers()
        {
            for(int i=0; i<NthTerm; i++)
            {
                c=b;
                b+=a;
                a=c;
                
            }
            return a;
        }
    }


}