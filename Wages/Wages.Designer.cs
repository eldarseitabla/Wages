namespace Wages
{
    partial class Wages
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            noOfHoursWorkedLabel = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // noOfHoursWorkedLabel
            // 
            noOfHoursWorkedLabel.AutoSize = true;
            noOfHoursWorkedLabel.Location = new Point(176, 101);
            noOfHoursWorkedLabel.Name = "noOfHoursWorkedLabel";
            noOfHoursWorkedLabel.Size = new Size(185, 25);
            noOfHoursWorkedLabel.TabIndex = 0;
            noOfHoursWorkedLabel.Text = "No. Of Hours Worked";
            noOfHoursWorkedLabel.Click += noOfHoursWorkedLabel_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(416, 95);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(116, 31);
            numericUpDown1.TabIndex = 1;
            // 
            // Wages
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(noOfHoursWorkedLabel);
            Name = "Wages";
            Text = "Wapes";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label noOfHoursWorkedLabel;
        private NumericUpDown numericUpDown1;
    }
}