// Grading ID: A1749
// CIS 199-01
// Program 1
// Due: 9/25/2018

// This program will calculate the minimum and actual gallons to buy when painting walls depending on given measurements

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog1
{
    public partial class Program1 : Form
    {
        public Program1()
        {
            InitializeComponent();
        }
        // Calculate and display measurements
        private void CalcBtn_Click(object sender, EventArgs e)
        {
            const double PaintCoverageG = 385; // How much Square feet a gallon covers
            const double PerDoor = 20; // Square feet per door
            const double PerWindow = 15; // Square feet per window
            double length; // This is claiming the length
            double height; // This is claiming the height
            uint doors; // recognizing the number of doors as a unsigned integer
            uint windows; // recognizing the number of windows as a unsigned integer
            uint coats; // recognizing the number of coats as a unsigned integer
            double outputG; // This is minimum gallons
            int gallonsToBuy; // This is the actual number of gallons to buy 

            
            // Converts input into a numnber
            length = double.Parse(LengthTxt.Text); 
            height = double.Parse(HeightTxt.Text);
            doors = uint.Parse(DoorsTxt.Text);
            windows = uint.Parse(WindowsTxt.Text);
            coats = uint.Parse(CoatsTxt.Text);

            //Calculation for how many gallons
            outputG = (length * height - doors * PerDoor - windows * PerWindow) * coats / PaintCoverageG;

            gallonsToBuy = (int)Math.Ceiling(outputG); 

            outputGlbl.Text = $"{outputG:F1}"; // displays the output in decimal form, ones places 
            outputG2lbl.Text = Convert.ToString(gallonsToBuy); // displays the output in a whole number that is rounded












        }
    }
}
