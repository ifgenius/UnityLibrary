using UnityEngine;

namespace UnityLibrary.ExtensionMethods
{
  public static class BoundsExtensions
  {
    public static Vector3 RandomPoint(this Bounds self)
    {
      var x = Random.Range(self.min.x, self.max.x);
      var y = Random.Range(self.min.y, self.max.y);
      var z = Random.Range(self.min.z, self.max.z);
      return new Vector3(x, y, z);
    }
  }
}