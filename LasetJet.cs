using System;
// Namespace pemrog11
namespace pemrog11
{
    // Kelas LasetJet yang mewarisi PrinterWindows
    public class LasetJet : PrinterWindows
    {
        // Implementasi metode Print dari kelas PrinterWindows
        public override void Print(Printer jenis)
        {
            Console.WriteLine("Printer LaserJet printing...");
        }

        // Implementasi metode Show dari kelas PrinterWindows
        public override void Show(Printer jenis)
        {
            Console.WriteLine("Dimensi display Printer LaserJet: 12*12");
        }
    }
}