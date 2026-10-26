using System.Globalization;

namespace Lab1_.Net
{
    public partial class UnitTest : Form
    {
        public UnitTest()
        {
            InitializeComponent();
        }

        private static bool TryRead(string text, out double value)
        {
            string normalized = text.Trim().Replace(',', '.');
            return double.TryParse(normalized, NumberStyles.Float, CultureInfo.InvariantCulture, out value)
                && double.IsFinite(value);
        }

        private void buttonCalc1_Click(object? sender, EventArgs e)
        {
            if (!TryRead(textBoxA1.Text, out double a) || !TryRead(textBoxB1.Text, out double b)
                || !TryRead(textBoxC1.Text, out double c))
            {
                MessageBox.Show("Введіть коректні числові значення a, b та c");
                return;
            }

            try
            {
                var calc = new Calculation_abc(a, b, c);
                textBoxResult1.Text = "Результат: " + Math.Round(calc.Calculate(), 4);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCalc2_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(textBoxA2.Text.Trim(), out int a) || !int.TryParse(textBoxB2.Text.Trim(), out int b))
            {
                MessageBox.Show("Введіть коректні цілі значення a та b");
                return;
            }

            try
            {
                var calc = new Calculation_ab(a, b);
                textBoxResult2.Text = "Кількість чисел на проміжку [" + a + "; " + b + "]: " + calc.Count();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool TryReadSector(out CircleSector? sector)
        {
            sector = null;
            if (!TryRead(textBoxRadius.Text, out double radius) || !TryRead(textBoxAlpha1.Text, out double alpha1)
                || !TryRead(textBoxAlpha2.Text, out double alpha2))
            {
                MessageBox.Show("Введіть коректні числові значення радіуса та кутів");
                return false;
            }

            try
            {
                sector = new CircleSector(radius, alpha1, alpha2);
                return true;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void buttonCalc3_Click(object? sender, EventArgs e)
        {
            if (!TryReadSector(out CircleSector? sector) || sector == null)
                return;

            textBoxResult3.Text =
                "Δα = " + Math.Round(sector.DeltaAngle, 4) + "°" + Environment.NewLine +
                "Площа сектора S = " + Math.Round(sector.CalculateArea(), 4) + Environment.NewLine +
                "Довжина дуги L = " + Math.Round(sector.CalculateLength(), 4);
        }

        private void buttonContains_Click(object? sender, EventArgs e)
        {
            if (!TryReadSector(out CircleSector? sector) || sector == null)
                return;

            if (!TryRead(textBoxAngle.Text, out double angle))
            {
                MessageBox.Show("Введіть коректне числове значення кута");
                return;
            }

            bool inside = sector.ContainsAngle(angle);
            textBoxResult3.Text = "Промінь " + angle + "° " + (inside ? "потрапляє" : "не потрапляє")
                + " у сектор [" + sector.Alpha1 + "°; " + sector.Alpha2 + "°]";
        }

        private void buttonClose_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
