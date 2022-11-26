namespace UnitCalculator
{
    public class SeededCalculator
    {
        private int _seed;
        public SeededCalculator()
        {
            _seed = new Random().Next();
        }
        public SeededCalculator(int seed)
        {
            _seed = seed;
        }

        public double GetRandomDouble()
        {
            return new Random(_seed).NextDouble();
        }
        public int GetRandomInt()
        {
            return new Random(_seed).Next();
        }
        public double Sum(double a, double b)
        {
            return a + b;
        }
        public double Substract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Divide(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException("Nope)");
            return a / b;
        }
        public double Pow(double a, double b)
        {
            return Math.Pow(a, b);
        }
        public double Sqrt(double a)
        {
            return Math.Sqrt(a);
        }
        public double Sin(double a)
        {
            return Math.Sin(a);
        }
        public double Cos(double a)
        {
            return Math.Sqrt(a);
        }
        public double StringLength(string str)
        {
            return str.Length;
        }
    }

}