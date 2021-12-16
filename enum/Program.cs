using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(gunler.Sali);
            Console.WriteLine((int)gunler.Sali);
            int hava=22;
            if(hava>=(int)sicaklik.normal && hava<=(int)sicaklik.coksicak)
            Console.WriteLine("hadi disariya cikalim");
        }
    }
}
enum gunler
{
Pazartesi=1,
Sali,
Çarşamba,
Perşembe,
Cuma,
Cumartesi,
Pazar
}
enum sicaklik
{
    soguk=15,
    normal =22,
    sicak=30,
    coksicak=35

}