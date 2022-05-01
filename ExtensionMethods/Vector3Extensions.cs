using System;
using UnityEngine;

namespace UnityLibrary.ExtensionMethods
{
  public static class Vector3Extensions
  {
    public static Vector3 Plus(this Vector3 self, float value)
    {
      self.x += value;
      self.y += value;
      self.z += value;
      return self;
    }

    public static bool Approximately(this Vector3 self, Vector3 other) =>
      Mathf.Approximately(self.x, other.x) &&
      Mathf.Approximately(self.y, other.y) &&
      Mathf.Approximately(self.z, other.z);

    public static Vector3 WithX(this Vector3 self, float x) => 
      new Vector3(x, self.y, self.z);

    public static Vector3 WithY(this Vector3 self, float y) => 
      new Vector3(self.x, y, self.z);

    public static Vector3 WithZ(this Vector3 self, float z) => 
      new Vector3(self.x, self.y, z);

    public static Vector2 ToVector2(this Vector3 self) => 
      new Vector2(self.x, self.y);

    public static Vector2Int ToVector2Int(this Vector3 self, Func<float, int> operation) => 
      new Vector2Int(operation.Invoke(self.x), operation.Invoke(self.y));

    public static Vector3Int ToVector3Int(this Vector3 self, Func<float, int> operation) => 
      new Vector3Int(operation.Invoke(self.x), operation.Invoke(self.y), operation.Invoke(self.z));
  }
}