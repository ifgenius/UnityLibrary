using UnityEngine;

namespace UnityLibrary.ExtensionMethods
{
  public static class CameraExtensions
  {
    public static Bounds OrthographicBounds(this Camera self)
    {
      var screenAspect = Screen.width / (float)Screen.height;
      var cameraHeight = self.orthographicSize * 2;
      var bounds = new Bounds(self.transform.position, new Vector3(cameraHeight * screenAspect, cameraHeight, 0));
      return bounds;
    }
  }
}