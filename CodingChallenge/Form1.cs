using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingChallenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            //placeholder for the outputs
            string output = "";
            //for loop to print out each number or word
            for(int i = 1; i <= 100; i++)
            {
                //if statements to check if the number is divisible by 3, 5, both, or neither. 
                if(i % 15 == 0)
                {
                    output += "MSUBears\r\n";
                }
                else if(i % 5 == 0)
                {
                    output += "Bears\r\n";
                }
                else if(i % 3 == 0)
                {
                    output += "MSU ";
                }
                else
                {
                    output += i + " ";
                }
            }
            //output to the text box
            outputTextBox.Text = output;
        }
    }
}
