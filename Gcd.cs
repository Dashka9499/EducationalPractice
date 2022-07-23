using System;
using System.Diagnostics;

namespace Gcd
{
    /// <summary>
    /// Provide methods with integers.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b)
        {
            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number cannot be {int.MinValue}.");
                throw new ArgumentOutOfRangeException(nameof(b), $"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.", nameof(a));
                throw new ArgumentException("Two numbers cannot be 0 at the same time.", nameof(b));
            }

            if (a < 0)
            {
                a *= -1;
            }

            if (b < 0)
            {
                b *= -1;
            }

            if (a == 0)
            {
                return b;
            }

            if (b == 0)
            {
                return a;
            }

            if (a <= b)
            {
                for (int i = a; i > 0; i--)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        return i;
                    }
                }
            }
            else
            {
                for (int i = b; i > 0; i--)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        return i;
                    }
                }
            }

            return 0;
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b, int c)
        {
            if (a == int.MinValue || b == int.MinValue || c == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number cannot be {int.MinValue}.");
                throw new ArgumentOutOfRangeException(nameof(b), $"Number cannot be {int.MinValue}.");
                throw new ArgumentOutOfRangeException(nameof(c), $"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.", nameof(a));
                throw new ArgumentException("Two numbers cannot be 0 at the same time.", nameof(b));
                throw new ArgumentException("Two numbers cannot be 0 at the same time.", nameof(c));
            }

            if (a < 0)
            {
                a *= -1;
            }

            if (b < 0)
            {
                b *= -1;
            }

            if (c < 0)
            {
                c *= -1;
            }

            if (a == 0 && c == 0)
            {
                return b;
            }

            if (b == 0 && c == 0)
            {
                return a;
            }

            if (a == 0 && b == 0)
            {
                return c;
            }

            if (a <= b && a <= c)
            {
                for (int i = a; i > 0; i--)
                {
                    if (a % i == 0 && b % i == 0 && c % i == 0)
                    {
                        return i;
                    }
                }
            }
            else if (a >= b && b <= c)
            {
                for (int i = b; i > 0; i--)
                {
                    if (a % i == 0 && b % i == 0 && c % i == 0)
                    {
                        return i;
                    }
                }
            }
            else if (c <= b && c <= a)
            {
                for (int i = c; i > 0; i--)
                {
                    if (a % i == 0 && b % i == 0 && c % i == 0)
                    {
                        return i;
                    }
                }
            }

            return 0;
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b, params int[] other)
        {
            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number cannot be {int.MinValue}.");
                throw new ArgumentOutOfRangeException(nameof(b), $"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0 && other == null)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(a));
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(b));
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(other));
            }

            if (a < 0)
            {
                a *= -1;
            }

            if (b < 0)
            {
                b *= -1;
            }

            if (other == null)
            {
                if (a == 0)
                {
                    return b;
                }

                if (b == 0)
                {
                    return a;
                }

                if (a < b)
                {
                    for (int i = a; i > 0; i--)
                    {
                        if (a % i == 0 && b % i == 0)
                        {
                            return i;
                        }
                    }
                }
                else
                {
                    for (int i = b; i > 0; i--)
                    {
                        if (a % i == 0 && b % i == 0)
                        {
                            return i;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < other.Length; i++)
                {
                    if (other[i] < 0)
                    {
                        other[i] *= -1;
                    }
                }

                int min = 1;
                bool flag = false;
                for (int i = 0; i < other.Length; i++)
                {
                    if (other[i] != 0)
                    {
                        flag = true;
                        min = other[i];
                        break;
                    }
                }

                if (flag)
                {
                    for (int i = 0; i < other.Length; i++)
                    {
                        if (other[i] == int.MinValue)
                        {
                            throw new ArgumentOutOfRangeException($"Number cannot be {int.MinValue}.");
                        }
                    }

                    for (int i = 0; i < other.Length; i++)
                    {
                        if (other[i] <= min && other[i] != 0)
                        {
                            min = other[i];
                        }
                    }

                    bool fl = true;
                    while (fl)
                    {
                        fl = false;
                        for (int i = 0; i < other.Length; i++)
                        {
                            if (other[i] % min != 0)
                            {
                                fl = true;
                            }
                        }

                        min--;
                        if (min == 0)
                        {
                            fl = false;
                        }
                    }

                    min++;
                    if (a == 0 && b == 0)
                    {
                        return min;
                    }

                    if (a == 0)
                    {
                        if (b <= min)
                        {
                            for (int i = b; i > 0; i--)
                            {
                                if (b % i == 0 && min % i == 0)
                                {
                                    return i;
                                }
                            }
                        }
                        else
                        {
                            for (int i = min; i > 0; i--)
                            {
                                if (b % i == 0 && min % i == 0)
                                {
                                    return i;
                                }
                            }
                        }
                    }
                    else if (b == 0)
                    {
                        if (a <= min)
                        {
                            for (int i = a; i > 0; i--)
                            {
                                if (a % i == 0 && min % i == 0)
                                {
                                    return i;
                                }
                            }
                        }
                        else
                        {
                            for (int i = min; i > 0; i--)
                            {
                                if (a % i == 0 && min % i == 0)
                                {
                                    return i;
                                }
                            }
                        }
                    }

                    if (a <= b && a <= min)
                    {
                        for (int i = a; i > 0; i--)
                        {
                            if (a % i == 0 && min % i == 0 && b % i == 0)
                            {
                                return i;
                            }
                        }
                    }
                    else if (b <= a && b <= min)
                    {
                        for (int i = b; i > 0; i--)
                        {
                            if (a % i == 0 && min % i == 0 && b % i == 0)
                            {
                                return i;
                            }
                        }
                    }
                    else if (min <= a && min <= b)
                    {
                        for (int i = min; i > 0; i--)
                        {
                            if (a % i == 0 && min % i == 0 && b % i == 0)
                            {
                                return i;
                            }
                        }
                    }
                }
                else
                {
                    if (a == 0 && b == 0)
                    {
                        throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(a));
                        throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(b));
                        throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(other));
                    }

                    if (a == 0)
                    {
                        return b;
                    }

                    if (b == 0)
                    {
                        return a;
                    }

                    if (a < b)
                    {
                        for (int i = a; i > 0; i--)
                        {
                            if (a % i == 0 && b % i == 0)
                            {
                                return i;
                            }
                        }
                    }
                    else
                    {
                        for (int i = b; i > 0; i--)
                        {
                            if (a % i == 0 && b % i == 0)
                            {
                                return i;
                            }
                        }
                    }
                }
            }

            return 0;
        }

        /// <summary>
        /// Calculates GCD of two integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b)
        {
            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number cannot be {int.MinValue}.");
                throw new ArgumentOutOfRangeException(nameof(b), $"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(a));
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(b));
            }

            if (a < 0)
            {
                a *= -1;
            }

            if (b < 0)
            {
                b *= -1;
            }

            if (a == 0)
            {
                return b;
            }

            if (b == 0)
            {
                return a;
            }

            if (a == b)
            {
                return a;
            }

            bool aIsEven = (a & 1u) == 0;
            bool bIsEven = (b & 1u) == 0;
            if (aIsEven && bIsEven)
            {
                return GetGcdByStein(a >> 1, b >> 1) << 1;
            }
            else if (aIsEven && !bIsEven)
            {
                return GetGcdByStein(a >> 1, b);
            }
            else if (bIsEven)
            {
                return GetGcdByStein(a, b >> 1);
            }
            else if (a > b)
            {
                return GetGcdByStein((a - b) >> 1, b);
            }
            else
            {
                return GetGcdByStein(a, (b - a) >> 1);
            }
        }

        /// <summary>
        /// Calculates GCD of three integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b, int c)
        {
            if (a == int.MinValue || b == int.MinValue || c == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number cannot be {int.MinValue}.");
                throw new ArgumentOutOfRangeException(nameof(b), $"Number cannot be {int.MinValue}.");
                throw new ArgumentOutOfRangeException(nameof(c), $"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(a));
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(b));
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(c));
            }

            if (a < 0)
            {
                a *= -1;
            }

            if (b < 0)
            {
                b *= -1;
            }

            if (c < 0)
            {
                c *= -1;
            }

            if ((a == 0 || a == b) && (c == 0 || c == b))
            {
                return b;
            }

            if ((b == 0 || b == a) && (c == 0 || c == a))
            {
                return a;
            }

            if ((a == 0 || a == c) && (b == 0 || b == c))
            {
                return c;
            }

            return GetGcdByStein(GetGcdByStein(a, b), c);
        }

        /// <summary>
        /// Calculates the GCD of integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b, params int[] other)
        {
            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number cannot be {int.MinValue}.");
                throw new ArgumentOutOfRangeException(nameof(b), $"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0 && other == null)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(a));
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(b));
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(other));
            }

            if (a < 0)
            {
                a *= -1;
            }

            if (b < 0)
            {
                b *= -1;
            }

            if (other == null)
            {
                if (a == 0)
                {
                    return b;
                }

                if (b == 0)
                {
                    return a;
                }

                return GetGcdByStein(a, b);
            }
            else
            {
                for (int i = 0; i < other.Length; i++)
                {
                    if (other[i] < 0)
                    {
                        other[i] *= -1;
                    }
                }

                int min = 1;
                bool flag = false;
                for (int i = 0; i < other.Length; i++)
                {
                    if (other[i] != 0)
                    {
                        flag = true;
                        min = other[i];
                        break;
                    }
                }

                if (flag)
                {
                    for (int i = 0; i < other.Length; i++)
                    {
                        if (other[i] == int.MinValue)
                        {
                            throw new ArgumentOutOfRangeException($"Number cannot be {int.MinValue}.");
                        }
                    }

                    for (int i = 0; i < other.Length; i++)
                    {
                        if (other[i] <= min && other[i] != 0)
                        {
                            min = other[i];
                        }
                    }

                    bool fl = true;
                    while (fl)
                    {
                        fl = false;
                        for (int i = 0; i < other.Length; i++)
                        {
                            if (other[i] % min != 0)
                            {
                                fl = true;
                            }
                        }

                        min--;
                        if (min == 0)
                        {
                            fl = false;
                        }
                    }

                    min++;
                    if (a == 0 && b == 0)
                    {
                        return min;
                    }

                    if (a == 0)
                    {
                        return GetGcdByStein(min, b);
                    }
                    else if (b == 0)
                    {
                        return GetGcdByStein(a, min);
                    }

                    return GetGcdByStein(GetGcdByStein(a, b), min);
                }
                else
                {
                    if (a == 0 && b == 0)
                    {
                        throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(a));
                        throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(b));
                        throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(other));
                    }

                    if (a == 0)
                    {
                        return b;
                    }

                    if (b == 0)
                    {
                        return a;
                    }

                    return GetGcdByStein(a, b);
                }
            }
        }

        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b)
        {
            var watch = Stopwatch.StartNew();
            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number cannot be {int.MinValue}.");
                throw new ArgumentOutOfRangeException(nameof(b), $"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.", nameof(a));
                throw new ArgumentException("Two numbers cannot be 0 at the same time.", nameof(b));
            }

            if (a < 0)
            {
                a *= -1;
            }

            if (b < 0)
            {
                b *= -1;
            }

            if (a == 0)
            {
                watch.Stop();
                elapsedTicks = watch.ElapsedTicks;
                return b;
            }

            if (b == 0)
            {
                watch.Stop();
                elapsedTicks = watch.ElapsedTicks;
                return a;
            }

            if (a <= b)
            {
                for (int i = a; i > 0; i--)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        watch.Stop();
                        elapsedTicks = watch.ElapsedTicks;
                        return i;
                    }
                }
            }
            else
            {
                for (int i = b; i > 0; i--)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        watch.Stop();
                        elapsedTicks = watch.ElapsedTicks;
                        return i;
                    }
                }
            }

            watch.Stop();
            elapsedTicks = watch.ElapsedTicks;
            return 0;
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b, int c)
        {
            var watch = Stopwatch.StartNew();
            if (a == int.MinValue || b == int.MinValue || c == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number cannot be {int.MinValue}.");
                throw new ArgumentOutOfRangeException(nameof(b), $"Number cannot be {int.MinValue}.");
                throw new ArgumentOutOfRangeException(nameof(c), $"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.", nameof(a));
                throw new ArgumentException("Two numbers cannot be 0 at the same time.", nameof(b));
                throw new ArgumentException("Two numbers cannot be 0 at the same time.", nameof(c));
            }

            if (a < 0)
            {
                a *= -1;
            }

            if (b < 0)
            {
                b *= -1;
            }

            if (c < 0)
            {
                c *= -1;
            }

            if (a == 0 && c == 0)
            {
                watch.Stop();
                elapsedTicks = watch.ElapsedTicks;
                return b;
            }

            if (b == 0 && c == 0)
            {
                watch.Stop();
                elapsedTicks = watch.ElapsedTicks;
                return a;
            }

            if (a == 0 && b == 0)
            {
                watch.Stop();
                elapsedTicks = watch.ElapsedTicks;
                return c;
            }

            if (a <= b && a <= c)
            {
                for (int i = a; i > 0; i--)
                {
                    if (a % i == 0 && b % i == 0 && c % i == 0)
                    {
                        watch.Stop();
                        elapsedTicks = watch.ElapsedTicks;
                        return i;
                    }
                }
            }
            else if (a >= b && b <= c)
            {
                for (int i = b; i > 0; i--)
                {
                    if (a % i == 0 && b % i == 0 && c % i == 0)
                    {
                        watch.Stop();
                        elapsedTicks = watch.ElapsedTicks;
                        return i;
                    }
                }
            }
            else if (c <= b && c <= a)
            {
                for (int i = c; i > 0; i--)
                {
                    if (a % i == 0 && b % i == 0 && c % i == 0)
                    {
                        watch.Stop();
                        elapsedTicks = watch.ElapsedTicks;
                        return i;
                    }
                }
            }

            watch.Stop();
            elapsedTicks = watch.ElapsedTicks;
            return 0;
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in Ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b, params int[] other)
        {
            var watch = Stopwatch.StartNew();
            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number cannot be {int.MinValue}.");
                throw new ArgumentOutOfRangeException(nameof(b), $"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0 && other == null)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(a));
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(b));
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(other));
            }

            if (a < 0)
            {
                a *= -1;
            }

            if (b < 0)
            {
                b *= -1;
            }

            if (other == null)
            {
                if (a == 0)
                {
                    watch.Stop();
                    elapsedTicks = watch.ElapsedTicks;
                    return b;
                }

                if (b == 0)
                {
                    watch.Stop();
                    elapsedTicks = watch.ElapsedTicks;
                    return a;
                }

                if (a < b)
                {
                    for (int i = a; i > 0; i--)
                    {
                        if (a % i == 0 && b % i == 0)
                        {
                            watch.Stop();
                            elapsedTicks = watch.ElapsedTicks;
                            return i;
                        }
                    }
                }
                else
                {
                    for (int i = b; i > 0; i--)
                    {
                        if (a % i == 0 && b % i == 0)
                        {
                            watch.Stop();
                            elapsedTicks = watch.ElapsedTicks;
                            return i;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < other.Length; i++)
                {
                    if (other[i] < 0)
                    {
                        other[i] *= -1;
                    }
                }

                int min = 1;
                bool flag = false;
                for (int i = 0; i < other.Length; i++)
                {
                    if (other[i] != 0)
                    {
                        flag = true;
                        min = other[i];
                        break;
                    }
                }

                if (flag)
                {
                    for (int i = 0; i < other.Length; i++)
                    {
                        if (other[i] == int.MinValue)
                        {
                            throw new ArgumentOutOfRangeException($"Number cannot be {int.MinValue}.");
                        }
                    }

                    for (int i = 0; i < other.Length; i++)
                    {
                        if (other[i] <= min && other[i] != 0)
                        {
                            min = other[i];
                        }
                    }

                    bool fl = true;
                    while (fl)
                    {
                        fl = false;
                        for (int i = 0; i < other.Length; i++)
                        {
                            if (other[i] % min != 0)
                            {
                                fl = true;
                            }
                        }

                        min--;
                        if (min == 0)
                        {
                            fl = false;
                        }
                    }

                    min++;
                    if (a == 0 && b == 0)
                    {
                        watch.Stop();
                        elapsedTicks = watch.ElapsedTicks;
                        return min;
                    }

                    if (a == 0)
                    {
                        if (b <= min)
                        {
                            for (int i = b; i > 0; i--)
                            {
                                if (b % i == 0 && min % i == 0)
                                {
                                    watch.Stop();
                                    elapsedTicks = watch.ElapsedTicks;
                                    return i;
                                }
                            }
                        }
                        else
                        {
                            for (int i = min; i > 0; i--)
                            {
                                if (b % i == 0 && min % i == 0)
                                {
                                    watch.Stop();
                                    elapsedTicks = watch.ElapsedTicks;
                                    return i;
                                }
                            }
                        }
                    }
                    else if (b == 0)
                    {
                        if (a <= min)
                        {
                            for (int i = a; i > 0; i--)
                            {
                                if (a % i == 0 && min % i == 0)
                                {
                                    watch.Stop();
                                    elapsedTicks = watch.ElapsedTicks;
                                    return i;
                                }
                            }
                        }
                        else
                        {
                            for (int i = min; i > 0; i--)
                            {
                                if (a % i == 0 && min % i == 0)
                                {
                                    watch.Stop();
                                    elapsedTicks = watch.ElapsedTicks;
                                    return i;
                                }
                            }
                        }
                    }

                    if (a <= b && a <= min)
                    {
                        for (int i = a; i > 0; i--)
                        {
                            if (a % i == 0 && min % i == 0 && b % i == 0)
                            {
                                watch.Stop();
                                elapsedTicks = watch.ElapsedTicks;
                                return i;
                            }
                        }
                    }
                    else if (b <= a && b <= min)
                    {
                        for (int i = b; i > 0; i--)
                        {
                            if (a % i == 0 && min % i == 0 && b % i == 0)
                            {
                                watch.Stop();
                                elapsedTicks = watch.ElapsedTicks;
                                return i;
                            }
                        }
                    }
                    else if (min <= a && min <= b)
                    {
                        for (int i = min; i > 0; i--)
                        {
                            if (a % i == 0 && min % i == 0 && b % i == 0)
                            {
                                watch.Stop();
                                elapsedTicks = watch.ElapsedTicks;
                                return i;
                            }
                        }
                    }
                }
                else
                {
                    if (a == 0 && b == 0)
                    {
                        throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(a));
                        throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(b));
                        throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(other));
                    }

                    if (a == 0)
                    {
                        watch.Stop();
                        elapsedTicks = watch.ElapsedTicks;
                        return b;
                    }

                    if (b == 0)
                    {
                        watch.Stop();
                        elapsedTicks = watch.ElapsedTicks;
                        return a;
                    }

                    if (a < b)
                    {
                        for (int i = a; i > 0; i--)
                        {
                            if (a % i == 0 && b % i == 0)
                            {
                                watch.Stop();
                                elapsedTicks = watch.ElapsedTicks;
                                return i;
                            }
                        }
                    }
                    else
                    {
                        for (int i = b; i > 0; i--)
                        {
                            if (a % i == 0 && b % i == 0)
                            {
                                watch.Stop();
                                elapsedTicks = watch.ElapsedTicks;
                                return i;
                            }
                        }
                    }
                }
            }

            watch.Stop();
            elapsedTicks = watch.ElapsedTicks;
            return 0;
        }

        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long elapsedTicks, int a, int b)
        {
            var watch = Stopwatch.StartNew();
            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number cannot be {int.MinValue}.");
                throw new ArgumentOutOfRangeException(nameof(b), $"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(a));
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(b));
            }

            if (a < 0)
            {
                a *= -1;
            }

            if (b < 0)
            {
                b *= -1;
            }

            if (a == 0)
            {
                watch.Stop();
                elapsedTicks = watch.ElapsedTicks;
                return b;
            }

            if (b == 0)
            {
                watch.Stop();
                elapsedTicks = watch.ElapsedTicks;
                return a;
            }

            if (a == b)
            {
                watch.Stop();
                elapsedTicks = watch.ElapsedTicks;
                return a;
            }

            bool aIsEven = (a & 1u) == 0;
            bool bIsEven = (b & 1u) == 0;
            if (aIsEven && bIsEven)
            {
                watch.Stop();
                elapsedTicks = watch.ElapsedTicks;
                return GetGcdByStein(a >> 1, b >> 1) << 1;
            }
            else if (aIsEven && !bIsEven)
            {
                watch.Stop();
                elapsedTicks = watch.ElapsedTicks;
                return GetGcdByStein(a >> 1, b);
            }
            else if (bIsEven)
            {
                watch.Stop();
                elapsedTicks = watch.ElapsedTicks;
                return GetGcdByStein(a, b >> 1);
            }
            else if (a > b)
            {
                watch.Stop();
                elapsedTicks = watch.ElapsedTicks;
                return GetGcdByStein((a - b) >> 1, b);
            }
            else
            {
                watch.Stop();
                elapsedTicks = watch.ElapsedTicks;
                return GetGcdByStein(a, (b - a) >> 1);
            }
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long elapsedTicks, int a, int b, int c)
        {
            var watch = Stopwatch.StartNew();
            if (a == int.MinValue || b == int.MinValue || c == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number cannot be {int.MinValue}.");
                throw new ArgumentOutOfRangeException(nameof(b), $"Number cannot be {int.MinValue}.");
                throw new ArgumentOutOfRangeException(nameof(c), $"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(a));
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(b));
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(c));
            }

            if (a < 0)
            {
                a *= -1;
            }

            if (b < 0)
            {
                b *= -1;
            }

            if (c < 0)
            {
                c *= -1;
            }

            if ((a == 0 || a == b) && (c == 0 || c == b))
            {
                watch.Stop();
                elapsedTicks = watch.ElapsedTicks;
                return b;
            }

            if ((b == 0 || b == a) && (c == 0 || c == a))
            {
                watch.Stop();
                elapsedTicks = watch.ElapsedTicks;
                return a;
            }

            if ((a == 0 || a == c) && (b == 0 || b == c))
            {
                watch.Stop();
                elapsedTicks = watch.ElapsedTicks;
                return c;
            }

            watch.Stop();
            elapsedTicks = watch.ElapsedTicks;
            return GetGcdByStein(GetGcdByStein(a, b), c);
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in Ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long elapsedTicks, int a, int b, params int[] other)
        {
            var watch = Stopwatch.StartNew();
            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number cannot be {int.MinValue}.");
                throw new ArgumentOutOfRangeException(nameof(b), $"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0 && other == null)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(a));
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(b));
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(other));
            }

            if (a < 0)
            {
                a *= -1;
            }

            if (b < 0)
            {
                b *= -1;
            }

            if (other == null)
            {
                if (a == 0)
                {
                    watch.Stop();
                    elapsedTicks = watch.ElapsedTicks;
                    return b;
                }

                if (b == 0)
                {
                    watch.Stop();
                    elapsedTicks = watch.ElapsedTicks;
                    return a;
                }

                watch.Stop();
                elapsedTicks = watch.ElapsedTicks;
                return GetGcdByStein(a, b);
            }
            else
            {
                for (int i = 0; i < other.Length; i++)
                {
                    if (other[i] < 0)
                    {
                        other[i] *= -1;
                    }
                }

                int min = 1;
                bool flag = false;
                for (int i = 0; i < other.Length; i++)
                {
                    if (other[i] != 0)
                    {
                        flag = true;
                        min = other[i];
                        break;
                    }
                }

                if (flag)
                {
                    for (int i = 0; i < other.Length; i++)
                    {
                        if (other[i] == int.MinValue)
                        {
                            throw new ArgumentOutOfRangeException($"Number cannot be {int.MinValue}.");
                        }
                    }

                    for (int i = 0; i < other.Length; i++)
                    {
                        if (other[i] <= min && other[i] != 0)
                        {
                            min = other[i];
                        }
                    }

                    bool fl = true;
                    while (fl)
                    {
                        fl = false;
                        for (int i = 0; i < other.Length; i++)
                        {
                            if (other[i] % min != 0)
                            {
                                fl = true;
                            }
                        }

                        min--;
                        if (min == 0)
                        {
                            fl = false;
                        }
                    }

                    min++;
                    if (a == 0 && b == 0)
                    {
                        watch.Stop();
                        elapsedTicks = watch.ElapsedTicks;
                        return min;
                    }

                    if (a == 0)
                    {
                        watch.Stop();
                        elapsedTicks = watch.ElapsedTicks;
                        return GetGcdByStein(min, b);
                    }
                    else if (b == 0)
                    {
                        watch.Stop();
                        elapsedTicks = watch.ElapsedTicks;
                        return GetGcdByStein(a, min);
                    }

                    watch.Stop();
                    elapsedTicks = watch.ElapsedTicks;
                    return GetGcdByStein(GetGcdByStein(a, b), min);
                }
                else
                {
                    if (a == 0 && b == 0)
                    {
                        throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(a));
                        throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(b));
                        throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(other));
                    }

                    if (a == 0)
                    {
                        watch.Stop();
                        elapsedTicks = watch.ElapsedTicks;
                        return b;
                    }

                    if (b == 0)
                    {
                        watch.Stop();
                        elapsedTicks = watch.ElapsedTicks;
                        return a;
                    }

                    watch.Stop();
                    elapsedTicks = watch.ElapsedTicks;
                    return GetGcdByStein(a, b);
                }
            }
        }
    }
}
