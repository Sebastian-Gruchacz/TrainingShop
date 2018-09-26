namespace TrainingShop.Model
{
    using System.Drawing;

    public class Pies
    {
        public string Nazwa;

        public Color Kolor;

        public decimal Waga;

        private Żołądek ZawartośćŻołądka;

        public void Jedz(Żarcie jedzenie)
        {
            this.ZawartośćŻołądka.Add(jedzenie);
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return $"Dog \"{this.Nazwa}\" is {this.Kolor} and has weigh {this.Waga}kg";
        }
    }
}