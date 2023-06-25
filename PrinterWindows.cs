using System;
using pemrog11;

// Namespace pemrog11
namespace pemrog11
{
    // Kelas abstrak PrinterWindows
    public abstract class PrinterWindows
    {
        // Metode abstrak Print dengan parameter Printer
        public abstract void Print(Printer jenis);

        // Metode abstrak Show dengan parameter Printer
        public abstract void Show(Printer jenis);
    }
}