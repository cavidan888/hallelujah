using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vovel_Constant
{
    class vovelConst
    {
        List<char> sait = new List<char>();
        List<char> samit = new List<char>();

        public void Vowel(string value)
        {

            int vowel = 0;
            int cont = 0;

            foreach (var x in value.ToLower())
            {
                if (x.Equals('a') || x.Equals('e') || x.Equals('i') || x.Equals('o') || x.Equals('u'))
                {
                    vowel++;
                    sait.Add(x);
                }


                if (x > 'a' && x <= 'd' || x > 'e' && x < 'i' || x > 'j' && x < 'o' || x >= 'p' && x < 'u' || x > 'v' && x < 'z')
                {
                    cont++;
                    samit.Add(x);
                }

            }
            
            Console.WriteLine("sait Siyahisi");
            Console.WriteLine();//bowluqlar ucun


            foreach (var item in sait)
            {

                Console.Write(item + " ");
                Console.WriteLine();

            }



            Console.WriteLine();//bowluqlar ucun
            Console.WriteLine(vowel + " Eded Sait Var");
            Console.WriteLine();

            //saits end


            Console.WriteLine("Samit Siyahisi");
            Console.WriteLine();//bowluqlar ucun

            foreach (var item in samit)
            {

                Console.Write(item + " ");
                Console.WriteLine();//bowluqlar ucun

            }

            Console.WriteLine();//bowluqlar ucun

            Console.WriteLine(cont + " Eded Samit Var");


        }



    }
   
}
