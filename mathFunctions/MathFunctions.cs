using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIO_Math
{
    static class MathFunctions
    {
        public static string ConvertDecimalToBinary(long number)
        {
            if (number < 0)
            {
                return "Error: Negative numbers are not supported.";
            }
            string binary = string.Empty;
            do
            {
                binary = (number % 2) + binary;
                number /= 2;
            } while (number > 0);
            return binary;
        }

        public static string ConvertBinaryToDecimal(long bin)
        {
            string binary = bin.ToString();
            if (string.IsNullOrEmpty(binary) || !binary.All(c => c == '0' || c == '1'))
            {
                return "Error: Invalid binary number.";
            }
            long decimalValue = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                decimalValue += (binary[binary.Length - 1 - i] - '0') * (int)Math.Pow(2, i);
            }
            return decimalValue.ToString();
        }

        public static string ConvertDecimalToHexadecimal(long number)
        {
            if (number < 0)
            {
                return "Error: Negative numbers are not supported.";
            }
            const string hexDigits = "0123456789ABCDEF";
            string hex = string.Empty;
            do
            {
                // cast can not work
                hex = hexDigits[(int)number % 16] + hex;
                number /= 16;
            } while (number > 0);
            return hex;
        }

        public static string ConvertHexadecimalToDecimal(string hex)
        {
            hex = hex.ToUpper();
            if (string.IsNullOrEmpty(hex) || !hex.All(c => char.IsDigit(c) || (c >= 'A' && c <= 'F')))
            {
                return "Error: Invalid hexadecimal number.";
            }
            int decimalValue = 0;
            for (int i = 0; i < hex.Length; i++)
            {
                decimalValue += (hex[hex.Length - 1 - i] - (char.IsDigit(hex[hex.Length - 1 - i]) ? '0' : 'A' - 10)) * (int)Math.Pow(16, i);
            }
            return decimalValue.ToString();
        }

        public static string ConvertBinaryToHexadecimal(long bin) 
            => ConvertDecimalToHexadecimal(long.Parse(ConvertBinaryToDecimal(bin)));
        //{
        //    return 

        //string binary = bin.ToString();
        //if (string.IsNullOrEmpty(binary) || !binary.All(c => c == '0' || c == '1'))
        //{
        //    return "Error: Invalid binary number.";
        //}
        //long decimalValue = 0;
        //for (int i = 0; i < binary.Length; i++)
        //{
        //    decimalValue += (binary[binary.Length - 1 - i] - '0') * (int)Math.Pow(2, i);
        //}
        //return ConvertDecimalToHexadecimal(decimalValue);
        //}

        public static string ConvertHexadecimalToBinary(string hex)
            => ConvertDecimalToBinary(long.Parse(ConvertHexadecimalToDecimal(hex.ToUpper())));
        //{
        //    if (string.IsNullOrEmpty(hex) || !hex.All(c => char.IsDigit(c) || (c >= 'A' && c <= 'F')))
        //    {
        //        return "Error: Invalid hexadecimal number.";
        //    }
        //    int decimalValue = 0;
        //    for (int i = 0; i < hex.Length; i++)
        //    {
        //        decimalValue += (hex[hex.Length - 1 - i] - (char.IsDigit(hex[hex.Length - 1 - i]) ? '0' : 'A' - 10)) * (int)Math.Pow(16, i);
        //    }
        //    return ConvertDecimalToBinary(decimalValue);
        //}

        public static long Pgcd(long a, long b)
        {
            if (a < 0 || b < 0)
            {
                throw new ArgumentException("PGCD is not defined for negative numbers.");
            }
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static long Ppcm(long a, long b)
        {
            if (a < 0 || b < 0)
            {
                throw new ArgumentException("PPCM is not defined for negative numbers.");
            }
            return (a * b) / Pgcd(a, b);
        }

        public static long Congruence(long a, long b, long m)
        {
            if (m <= 0)
            {
                throw new ArgumentException("Modulo must be a positive integer.");
            }

            a = a % m;
            b = b % m;
            if (a < 0) a += m;
            if (b < 0) b += m;
            return (a - b + m) % m;
        }

        public static List<long> FindCongruences(long a, long b)
        {
            long final = a;
            if (b > a)
                final = b;

            List<long> listCongruencs = new List<long>();
            for(long i = 1; i<= final; i++)
            {
                if(Congruence(a, b, i) == 0)
                    listCongruencs.Add(i);
            }

            return listCongruencs;
        }
    }
}
