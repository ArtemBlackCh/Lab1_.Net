namespace Lab1_.Net
{
    internal class OneDimArray
    {
        private int[] data;
        private int minValue;
        private int maxValue;
        public string Name;

        public OneDimArray() : this(20, -100, 100)
        {
        }

        public OneDimArray(int size, int minValue, int maxValue)
        {
            if (size <= 0)
                throw new ArgumentException("Розмір масиву повинен бути більшим за 0");
            if (minValue > maxValue)
                throw new ArgumentException("Мінімальне значення більше за максимальне");
            data = new int[size];
            this.minValue = minValue;
            this.maxValue = maxValue;
            Name = "A";
            Randomize();
        }

        public int Length
        {
            get { return data.Length; }
        }

        public int MinValue
        {
            get { return minValue; }
        }

        public int MaxValue
        {
            get { return maxValue; }
        }

        public int this[int index]
        {
            get
            {
                CheckIndex(index);
                return data[index];
            }
            set
            {
                CheckIndex(index);
                if (value < minValue || value > maxValue)
                    throw new ArgumentException("Значення має бути в діапазоні [" + minValue + ", " + maxValue + "]");
                data[index] = value;
            }
        }

        private void CheckIndex(int index)
        {
            if (index < 0 || index >= data.Length)
                throw new IndexOutOfRangeException("Індекс " + index + " виходить за межі масиву [0, " + (data.Length - 1) + "]");
        }

        public void Randomize()
        {
            for (int i = 0; i < data.Length; i++)
                data[i] = Random.Shared.Next(minValue, maxValue + 1);
        }

        public long SumNegative()
        {
            long sum = 0;
            for (int i = 0; i < data.Length; i++)
                if (data[i] < 0)
                    sum += data[i];
            return sum;
        }

        public long SumPositive()
        {
            long sum = 0;
            for (int i = 0; i < data.Length; i++)
                if (data[i] > 0)
                    sum += data[i];
            return sum;
        }

        public long SumAll()
        {
            long sum = 0;
            for (int i = 0; i < data.Length; i++)
                sum += data[i];
            return sum;
        }

        public long SumByRemainder(int divisor, int remainder)
        {
            if (divisor == 0)
                throw new ArgumentException("Дільник не може дорівнювати 0");
            long sum = 0;
            for (int i = 0; i < data.Length; i++)
                if (data[i] % divisor == remainder)
                    sum += data[i];
            return sum;
        }

        public string ElementToString(int index)
        {
            return Name + "[" + index + "] = " + this[index];
        }

        public override string ToString()
        {
            return string.Join(", ", data);
        }
    }
}
