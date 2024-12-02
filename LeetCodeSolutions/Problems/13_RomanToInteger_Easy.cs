/* Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
Given a roman numeral, convert it to an integer.

 

Example 1:

Input: s = "III"
Output: 3
Explanation: III = 3.
Example 2:

Input: s = "LVIII"
Output: 58
Explanation: L = 50, V= 5, III = 3.
Example 3:

Input: s = "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
 

Constraints:

1 <= s.length <= 15
s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
It is guaranteed that s is a valid roman numeral in the range [1, 3999]. */

namespace LeetCodeSolutions.Problems
{
    public static class _13_RomanToInteger_Easy
    {
        public static int Solution(string numeroRomano)
        {
            // Definizione dei numeri romani e dei loro valori corrispondenti
            string[] numeriRomani = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] valori = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            int numeroConvertito = 0;
            int i = 0;

            // Unico ciclo for
            for (int pos = 0; pos < numeroRomano.Length;)
            {
                // Controlla se la parte della stringa inizia con il numero romano corrente
                if (numeroRomano.Substring(pos).StartsWith(numeriRomani[i]))
                {
                    // Somma il valore corrispondente al risultato
                    numeroConvertito += valori[i];
                    // Avanza nella stringa di lunghezza del numero romano trovato
                    pos += numeriRomani[i].Length;
                }
                else
                {
                    // Passa al numero romano successivo nell'array
                    i++;
                }
            }

            return numeroConvertito;
        }
    }

}