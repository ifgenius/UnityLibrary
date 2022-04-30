using System;

namespace UnityLibrary.ExtensionMethods
{
  public static class FunctionalExtensions
  {
    public static T With<T>(this T self, Action<T> action) where T : class
    {
      action?.Invoke(self);
      return self;
    }
  }
}