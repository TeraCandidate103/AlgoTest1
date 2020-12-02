namespace SumMultiples
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      IAdder adder = new MyAdder();
      Tester tester = new Tester(adder);
      tester.go();
    }
  }
}