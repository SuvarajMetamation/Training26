using System;
using System.Collections.Generic;
using System.Text;

namespace Training26 {
   public static class MagicSqure {
      public static bool IsMagicSquare (int[,] square) {
         int n = square.GetLength (0);
         if (n != square.GetLength (1))
            return false;
         int targetSum = 0;
         for (int j = 0; j < n; j++) {
            targetSum += square[0, j];
         }
         // Check each row
         for (int i = 0; i < n; i++) {
            int rowSum = 0;
            for (int j = 0; j < n; j++) {
               rowSum += square[i, j];
            }
            if (rowSum != targetSum)
               return false;
         }
         // Check each column
         for (int j = 0; j < n; j++) {
            int colSum = 0;
            for (int i = 0; i < n; i++) {
               colSum += square[i, j];
            }
            if (colSum != targetSum)
               return false;
         }
         // Check main diagonal
         int diag1 = 0;
         for (int i = 0; i < n; i++) {
            diag1 += square[i, i];
         }
         if (diag1 != targetSum)
            return false;
         // Check secondary diagonal
         int diag2 = 0;
         for (int i = 0; i < n; i++) {
            diag2 += square[i, n - 1 - i];
         }
         return diag2 == targetSum;
      }
   }
}
