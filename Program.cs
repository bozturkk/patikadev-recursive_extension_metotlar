using System;

namespace recursive_extension_metotlar // Note: actual namespace depends on the project name.
{
    class Program
    {
        static async void Main(string[] args)
        {
            //recursive öz yinelemeli fonksiyondur.
            //başka şekilde de yapılabilir. For döngüsü gibi düşünülebilir.

            //3^4 3*3*3*3
            
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);
            Islemler islemler = new Islemler();
            Console.WriteLine(islemler.Expo(3,4));

            //extension metotlar
            string ifade = "Büşra Öztürk";
            bool sonuc = ifade.Bosluk();
            Console.WriteLine(sonuc);
            if(sonuc)
            {
                Console.WriteLine(ifade.Degistir());
            }
        }
    }

    public class Islemler
    {
        public int Expo(int sayi, int üs)
        {
            if(üs<2)
                return sayi;
            return Expo(sayi, üs-1) * sayi;

        }
    }
    public static class Extension
    {
        public static bool Bosluk(this string param)
        {
           return param.Contains(" ");
        }
        public static string Degistir(this string param)
        {
           string[] dizi = param.Split(" ");
           return string.Join(",",dizi);

        }
    }

}

