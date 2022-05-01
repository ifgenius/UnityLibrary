namespace UnityLibrary.ExtensionMethods
{
  public static class CastExtensions
  {
    public static TResult As<TCurrent, TResult>(this TCurrent self) 
      where TCurrent : class 
      where TResult : class =>
      self as TResult;
  }
}