namespace Lab1_.Net
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dataGridView1 = new DataGridView();
            x = new DataGridViewTextBoxColumn();
            y = new DataGridViewTextBoxColumn();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            menuStrip1 = new MenuStrip();
            menuArrays = new ToolStripMenuItem();
            menuOneDim = new ToolStripMenuItem();
            menuTwoDim = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 40);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "Xn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 40);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 1;
            label2.Text = "Xk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 40);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 2;
            label3.Text = "h";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(260, 40);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 3;
            label4.Text = "a";
            // 
            // label5
            // 
            label5.Location = new Point(440, 32);
            label5.Name = "label5";
            label5.Size = new Size(340, 80);
            label5.TabIndex = 11;
            label5.Text = "y = f(x) =\r\n      x·sin(x + 4),   якщо x ≤ 0\r\n      ln(4x² + 1),   якщо 0 < x ≤ a\r\n      ln ⁵√(5 + x²),   якщо x > a";
            // 
            // button1
            // 
            button1.Location = new Point(340, 70);
            button1.Name = "button1";
            button1.Size = new Size(80, 23);
            button1.TabIndex = 4;
            button1.Text = "Обрахувати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(60, 23);
            textBox1.TabIndex = 5;
            textBox1.Text = "-1,9";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(60, 23);
            textBox2.TabIndex = 6;
            textBox2.Text = "15,4";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(180, 70);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(60, 23);
            textBox3.TabIndex = 7;
            textBox3.Text = "0,45";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(260, 70);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(60, 23);
            textBox4.TabIndex = 8;
            textBox4.Text = "4";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { x, y });
            dataGridView1.Location = new Point(20, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(250, 330);
            dataGridView1.TabIndex = 9;
            // 
            // x
            // 
            x.HeaderText = "x";
            x.Name = "x";
            x.ReadOnly = true;
            // 
            // y
            // 
            y.HeaderText = "y";
            y.Name = "y";
            y.ReadOnly = true;
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.AxisX.LabelStyle.Format = "0.##";
            chartArea1.AxisX.Title = "x";
            chartArea1.AxisY.Title = "y";
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Location = new Point(290, 120);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(490, 330);
            chart1.TabIndex = 10;
            chart1.Text = "chart1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuArrays });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuArrays
            // 
            menuArrays.DropDownItems.AddRange(new ToolStripItem[] { menuOneDim, menuTwoDim });
            menuArrays.Name = "menuArrays";
            menuArrays.Size = new Size(60, 20);
            menuArrays.Text = "Масиви";
            // 
            // menuOneDim
            // 
            menuOneDim.Name = "menuOneDim";
            menuOneDim.Size = new Size(180, 22);
            menuOneDim.Text = "Одномірні масиви";
            menuOneDim.Click += menuOneDim_Click;
            // 
            // menuTwoDim
            // 
            menuTwoDim.Name = "menuTwoDim";
            menuTwoDim.Size = new Size(180, 22);
            menuTwoDim.Text = "Двовимірні масиви";
            menuTwoDim.Click += menuTwoDim_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 470);
            Controls.Add(menuStrip1);
            Controls.Add(label5);
            Controls.Add(chart1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Лабораторна робота № 1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn x;
        private DataGridViewTextBoxColumn y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuArrays;
        private ToolStripMenuItem menuOneDim;
        private ToolStripMenuItem menuTwoDim;
    }
}
