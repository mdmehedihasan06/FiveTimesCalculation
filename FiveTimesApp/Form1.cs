using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveTimesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showFiveTimesButton_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(aNumberTextBox.Text);
            double result = GetDouble(number);
            fiveTimesResultTextBox.Text = result.ToString();
        }
        private double GetDouble (double value)
        {
            return value*5;
        }
    }
}
