namespace UnityLibrary.ExtensionMethods
{
  public static class NullableExtensions
  {
    public static T Or<T>(this T? self, T other) where T : struct =>
      self ?? other;

    public static T OrDefault<T>(this T? self) where T : struct =>
      self.GetValueOrDefault();
  }
}