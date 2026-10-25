namespace Lab1_.Net
{
    public partial class Form2 : Form
    {
        private OneDimArray array = new OneDimArray(20, 200, 300);

        public Form2()
        {
            InitializeComponent();
            ShowArray();
        }

        private void ShowArray()
        {
            textBoxArray.Text = array.ToString();
            labelIndex.Text = "Індекс (0–" + (array.Length - 1) + ")";
            labelValue.Text = "Значення [" + array.MinValue + "; " + array.MaxValue + "]";
        }

        private void buttonGenerate_Click(object? sender, EventArgs e)
        {
            array.Randomize();
            ShowArray();
            textBoxResult.Clear();
        }

        private void buttonGet_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(textBoxIndex.Text, out int index))
            {
                MessageBox.Show("Введіть коректний індекс");
                return;
            }

            try
            {
                textBoxResult.Text = array.ElementToString(index);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSet_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(textBoxIndex.Text, out int index) || !int.TryParse(textBoxValue.Text, out int value))
            {
                MessageBox.Show("Введіть коректні індекс та значення");
                return;
            }

            try
            {
                array[index] = value;
                ShowArray();
                textBoxResult.Text = array.ElementToString(index);
            }
            catch (Exception ex) when (ex is IndexOutOfRangeException || ex is ArgumentException)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCalc_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(textBoxDivisor.Text, out int divisor) || !int.TryParse(textBoxRemainder.Text, out int remainder))
            {
                MessageBox.Show("Введіть коректні цілі значення дільника та остачі");
                return;
            }

            try
            {
                textBoxResult.Text =
                    "Сума від'ємних елементів: " + array.SumNegative() + Environment.NewLine +
                    "Сума додатних елементів: " + array.SumPositive() + Environment.NewLine +
                    "Сума всіх елементів: " + array.SumAll() + Environment.NewLine +
                    "Сума елементів, у яких остача від ділення на " + divisor + " дорівнює " + remainder + ": " + array.SumByRemainder(divisor, remainder);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClose_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
