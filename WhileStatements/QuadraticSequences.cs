namespace WhileStatements
{
    public static class QuadraticSequences
    {
        public static long SumQuadraticSequenceTerms1(long a, long b, long c, long maxTerm)
        {
            long sum = 0, term = 0, i = 1;

            while (term <= maxTerm)
            {
                term = (a * i * i) + (b * i) + c;
                if (term <= maxTerm)
                {
                    sum += term;
                }

                i++;
            }

            return sum;
        }

        public static long SumQuadraticSequenceTerms2(long a, long b, long c, long startN, long count)
        {
            long term, i = startN, sum = 0, co = count;

            while (co > 0)
            {
                term = (a * i * i) + (b * i) + c;
                co--;
                sum += term;
                i++;
            }

            return sum;
        }
    }
}
