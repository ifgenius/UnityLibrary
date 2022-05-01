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

    public static string RemoveSuffix(this string self, string suffix) =>
      self.EndsWith(suffix) ? self.Remove(self.Length - suffix.Length) : self;

    public static string RemovePrefix(this string self, string prefix) =>
      self.StartsWith(prefix) ? self.Remove(0, prefix.Length) : self;

    public static string DirectoryName(this string self) => 
      Path.GetDirectoryName(self);

    public static T ToEnum<T>(this string self) => 
      (T) Enum.Parse(typeof(T), self);
  }
}