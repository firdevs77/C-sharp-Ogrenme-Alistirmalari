C# Öğrenme Alıştırmaları
Bu depo C# öğrenme sürecimde yazdığım konsol uygulamalarını içermektedir.

```
  //ehliyet alma yaşı kontrolü
  Console.Write("Yaşınızı giriniz: ");
  if (int.TryParse(Console.ReadLine(), out int yas))
  {
      if (yas >= 18)
      {
          Console.WriteLine("Ehliyet Alabilirsiniz.");
      }
      else
      {
          Console.WriteLine("Ehliyet Alamazsınız.");
      }
      Console.ReadKey();
  }
```

    //tek mi çift mi kontrolü
  Console.Write("Bir sayı giriniz: ");
  if (int.TryParse(Console.ReadLine(), out int sayi))
  {
      string sonuc = (sayi % 2 == 0) ? "Çift sayı" : "Tek sayı";
      Console.WriteLine("Girdiğiniz sayı bir " + sonuc + "dır.");
  }
  Console.ReadKey();



  //mevsim belirleme
  Console.Write("bir ay ismi giriniz: ");
  string ayısmi = Console.ReadLine().ToLower();
  switch (ayısmi)
  {
      case "ocak":
      case "şubat":
      case "mart":
          Console.WriteLine("Kış mevsimi");
          break;
      case "nisan":
      case "mayıs":
      case "haziran":
          Console.WriteLine("İlkbahar mevsimi");
          break;
      case "temmuz":
      case "ağustos":
      case "eylül":
          Console.WriteLine("Yaz mevsimi");
          break;
      case "ekim":
      case "kasım":
      case "aralık":
          Console.WriteLine("Sonbahar mevsimi");
          break;
      default:
          Console.WriteLine("Geçersiz ay ismi");
          break;
  }
  Console.ReadKey();






 //basit hesap makinesi
 Console.WriteLine("1.sayıyı giriniz: ");
 if (!double.TryParse(Console.ReadLine(), out double sayi1))
 {
     Console.WriteLine("Hata:Geçersiz sayı girdiniz!");
     return;
 }
 Console.WriteLine("2.sayıyı giriniz: ");
 if (!double.TryParse(Console.ReadLine(), out double sayi2))
 {
     Console.WriteLine("Hata:Geçersiz sayı girdiniz!");
     return;
 }
 Console.WriteLine("Yapmak istediğiniz işlemi seçiniz (+, -, *, /): ");
 string islem = Console.ReadLine();

 string sonucMesajı;
 switch (islem)
 {
     case "+":
         sonucMesajı = $"Sonuç: {sayi1 + sayi2}";
         break;
     case "-":
         sonucMesajı = $"Sonuç: {sayi1 - sayi2}";
         break;
     case "*":
         sonucMesajı = $"Sonuç: {sayi1 * sayi2}";
         break;
     case "/":
         if (sayi2 == 0)
         {
             sonucMesajı = "Hata: Sıfıra bölme hatası!";
         }
         else
         {
             sonucMesajı = $"Sonuç: {sayi1 / sayi2}";
         }
         break;
     default:
         sonucMesajı = "Hata: Geçersiz işlem seçtiniz!";
         break;
 }
 Console.WriteLine(sonucMesajı);
 Console.ReadKey();




//1'den 100'e kadar olan 3'e bölünebilen sayıların topl
int toplam = 0;
for (int i = 1; i <= 100; i++) 
{
    if (i % 3 == 0)
        toplam = toplam + i;
}
Console.WriteLine("sonuç:  {0}", toplam);
Console.ReadKey();




 //faktöriyel hasaplama
 int toplam = 1;
 int sayi;
 Console.WriteLine("Faktöriyel alınacak sayı giriniz:");
 sayi = int.Parse(Console.ReadLine());
 for (int i = 1; i <= sayi; i++)
 {
     toplam = toplam * i;
 }
 Console.WriteLine("Sonuç: {0}", toplam);
 Console.ReadKey();




 //bakterilerin saat başı çoğalması
 int bacterium = 1;

 for (int i = 1; i <= 24; i++)
 {
     bacterium *= 2;
     Console.WriteLine(i + ". saat: " + bacterium);
 }
 Console.ReadKey();



//girilen sayıyı basamaklarına ayırır ve sayının oluştuğu rakamları toplar
Console.Write("Lütfen bir sayı giriniz: ");
int number = int.Parse(Console.ReadLine());
int ones, tens, hundreds;
int sum;

ones = number % 10;
tens = number % 100 / 10;
hundreds = number / 100;
Console.WriteLine(ones + "--" + tens + "--" + hundreds);

sum = ones + tens + hundreds;
Console.WriteLine(sum);




  //* şekil oluşturma
  int n = 5;
  for (int i = 1; i <= n; i++)
  {
      for (int j = n - 1; j <= 2; j++)
      {
          Console.Write("*");
      }

      for (int k = 1; k <= 2 * i - 1; k++)
      {
          Console.Write("*");
      }
      Console.WriteLine();
  }

  for (int i = n - 1; i >= n; i--)
  {
      for (int j = n - 1; j >= 0; j--)
      {
          Console.Write(" ");
      }

      for (int k = 1; k <= 2 * i - 1; k++)
      {
          Console.Write("*");
      }
      Console.WriteLine();
  }
