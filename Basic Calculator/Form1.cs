using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator
{
    public partial class calculatorForm : Form
    {
        private double firstNumber, secondNumber;

        public calculatorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This shows a quit screen after the 
        /// button has been clicked, and then 
        /// closes the program once the quit screen 
        /// has been clicked
        /// </summary>
        private void closeApplication(object sender, EventArgs e)
        {
            quitScreen QScreen = new quitScreen();
            QScreen.ShowDialog();
        }

        private void subtractNumbers(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            outcomeLabel.Text = Convert.ToString(firstNumber - secondNumber);
        }

        private void multiplyNumbers(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            outcomeLabel.Text = Convert.ToString(firstNumber * secondNumber);
        }

        private void divideNumbers(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            if(secondNumber == 0)
            {
                MessageBox.Show("You should NOT divide by ZERO!");
            }
            else
            {
                outcomeLabel.Text = Convert.ToString(firstNumber / secondNumber);
            }
        }

        /// <summary>
        /// This shows a start up screen before the 
        /// main program and once clicked shows the
        /// main program after a 2 second wait time.
        /// </summary>
        private void startUpScreen(object sender, EventArgs e)
        {
            splashScreenForm SScreen = new splashScreenForm();
            SScreen.ShowDialog();
            System.Threading.Thread.Sleep(2000);
            SScreen.Close();
        }

        private void clearTextBoxes(object sender, EventArgs e)
        {
            firstNumberTextBox.Text = "";
            secondNumberTextBox.Text = "";
        }

        private void powerNumbers(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            outcomeLabel.Text = Convert.ToString(Math.Pow(firstNumber, secondNumber));
        }

        private void averageNumbers(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            outcomeLabel.Text = Convert.ToString((firstNumber + secondNumber) / 2);
        }

        private void addNumbers(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            outcomeLabel.Text = Convert.ToString(firstNumber + secondNumber);
        }
    }
}
