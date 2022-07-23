namespace WhileStatements
{
    public static class GeometricSequences
    {
        public static uint SumGeometricSequenceTerms1(uint a, uint r, uint n)
        {
            uint sum = 0, i = 0;

            while (i < n)
            {
                uint j = 0;
                uint rpow = 1;

                while (j < i)
                {
                    rpow *= r;
                    j++;
                }

                sum += a * rpow;
                i++;
            }

            return sum;
        }

        public static uint SumGeometricSequenceTerms2(uint n)
        {
            const uint first = 13;
            const uint common = 3;
            uint i = 1, term = first, sum = 0;

            while (i <= n)
            {
                sum += term;
                term *= common;
                i++;
            }

            return sum;
        }

        public static uint CountGeometricSequenceTerms3(uint a, uint r, uint maxTerm)
        {
            uint count = 0;
            uint term = a;

            while (term <= maxTerm)
            {
                count++;
                term *= r;
            }

            return count;
        }

        public static uint CountGeometricSequenceTerms4(uint a, uint r, uint n, uint minTerm)
        {
            uint count = 0, i = 0, term = a;

            while (i < n)
            {
                if (term >= minTerm)
                {
                    count++;
                }

                term *= r;
                i++;
            }

            return count;
        }
    }
}
