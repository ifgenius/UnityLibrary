namespace UnityLibrary.ExtensionMethods
{
  public static class NumericExtensions
  {
    public static bool IsEven(this int self) =>
      self % 2 == 0;

    public static bool IsOdd(this int self) =>
      self % 2 != 0;
  }
}