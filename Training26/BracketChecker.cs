using System;
using System.Collections.Generic;
using System.Text;

namespace Training26 {
   public static class BracketChecker {
      public static bool IsBracketChecker (string s) {
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
}
