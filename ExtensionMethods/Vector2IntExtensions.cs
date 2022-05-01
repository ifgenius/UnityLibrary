using UnityEngine;

namespace UnityLibrary.ExtensionMethods
{
  public static class Vector2IntExtensions
  {
    public static Vector2Int Plus(this Vector2Int self, int value)
    {
      self.x += value;
      self.y += value;
      return self;
    }
    
    public static Vector2Int WithX(this Vector2Int self, int x) => 
      new Vector2Int(x, self.y);

    public static Vector2Int WithY(this Vector2Int self, int y) => 
      new Vector2Int(self.x, y);

    public static Vector3Int ToVector3Int(this Vector2Int self) => 
      new Vector3Int(self.x, self.y, 0);
  }
}