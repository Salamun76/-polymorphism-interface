using System;

namespace PolymorphismInterface
{
  public interface IPrinterWindows
    {
        void Show(); /*{
            Console.WriteLine("\nPrinter display dimension"); }*/
        void Print(); /*{
            Console.WriteLine("\nPrinter printing"); }*/
    }
}