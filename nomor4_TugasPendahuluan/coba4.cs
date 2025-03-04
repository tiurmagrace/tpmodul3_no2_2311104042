using System;
using System.Collections.Generic;

class coba4
{
    static void MainCoba4()
    {
        
        Dictionary<string, double> diskonTable = new Dictionary<string, double>
        {
            {"Silver", 0.05},  
            {"Gold", 0.10},    
            {"Platinum", 0.15} 
        };

      
        Console.Write("Masukkan kategori pelanggan (Silver/Gold/Platinum): ");
        string kategori = Console.ReadLine();

       
        Console.Write("Masukkan harga barang: ");
        double harga = Convert.ToDouble(Console.ReadLine());

       
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
