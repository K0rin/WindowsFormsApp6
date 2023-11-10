using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {

        private static int generateRandInt(int minValue, int maxValue) 
        {
            Random rand = new Random();
            int newNumber = rand.Next(0, 100);
            return newNumber;

        }

        public Form1()
        {
            InitializeComponent();
        }

        int number = generateRandInt(0, 100);

        int count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("")) {
                MessageBox.Show("You have not entered a number");
            }

            int guessNumber = 0;

            try 
            {
                guessNumber = Int32.Parse(textBox1.Text);
            } 
            catch 
            {
                MessageBox.Show("not a number");
                return;
            }

            if (guessNumber < 0)
            {
                MessageBox.Show("You have entered a negative value!");
                return;
            }
            else 
            {
                if (guessNumber != number)
                {
                    MessageBox.Show("It is a wrong number!");
                    count = count + 1;
                    //label2.Text = number.ToString();
                    return;
                }
                else 
                {
                    MessageBox.Show("You won a game! \n The number of tries is " + count.ToString());
                    number = generateRandInt(0, 100);
                    count = 0;
                    label2.Text = "A new number was generated. Can you guess it?";
                }
            }
        }
    }
}
