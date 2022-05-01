using System;
using System.Collections.Generic;

namespace UnityLibrary.ExtensionMethods
{
  public static class ListExtensions
  {
    private static readonly Random Rand = new Random();

    public static IList<T> Shuffle<T>(this IList<T> self)
    {
      var n = self.Count;
      while (n > 1)
      {
        n--;
        var k = Rand.Next(n + 1);
        (self[k], self[n]) = (self[n], self[k]);
      }
      
      return self;
    }

    public static T Random<T>(this IList<T> self)
    {
      switch (self.Count)
      {
        case 0:
          throw new IndexOutOfRangeException();
        case 1:
          return self[0];
        default:
          return self[UnityEngine.Random.Range(0, self.Count)];
      }
    }

    public static T ElementAtOr<T>(this IList<T> self, int index, T or) => 
      self.TryGetValue(index, out var result) ? result : or;

    public static bool TryGetValue<T>(this IList<T> self, int index, out T value)
    {
      if (self == null || self.Count == 0)
      {
        value = default;
        return false;
      }

      if (index < 0 || index >= self.Count)
      {
        value = default;
        return false;
      }

      value = self[index];
      return true;
    }
  }
}