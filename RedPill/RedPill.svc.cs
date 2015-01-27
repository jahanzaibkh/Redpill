using System;
using System.Linq;
using System.ServiceModel;

namespace RedPill
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RedPill" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RedPill.svc or RedPill.svc.cs at the Solution Explorer and start debugging.
    public class RedPill : IRedPill
    {

        public Guid WhatIsYourToken()
        {
            return new Guid("09dfd5da-7efa-469f-b71b-5ba6bfd0e02e");
        }

        public long FibonacciNumber(long n)
        {

            try
            {
                if (n <= long.MaxValue || n >= long.MinValue)
                {
                    if (n < 2)
                        return n;
                    long[] f = new long[n + 1];
                    f[0] = 0;
                    f[1] = 1;

                    for (int i = 2; i <= n; i++)
                    {
                        f[i] = f[i - 1] + f[i - 2];
                    }
                    return f[n];
                }
                throw new ArgumentOutOfRangeException("n");
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public string ReverseWords(string s)
        {
            try
            {
                var word = "";
                var finalword = "";

                foreach (var c in s)
                {
                    if (c != ' ')
                    {
                        word = c + word;
                    }
                    else
                    {
                        finalword += word + ' ';
                        word = "";
                    }
                }

                if (word.Length > 0)
                {
                    finalword += word;
                }

                return finalword.Trim();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }

        }

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
          
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return TriangleType.Error;
            }
            var ab = a == b;
            var ac = a == c;
            var bc = b == c;
            if (ab && ac && bc)
            {
                return TriangleType.Equilateral;
            }
            if (ab)
            {
                return a + b <= c ? TriangleType.Error : TriangleType.Isosceles;
            }

            if (ac)
            {
                return a + c <= b ? TriangleType.Error : TriangleType.Isosceles;
            }

            if (bc)
            {
                return b + c <= a ? TriangleType.Error : TriangleType.Isosceles;
            }
            if (a > b && a > c && b + c <= a)
            {
                return TriangleType.Error;
            }

            if (b > a && b > c && a + c <= b)
            {
                return TriangleType.Error;
            }

            return a + b <= c ? TriangleType.Error : TriangleType.Scalene;
        }

    }
}
