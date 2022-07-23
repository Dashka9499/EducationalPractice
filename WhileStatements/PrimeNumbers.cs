namespace WhileStatements
{
    public static class PrimeNumbers
    {
        public static bool IsPrimeNumber(uint n)
        {
            if (n == 0 || n == 1)
            {
                return false;
            }

            uint i = n - 1;

            while (n % i != 0)
            {
                i--;
            }

            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static uint GetLastPrimeNumber(uint n)
        {
            if (n == 0 || n == 1)
            {
                return 0;
            }

            while (n > 0)
            {
                uint i = n - 1;

                while (n % i != 0)
                {
                    i--;
                }

                if (i == 1)
                {
                    return n;
                }

                n--;
            }

            return 2;
        }

        public static uint SumLastPrimeNumbers(uint n, uint count)
        {
            if (n == 0 || n == 1)
            {
                return 0;
            }

            uint sum = 0;

            while (count > 0 && n > 0)
            {
                uint i = n - 1;

                while (n % i != 0 && i != 0)
                {
                    i--;
                }

                if (i == 1)
                {
                    sum += n;
                    count--;
                }

                n--;
            }

            return sum;
        }
    }
}
