namespace Training26 {
   class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Enter temperatures separated by spaces:");

         int[] temperatures = Console.ReadLine ()
                                     .Split (' ', StringSplitOptions.RemoveEmptyEntries)
                                     .Select (int.Parse)
                                     .ToArray ();
         int[] result = DaysUntilCoolerTemperature (temperatures);

         Console.WriteLine ("Output:");
         Console.WriteLine ("[" + string.Join (", ", result) + "]");
      }
      static int[] DaysUntilCoolerTemperature (int[] temperatures) {
         int n = temperatures.Length;
         int[] answer = new int[n];
         Stack<int> stack = new Stack<int> ();
         for (int i = n - 1; i >= 0; i--) {
            while (stack.Count > 0 &&
                   temperatures[stack.Peek ()] >= temperatures[i]) {
               stack.Pop ();
            }
            if (stack.Count > 0) {
               answer[i] = stack.Peek () - i;
            } else {
               answer[i] = 0;
            }
            stack.Push (i);
         }
         return answer;
      }
   }
}
