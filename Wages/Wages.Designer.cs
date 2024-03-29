﻿namespace Wages
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
            noOfHoursWorkedNumericUpDown = new NumericUpDown();
            selectOvertimeHoursNumericUpDown = new NumericUpDown();
            selectOvertimeHoursLabel = new Label();
            overtimeCheckBox = new CheckBox();
            selectHourlyRateLabel = new Label();
            selectHourlyRateComboBox = new ComboBox();
            calculateButton = new Button();
            clearButton = new Button();
            ((System.ComponentModel.ISupportInitialize)noOfHoursWorkedNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selectOvertimeHoursNumericUpDown).BeginInit();
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
            // noOfHoursWorkedNumericUpDown
            // 
            noOfHoursWorkedNumericUpDown.Location = new Point(386, 99);
            noOfHoursWorkedNumericUpDown.Name = "noOfHoursWorkedNumericUpDown";
            noOfHoursWorkedNumericUpDown.Size = new Size(131, 31);
            noOfHoursWorkedNumericUpDown.TabIndex = 1;
            noOfHoursWorkedNumericUpDown.ValueChanged += noOfHoursWorkedNumericUpDown_ValueChanged;
            // 
            // selectOvertimeHoursNumericUpDown
            // 
            selectOvertimeHoursNumericUpDown.Location = new Point(425, 163);
            selectOvertimeHoursNumericUpDown.Name = "selectOvertimeHoursNumericUpDown";
            selectOvertimeHoursNumericUpDown.Size = new Size(92, 31);
            selectOvertimeHoursNumericUpDown.TabIndex = 3;
            selectOvertimeHoursNumericUpDown.ValueChanged += selectOvertimeHoursNumericUpDown_ValueChanged;
            // 
            // selectOvertimeHoursLabel
            // 
            selectOvertimeHoursLabel.AutoSize = true;
            selectOvertimeHoursLabel.Location = new Point(308, 166);
            selectOvertimeHoursLabel.Name = "selectOvertimeHoursLabel";
            selectOvertimeHoursLabel.Size = new Size(111, 25);
            selectOvertimeHoursLabel.TabIndex = 4;
            selectOvertimeHoursLabel.Text = "Select Hours";
            selectOvertimeHoursLabel.Click += selectOvertimeHoursLabel_Click;
            // 
            // overtimeCheckBox
            // 
            overtimeCheckBox.AutoSize = true;
            overtimeCheckBox.Location = new Point(176, 165);
            overtimeCheckBox.Name = "overtimeCheckBox";
            overtimeCheckBox.Size = new Size(111, 29);
            overtimeCheckBox.TabIndex = 5;
            overtimeCheckBox.Text = "Overtime";
            overtimeCheckBox.UseVisualStyleBackColor = true;
            overtimeCheckBox.CheckedChanged += overtimeCheckBox_CheckedChanged;
            // 
            // selectHourlyRateLabel
            // 
            selectHourlyRateLabel.AutoSize = true;
            selectHourlyRateLabel.Location = new Point(176, 281);
            selectHourlyRateLabel.Name = "selectHourlyRateLabel";
            selectHourlyRateLabel.Size = new Size(156, 25);
            selectHourlyRateLabel.TabIndex = 6;
            selectHourlyRateLabel.Text = "Select Hourly Rate";
            selectHourlyRateLabel.Click += selectHourlyRateLabel_Click;
            // 
            // selectHourlyRateComboBox
            // 
            selectHourlyRateComboBox.FormattingEnabled = true;
            selectHourlyRateComboBox.Location = new Point(344, 281);
            selectHourlyRateComboBox.Name = "selectHourlyRateComboBox";
            selectHourlyRateComboBox.Size = new Size(158, 33);
            selectHourlyRateComboBox.TabIndex = 7;
            selectHourlyRateComboBox.SelectedIndexChanged += selectHourlyRateComboBox_SelectedIndexChanged;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(176, 458);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(112, 34);
            calculateButton.TabIndex = 8;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(405, 458);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(112, 34);
            clearButton.TabIndex = 9;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // Wages
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 603);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(selectHourlyRateComboBox);
            Controls.Add(selectHourlyRateLabel);
            Controls.Add(overtimeCheckBox);
            Controls.Add(selectOvertimeHoursLabel);
            Controls.Add(selectOvertimeHoursNumericUpDown);
            Controls.Add(noOfHoursWorkedNumericUpDown);
            Controls.Add(noOfHoursWorkedLabel);
            Name = "Wages";
            Text = "Wapes";
            Load += Wages_Load;
            ((System.ComponentModel.ISupportInitialize)noOfHoursWorkedNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)selectOvertimeHoursNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label noOfHoursWorkedLabel;
        private NumericUpDown noOfHoursWorkedNumericUpDown;
        private NumericUpDown selectOvertimeHoursNumericUpDown;
        private Label selectOvertimeHoursLabel;
        private CheckBox overtimeCheckBox;
        private Label selectHourlyRateLabel;
        private ComboBox selectHourlyRateComboBox;
        private Button calculateButton;
        private Button clearButton;
    }
}