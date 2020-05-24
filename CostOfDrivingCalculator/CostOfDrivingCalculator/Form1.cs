using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostOfDrivingCalculator
{
    public partial class CostOfDrivingForm : Form
    {
        String Distance = "";
        Boolean Miles = false;
        Double FuelCost;
        Double Efficiency;
       
        public CostOfDrivingForm()
        {
            InitializeComponent();
        }

        private void DistanceTravelled_TextChanged(object sender, EventArgs e)
        {
            //Task.Delay(2000).Wait();
             Distance = DistanceTravelled.Text;
        }

        private void FuelPrice_ValueChanged(object sender, EventArgs e)
        {
            FuelCost = Convert.ToDouble(FuelPrice.Value);
            
            
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //Depending on Miles? selector status convert to 
            //Miles if necessary
            Double Dist = 0;
            Double GallonsUsed = 0;
            Double Litres = 0;
            
            double WeeklyCostNum = 0;
            
            
            if (Miles == true)
            {
                Dist = Convert.ToDouble(Distance);
                Dist = Dist * 10; // weekly distcnce
            }
            else
            {
                Dist = Convert.ToDouble(Distance);
                Dist = Dist / 1.60934; // Apply conversion factor to switch to Miles
                Dist = Dist * 10; // weekly distance
            }

            GallonsUsed = Dist / Efficiency;
            Litres = GallonsUsed * 4.546; // Multiply by conversion factor to get litres used
            WeeklyCostNum = (Litres * FuelCost); // Calculate Weekly Cost

            WeeklyCostOutput.Text = WeeklyCostNum.ToString();
            MonthlyCostOutput.Text = (WeeklyCostNum * 4.5).ToString();
            AnnualCostOutput.Text = (WeeklyCostNum * 52).ToString();

            WeeklyWagesOutput.Text = ((WeeklyCostNum/48)*100).ToString();
            MonthlyWagesOutput.Text = (((WeeklyCostNum / 48) * 100) * 4.5).ToString();
            AnnualWagesOutput.Text = (((WeeklyCostNum / 48) * 100) * 52).ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DistanceTravelled.Text = "";
            FuelPrice.Value = 0;
            MPG.Value = 0;
            WeeklyCostOutput.Text = "";
            MonthlyCostOutput.Text = "";
            AnnualCostOutput.Text = "";

            WeeklyWagesOutput.Text = "";
            MonthlyWagesOutput.Text = "";
            AnnualWagesOutput.Text = "";
        }

        private void Miles_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Miles = Miles_Checkbox.Checked;

        }

        private void MPG_ValueChanged(object sender, EventArgs e)
        {
            Efficiency = Convert.ToDouble(MPG.Value); 
            
        }
    }
}
