using System.Globalization;

namespace Lab1_.Net
{
    public partial class Form1 : Form
    {
        private Tabulator tabulator = new Tabulator();

        public Form1()
        {
            InitializeComponent();
        }

        private static bool TryRead(string text, out double value)
        {
            string normalized = text.Trim().Replace(',', '.');
            return double.TryParse(normalized, NumberStyles.Float, CultureInfo.InvariantCulture, out value)
                && double.IsFinite(value);
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            if (!TryRead(textBox1.Text, out double xn) || !TryRead(textBox2.Text, out double xk)
                || !TryRead(textBox3.Text, out double h) || !TryRead(textBox4.Text, out double a))
            {
                MessageBox.Show("Введіть коректні числові значення Xn, Xk, h та a");
                return;
            }

            try
            {
                tabulator.Tab(xn, xk, h, a);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            dataGridView1.Rows.Clear();
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < tabulator.Count; i++)
            {
                double x = tabulator[i, 0];
                double y = tabulator[i, 1];
                dataGridView1.Rows.Add(Math.Round(x, 4), Math.Round(y, 4));
                chart1.Series[0].Points.AddXY(x, y);
            }
        }

        private void menuOneDim_Click(object? sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void menuTwoDim_Click(object? sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }
    }
}
