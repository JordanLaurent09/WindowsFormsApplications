using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextInputPartitionApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            ListBoxOperator(StringToArray(UserInputTB.Text));
        }

        private void ListBoxOperator(string[] arrayOfString)
        {
            for(int i = 0; i < arrayOfString.Length; i++)
            {
                listBox1.Items.Add(arrayOfString[i]);
            }
        }

        private string[] StringToArray(string sourceString)
        {
            return sourceString.Split(' ');
        }
    }
}
