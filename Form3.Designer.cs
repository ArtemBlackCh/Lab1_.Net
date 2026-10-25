namespace Lab1_.Net
{
    partial class Form3
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
            buttonGenerate = new Button();
            dataGridView1 = new DataGridView();
            labelRow = new Label();
            textBoxRow = new TextBox();
            labelCol = new Label();
            textBoxCol = new TextBox();
            labelValue = new Label();
            textBoxValue = new TextBox();
            buttonGet = new Button();
            buttonSet = new Button();
            buttonCalc = new Button();
            textBoxResult = new TextBox();
            buttonClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(20, 15);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(160, 28);
            buttonGenerate.TabIndex = 0;
            buttonGenerate.Text = "Згенерувати масив";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 60;
            dataGridView1.Size = new Size(600, 150);
            dataGridView1.TabIndex = 1;
            // 
            // labelRow
            // 
            labelRow.AutoSize = true;
            labelRow.Location = new Point(20, 225);
            labelRow.Name = "labelRow";
            labelRow.Size = new Size(40, 15);
            labelRow.TabIndex = 2;
            labelRow.Text = "Рядок";
            // 
            // textBoxRow
            // 
            textBoxRow.Location = new Point(20, 245);
            textBoxRow.Name = "textBoxRow";
            textBoxRow.Size = new Size(100, 23);
            textBoxRow.TabIndex = 3;
            textBoxRow.Text = "0";
            // 
            // labelCol
            // 
            labelCol.AutoSize = true;
            labelCol.Location = new Point(140, 225);
            labelCol.Name = "labelCol";
            labelCol.Size = new Size(55, 15);
            labelCol.TabIndex = 4;
            labelCol.Text = "Стовпець";
            // 
            // textBoxCol
            // 
            textBoxCol.Location = new Point(140, 245);
            textBoxCol.Name = "textBoxCol";
            textBoxCol.Size = new Size(100, 23);
            textBoxCol.TabIndex = 5;
            textBoxCol.Text = "0";
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Location = new Point(260, 225);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(55, 15);
            labelValue.TabIndex = 6;
            labelValue.Text = "Значення";
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(260, 245);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(100, 23);
            textBoxValue.TabIndex = 7;
            // 
            // buttonGet
            // 
            buttonGet.Location = new Point(380, 243);
            buttonGet.Name = "buttonGet";
            buttonGet.Size = new Size(110, 27);
            buttonGet.TabIndex = 8;
            buttonGet.Text = "Показати";
            buttonGet.UseVisualStyleBackColor = true;
            buttonGet.Click += buttonGet_Click;
            // 
            // buttonSet
            // 
            buttonSet.Location = new Point(500, 243);
            buttonSet.Name = "buttonSet";
            buttonSet.Size = new Size(110, 27);
            buttonSet.TabIndex = 9;
            buttonSet.Text = "Записати";
            buttonSet.UseVisualStyleBackColor = true;
            buttonSet.Click += buttonSet_Click;
            // 
            // buttonCalc
            // 
            buttonCalc.Location = new Point(20, 285);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(160, 28);
            buttonCalc.TabIndex = 10;
            buttonCalc.Text = "Обчислити";
            buttonCalc.UseVisualStyleBackColor = true;
            buttonCalc.Click += buttonCalc_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(20, 325);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(600, 140);
            textBoxResult.TabIndex = 11;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(520, 480);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(100, 28);
            buttonClose.TabIndex = 12;
            buttonClose.Text = "Закрити";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 520);
            Controls.Add(buttonClose);
            Controls.Add(textBoxResult);
            Controls.Add(buttonCalc);
            Controls.Add(buttonSet);
            Controls.Add(buttonGet);
            Controls.Add(textBoxValue);
            Controls.Add(labelValue);
            Controls.Add(textBoxCol);
            Controls.Add(labelCol);
            Controls.Add(textBoxRow);
            Controls.Add(labelRow);
            Controls.Add(dataGridView1);
            Controls.Add(buttonGenerate);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Двовимірні масиви";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGenerate;
        private DataGridView dataGridView1;
        private Label labelRow;
        private TextBox textBoxRow;
        private Label labelCol;
        private TextBox textBoxCol;
        private Label labelValue;
        private TextBox textBoxValue;
        private Button buttonGet;
        private Button buttonSet;
        private Button buttonCalc;
        private TextBox textBoxResult;
        private Button buttonClose;
    }
}
