using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvenOddApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            int parameter = int.Parse(UserInputTB.Text);
            ResultLabel.Text = CheckEvenNumber(parameter);
        }

        public string CheckEvenNumber(int number)
        {
            string result = "Odd";
            if (number % 2 == 0) result = "Even";
            return result;
        }
    }
}
