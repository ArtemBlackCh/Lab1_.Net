namespace Lab1_.Net
{
    public class Calculation_ab
    {
        private int a, b;

        public Calculation_ab()
        {
        }

        public Calculation_ab(int b)
        {
            this.b = b;
        }

        public Calculation_ab(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public int B
        {
            get { return b; }
            set { b = value; }
        }

        private static long Mod(long x, long m)
        {
            return (x % m + m) % m;
        }

        public int Count()
        {
            if (a > b)
                throw new ArgumentOutOfRangeException(nameof(a), "A should be less than or equal to B");

            int count = 0;

            for (long i = a; i <= b; i++)
            {
                if (Mod(i, 29) == 0 && Mod(i, 2) == 0 && Mod(i, 5) == 2)
                    count++;
            }
            return count;
        }
    }
}
