// Using LINQ
// Samuel Tollefson
// POS/409
// April 28, 2015
// Jon Jensen

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Simulation
{
    public partial class MainForm : Form
    {
        // Initiate ArrayLists.
        ArrayList roll1 = new ArrayList();
        ArrayList roll2 = new ArrayList();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnRoll1_Click(object sender, EventArgs e)
        {
            // Clear the ArrayList.
            roll1.Clear();

            // Set ArrayList.
            roll1 = rollDice();
        }

        private void btnRoll2_Click(object sender, EventArgs e)
        {
            // Clear the ArrayList.
            roll2.Clear();

            // Set ArrayList.
            roll2 = rollDice();          
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear(); // Clear the list
            string output = ""; // Output variable to concat.

            lstResults.Items.Add("Roll 1 doubles:");

            // Get first sequence of doubles rolled for user to view.
            var query1 = from int num in roll1
                         orderby num ascending
                         select num;
            foreach (int num in query1)
            {
                output += num + ", "; // Concat output variable.
            }

            lstResults.Items.Add(output);
            lstResults.Items.Add("");
            output = ""; // Reset output variable.

            lstResults.Items.Add("Roll 2 doubles:");

            // Get second sequence of doubles rolled for user to view.
            var query2 = from int num in roll2
                         where num > 0
                         orderby num ascending
                         select num;
            foreach (int num in query2)
            {
                output += num + ", "; // Concat output variable.
            }

            lstResults.Items.Add(output);
            lstResults.Items.Add("");

            // Convert ArrayLists to Arrays for .Except.
            int[] numbers1 = (int[])roll1.ToArray(typeof(int));
            int[] numbers2 = (int[])roll2.ToArray(typeof(int));

            // Look for missing numbers.
            IEnumerable<int> onlyInFirstSet = numbers1.Except(numbers2);
            IEnumerable<int> onlyInSecondSet = numbers2.Except(numbers1);

            Boolean hasAll = true; // Variable to test for missing values.

            // Display numbers only available in first sequence.
            foreach (int number in onlyInFirstSet)
            {
                if (roll1.Contains(number))
                    lstResults.Items.Add("Roll one is the only sequence that containes a " + number);
                hasAll = false; // Has missing values.
            }

            // Display numbers only available in second sequence.
            foreach (int number in onlyInSecondSet)
            {
                if (roll2.Contains(number))
                    lstResults.Items.Add("Roll two is the only sequence that containes a " + number);
                hasAll = false; // Has missing values.
            }
            if (hasAll == true)
                lstResults.Items.Add("Both sequences contain all six sides of a dice.");
        }

        // Didn't want to do this wtice.
        public ArrayList rollDice()
        {
            lstResults.Items.Clear(); // Clear the list

            ArrayList temp = new ArrayList();

            Dice dice1 = new Dice(); // Variable to hold the value of the first dice.
            Dice dice2 = new Dice(); // Variable to hold the value of the first dice.

            int inaRow = 0; // Variable to hold the number of sequential double rolls.

            lstResults.Items.Clear(); // Clear the list

            // Count up to 100 in increments of 1.
            for (int sequence = 1; sequence <= 100; sequence++)
            {
                // Roll the Dice.
                dice1.Roll();
                dice2.Roll();

                if (dice1.currnetValue == dice2.currnetValue) // Compare the numbers.
                {
                    inaRow = inaRow + 1; // Increment sequential double rolls.

                    // Display the rolls that produced doubles.
                    lstResults.Items.Add("Roll " + sequence + " produced a pair of " + dice1.currnetValue + "s");

                    temp.Add(dice1.currnetValue);

                    // This if statement was added because the following else statement displays the sequential doubles 
                    // only after the sequential doubles are finished. If the doubles end on the final roll,
                    // there is no other roll to display the number of doubles rolled.
                    if (inaRow > 1 & sequence == 100)
                    {
                        // Display the number of sequential double rolls.
                        lstResults.Items.Add("Nice, " + inaRow + " in a row");
                    }
                }
                else
                {
                    // Check to see if doubles have been rolled at least twice in a row.
                    if (inaRow > 1)
                    {
                        // Display the number of sequential double rolls.
                        lstResults.Items.Add("Nice, " + inaRow + " in a row");
                    }
                    inaRow = 0; // If doubles are not rolled, reset the variable.
                }
            }
            return temp; // Return temporary ArrayList.
        }
    }
}

