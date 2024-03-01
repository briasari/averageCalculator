using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace averageCalculator
{
    public partial class Form1 : Form
    {

        double average;
        double num;
        double sum;
        int count;

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            num = Convert.ToInt32(numInput.Text);
            {
                if (num != 0)
                {
                    count++;
                    sum += num;
                    outputLabel.Text = $"{num} was added to the sum";
                }
                else
                {
                    average = (sum / count);
                    outputLabel.Text = $"{average} is your average";
                }

            }
        }

            private void resetButton_Click(object sender, EventArgs e)
            {
                average = 0;
                num = 0;
                sum = 0;
                count = 0;

                outputLabel.Text = "";
            }
        }
    }
