using System.Collections.Generic;
using System.Linq;

namespace UnityLibrary.ExtensionMethods
{
  public static class EnumerableExtensions
  {
    public static bool IsNullOrEmpty<T>(this IEnumerable<T> self) =>
      self == null || self.IsEmpty();

    public static bool IsEmpty<T>(this IEnumerable<T> self)
    {
      if (self is IList<T> list)
        return list.Count == 0;

      if (self is ICollection<T> collection)
        return collection.Count == 0;

      return !self.Any();
    }
  }
}