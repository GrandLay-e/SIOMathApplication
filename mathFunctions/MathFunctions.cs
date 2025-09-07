using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIO_Math
{
    static class MathFunctions
    {
        private const string hexDigits = "0123456789ABCDEF";
        
        public static bool isBinary(this string bin) 
            => !string.IsNullOrEmpty(bin) && bin.All(c => c == '0' || c == '1');
        public static bool isDecimal(this string number) 
            => !string.IsNullOrEmpty(number) && long.TryParse(number, out long _number) && _number > 0;
        public static bool isHexadecimal(this string hex) 
            => !string.IsNullOrEmpty(hex) && hex.All(c=> char.IsAsciiHexDigit(c));

        public static string ConvertListToStringToDisplayOperations(this List<List<string>> list, string separator = "\n", int listIndex = 0)
        {
            if (listIndex < 0 || listIndex >= list.Count)
                throw new ArgumentOutOfRangeException(nameof(listIndex), "Invalid list index.");
            return string.Join(separator, list[listIndex]);
        }
        public static List<List<string>> SuccessiveDivisons(this long number, int @base)
        {
            if (@base != 2 && @base != 16)
                throw new ArgumentException("Base must be 2 or 16.");
            
            List<string> operations = new List<string>();
            List<string> results = new List<string>();
            
            do
            {
                long rest = number % @base;
                long quotient = number / @base;
                
                // Convertir le reste en représentation appropriée
                string restRepresentation = @base == 16 && rest >= 10 
                    ? ((char)('A' + rest - 10)).ToString() 
                    : rest.ToString();
                    
                operations.Add($"{number} / {@base} = {quotient} --> [{restRepresentation}]");
                results.Add(restRepresentation);
                number = quotient;
            } while (number > 0);

            results.Reverse();
            return new List<List<string>> { operations, results};
        }

        public static List<List<string>> ConvertDecimalToBinary(long number) =>number.SuccessiveDivisons(2);
        //{
        //    List<string> operations = new List<string>();
        //    List<string> results = new List<string>();

        //    string binary = string.Empty;
        //    long originalNumber = number;

        //    do
        //    {
        //        long rest = number % 2;
        //        long quotient = number / 2;
        //        operations.Add($"{number} / 2 = {quotient} reste {rest}");
        //        results.Add(rest.ToString());
        //        binary = rest + binary;
        //        number = quotient;
        //    } while (number > 0);

        //    results.Add(binary);

        //    return new List<List<string>> { operations, results };
        //}

        public static List<List<string>> ConvertBinaryToDecimal(long bin)
        {
            string binary = bin.ToString();
            List<string> operations = new List<string>();
            List<string> results = new List<string>();
            
            long decimalValue = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                int digit = binary[binary.Length - 1 - i] - '0';
                long powerValue = (long)Math.Pow(2, i);
                long contribution = digit * powerValue;
                
                operations.Add($"{digit} × 2^{i} = {digit} × {powerValue} = {contribution}");
                results.Add(contribution.ToString());
                decimalValue += contribution;
            }
            
            operations.Add($"Somme totale: {decimalValue}");
            results.Add(decimalValue.ToString());
            
            return new List<List<string>> { operations, results };
        }

        public static List<List<string>> ConvertDecimalToHexadecimal(long number) => number.SuccessiveDivisons(16);
        //{
        //    List<string> operations = new List<string>();
        //    List<string> results = new List<string>();

        //    string hex = string.Empty;
        //    long originalNumber = number;

        //    do
        //    {
        //        long rest = number % 16;
        //        long quotient = number / 16;
        //        // Remplacez cette ligne dans ConvertDecimalToHexadecimal :
        //        string hexDigit = hexDigits[(int)rest].ToString();

        //        operations.Add($"{number} / 16 = {quotient} reste {rest} ({hexDigit})");
        //        results.Add(hexDigit);
        //        hex = hexDigit + hex;
        //        number = quotient;
        //    } while (number > 0);

        //    operations.Add($"Résultat final: {hex}");
        //    results.Add(hex);

        //    return new List<List<string>> { operations, results };
        //}

        public static List<List<string>> ConvertHexadecimalToDecimal(string hex)
        {
            hex = hex.ToUpper();
            List<string> operations = new List<string>();
            List<string> results = new List<string>();
            
            int decimalValue = 0;
            for (int i = 0; i < hex.Length; i++)
            {
                char hexChar = hex[hex.Length - 1 - i];
                int digit = char.IsDigit(hexChar) ? hexChar - '0' : hexChar - 'A' + 10;
                int powerValue = (int)Math.Pow(16, i);
                int contribution = digit * powerValue;
                
                operations.Add($"{hexChar} × 16^{i} = {digit} × {powerValue} = {contribution}");
                results.Add(contribution.ToString());
                decimalValue += contribution;
            }
            
            operations.Add($"Somme totale: {decimalValue}");
            results.Add(decimalValue.ToString());
            
            return new List<List<string>> { operations, results };
        }

        // Fonction factorísée pour les conversions via décimal
        private static List<List<string>> ConvertViaDecimal(string input, string inputType, string outputType, 
            Func<string, List<List<string>>> inputToDecimal, Func<long, List<List<string>>> decimalToOutput)
        {
            List<string> operations = new List<string>();
            List<string> results = new List<string>();
            
            // Étape 1: Conversion vers décimal
            operations.Add($"Étape 1: Conversion {inputType} vers décimal");
            var toDecimalResult = inputToDecimal(input);
            operations.AddRange(toDecimalResult[0]);
            
            string decimalValue = toDecimalResult[1].Last();
            
            // Étape 2: Conversion décimal vers sortie
            operations.Add($"Étape 2: Conversion décimal vers {outputType}");
            var fromDecimalResult = decimalToOutput(long.Parse(decimalValue));
            operations.AddRange(fromDecimalResult[0]);
            results.AddRange(fromDecimalResult[1]);
            
            return new List<List<string>> { operations, results };
        }

        public static List<List<string>> ConvertBinaryToHexadecimal(long bin)
        {
            return ConvertViaDecimal(bin.ToString(), "binaire", "hexadécimal", 
                (b) => ConvertBinaryToDecimal(long.Parse(b)), 
                ConvertDecimalToHexadecimal);
        }

        public static List<List<string>> ConvertHexadecimalToBinary(string hex)
        {
            return ConvertViaDecimal(hex.ToUpper(), "hexadécimal", "binaire", 
                ConvertHexadecimalToDecimal, 
                ConvertDecimalToBinary);
        }

        public static List<List<string>> Pgcd(long a, long b)
        {
            List<string> operations = new List<string>();
            List<string> results = new List<string>();
            
            long originalA = a, originalB = b;
            operations.Add($"Calcul PGCD({originalA}, {originalB}) avec l'algorithme d'Euclide:");
            
            while (b != 0)
            {
                long temp = b;
                long remainder = a % b;
                operations.Add($"{a} = {b} × {a / b} + {remainder}");
                results.Add(remainder.ToString());
                
                b = remainder;
                a = temp;
            }
            
            operations.Add($"PGCD({originalA}, {originalB}) = {a}");
            results.Add(a.ToString());
            
            return new List<List<string>> { operations, results };
        }

        public static List<List<string>> Ppcm(long a, long b)
        {
            List<string> operations = new List<string>();
            List<string> results = new List<string>();
            
            operations.Add($"Calcul PPCM({a}, {b}) avec la formule: PPCM(a,b) = (a × b) / PGCD(a,b)");
            
            var pgcdResult = Pgcd(a, b);
            operations.AddRange(pgcdResult[0]);
            long pgcdValue = long.Parse(pgcdResult[1].Last());
            
            long product = a * b;
            long ppcmValue = product / pgcdValue;
            
            operations.Add($"PPCM({a}, {b}) = ({a} × {b}) / {pgcdValue} = {product} / {pgcdValue} = {ppcmValue}");
            results.Add(ppcmValue.ToString());
            
            return new List<List<string>> { operations, results };
        }

        public static List<List<string>> Congruence(long a, long b, long m)
        {
            List<string> operations = new List<string>();
            List<string> results = new List<string>();
            
            operations.Add($"Calcul de la congruence: {a} ≡ {b} (mod {m})");
            
            long normalizedA = a % m;
            long normalizedB = b % m;
            
            if (normalizedA < 0) normalizedA += m;
            if (normalizedB < 0) normalizedB += m;
            
            operations.Add($"{a} mod {m} = {normalizedA}");
            operations.Add($"{b} mod {m} = {normalizedB}");
            
            long difference = (normalizedA - normalizedB + m) % m;
            operations.Add($"Différence: ({normalizedA} - {normalizedB} + {m}) mod {m} = {difference}");
            
            results.Add(difference.ToString());
            
            return new List<List<string>> { operations, results };
        }

        public static List<List<string>> FindCongruences(long a, long b)
        {
            List<string> operations = new List<string>();
            List<string> results = new List<string>();
            
            long final = Math.Max(a, b);
            operations.Add($"Recherche des modulos pour lesquels {a} ≡ {b} (mod m), avec m de 1 à {final}");
            
            List<long> congruences = new List<long>();
            for(long i = 1; i <= final; i++)
            {
                var congruenceResult = Congruence(a, b, i);
                long congruenceValue = long.Parse(congruenceResult[1][0]);
                
                if(congruenceValue == 0)
                {
                    operations.Add($"m = {i}: {a} ≡ {b} (mod {i}) ✓");
                    results.Add(i.ToString());
                    congruences.Add(i);
                }
            }
            
            operations.Add($"Modulos trouvés: [{string.Join(", ", congruences)}]");
            
            return new List<List<string>> { operations, results };
        }
    }
}
