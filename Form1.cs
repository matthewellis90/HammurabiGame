using System;
using System.Windows.Forms;

namespace Hammurabi
{
    public partial class Form1 : Form
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

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            if (yearCount >= 10)
            {
                ActionButton.Enabled = false;
                return;
            }

            bushelsForFeeding = Convert.ToInt32(FeedUpDown.Value);
            acresBought = Convert.ToInt32(LandUpDown.Value);
            bushelsForPlanting = Convert.ToInt32(PlantUpDown.Value);

            acreCost = rnd.Next(40, 45);

            if (bushelsForFeeding + bushelsForPlanting + acresBought * acreCost > noBushels)
            {
                MessageBox.Show("You have exceeded the number of bushels you have available");
                return;
            }

            YieldperAcre = rnd.Next(11, 22);
            peopleFed = bushelsForFeeding * 20;

            noAcres += acresBought;
            acresPlanted = bushelsForPlanting;

            noBushels -= (bushelsForFeeding + bushelsForPlanting + acresBought * acreCost);
            noBushels += acresPlanted * YieldperAcre;

            yearCount++;

            // Update UI
            YearProgressBar.Value = yearCount;
            YearLabel.Text = yearCount.ToString();
            ReportLabel.Text = $"Bushels: {noBushels} | Acres: {noAcres} | People: {noPeople} | Yield: {YieldperAcre}";

            BushelChart.Series["Bushels"].Points.AddXY(yearCount, noBushels);
            AcresChart.Series["Acres"].Points.AddXY(yearCount, noAcres);
            PopChart.Series["Population"].Points.AddXY(yearCount, noPeople);

            finalScore = (100 * noPeople + 40 * noAcres + 60 + noBushels) * yearCount;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional initialization
        }
    }
}
