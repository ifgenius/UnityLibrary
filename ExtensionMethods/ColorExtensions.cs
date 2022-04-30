using UnityEngine;

namespace UnityLibrary.ExtensionMethods
{
  public static class ColorExtensions
  {
    public static Color WithAlpha(this Color self, float alpha)
    {
      self.a = alpha;
      return self;
    }
  }
}