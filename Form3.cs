using System.Numerics;

namespace Lab1_.Net
{
    public partial class Form3 : Form
    {
        private TwoDimArray array = new TwoDimArray(4, 5, -10, 10);

        public Form3()
        {
            InitializeComponent();
            ShowArray();
        }

        private void ShowArray()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            for (int j = 0; j < array.Cols; j++)
                dataGridView1.Columns.Add("c" + j, j.ToString());
            for (int i = 0; i < array.Rows; i++)
            {
                int r = dataGridView1.Rows.Add();
                dataGridView1.Rows[r].HeaderCell.Value = i.ToString();
                for (int j = 0; j < array.Cols; j++)
                    dataGridView1[j, r].Value = array[i, j];
            }
            labelRow.Text = "Рядок (0–" + (array.Rows - 1) + ")";
            labelCol.Text = "Стовпець (0–" + (array.Cols - 1) + ")";
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
            if (!int.TryParse(textBoxRow.Text, out int i) || !int.TryParse(textBoxCol.Text, out int j))
            {
                MessageBox.Show("Введіть коректні індекси");
                return;
            }

            try
            {
                textBoxResult.Text = array.ElementToString(i, j);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSet_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(textBoxRow.Text, out int i) || !int.TryParse(textBoxCol.Text, out int j)
                || !int.TryParse(textBoxValue.Text, out int value))
            {
                MessageBox.Show("Введіть коректні індекси та значення");
                return;
            }

            try
            {
                array[i, j] = value;
                ShowArray();
                textBoxResult.Text = array.ElementToString(i, j);
            }
            catch (Exception ex) when (ex is IndexOutOfRangeException || ex is ArgumentException)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCalc_Click(object? sender, EventArgs e)
        {
            string result = "Сума від'ємних елементів: " + array.SumNegative() + Environment.NewLine;

            if (array.TryProductPositive(out BigInteger product))
                result += "Добуток додатних елементів: " + product + Environment.NewLine;
            else
                result += "Добуток додатних елементів: додатних елементів немає" + Environment.NewLine;

            double[] averages = array.ColumnAverages();
            for (int j = 0; j < averages.Length; j++)
                result += "Середнє арифметичне стовпця " + j + ": " + averages[j].ToString("F2") + Environment.NewLine;

            textBoxResult.Text = result;
        }

        private void buttonClose_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
