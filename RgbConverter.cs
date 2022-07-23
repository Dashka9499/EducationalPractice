using System;

namespace RgbConverter
{
    public static class Rgb
    {
        /// <summary>
        /// Gets hexadecimal representation source RGB decimal values.
        /// </summary>
        /// <param name="red">The valid decimal value for RGB is in the range 0-255.</param>
        /// <param name="green">The valid decimal value for RGB is in the range 0-255.</param>
        /// <param name="blue">The valid decimal value for RGB is in the range 0-255.</param>
        /// <returns>Returns hexadecimal representation source RGB decimal values.</returns>
        public static string GetHexRepresentation(int red, int green, int blue)
        {
            if (red < 0)
            {
                red = 0;
            }

            if (green < 0)
            {
                green = 0;
            }

            if (blue < 0)
            {
                blue = 0;
            }

            if (red > 255)
            {
                red = 255;
            }

            if (green > 255)
            {
                green = 255;
            }

            if (blue > 255)
            {
                blue = 255;
            }

            char ones, twos, three, four, five, six;
            if (red / 16 > 9)
            {
                ones = Convert.ToChar('A' + (red / 16) - 10);
            }
            else
            {
                ones = Convert.ToChar('0' + (red / 16));
            }

            if (red - ((red / 16) * 16) > 9)
            {
                twos = Convert.ToChar('A' + red - ((red / 16) * 16) - 10);
            }
            else
            {
                twos = Convert.ToChar('0' + red - ((red / 16) * 16));
            }

            if (green / 16 > 9)
            {
                three = Convert.ToChar('A' + (green / 16) - 10);
            }
            else
            {
                three = Convert.ToChar('0' + (green / 16));
            }

            if (green - ((green / 16) * 16) > 9)
            {
                four = Convert.ToChar('A' + green - ((green / 16) * 16) - 10);
            }
            else
            {
                four = Convert.ToChar('0' + green - ((green / 16) * 16));
            }

            if (blue / 16 > 9)
            {
                five = Convert.ToChar('A' + (blue / 16) - 10);
            }
            else
            {
                five = Convert.ToChar('0' + (blue / 16));
            }

            if (blue - ((blue / 16) * 16) > 9)
            {
                six = Convert.ToChar('A' + blue - ((blue / 16) * 16) - 10);
            }
            else
            {
                six = Convert.ToChar('0' + blue - ((blue / 16) * 16));
            }

            string rgb = new string(new char[] { ones, twos, three, four, five, six });
            return rgb;
        }
    }
}
