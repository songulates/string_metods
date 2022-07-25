using System;

namespace proje_odev // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
           string degisken="hazir metod kullanimi";
           string degisken2="Hazir metod ";
           Console.WriteLine(degisken.Length); //harf sayisi
           Console.WriteLine(degisken.ToUpper()); //büyük harf
           Console.WriteLine(degisken.ToLower()); //kücük harf
           Console.WriteLine(string.Concat(degisken,"merhaba"));
           Console.WriteLine(degisken.CompareTo(degisken2)); //0,1,-1
           Console.WriteLine(string.Compare(degisken,degisken2,true));
           Console.WriteLine(string.Compare(degisken,degisken2,false));
           Console.WriteLine(degisken.Contains(degisken2)); //DEGİSKEN içinde degisken2 varmı
           Console.WriteLine(degisken.StartsWith("merhaba"));
           Console.WriteLine(degisken.EndsWith("hosgeldin"));
           Console.WriteLine(degisken.IndexOf("metod"));
           Console.WriteLine(degisken.Insert(0,"merhaba"));
           Console.WriteLine(degisken.LastIndexOf("i"));
           Console.WriteLine(degisken+degisken2.PadLeft(20));
           Console.WriteLine(degisken.PadRight(50)+degisken2.PadLeft(20,'*'));
           Console.WriteLine(degisken+degisken2.PadLeft(20,'*'));
           Console.WriteLine(degisken.Remove(10));
           Console.WriteLine(degisken.Remove(5,3));//5inci karakterden başlayarak 3 karakter siliyo
           Console.WriteLine(degisken.Remove(0,1));
           Console.WriteLine(degisken.Replace("hazir","ready"));
           Console.WriteLine(degisken.Split(' ').Count());
           Console.WriteLine(degisken.Substring(2));
           Console.WriteLine(degisken.Substring(2,4));
        }

    }
}