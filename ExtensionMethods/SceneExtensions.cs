using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityLibrary.ExtensionMethods
{
  public static class SceneExtensions
  {
    public static List<GameObject> AllGameObjects(this Scene self)
    {
      var gameObjects = new List<GameObject>();

      foreach (var rootGameObject in self.GetRootGameObjects())
      foreach (var component in rootGameObject.GetComponentsInChildren<Transform>(includeInactive: true))
      {
        gameObjects.Add(component.gameObject);
      }

      return gameObjects;
    }
  }
}