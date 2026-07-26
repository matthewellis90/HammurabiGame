//Hamurabi Rules:

// The game will last for 10 years with one year consisting of one turn.
// Each year, you will need to enter how many bushels of grain to allocate to buying or selling acres of land, also for feeding the population and planting crops for the next year.
// Each person will need 20 bushels of grain each year to live and can have a maximum of 10 acres of land.
// Each acre of land will need 1 bushel of grain to plant seeds.
// The price of each acre of land will fluctuate from 17 bushels to 26 bushels per acre.
// If living conditions become bad enough, you will be overthrown by the people and you will not be able to finish your 10 year term.
// Should you make it to the 11th year in power, your time in charge shall be evaluated and you will be ranked against some of the great rulers in history.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hammurabi
{
    public partial class Hammurabi : Form
    {
        int noBushels = 2800;
        int noAcres = 1000;
        int noPeople = 100;
        int noYears = 10;
        int YieldperAcre;
        int peopleFed;
        int bushelsForFeeding;
        int acresBought;
        int acresPlanted;
        int bushelsForPlanting;
        int acreCost;
        int yearCount = 0;
        int finalScore;

        Random rnd = new Random();  // A random number generator for bushel yield


        public Hammurabi()
        {
            InitializeComponent();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   if (yearCount > 9) // A check to make sure we do not go beyond 10 years
            {

                button1.Enabled = false; // if we go above 10 years the button will disable

            }
            else
            {


                bushelsForFeeding = Convert.ToInt16(numericUpDown2.Value);
                acresBought = Convert.ToInt16(numericUpDown1.Value);
                bushelsForPlanting = Convert.ToInt16(numericUpDown3.Value);

                if (bushelsForFeeding + bushelsForPlanting + acresBought * acreCost > noBushels)
                {

                    MessageBox.Show("You have exceeded the number of bushels you have available");

                }

                else
                {

                    YieldperAcre = rnd.Next(11, 22);
                    acreCost = rnd.Next(40, 45);
                    peopleFed = bushelsForFeeding * 20;
                    noAcres = noAcres + acresBought;
                    acresPlanted = bushelsForPlanting;
                    noBushels = noBushels - (bushelsForFeeding + bushelsForPlanting + acresBought * acreCost);
                    noBushels = noBushels + acresPlanted * YieldperAcre;
                    yearCount = yearCount + 1;

                    progressBar1.Value = yearCount;
                    label7.Text = yearCount.ToString();
                    label10.Text = Convert.ToString(noBushels);
                    label11.Text = Convert.ToString(noAcres);
                    label12.Text = Convert.ToString(noPeople);
                    label13.Text = Convert.ToString(YieldperAcre);
                    this.chart1.Series["Bushels"].Points.AddXY(yearCount, noBushels);
                    this.chart2.Series["Acres"].Points.AddXY(yearCount, noAcres);
                    this.chart3.Series["People"].Points.AddXY(yearCount, noPeople);
                    finalScore = (100 * noPeople + 40 * noAcres + 60 + noBushels) * yearCount;
                   
                }
                    label14.Text = finalScore.ToString();

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"HighScores.txt");
            foreach (string line in lines)
            {
                listBox1.Items.Add(line);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"HighScores.txt", true))
            {

                file.WriteLine(textBox1.Text + " " + finalScore.ToString());
            }
            MessageBox.Show("Score saved");
        }
    }
}
