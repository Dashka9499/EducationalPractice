using System;

namespace ShiftArrayElements
{
    public static class Shifter
    {
        /// <summary>
        /// Shifts elements in a <see cref="source"/> array using <see cref="iterations"/> array for getting directions and iterations (see README.md for detailed instructions).
        /// </summary>
        /// <param name="source">A source array.</param>
        /// <param name="iterations">An array with iterations.</param>
        /// <returns>An array with shifted elements.</returns>
        /// <exception cref="ArgumentNullException">source array is null.</exception>
        /// <exception cref="ArgumentNullException">iterations array is null.</exception>
        public static int[] Shift(int[]? source, int[]? iterations)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (iterations == null)
            {
                throw new ArgumentNullException(nameof(iterations));
            }

            Direction dir = Direction.Left;

            for (int i = 0; i < iterations.Length; i++)
            {
                if (dir == Direction.Left)
                {
                    for (int j = 0; j < iterations[i]; j++)
                    {
                        int temp = source[0];
                        for (int k = 0; k < source.Length - 1; k++)
                        {
                            source[k] = source[k + 1];
                        }

                        source[source.Length - 1] = temp;
                    }

                    dir = Direction.Right;
                }
                else
                {
                    for (int j = 0; j < iterations[i]; j++)
                    {
                        int temp = source[source.Length - 1];
                        for (int k = source.Length - 1; k > 0; k--)
                        {
                            source[k] = source[k - 1];
                        }

                        source[0] = temp;
                    }

                    dir = Direction.Left;
                }
            }

            return source;
        }
    }
}
