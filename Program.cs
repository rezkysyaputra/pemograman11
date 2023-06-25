using System;
using System.Reflection;

// Namespace pemrog11
namespace pemrog11
{
    // Kelas Program
    public class Program
    {
        // Metode utama Main
        static void Main(string[] args)
        {
            // Membuat objek Printer
            Printer printer = new Printer();

            // Menampilkan pilihan printer kepada pengguna
            Console.WriteLine("Pilih Printer:");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            // Mengambil input nomor printer dari pengguna
            Console.Write("Nomor Printer[1...3]:");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());
            printer.jenis = nomorPrinter;

            // Mendeklarasikan objek PrinterWindows show dan print
            PrinterWindows? show = null, print = null;

            // Memilih objek printer sesuai dengan nomor yang dipilih pengguna
            if (printer.jenis == 1)
            {
                show = new Epson();
                print = new Epson();
            }
            else if (printer.jenis == 2)
            {
                show = new Canon();
                print = new Canon();
            }
            else if (printer.jenis == 3)
            {
                show = new LasetJet();
                print = new LasetJet();
            }
            else
            {
                Console.WriteLine("INPUTAN SALAH!");
            }

            // Memanggil metode Show dan Print pada objek printer yang telah dipilih
            show?.Show(printer);
            print?.Print(printer);
            Console.ReadKey();
        }
    }
}