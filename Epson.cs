using System;
// Namespace pemrog11
namespace pemrog11
{
    // Kelas Epson yang mewarisi PrinterWindows
    public class Epson : PrinterWindows
    {
        // Implementasi metode Print dari kelas PrinterWindows
        public override void Print(Printer jenis)
        {
            Console.WriteLine("Printer Epson printing...");
        }

        // Implementasi metode Show dari kelas PrinterWindows
        public override void Show(Printer jenis)
        {
            Console.WriteLine("Dimensi display Epson: 10*11");
        }
    }
}


