using System;

namespace polymorphismInterface
{
  public class Epson : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }
        public void Print()
        {
            Console.WriteLine("Epson printer printing...");
        }
    }
}