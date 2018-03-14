using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace vovel_Constant
{
    class Program
    {
        static void Main(string[] args)
        {
            vovelConst voCo = new vovelConst();
            Console.WriteLine("Cumlenizi Yazin");
            var screenWord = Console.ReadLine();
            voCo.Vowel(screenWord);





            //void findDigitOfNumber()
            //{


            //    int i = 0;

            //    Console.WriteLine("Istediyiniz Ededi Yazin");
            //    var eded = Convert.ToInt32(Console.ReadLine());


            //    do
            //    {
            //        eded = eded / 10;
            //        i++;

            //    } while (eded > 0);
            //    Console.WriteLine("Reqemlerin Sayi " + i);

            //}
            //findDigitOfNumber();





            //void findDigitOfNumberWithWhile()
            //{
            //    int i = 0;

            //    Console.WriteLine("Istediyiniz Ededi Yazin");
            //    var eded = Convert.ToInt32(Console.ReadLine());

            //    while (eded > 0)
            //    {
            //        eded = eded / 10;
            //        i++;

            //    }
            //    Console.WriteLine("Reqemlerin Sayi " + i);

            //}
            //findDigitOfNumberWithWhile();








            //void findSumDigitOfNumber()
            //{
            //    Console.WriteLine("Istediyiniz Reqemi Yazin");
            //    int screenNumber = Convert.ToInt32(Console.ReadLine());
            //    int r;
            //    int cem = 0;

            //    while (screenNumber != 0)
            //    {
            //        r = screenNumber % 10;
            //        screenNumber = screenNumber / 10;
            //        cem = cem + r;
            //    }
            //    Console.WriteLine("Reqemlerin Cemi " + cem);
            //}
            //findSumDigitOfNumber();



            //void showSentences()
            //{
            //    Console.WriteLine("Bir Cumle Yazin");
            //    var cmle = Console.ReadLine();

            //    string[] sozler = cmle.Split(' ');

            //    foreach (var item in sozler)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //showSentences();


            //void noticeKeywordInStatement()
            //    {
            //        List<string> keywords = new List<string>() { "Tenbel", "Kod yazmayan", "Yola Veren", "Esneyen", "Bekar" };
            //        Console.WriteLine("Cumle Yazin");
            //        var cmle = Console.ReadLine();

            //        foreach (var item in keywords)
            //        {
            //            if (cmle.Contains(item) == true)
            //            {
            //                Console.WriteLine("Siz Lozersiz");
            //            }
            //        }
            //    }
            //        noticeKeywordInStatement();


            //void changeItemOfSentence()
            //{
            //    Console.WriteLine("Cumleni Yaz");
            //    var cmle = Console.ReadLine();
            //    string[] a = cmle.Split(' ');
            //    var kw = "Loser";

            //    for (int i = 0; i < a.Length; i++)
            //    {


            //        if (a[i] == "Tenbel" || a[i] == "tenbel")
            //        {
            //            a[i] = kw;
            //        }
            //        Console.Write(a[i] + " ");

            //    }
            //}
            //changeItemOfSentence();


            //void giveMoney()
            //{
            //    Console.WriteLine("Pul miqdarini daxil edin :");
            //    var pul = Convert.ToInt32(Console.ReadLine());
            //    int yuzduk = 0;
            //    int elilik = 0;
            //    int onlug = 0;
            //    int birlik = 0;

            //    yuzduk = pul / 100;
            //    pul = pul % 100;
            //    elilik = pul / 50;
            //    pul = pul % 50;
            //    onlug = pul / 10;
            //    pul = pul % 10;
            //    birlik = pul;

            //    Console.WriteLine(yuzduk + " dene yuzduk " + elilik + " dene elilik " + onlug + " dene onlug " + birlik + " dene manatliq ");

            //}

            //giveMoney();


        }

    }
}

