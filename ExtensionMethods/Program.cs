
// Extension methods  are used to add methods to an existing class without modifying the source code of the class
string sentence = "we will use all to learn c# .Net";
Console.WriteLine(sentence.ToTitle());  
// output: We Will Use All To Learn C# .Net
public static class StringExtension
{
   public static string ToTitle(this string str)
   {
      char[] letters = new char[str.Length];
      letters[0] = char.ToUpper(str[0]);
      for (int i = 1; i < str.Length; i++)
      {
         letters[i] = str[i];
         if (char.IsWhiteSpace(str[i]))
         {
            letters[i + 1] = char.ToUpper(str[++i]);
         }
      }
      return new string(letters);
   }
}

