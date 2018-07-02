using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialCalc
{
    public partial class Form1 : Form
    {
        /*****************************************
         * This program is a factorial calculator
         * it will ask the user to enter a number
         * betwee 1 and 20.
         *****************************************/
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /***************************************
             * define variables for program, one
             * to get number from user and anoher
             * to calculate factor for the entered
             * number the user enters
             ***************************************/

            //number has a datatype of int,
            //will allow for user to enter a number
            int number = 1;

            //factror has a datatype of long,
            //will be the number to calculate
            //against number
            long factor = 1;

            //asks for the user to enter
            //a number
            number = int.Parse(txtNumber.Text);

            //Validate for the vaiable number
            if (number < 0)     
            {              //validates for the condition of 
                           //any negatives have been entered
                MessageBox.Show("Please enter a positive number!");
            }
            else if (number == 0)       
            {                      //validates for the condition if
                                   //the user enters a zero
                MessageBox.Show("Please enter a number between 1 and 20!");

            }
            else if (number > 20)
            {                     //validates for the condition if
                                  //the user enters a number
                                  //greater than 20
                MessageBox.Show("Please enter a number 20 or less!");
            }
            else
            {
                //for loop to calculate the factor
                //the user enters a number
                for (int i = number; i >= 1; i--)
                {
                    factor = factor * i;
                }

                //displays the factor in txtFactor
                txtFactor.Text = factor.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            /******************************************
             * This method is wired to the Exit button
             * to close the program
             ******************************************/

            //this keyword will invoke the close method
            //to close the program
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /******************************************
             * This method is wired to the form itself
             ******************************************/

            //on the txtFactor will invoke the ReadOnly
            //and is set to true, the user will not be
            //able to enter a number
            txtFactor.ReadOnly = true;
        }
    }
}
