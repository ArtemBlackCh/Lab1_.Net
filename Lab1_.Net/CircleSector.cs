namespace Lab1_.Net
{
    public class CircleSector
    {
        private double radius, alpha1, alpha2;

        public CircleSector() : this(1, 0, 90)
        {
        }

        public CircleSector(double radius) : this(radius, 0, 90)
        {
        }

        public CircleSector(double radius, double alpha1, double alpha2)
        {
            Radius = radius;
            Alpha1 = alpha1;
            Alpha2 = alpha2;
            CheckAngles();
        }

        public double Radius
        {
            get { return radius; }
            set
            {
                if (!double.IsFinite(value) || value <= 0)
                    throw new ArgumentException("Радіус повинен бути додатним скінченним числом");
                radius = value;
            }
        }

        public double Alpha1
        {
            get { return alpha1; }
            set
            {
                if (!double.IsFinite(value))
                    throw new ArgumentException("Кут α1 повинен бути скінченним числом");
                alpha1 = value;
            }
        }

        public double Alpha2
        {
            get { return alpha2; }
            set
            {
                if (!double.IsFinite(value))
                    throw new ArgumentException("Кут α2 повинен бути скінченним числом");
                alpha2 = value;
            }
        }

        public double DeltaAngle
        {
            get { return alpha2 - alpha1; }
        }

        private void CheckAngles()
        {
            if (alpha2 < alpha1)
                throw new ArgumentException("Кут α2 не може бути меншим за α1");
            if (alpha2 - alpha1 > 360)
                throw new ArgumentException("Різниця кутів не може перевищувати 360°");
        }

        public double CalculateArea()
        {
            CheckAngles();
            return Math.PI * radius * radius * DeltaAngle / 360;
        }

        public double CalculateLength()
        {
            CheckAngles();
            return Math.PI * radius * DeltaAngle / 180;
        }

        public bool ContainsAngle(double angle)
        {
            CheckAngles();
            return alpha1 <= angle && angle <= alpha2;
        }
    }
}
