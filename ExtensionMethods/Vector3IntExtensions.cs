using UnityEngine;

namespace UnityLibrary.ExtensionMethods
{
  public static class Vector3IntExtensions
  {
    public static Vector3Int Plus(this Vector3Int self, int value)
    {
      self.x += value;
      self.y += value;
      self.z += value;
      return self;
    }

    public static Vector3Int WithX(this Vector3Int self, int x) => 
      new Vector3Int(x, self.y, self.z);

    public static Vector3Int WithY(this Vector3Int self, int y) => 
      new Vector3Int(self.x, y, self.z);

    public static Vector3Int WithZ(this Vector3Int self, int z) => 
      new Vector3Int(self.x, self.y, z);

    public static Vector3Int WithXY(this Vector3Int self, int x, int y) => 
      new Vector3Int(x, y, self.z);

    public static Vector3Int WithXZ(this Vector3Int self, int x, int z) => 
      new Vector3Int(x, self.y, z);

    public static Vector3Int WithYZ(this Vector3Int self, int y, int z) => 
      new Vector3Int(self.x, y, z);

    public static Vector2Int ToVector2Int(this Vector3Int self) => 
      new Vector2Int(self.x, self.y);
  }
}