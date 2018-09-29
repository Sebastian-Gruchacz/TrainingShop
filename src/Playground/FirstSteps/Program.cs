namespace FirstSteps
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading.Tasks;

    using TrainingShop.Model;

    static partial class Program
    {
        static void Main(string[] args)
        {
            // Lekcja_1();

            LekcjaDruga();
        }

        private static void LekcjaDruga()
        {
            double promień = 15.0D;
            double poleKoła = PoleKoła(promień);

            Console.WriteLine(poleKoła);

            promień = 164324423423.0D;
            poleKoła = PoleKoła(promień);

            Console.WriteLine("{0:N}", poleKoła);

            int największaLiczbaCałkowitaInt32 = int.MaxValue;
            Console.WriteLine(największaLiczbaCałkowitaInt32);

            największaLiczbaCałkowitaInt32 = (int)poleKoła;
            Console.WriteLine(największaLiczbaCałkowitaInt32);

            var d = decimal.MaxValue; // MONEY!!!!!!
            Console.WriteLine("{0:N}",d);
            Console.WriteLine("{0:N}", double.MaxValue);


            string napis = @"fsdfsdf sdfsd fsd f sd fsdf";
            napis = string.Concat(
                new string(napis.ToCharArray().Take(4).ToArray()),
                "d", 
                new string(napis.ToCharArray().Skip(5).ToArray()));

            napis = string.Join("-", "ala", "ma", "kota");
           // napis = napis + " " +  napis;
            
            Console.WriteLine(napis);
            Console.WriteLine(@"---------------------------");

            int[] wiekMoichDzieci = new int[] { 13, 9, 4 };
            foreach (int i in wiekMoichDzieci)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(@"---------------------------");

            int[] kamyki = new int[wiekMoichDzieci[2]];
            kamyki[0] = 17;
            kamyki[3] = 56;

            foreach (int i in kamyki)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(@"---------------------------");

            var kamyki2 = new[] {kamyki[0] * 10, kamyki[1] * 10, kamyki[2] * 10, kamyki[3] * 10, 0, 0};
            foreach (int i in kamyki2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(@"---------------------------");
            foreach (int i in kamyki)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(@"---------------------------");

            string[] napisy = {"ala", "ma", "kota"};
            napisy[2] = "psa";
            napis = string.Join(":", napisy);

            Console.WriteLine(napis);

        }




        /// <summary>
        /// Oblicza pole koła
        /// </summary>
        /// <param name="promień"></param>
        /// <returns></returns>
        private static double PoleKoła(double promień)
        {
            return Math.PI * Math.Pow(promień, 2.0D);
        }

        private static void Lekcja_1()
        {
            Pies wyżełAzor = new Pies
            {
                Nazwa = "Azor",
                Kolor = Color.SaddleBrown,
                Waga = 15.5m
            };

            Pies pudelFafik = new Pies
            {
                Nazwa = "Fafik",
                Kolor = Color.Gray,
                Waga = 5.75m
            };

            Console.WriteLine(wyżełAzor.ToString());
            Console.WriteLine(pudelFafik.ToString());

            pudelFafik.Nazwa = "Bogdan";

            Console.WriteLine(pudelFafik.ToString());

            pudelFafik = wyżełAzor;
            pudelFafik.Nazwa = "Brutus";

            Console.WriteLine(wyżełAzor.ToString());
            Console.WriteLine(pudelFafik.ToString());

            int a = 1;
            int b = 2;
            int c;

            c = (a + b);
            a = 5;
            c = a + b;

            Console.WriteLine(c);

            b = 6;

            Console.WriteLine(c);


            var d = new Sumator();
            d.A = 1;
            d.B = 2;

            Console.WriteLine(d.ToString());

            d.A = 5;

            Console.WriteLine(d);
        }
    }
}
