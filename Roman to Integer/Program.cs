/*

Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
For example, 2 is written as II in Roman numeral, just two ones added together.
12 is written as XII, which is simply X + II. The number 27 is written as XXVII, 
which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. 
However, the numeral for four is not IIII. Instead, the number four is written as IV. 
Because the one is before the five we subtract it making four. 
The same principle applies to the number nine, which is written as IX. 
There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
Given a roman numeral, convert it to an integer.
 
 */

Solution s = new Solution();
Console.WriteLine(s.RomanToInt("MCMXCIV")); // 1994
Console.WriteLine(s.RomanToInt("LVIII")); // 58

public class Solution
{
    public int RomanToInt(string s)
    {
     //declare return value
        int result = 0;
     //create a Dictionary
        Dictionary<char, int> romanValues = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
        for (int i = 0; i < s.Length; i++)
        {
         //pull the index value and match to the dictionary key value I = 1
         //then the value will be stored in current 
            int current = romanValues[s[i]];

             //Check if the next there are more values left in s
            //Also check if the next value is bigger
            if (i + 1 < s.Length && current < romanValues[s[i + 1]])
            {
               //Remove the current value from the result if it is less than the next value
                result -= current;   // subtractive pair — this symbol counts negative
            }
            else
            {
             //if current is bigger than the next, store in result
                result += current;   // normal case — add as before
            }
        }
        return result;

    }
}
