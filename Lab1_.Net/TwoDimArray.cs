using System.Numerics;

namespace Lab1_.Net
{
    internal class TwoDimArray
    {
        private int[,] data;
        private int minValue;
        private int maxValue;
        public string Name;

        public TwoDimArray() : this(4, 5, -10, 10)
        {
        }

        public TwoDimArray(int rows, int cols, int minValue, int maxValue)
        {
            if (rows <= 0 || cols <= 0)
                throw new ArgumentException("Розміри масиву повинні бути більшими за 0");
            if (minValue > maxValue)
                throw new ArgumentException("Мінімальне значення більше за максимальне");
            data = new int[rows, cols];
            this.minValue = minValue;
            this.maxValue = maxValue;
            Name = "A";
            Randomize();
        }

        public int Rows
        {
            get { return data.GetLength(0); }
        }

        public int Cols
        {
            get { return data.GetLength(1); }
        }

        public int MinValue
        {
            get { return minValue; }
        }

        public int MaxValue
        {
            get { return maxValue; }
        }

        public int this[int i, int j]
        {
            get
            {
                CheckIndex(i, j);
                return data[i, j];
            }
            set
            {
                CheckIndex(i, j);
                if (value < minValue || value > maxValue)
                    throw new ArgumentException("Значення має бути в діапазоні [" + minValue + ", " + maxValue + "]");
                data[i, j] = value;
            }
        }

        private void CheckIndex(int i, int j)
        {
            if (i < 0 || i >= Rows || j < 0 || j >= Cols)
                throw new IndexOutOfRangeException("Індекси [" + i + ", " + j + "] виходять за межі масиву [0.." + (Rows - 1) + ", 0.." + (Cols - 1) + "]");
        }

        public void Randomize()
        {
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                    data[i, j] = Random.Shared.Next(minValue, maxValue + 1);
        }

        public long SumNegative()
        {
            long sum = 0;
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                    if (data[i, j] < 0)
                        sum += data[i, j];
            return sum;
        }

        public bool TryProductPositive(out BigInteger product)
        {
            product = BigInteger.One;
            bool found = false;
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                    if (data[i, j] > 0)
                    {
                        product *= data[i, j];
                        found = true;
                    }
            if (!found)
                product = BigInteger.Zero;
            return found;
        }

        public double[] ColumnAverages()
        {
            double[] averages = new double[Cols];
            for (int j = 0; j < Cols; j++)
            {
                double sum = 0;
                for (int i = 0; i < Rows; i++)
                    sum += data[i, j];
                averages[j] = sum / Rows;
            }
            return averages;
        }

        public string ElementToString(int i, int j)
        {
            return Name + "[" + i + ", " + j + "] = " + this[i, j];
        }

        public override string ToString()
        {
            string[] lines = new string[Rows];
            for (int i = 0; i < Rows; i++)
            {
                string[] items = new string[Cols];
                for (int j = 0; j < Cols; j++)
                    items[j] = data[i, j].ToString();
                lines[i] = string.Join("\t", items);
            }
            return string.Join(Environment.NewLine, lines);
        }
    }
}
