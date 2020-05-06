class program 
{
    
  static void Main(string[] args) 
  {
      
    PrinterWindows printer;

            Console.WriteLine("Pilih Printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet");

            Console.Write("Nomor Printer [1...3] : ");
            int NomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (NomorPrinter == 1)
            {
                printer = new Epson();
            }
            else if (NomorPrinter == 2)
            {
                printer = new Canon();
            }
            else
            {
                printer = new LaserJet();
            }

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
    