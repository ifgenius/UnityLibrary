using System.Collections.Generic;

namespace UnityLibrary.ExtensionMethods
{
  public static class DictionaryExtensions
  {
    public static bool TryAdd<TKey, TValue>(this Dictionary<TKey, TValue> self, TKey key, TValue value)
    {
      if (self.ContainsKey(key))
        return false;

      self.Add(key, value);
      return true;
    }

    public static void AddOrSet<TKey, TValue>(this Dictionary<TKey, TValue> self, TKey key, TValue value)
    {
      if (self.ContainsKey(key))
      {
        self[key] = value;
        return;
      }

      self.Add(key, value);
    }
  }
}