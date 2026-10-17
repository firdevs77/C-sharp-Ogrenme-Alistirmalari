using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_uygulamalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("\tLütfen Doğum Yılınızı Giriniz: ");
            //int dogumYili = Convert.ToInt32(Console.ReadLine());

            //int güncelYil =2026;
            //int yas = güncelYil - dogumYili;
            //Console.WriteLine("\n\t Hesaplanan Yaşınız: " + yas);
            //Console.ReadKey();



            //Console.WriteLine("Lütfen Bir Sayı Giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int karekok = sayi * sayi;
            //Console.WriteLine($"\n\tGirdiğiniz Sayının Karesi: {karekok}");
            //Console.ReadKey();





            //Console.WriteLine("Lütfen Bir Sayı Giriniz: ");
            //double sayi1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("lütfen ikinci sayıyı giriniz: ");
            //double sayi2=Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Lütfen üçüncü sayıyı giriniz: ");
            //double sayi3=Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Lütfen dördüncü sayıyı giriniz: ");
            //double sayi4=Convert.ToDouble(Console.ReadLine());

            //double toplam = sayi1 + sayi2 + sayi3 + sayi4;
            //double ortalama = toplam / 4;

            //Console.WriteLine("Girdiğiniz sayıların toplamı: " + toplam);
            //Console.WriteLine("Girdiğiniz sayıların ortalaması: " + ortalama);
            //Console.ReadKey();  




            Console.WriteLine("3x+4y denkleminin sonucunu hesaplamak için x ve y değerlerini giriniz.");   
            
            Console.Write("x değişkenini giriniz: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("y değişkenini giriniz: ");
            double y=Convert.ToDouble(Console.ReadLine());

            double sonuc = 3 * x + 4 * y;
            Console.WriteLine($"3x+4y denkleminin sonucu: {sonuc}");
            Console.ReadKey();
        }
    }
} 
