using System;

namespace ShiftArrayElements
{
    public static class EnumShifter
    {
        /// <summary>
        /// Shifts elements in a <see cref="source"/> array using directions from <see cref="directions"/> array, one element shift per each direction array element.
        /// </summary>
        /// <param name="source">A source array.</param>
        /// <param name="directions">An array with directions.</param>
        /// <returns>An array with shifted elements.</returns>
        /// <exception cref="ArgumentNullException">source array is null.</exception>
        /// <exception cref="ArgumentNullException">directions array is null.</exception>
        /// <exception cref="InvalidOperationException">direction array contains an element that is not <see cref="Direction.Left"/> or <see cref="Direction.Right"/>.</exception>
        public static int[] Shift(int[]? source, Direction[]? directions)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (directions == null)
            {
                throw new ArgumentNullException(nameof(directions));
            }

            for (int i = 0; i < directions.Length; i++)
            {
                if (directions[i] != Direction.Left && directions[i] != Direction.Right)
                {
                    throw new InvalidOperationException(nameof(directions));
                }
            }

            int l = 0;

            for (int i = 0; i < directions.Length; i++)
            {
                if (directions[i] == Direction.Left)
                {
                    l++;
                }
                else
                {
                    l--;
                }
            }

            if (l > 0)
            {
                for (int i = 0; i < l; i++)
                {
                    int temp = source[0];
                    for (int k = 0; k < source.Length - 1; k++)
                    {
                        source[k] = source[k + 1];
                    }

                    source[source.Length - 1] = temp;
                }
            }
            else if (l < 0)
            {
                for (int i = 0; i > l; i--)
                {
                    int temp = source[source.Length - 1];
                    for (int k = source.Length - 1; k > 0; k--)
                    {
                        source[k] = source[k - 1];
                    }

                    source[0] = temp;
                }
            }

            return source;
        }
    }
}
