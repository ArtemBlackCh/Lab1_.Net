namespace Lab1_.Net
{
    public class Calculation_abc
    {
        private double a, b, c;

        public Calculation_abc()
        {
        }

        public Calculation_abc(double a, double b)
        {
            A = a;
            B = b;
        }

        public Calculation_abc(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double A
        {
            get { return a; }
            set { a = Check(value, "A"); }
        }

        public double B
        {
            get { return b; }
            set { b = Check(value, "B"); }
        }

        public double C
        {
            get { return c; }
            set { c = Check(value, "C"); }
        }

        private static double Check(double value, string name)
        {
            if (!double.IsFinite(value))
                throw new ArgumentException("Число " + name + " має бути скінченним");
            return value;
        }

        public double Calculate()
        {
            if (a > 0 || b > 0 || c > 0)
            {
                double sum = a + b + c;
                return sum * sum;
            }
            return a * a + b * b + c * c;
        }
    }
}
