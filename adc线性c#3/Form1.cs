using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using NumericsVector = MathNet.Numerics.LinearAlgebra.Vector<double>;

namespace PolynomialRegressionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                var adcValues = GetValuesFromGrid(adcValuesInput);
                var realValues = GetValuesFromGrid(realValuesInput);
                int degree = int.Parse(degreeInput.Text);

                if (adcValues.Count != realValues.Count || adcValues.Count == 0)
                {
                    MessageBox.Show("错误：ADC值和真实值数量不匹配或没有输入数据。");
                    return;
                }

                var coefficients = PolynomialRegression(adcValues, realValues, degree);
                resultTextBox.Text = "多项式回归公式: y = " + string.Join(" + ", coefficients.Select((c, i) => i == 0 ? $"{c}" : $"{c} * x^{i}").Where((_, i) => i > 0 || coefficients[i] != 0).Reverse());
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误：" + ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            adcValuesInput.Rows.Clear();
            realValuesInput.Rows.Clear();
            degreeInput.Clear();
            resultTextBox.Text = string.Empty;
        }

        private NumericsVector PolynomialRegression(List<double> x, List<double> y, int degree)
        {
            int n = x.Count;
            var X = Matrix<double>.Build.Dense(n, degree + 1, (i, j) => Math.Pow(x[i], j));
            var Y = NumericsVector.Build.Dense(y.ToArray());

            return X.Svd(true).Solve(Y);
        }

        private List<double> GetValuesFromGrid(DataGridView grid)
        {
            List<double> values = new List<double>();
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if (double.TryParse(row.Cells[0].Value.ToString(), out double value))
                    {
                        values.Add(value);
                    }
                }
            }
            return values;
        }

        private void adcValuesInput_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (var b = new SolidBrush(adcValuesInput.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), adcValuesInput.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void realValuesInput_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (var b = new SolidBrush(realValuesInput.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), realValuesInput.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
