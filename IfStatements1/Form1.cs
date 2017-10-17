using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfStatements1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt16(intInput.Text);
            if (num >= 0)
            {
                polarityLabel.Text = num + " is a positive number.";
            }
            else
            {
                polarityLabel.Text = num + " is a negative number.";
            }

            if (num % 7 == 0)
            {
                remainderLabel.Text = num + " is divisible by 7.";
            }
            else
            {
                remainderLabel.Text = num + " is not divisible by 7.";
            }

        }
    }
}
