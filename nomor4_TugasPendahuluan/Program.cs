class Program
{
    static void Main()
    {
        DoorMachine pintu = new DoorMachine(); // Pintu terkunci secara default

        pintu.BukaPintu();  // Output: Pintu tidak terkunci
        pintu.KunciPintu(); // Output: Pintu terkunci
        pintu.BukaPintu();  // Output: Pintu tidak terkunci
        pintu.BukaPintu();  // Output: Pintu sudah terbuka
    }
}
