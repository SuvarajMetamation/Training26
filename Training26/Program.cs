namespace Training26;

public static class Program {
   static void Main (string[] args) {
      Console.WriteLine(IsBracketChecker ("([])")); //True
      Console.WriteLine (IsBracketChecker ("(]")); //False
   }
   public static bool IsBracketChecker(string s) {
      Stack<char> stack = new Stack<char> ();
      foreach (char c in s) {
         if (c == '(' || c == '[') {
            stack.Push (c);
         } else if (c == ')' || c == ']') {
            if (stack.Count == 0)
               return false;
            char top = stack.Pop ();
            if ((c == ')' && top != '(') ||
                (c == ']' && top != '[')) {
               return false;
            }
         }
      }
      return stack.Count == 0;
   }
}

