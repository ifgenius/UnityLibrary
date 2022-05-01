using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace UnityLibrary.ExtensionMethods
{
  public static class TransformExtensions
  {
    public static string PathFromRoot(this Transform self)
    {
      var stack = new Stack<string>();
      var stringBuilder = new StringBuilder();

      stack.Push(self.name);
      var current = self.parent;

      while (current != null)
      {
        stack.Push(current.name);
        current = current.parent;
      }

      while (stack.Count != 0)
      {
        var name = stack.Pop();
        stringBuilder.Append(name);
        
        if (stack.Count == 0)
          break;
        
        stringBuilder.Append('/');
      }

      return stringBuilder.ToString();
    }
  }
}