using System;
using System.Windows.Forms;
using CalculatorApp.BLL;

namespace CalculatorApp
{
    public partial class MainForm : Form
    {
        private Calculator _calculator;

        public MainForm()
        {
            InitializeComponent();
            _calculator = new Calculator();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtNumber1.Text);
            double b = Convert.ToDouble(txtNumber2.Text);
            double result = _calculator.Add(a, b);
            lblResult.Text = result.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtNumber1.Text);
            double b = Convert.ToDouble(txtNumber2.Text);
            double result = _calculator.Subtract(a, b);
            lblResult.Text = result.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtNumber1.Text);
            double b = Convert.ToDouble(txtNumber2.Text);
            double result = _calculator.Multiply(a, b);
            lblResult.Text = result.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtNumber1.Text);
                double b = Convert.ToDouble(txtNumber2.Text);
                double result = _calculator.Divide(a, b);
                lblResult.Text = result.ToString();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
