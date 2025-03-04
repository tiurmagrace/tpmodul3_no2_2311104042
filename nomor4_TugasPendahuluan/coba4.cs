using System;
using System.Collections.Generic;

class coba4
{
    static void Main()
    {
        // Dictionary sebagai table-driven untuk menyimpan diskon berdasarkan kategori pelanggan
        Dictionary<string, double> diskonTable = new Dictionary<string, double>
        {
            {"Silver", 0.05},  // 5% diskon
            {"Gold", 0.10},    // 10% diskon
            {"Platinum", 0.15} // 15% diskon
        };

        // Input kategori pelanggan
        Console.Write("Masukkan kategori pelanggan (Silver/Gold/Platinum): ");
        string kategori = Console.ReadLine();

        // Input harga barang
        Console.Write("Masukkan harga barang: ");
        double harga = Convert.ToDouble(Console.ReadLine());

        // Menghitung diskon berdasarkan table-driven
        if (diskonTable.ContainsKey(kategori))
        {
            double diskon = harga * diskonTable[kategori];
            double totalHarga = harga - diskon;

            Console.WriteLine($"Diskon untuk kategori {kategori}: {diskon * 100}%");
            Console.WriteLine($"Total harga setelah diskon: {totalHarga}");
        }
        else
        {
            Console.WriteLine("Kategori tidak valid. Tidak ada diskon.");
        }
    }
}
