using System;

class Program
{
    static void Main()
    {
        int score = 0;

        //burda ilk soru soruyoruz 

        Console.WriteLine("soru 1 :c# hangı sirket tarafından geliştirildi");
        Console.WriteLine(" A ) Google");
        Console.WriteLine(" B ) Mıcrosoof");
        Console.WriteLine(" C ) Apple ");
        Console.WriteLine("cevabınızı giriniz A/B/C");
        string asnwer1 = Console.ReadLine().ToUpper();

        switch (asnwer1)
        {
            case "B":
                Console.WriteLine("dogru cevap");
                score++;
                break;
            case "A":
            case "C":
                Console.WriteLine("yanlıs cevap Dogru cevap B) mıcrosoft");
                break;

            default:
                Console.WriteLine("gecersiz cevap");
                break;

        }
        //soru 2 
        Console.WriteLine("soru 1 :dünyanın en buyuk okyanusu hangisidir");
        Console.WriteLine(" A ) Hınt okyanusu");
        Console.WriteLine(" B ) Atlas okyanusu");
        Console.WriteLine(" C ) pasifik ");
        Console.WriteLine("cevabınızı giriniz A/B/C"); ;
        string asnwer2 = Console.ReadLine().ToUpper();
        switch (asnwer2)
        {
            case "C":
                Console.WriteLine("dogru cevap");
                score++;
                break;

            case "B":
            case "A":
                Console.WriteLine("yanlıs cevap dogru cevap C)pasifik");
                break;

            default:
                Console.WriteLine("gecersiz cevap");
                break;

        }
        
        Console.WriteLine("türkiyenin en büyük spor kulubü hangisidir ");
        Console.WriteLine("A ) GALATASARAY");
        Console.WriteLine("B ) fenerbahce");
        Console.WriteLine("C ) besiktas");
        Console.WriteLine("cevabınızı giriniz A/B/C");

        string asnwer3 = Console.ReadLine().ToUpper();

        switch (asnwer3)
        {
            case "A":
                Console.WriteLine("dogru cevap");
                score++;
                break;
            case "B":
            case "C":
                Console.WriteLine("yanlıs cevap dogru cevap A)GALATASARAY");
                break;

            default:
                Console.WriteLine("gecersiz cevap");
                break;


        }
        //sonuc 
        Console.WriteLine("yarsıma sona erdi toplam puanınız " + score);
       }
    }