using UnityEngine;

namespace UnityLibrary.ExtensionMethods
{
  public static class Vector2Extensions
  {
    public static Vector2 Plus(this Vector2 self, float value)
    {
      self.x += value;
      self.y += value;
      return self;
    }

    public static bool Approximately(this Vector2 self, Vector2 other) =>
      Mathf.Approximately(self.x, other.x) &&
      Mathf.Approximately(self.y, other.y);

    public static Vector2 Abs(this Vector2 self) =>
      new Vector2(Mathf.Abs(self.x), Mathf.Abs(self.y));

    public static Vector2 WithX(this Vector2 self, float x) =>
      new Vector2(x, self.y);

    public static Vector2 WithY(this Vector2 self, float y) =>
      new Vector2(self.x, y);

    public static Vector3 WithZ(this Vector2 self, float z) =>
      new Vector3(self.x, self.y, z);
  }
}