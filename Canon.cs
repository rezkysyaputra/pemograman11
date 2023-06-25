using System;
// Namespace pemrog11
namespace pemrog11
{
    // Kelas Canon yang mewarisi PrinterWindows
    public class Canon : PrinterWindows
    {
        // Implementasi metode Print dari kelas PrinterWindows
        public override void Print(Printer jenis)
        {
            Console.WriteLine("Printer Canon printing...");
        }

        // Implementasi metode Show dari kelas PrinterWindows
        public override void Show(Printer jenis)
        {
            Console.WriteLine("Dimensi display Printer Canon: 9.5*12");
        }
    }
}
