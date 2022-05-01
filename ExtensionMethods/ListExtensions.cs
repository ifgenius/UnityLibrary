using System;
using System.Collections.Generic;

namespace UnityLibrary.ExtensionMethods
{
  public static class ListExtensions
  {
    private static readonly Random Random = new Random();

    public static IList<T> Shuffle<T>(this IList<T> self)
    {
      var n = self.Count;
      while (n > 1)
      {
        n--;
        var k = Random.Next(n + 1);
        (self[k], self[n]) = (self[n], self[k]);
      }

      return self;
    }
  }
}