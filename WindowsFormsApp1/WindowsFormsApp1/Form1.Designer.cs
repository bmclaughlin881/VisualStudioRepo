namespace WindowsFormsApp1
{
    partial class Form1
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
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonsGrid = new System.Windows.Forms.TableLayoutPanel();
            this.CButton = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.Eight_Button = new System.Windows.Forms.Button();
            this.Nine_Button = new System.Windows.Forms.Button();
            this.Multiply_Button = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.ButtonsGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.ForeColor = System.Drawing.Color.Black;
            this.UserInputText.Location = new System.Drawing.Point(12, 12);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.UserInputText.Size = new System.Drawing.Size(458, 22);
            this.UserInputText.TabIndex = 0;
            this.UserInputText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter and Equation and press enter to see the result";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonsGrid
            // 
            this.ButtonsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsGrid.ColumnCount = 4;
            this.ButtonsGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsGrid.Controls.Add(this.button19, 3, 4);
            this.ButtonsGrid.Controls.Add(this.button18, 2, 4);
            this.ButtonsGrid.Controls.Add(this.button17, 1, 4);
            this.ButtonsGrid.Controls.Add(this.button16, 0, 4);
            this.ButtonsGrid.Controls.Add(this.button15, 3, 3);
            this.ButtonsGrid.Controls.Add(this.button14, 2, 3);
            this.ButtonsGrid.Controls.Add(this.button13, 1, 3);
            this.ButtonsGrid.Controls.Add(this.button12, 0, 3);
            this.ButtonsGrid.Controls.Add(this.button11, 3, 2);
            this.ButtonsGrid.Controls.Add(this.button10, 2, 2);
            this.ButtonsGrid.Controls.Add(this.button9, 1, 2);
            this.ButtonsGrid.Controls.Add(this.FourButton, 0, 2);
            this.ButtonsGrid.Controls.Add(this.Multiply_Button, 3, 1);
            this.ButtonsGrid.Controls.Add(this.Nine_Button, 2, 1);
            this.ButtonsGrid.Controls.Add(this.Eight_Button, 1, 1);
            this.ButtonsGrid.Controls.Add(this.SevenButton, 0, 1);
            this.ButtonsGrid.Controls.Add(this.DivideButton, 3, 0);
            this.ButtonsGrid.Controls.Add(this.DeleteButton, 2, 0);
            this.ButtonsGrid.Controls.Add(this.CEButton, 1, 0);
            this.ButtonsGrid.Controls.Add(this.CButton, 0, 0);
            this.ButtonsGrid.Location = new System.Drawing.Point(15, 63);
            this.ButtonsGrid.Name = "ButtonsGrid";
            this.ButtonsGrid.RowCount = 5;
            this.ButtonsGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonsGrid.Size = new System.Drawing.Size(462, 398);
            this.ButtonsGrid.TabIndex = 2;
            this.ButtonsGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonsGrid_Paint);
            // 
            // CButton
            // 
            this.CButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CButton.Location = new System.Drawing.Point(3, 3);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(109, 73);
            this.CButton.TabIndex = 0;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CEButton
            // 
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Location = new System.Drawing.Point(118, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(109, 73);
            this.CEButton.TabIndex = 1;
            this.CEButton.Text = "\r\nCE";
            this.CEButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteButton.Location = new System.Drawing.Point(233, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(109, 73);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // DivideButton
            // 
            this.DivideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivideButton.Location = new System.Drawing.Point(348, 3);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(111, 73);
            this.DivideButton.TabIndex = 3;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SevenButton.Location = new System.Drawing.Point(3, 82);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(109, 73);
            this.SevenButton.TabIndex = 4;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            // 
            // Eight_Button
            // 
            this.Eight_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Eight_Button.Location = new System.Drawing.Point(118, 82);
            this.Eight_Button.Name = "Eight_Button";
            this.Eight_Button.Size = new System.Drawing.Size(109, 73);
            this.Eight_Button.TabIndex = 5;
            this.Eight_Button.Text = "8";
            this.Eight_Button.UseVisualStyleBackColor = true;
            // 
            // Nine_Button
            // 
            this.Nine_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nine_Button.Location = new System.Drawing.Point(233, 82);
            this.Nine_Button.Name = "Nine_Button";
            this.Nine_Button.Size = new System.Drawing.Size(109, 73);
            this.Nine_Button.TabIndex = 6;
            this.Nine_Button.Text = "9";
            this.Nine_Button.UseVisualStyleBackColor = true;
            // 
            // Multiply_Button
            // 
            this.Multiply_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Multiply_Button.Location = new System.Drawing.Point(348, 82);
            this.Multiply_Button.Name = "Multiply_Button";
            this.Multiply_Button.Size = new System.Drawing.Size(111, 73);
            this.Multiply_Button.TabIndex = 7;
            this.Multiply_Button.Text = "X";
            this.Multiply_Button.UseVisualStyleBackColor = true;
            // 
            // FourButton
            // 
            this.FourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FourButton.Location = new System.Drawing.Point(3, 161);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(109, 73);
            this.FourButton.TabIndex = 8;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Location = new System.Drawing.Point(118, 161);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(109, 73);
            this.button9.TabIndex = 9;
            this.button9.Text = "5";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Location = new System.Drawing.Point(233, 161);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(109, 73);
            this.button10.TabIndex = 10;
            this.button10.Text = "6";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.Location = new System.Drawing.Point(348, 161);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(111, 73);
            this.button11.TabIndex = 11;
            this.button11.Text = "-";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.Location = new System.Drawing.Point(3, 240);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(109, 73);
            this.button12.TabIndex = 12;
            this.button12.Text = "1";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.Location = new System.Drawing.Point(118, 240);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(109, 73);
            this.button13.TabIndex = 13;
            this.button13.Text = "2";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.Location = new System.Drawing.Point(233, 240);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(109, 73);
            this.button14.TabIndex = 14;
            this.button14.Text = "3";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button15.Location = new System.Drawing.Point(348, 240);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(111, 73);
            this.button15.TabIndex = 15;
            this.button15.Text = "+";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button16.Location = new System.Drawing.Point(3, 319);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(109, 76);
            this.button16.TabIndex = 16;
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button17.Location = new System.Drawing.Point(118, 319);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(109, 76);
            this.button17.TabIndex = 17;
            this.button17.Text = "0";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button18.Location = new System.Drawing.Point(233, 319);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(109, 76);
            this.button18.TabIndex = 18;
            this.button18.Text = ".";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button19.Location = new System.Drawing.Point(348, 319);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(111, 76);
            this.button19.TabIndex = 19;
            this.button19.Text = "=";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 473);
            this.Controls.Add(this.ButtonsGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserInputText);
            this.MinimumSize = new System.Drawing.Size(500, 520);
            this.Name = "Form1";
            this.Text = "Basic Calculator";
            this.ButtonsGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel ButtonsGrid;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button Multiply_Button;
        private System.Windows.Forms.Button Nine_Button;
        private System.Windows.Forms.Button Eight_Button;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CEButton;
    }
}

