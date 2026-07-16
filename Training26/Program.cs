namespace Training26;

public class Program {
   static void Main (string[] args) {
      Console.Write ("Enter the size of the square (n): ");
      int n = int.Parse (Console.ReadLine ());
      int[,] square = new int[n, n];
      Console.WriteLine ($"Enter {n * n} numbers:");
      for (int i = 0; i < n; i++) {
         string[] input = Console.ReadLine ().Split (' ');
         for (int j = 0; j < n; j++) {
            square[i, j] = int.Parse (input[j]);
         }
      }
      bool result = MagicSqure.IsMagicSquare (square);
      Console.WriteLine (result);
   }
}

