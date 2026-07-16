namespace Training26;

class Program {
   static void Main (string[] args) {
      Console.WriteLine(BracketChecker.IsBracketChecker ("([])")); //True
      Console.WriteLine (BracketChecker.IsBracketChecker ("(]")); //False
   }
}

