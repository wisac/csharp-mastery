/*
QUESTION: 
Given a string s, find the length of the longest 
substring
 without repeating characters.

Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
Example 2:

Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.

Constraints:

0 <= s.length <= 5 * 104
s consists of English letters, digits, symbols and spaces.
*/


// PSEUDO CODE 
// sort the string
// compare current letter with previous letter
// IF NOT same
//    increment length
// ELSE
//   reset length to 1
//    
// return max length
//  


using System.Text;

namespace Question1;
public class Solution
{
   public static int LengthOfLongestSubstring(string s)
   {
      List<char> letters = new(s);
      int length = 1;
      int maxLength = 1;
      letters.Sort();

foreach (var item in letters)
{
   Console.WriteLine(item);
   
}
      for (int i = 1; i < letters.Count; i++)
      {
         if (letters[i] != letters[i - 1])
         {
            length++;
         }
         else
         {
            maxLength = maxLength < length ? length : maxLength;
            length = 1;
         }
         maxLength = maxLength < length ? length : maxLength;
      }
      Console.WriteLine(length);
      return maxLength;

   }
}