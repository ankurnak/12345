using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputString = textBox1.Text;
            try
            {
                bool isPalindrome = CheckPalindrome(inputString);
                if (isPalindrome)
                {
                    MessageBox.Show("The input string is a palindrome.");
                }
                else
                {
                    MessageBox.Show("The input string is not a palindrome.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while checking for palindrome: " + ex.Message);
            }
        }

        private bool CheckPalindrome(string inputString)
        {
            if (inputString.Length == 0)
            {
                throw new ArgumentException("Input string cannot be empty.");
            }

            int i = 0;
            int j = inputString.Length - 1;

            while (i < j)
            {
                if (inputString[i] != inputString[j])
                {
                    return false;
                }

                i++;
                j--;
            }

            return true;
        }
    }
}
