namespace PolynomialRegressionApp
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

        private void InitializeComponent()
        {
            adcValuesInput = new DataGridView();
            adcColumn = new DataGridViewTextBoxColumn();
            realValuesInput = new DataGridView();
            realColumn = new DataGridViewTextBoxColumn();
            degreeInput = new TextBox();
            submitButton = new Button();
            clearButton = new Button();
            resultTextBox = new TextBox();
            degreeLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)adcValuesInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)realValuesInput).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // adcValuesInput
            // 
            adcValuesInput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adcValuesInput.Columns.AddRange(new DataGridViewColumn[] { adcColumn });
            tableLayoutPanel1.SetColumnSpan(adcValuesInput, 2);
            adcValuesInput.Dock = DockStyle.Fill;
            adcValuesInput.Location = new Point(3, 3);
            adcValuesInput.Name = "adcValuesInput";
            adcValuesInput.Size = new Size(344, 138);
            adcValuesInput.TabIndex = 0;
            adcValuesInput.RowPostPaint += adcValuesInput_RowPostPaint;
            // 
            // adcColumn
            // 
            adcColumn.HeaderText = "ADC值";
            adcColumn.Name = "adcColumn";
            adcColumn.Width = 300;
            // 
            // realValuesInput
            // 
            realValuesInput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            realValuesInput.Columns.AddRange(new DataGridViewColumn[] { realColumn });
            tableLayoutPanel1.SetColumnSpan(realValuesInput, 2);
            realValuesInput.Dock = DockStyle.Fill;
            realValuesInput.Location = new Point(3, 147);
            realValuesInput.Name = "realValuesInput";
            realValuesInput.Size = new Size(344, 138);
            realValuesInput.TabIndex = 1;
            realValuesInput.RowPostPaint += realValuesInput_RowPostPaint;
            // 
            // realColumn
            // 
            realColumn.HeaderText = "真实值";
            realColumn.Name = "realColumn";
            realColumn.Width = 300;
            // 
            // degreeInput
            // 
            tableLayoutPanel1.SetColumnSpan(degreeInput, 2);
            degreeInput.Dock = DockStyle.Fill;
            degreeInput.Location = new Point(3, 321);
            degreeInput.Name = "degreeInput";
            degreeInput.Size = new Size(344, 23);
            degreeInput.TabIndex = 2;
            // 
            // submitButton
            // 
            submitButton.Anchor = AnchorStyles.None;
            submitButton.Location = new Point(50, 351);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 3;
            submitButton.Text = "提交";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.None;
            clearButton.Location = new Point(225, 351);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 4;
            clearButton.Text = "清空";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // resultTextBox
            // 
            tableLayoutPanel1.SetColumnSpan(resultTextBox, 2);
            resultTextBox.Dock = DockStyle.Fill;
            resultTextBox.Location = new Point(3, 381);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.Size = new Size(344, 66);
            resultTextBox.TabIndex = 5;
            // 
            // degreeLabel
            // 
            degreeLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(degreeLabel, 2);
            degreeLabel.Dock = DockStyle.Fill;
            degreeLabel.Location = new Point(3, 288);
            degreeLabel.Name = "degreeLabel";
            degreeLabel.Size = new Size(344, 30);
            degreeLabel.TabIndex = 6;
            degreeLabel.Text = "多项式度数：";
            degreeLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(submitButton, 0, 4);
            tableLayoutPanel1.Controls.Add(clearButton, 1, 4);
            tableLayoutPanel1.Controls.Add(adcValuesInput, 0, 0);
            tableLayoutPanel1.Controls.Add(realValuesInput, 0, 1);
            tableLayoutPanel1.Controls.Add(degreeLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(degreeInput, 0, 3);
            tableLayoutPanel1.Controls.Add(resultTextBox, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(350, 450);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // Form1
            // 
            ClientSize = new Size(350, 450);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(350, 450);
            Name = "Form1";
            Text = "多项式回归";
            ((System.ComponentModel.ISupportInitialize)adcValuesInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)realValuesInput).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView adcValuesInput;
        private System.Windows.Forms.DataGridView realValuesInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn adcColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realColumn;
        private System.Windows.Forms.TextBox degreeInput;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label degreeLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
