namespace Lab1_.Net
{
    partial class Form2
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
            labelArray = new Label();
            textBoxArray = new TextBox();
            labelIndex = new Label();
            textBoxIndex = new TextBox();
            labelValue = new Label();
            textBoxValue = new TextBox();
            buttonGet = new Button();
            buttonSet = new Button();
            labelDivisor = new Label();
            textBoxDivisor = new TextBox();
            labelRemainder = new Label();
            textBoxRemainder = new TextBox();
            buttonCalc = new Button();
            textBoxResult = new TextBox();
            buttonClose = new Button();
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
            // labelArray
            // 
            labelArray.AutoSize = true;
            labelArray.Location = new Point(20, 55);
            labelArray.Name = "labelArray";
            labelArray.Size = new Size(45, 15);
            labelArray.TabIndex = 1;
            labelArray.Text = "Масив:";
            // 
            // textBoxArray
            // 
            textBoxArray.Location = new Point(20, 75);
            textBoxArray.Multiline = true;
            textBoxArray.Name = "textBoxArray";
            textBoxArray.ReadOnly = true;
            textBoxArray.Size = new Size(600, 50);
            textBoxArray.TabIndex = 2;
            // 
            // labelIndex
            // 
            labelIndex.AutoSize = true;
            labelIndex.Location = new Point(20, 140);
            labelIndex.Name = "labelIndex";
            labelIndex.Size = new Size(45, 15);
            labelIndex.TabIndex = 3;
            labelIndex.Text = "Індекс";
            // 
            // textBoxIndex
            // 
            textBoxIndex.Location = new Point(20, 160);
            textBoxIndex.Name = "textBoxIndex";
            textBoxIndex.Size = new Size(100, 23);
            textBoxIndex.TabIndex = 4;
            textBoxIndex.Text = "0";
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Location = new Point(140, 140);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(55, 15);
            labelValue.TabIndex = 5;
            labelValue.Text = "Значення";
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(140, 160);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(100, 23);
            textBoxValue.TabIndex = 6;
            // 
            // buttonGet
            // 
            buttonGet.Location = new Point(260, 158);
            buttonGet.Name = "buttonGet";
            buttonGet.Size = new Size(150, 27);
            buttonGet.TabIndex = 7;
            buttonGet.Text = "Показати елемент";
            buttonGet.UseVisualStyleBackColor = true;
            buttonGet.Click += buttonGet_Click;
            // 
            // buttonSet
            // 
            buttonSet.Location = new Point(420, 158);
            buttonSet.Name = "buttonSet";
            buttonSet.Size = new Size(150, 27);
            buttonSet.TabIndex = 8;
            buttonSet.Text = "Записати елемент";
            buttonSet.UseVisualStyleBackColor = true;
            buttonSet.Click += buttonSet_Click;
            // 
            // labelDivisor
            // 
            labelDivisor.AutoSize = true;
            labelDivisor.Location = new Point(20, 205);
            labelDivisor.Name = "labelDivisor";
            labelDivisor.Size = new Size(61, 15);
            labelDivisor.TabIndex = 9;
            labelDivisor.Text = "Ділити на";
            // 
            // textBoxDivisor
            // 
            textBoxDivisor.Location = new Point(20, 225);
            textBoxDivisor.Name = "textBoxDivisor";
            textBoxDivisor.Size = new Size(100, 23);
            textBoxDivisor.TabIndex = 10;
            textBoxDivisor.Text = "2";
            // 
            // labelRemainder
            // 
            labelRemainder.AutoSize = true;
            labelRemainder.Location = new Point(140, 205);
            labelRemainder.Name = "labelRemainder";
            labelRemainder.Size = new Size(43, 15);
            labelRemainder.TabIndex = 11;
            labelRemainder.Text = "Остача";
            // 
            // textBoxRemainder
            // 
            textBoxRemainder.Location = new Point(140, 225);
            textBoxRemainder.Name = "textBoxRemainder";
            textBoxRemainder.Size = new Size(100, 23);
            textBoxRemainder.TabIndex = 12;
            textBoxRemainder.Text = "3";
            // 
            // buttonCalc
            // 
            buttonCalc.Location = new Point(260, 223);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(150, 27);
            buttonCalc.TabIndex = 13;
            buttonCalc.Text = "Обчислити";
            buttonCalc.UseVisualStyleBackColor = true;
            buttonCalc.Click += buttonCalc_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(20, 265);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(600, 100);
            textBoxResult.TabIndex = 14;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(520, 380);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(100, 28);
            buttonClose.TabIndex = 15;
            buttonClose.Text = "Закрити";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 425);
            Controls.Add(buttonClose);
            Controls.Add(textBoxResult);
            Controls.Add(buttonCalc);
            Controls.Add(textBoxRemainder);
            Controls.Add(labelRemainder);
            Controls.Add(textBoxDivisor);
            Controls.Add(labelDivisor);
            Controls.Add(buttonSet);
            Controls.Add(buttonGet);
            Controls.Add(textBoxValue);
            Controls.Add(labelValue);
            Controls.Add(textBoxIndex);
            Controls.Add(labelIndex);
            Controls.Add(textBoxArray);
            Controls.Add(labelArray);
            Controls.Add(buttonGenerate);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Одномірні масиви";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGenerate;
        private Label labelArray;
        private TextBox textBoxArray;
        private Label labelIndex;
        private TextBox textBoxIndex;
        private Label labelValue;
        private TextBox textBoxValue;
        private Button buttonGet;
        private Button buttonSet;
        private Label labelDivisor;
        private TextBox textBoxDivisor;
        private Label labelRemainder;
        private TextBox textBoxRemainder;
        private Button buttonCalc;
        private TextBox textBoxResult;
        private Button buttonClose;
    }
}
