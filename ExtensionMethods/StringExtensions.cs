using System;
using System.IO;
using UnityEngine;

namespace UnityLibrary.ExtensionMethods
{
  public static class StringExtensions
  {
    public static bool IsNullOrEmpty(this string self) => 
      string.IsNullOrEmpty(self);

    public static string AddColorTag(this string self, Color color) =>
      $"<color=#{ColorUtility.ToHtmlStringRGB(color)}>{self}</color>";

    public static string TrimEnd(this string self, string end) =>
      self.EndsWith(end) ? self.Remove(self.Length - end.Length) : self;

    public static string DirectoryName(this string self) => 
      Path.GetDirectoryName(self);

    public static T ToEnum<T>(this string self)
    {
      var enumType = typeof(T);
      return (T) Enum.Parse(enumType, self);
    }
  }
}