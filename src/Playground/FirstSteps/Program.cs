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

    static class Program
    {
        static void Main(string[] args)
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

        internal class Sumator
        {
            public int A { get; set; }

            public int B { get; set; }

            public override string ToString()
            {
                return (this.A + this.B).ToString();
            }
        }
    }
}
