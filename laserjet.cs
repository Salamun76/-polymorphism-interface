using System;

namespace polymorphismInterface
{
  public class LaserJet : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("LaserJet display dimension : 12*12");
        }
        public void Print()
        {
            Console.WriteLine("LaserJet printer printing...");
        }
    }
}
