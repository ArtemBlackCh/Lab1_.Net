namespace Lab1_.Net
{
    internal class Tabulator
    {
        private const int MaxPoints = 100000;
        private double[,] xy;
        private int n;

        public Tabulator()
        {
            xy = new double[0, 2];
            n = 0;
        }

        public int Count
        {
            get { return n; }
        }

        public double this[int i, int j]
        {
            get
            {
                if (i < 0 || i >= n || j < 0 || j > 1)
                    throw new IndexOutOfRangeException("Індекс виходить за межі таблиці значень");
                return xy[i, j];
            }
        }

        public static double F1(double x)
        {
            return x * Math.Sin(x + 4);
        }

        public static double F2(double x)
        {
            return Math.Log(4 * x * x + 1);
        }

        public static double F3(double x)
        {
            return Math.Log(Math.Pow(5 + x * x, 1.0 / 5));
        }

        public void Tab(double xn, double xk, double h, double a)
        {
            if (h <= 0)
                throw new ArgumentException("Крок h повинен бути більшим за 0");
            if (xn > xk)
                throw new ArgumentException("Xn не повинно бути більшим за Xk");

            double steps = Math.Floor((xk - xn) / h + 1e-9) + 1;
            if (steps > MaxPoints)
                throw new ArgumentException("Забагато точок, збільште крок h");

            int count = (int)steps;
            double[,] result = new double[count, 2];
            for (int i = 0; i < count; i++)
            {
                double x = xn + i * h;
                double y;
                if (x <= 0)
                    y = F1(x);
                else if (x <= a)
                    y = F2(x);
                else
                    y = F3(x);
                result[i, 0] = x;
                result[i, 1] = y;
            }
            xy = result;
            n = count;
        }
    }
}
