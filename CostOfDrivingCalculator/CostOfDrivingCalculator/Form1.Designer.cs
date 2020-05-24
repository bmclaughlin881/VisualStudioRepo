namespace CostOfDrivingCalculator
{
    partial class CostOfDrivingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DistanceTravelled = new System.Windows.Forms.TextBox();
            this.Distance_Travelled = new System.Windows.Forms.Label();
            this.Miles_Checkbox = new System.Windows.Forms.CheckBox();
            this.FuelPrice = new System.Windows.Forms.NumericUpDown();
            this.PricePerLitre = new System.Windows.Forms.Label();
            this.WeeklyCostOutput = new System.Windows.Forms.TextBox();
            this.WeeklyCostLabel = new System.Windows.Forms.Label();
            this.Monthly_Cost = new System.Windows.Forms.Label();
            this.MonthlyCostOutput = new System.Windows.Forms.TextBox();
            this.AnnualCostOutput = new System.Windows.Forms.TextBox();
            this.Annual_Cost_Label = new System.Windows.Forms.Label();
            this.WeeklyWagesOutput = new System.Windows.Forms.TextBox();
            this.WeeklyWagesLabel = new System.Windows.Forms.Label();
            this.MonthlyWagesOutput = new System.Windows.Forms.TextBox();
            this.AnnualWagesOutput = new System.Windows.Forms.TextBox();
            this.MonthlyWagesLabel = new System.Windows.Forms.Label();
            this.AnnualWagesLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.MPG = new System.Windows.Forms.NumericUpDown();
            this.MPG_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FuelPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MPG)).BeginInit();
            this.SuspendLayout();
            // 
            // DistanceTravelled
            // 
            this.DistanceTravelled.Location = new System.Drawing.Point(16, 20);
            this.DistanceTravelled.Name = "DistanceTravelled";
            this.DistanceTravelled.Size = new System.Drawing.Size(192, 22);
            this.DistanceTravelled.TabIndex = 0;
            this.DistanceTravelled.TextChanged += new System.EventHandler(this.DistanceTravelled_TextChanged);
            // 
            // Distance_Travelled
            // 
            this.Distance_Travelled.AutoSize = true;
            this.Distance_Travelled.Location = new System.Drawing.Point(13, 0);
            this.Distance_Travelled.Name = "Distance_Travelled";
            this.Distance_Travelled.Size = new System.Drawing.Size(130, 17);
            this.Distance_Travelled.TabIndex = 1;
            this.Distance_Travelled.Text = "Distance_Travelled";
            // 
            // Miles_Checkbox
            // 
            this.Miles_Checkbox.AutoSize = true;
            this.Miles_Checkbox.Location = new System.Drawing.Point(262, 21);
            this.Miles_Checkbox.Name = "Miles_Checkbox";
            this.Miles_Checkbox.Size = new System.Drawing.Size(70, 21);
            this.Miles_Checkbox.TabIndex = 2;
            this.Miles_Checkbox.Text = "Miles?";
            this.Miles_Checkbox.UseVisualStyleBackColor = true;
            this.Miles_Checkbox.CheckedChanged += new System.EventHandler(this.Miles_Checkbox_CheckedChanged);
            // 
            // FuelPrice
            // 
            this.FuelPrice.DecimalPlaces = 2;
            this.FuelPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.FuelPrice.Location = new System.Drawing.Point(16, 76);
            this.FuelPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FuelPrice.Name = "FuelPrice";
            this.FuelPrice.Size = new System.Drawing.Size(192, 22);
            this.FuelPrice.TabIndex = 3;
            this.FuelPrice.ValueChanged += new System.EventHandler(this.FuelPrice_ValueChanged);
            // 
            // PricePerLitre
            // 
            this.PricePerLitre.AutoSize = true;
            this.PricePerLitre.Location = new System.Drawing.Point(19, 56);
            this.PricePerLitre.Name = "PricePerLitre";
            this.PricePerLitre.Size = new System.Drawing.Size(120, 17);
            this.PricePerLitre.TabIndex = 4;
            this.PricePerLitre.Text = "Price Per Litre (€)";
            // 
            // WeeklyCostOutput
            // 
            this.WeeklyCostOutput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.WeeklyCostOutput.Location = new System.Drawing.Point(16, 141);
            this.WeeklyCostOutput.Name = "WeeklyCostOutput";
            this.WeeklyCostOutput.Size = new System.Drawing.Size(192, 22);
            this.WeeklyCostOutput.TabIndex = 5;
            // 
            // WeeklyCostLabel
            // 
            this.WeeklyCostLabel.AutoSize = true;
            this.WeeklyCostLabel.Location = new System.Drawing.Point(18, 121);
            this.WeeklyCostLabel.Name = "WeeklyCostLabel";
            this.WeeklyCostLabel.Size = new System.Drawing.Size(108, 17);
            this.WeeklyCostLabel.TabIndex = 6;
            this.WeeklyCostLabel.Text = "Weekly Cost (€)";
            // 
            // Monthly_Cost
            // 
            this.Monthly_Cost.AutoSize = true;
            this.Monthly_Cost.Location = new System.Drawing.Point(18, 165);
            this.Monthly_Cost.Name = "Monthly_Cost";
            this.Monthly_Cost.Size = new System.Drawing.Size(111, 17);
            this.Monthly_Cost.TabIndex = 8;
            this.Monthly_Cost.Text = "Monthly Cost (€)";
            // 
            // MonthlyCostOutput
            // 
            this.MonthlyCostOutput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MonthlyCostOutput.Location = new System.Drawing.Point(16, 185);
            this.MonthlyCostOutput.Name = "MonthlyCostOutput";
            this.MonthlyCostOutput.Size = new System.Drawing.Size(192, 22);
            this.MonthlyCostOutput.TabIndex = 7;
            // 
            // AnnualCostOutput
            // 
            this.AnnualCostOutput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AnnualCostOutput.Location = new System.Drawing.Point(16, 230);
            this.AnnualCostOutput.Name = "AnnualCostOutput";
            this.AnnualCostOutput.Size = new System.Drawing.Size(192, 22);
            this.AnnualCostOutput.TabIndex = 7;
            // 
            // Annual_Cost_Label
            // 
            this.Annual_Cost_Label.AutoSize = true;
            this.Annual_Cost_Label.Location = new System.Drawing.Point(18, 210);
            this.Annual_Cost_Label.Name = "Annual_Cost_Label";
            this.Annual_Cost_Label.Size = new System.Drawing.Size(106, 17);
            this.Annual_Cost_Label.TabIndex = 8;
            this.Annual_Cost_Label.Text = "Annual Cost (€)";
            // 
            // WeeklyWagesOutput
            // 
            this.WeeklyWagesOutput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.WeeklyWagesOutput.Location = new System.Drawing.Point(262, 141);
            this.WeeklyWagesOutput.Name = "WeeklyWagesOutput";
            this.WeeklyWagesOutput.Size = new System.Drawing.Size(192, 22);
            this.WeeklyWagesOutput.TabIndex = 5;
            // 
            // WeeklyWagesLabel
            // 
            this.WeeklyWagesLabel.AutoSize = true;
            this.WeeklyWagesLabel.Location = new System.Drawing.Point(264, 121);
            this.WeeklyWagesLabel.Name = "WeeklyWagesLabel";
            this.WeeklyWagesLabel.Size = new System.Drawing.Size(189, 17);
            this.WeeklyWagesLabel.TabIndex = 6;
            this.WeeklyWagesLabel.Text = "Weekly Wages Decrease (€)";
            // 
            // MonthlyWagesOutput
            // 
            this.MonthlyWagesOutput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MonthlyWagesOutput.Location = new System.Drawing.Point(262, 185);
            this.MonthlyWagesOutput.Name = "MonthlyWagesOutput";
            this.MonthlyWagesOutput.Size = new System.Drawing.Size(192, 22);
            this.MonthlyWagesOutput.TabIndex = 7;
            // 
            // AnnualWagesOutput
            // 
            this.AnnualWagesOutput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AnnualWagesOutput.Location = new System.Drawing.Point(262, 230);
            this.AnnualWagesOutput.Name = "AnnualWagesOutput";
            this.AnnualWagesOutput.Size = new System.Drawing.Size(192, 22);
            this.AnnualWagesOutput.TabIndex = 7;
            // 
            // MonthlyWagesLabel
            // 
            this.MonthlyWagesLabel.AutoSize = true;
            this.MonthlyWagesLabel.Location = new System.Drawing.Point(264, 166);
            this.MonthlyWagesLabel.Name = "MonthlyWagesLabel";
            this.MonthlyWagesLabel.Size = new System.Drawing.Size(192, 17);
            this.MonthlyWagesLabel.TabIndex = 8;
            this.MonthlyWagesLabel.Text = "Monthly Wages Decrease (€)";
            // 
            // AnnualWagesLabel
            // 
            this.AnnualWagesLabel.AutoSize = true;
            this.AnnualWagesLabel.Location = new System.Drawing.Point(264, 210);
            this.AnnualWagesLabel.Name = "AnnualWagesLabel";
            this.AnnualWagesLabel.Size = new System.Drawing.Size(187, 17);
            this.AnnualWagesLabel.TabIndex = 8;
            this.AnnualWagesLabel.Text = "Annual Wages Decrease (€)";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(16, 269);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(107, 58);
            this.CalculateButton.TabIndex = 9;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(344, 269);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(107, 58);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MPG
            // 
            this.MPG.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.MPG.Location = new System.Drawing.Point(262, 76);
            this.MPG.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MPG.Name = "MPG";
            this.MPG.Size = new System.Drawing.Size(192, 22);
            this.MPG.TabIndex = 3;
            this.MPG.ValueChanged += new System.EventHandler(this.MPG_ValueChanged);
            // 
            // MPG_Label
            // 
            this.MPG_Label.AutoSize = true;
            this.MPG_Label.Location = new System.Drawing.Point(265, 56);
            this.MPG_Label.Name = "MPG_Label";
            this.MPG_Label.Size = new System.Drawing.Size(39, 17);
            this.MPG_Label.TabIndex = 4;
            this.MPG_Label.Text = "MPG";
            // 
            // CostOfDrivingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 339);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.AnnualWagesLabel);
            this.Controls.Add(this.Annual_Cost_Label);
            this.Controls.Add(this.MonthlyWagesLabel);
            this.Controls.Add(this.Monthly_Cost);
            this.Controls.Add(this.AnnualWagesOutput);
            this.Controls.Add(this.MonthlyWagesOutput);
            this.Controls.Add(this.AnnualCostOutput);
            this.Controls.Add(this.WeeklyWagesLabel);
            this.Controls.Add(this.MonthlyCostOutput);
            this.Controls.Add(this.WeeklyWagesOutput);
            this.Controls.Add(this.WeeklyCostLabel);
            this.Controls.Add(this.WeeklyCostOutput);
            this.Controls.Add(this.MPG_Label);
            this.Controls.Add(this.PricePerLitre);
            this.Controls.Add(this.MPG);
            this.Controls.Add(this.FuelPrice);
            this.Controls.Add(this.Miles_Checkbox);
            this.Controls.Add(this.Distance_Travelled);
            this.Controls.Add(this.DistanceTravelled);
            this.MinimumSize = new System.Drawing.Size(497, 386);
            this.Name = "CostOfDrivingForm";
            this.Text = "Cost Of Driving Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.FuelPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MPG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DistanceTravelled;
        private System.Windows.Forms.Label Distance_Travelled;
        private System.Windows.Forms.CheckBox Miles_Checkbox;
        private System.Windows.Forms.NumericUpDown FuelPrice;
        private System.Windows.Forms.Label PricePerLitre;
        private System.Windows.Forms.TextBox WeeklyCostOutput;
        private System.Windows.Forms.Label WeeklyCostLabel;
        private System.Windows.Forms.Label Monthly_Cost;
        private System.Windows.Forms.TextBox MonthlyCostOutput;
        private System.Windows.Forms.TextBox AnnualCostOutput;
        private System.Windows.Forms.Label Annual_Cost_Label;
        private System.Windows.Forms.TextBox WeeklyWagesOutput;
        private System.Windows.Forms.Label WeeklyWagesLabel;
        private System.Windows.Forms.TextBox MonthlyWagesOutput;
        private System.Windows.Forms.TextBox AnnualWagesOutput;
        private System.Windows.Forms.Label MonthlyWagesLabel;
        private System.Windows.Forms.Label AnnualWagesLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.NumericUpDown MPG;
        private System.Windows.Forms.Label MPG_Label;
    }
}

