using System.Collections.Generic;
using UnityEngine;

namespace UnityLibrary.ExtensionMethods
{
  public static class GameObjectExtensions
  {
    public static bool HasComponent<T>(this GameObject self) where T : Component => 
      self.GetComponent<T>() != null;

    public static T GetOrAddComponent<T>(this GameObject self) where T : Component
    {
      if (self.TryGetComponent<T>(out var component))
        return component;

      component = self.AddComponent<T>();
      return component;
    }

    public static void RemoveAllComponents<T>(this GameObject self) where T : Component
    {
      foreach (var component in self.GetComponents<T>())
      {
        Object.Destroy(component);
      }
    }

    public static void Destroy(this GameObject self) => 
      Object.Destroy(self);

    public static List<GameObject> Children(this GameObject self)
    {
      var children = new List<GameObject>();
      var transform = self.transform;
      for (var i = 0; i < transform.childCount; i++)
      {
        children.Add(transform.GetChild(i).gameObject);
      }

      return children;
    }

    public static List<GameObject> AllChildren(this GameObject self)
    {
      var children = new List<GameObject>();

      foreach (var child in self.transform.GetComponentsInChildren<Transform>(includeInactive: true))
        children.Add(child.gameObject);

      return children;
    }

    public static bool IsPrefab(this GameObject self) => 
      self.scene.name == null;
  }
}