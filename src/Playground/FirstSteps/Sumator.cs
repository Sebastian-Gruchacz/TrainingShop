namespace FirstSteps
{
    static partial class Program
    {
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
