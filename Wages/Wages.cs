namespace Wages
{
    public partial class Wages : Form
    {
        public Wages()
        {
            InitializeComponent();

            // Configure the controls
            noOfHoursWorkedNumericUpDown.Minimum = 8;
            noOfHoursWorkedNumericUpDown.Maximum = 55;
            selectOvertimeHoursNumericUpDown.Visible = false;
            selectOvertimeHoursLabel.Visible = false;

            // Populate the ComboBox with hourly rates.
            selectHourlyRateComboBox.Items.AddRange(new object[] { 10.00, 15.00, 20.00, 25.00 });

            // Initially disable the controls as required.
            DisableControls();
        }

        private void DisableControls()
        {
            noOfHoursWorkedNumericUpDown.Enabled = true;
            overtimeCheckBox.Enabled = true;
            selectOvertimeHoursNumericUpDown.Enabled = false;
            selectHourlyRateComboBox.Enabled = true;
            calculateButton.Enabled = true;
        }

        private void noOfHoursWorkedLabel_Click(object sender, EventArgs e)
        {

        }

        private void noOfHoursWorkedNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void overtimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            selectOvertimeHoursNumericUpDown.Visible = overtimeCheckBox.Checked;
            selectOvertimeHoursNumericUpDown.Enabled = true;
        }

        private void Wages_Load(object sender, EventArgs e)
        {

        }

        private void selectOvertimeHoursLabel_Click(object sender, EventArgs e)
        {

        }

        private void selectOvertimeHoursNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }


        private void selectHourlyRateLabel_Click(object sender, EventArgs e)
        {

        }

        private void selectHourlyRateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double hoursWorked = (double)noOfHoursWorkedNumericUpDown.Value;
            double overtimeHours = overtimeCheckBox.Checked ? (double)selectOvertimeHoursNumericUpDown.Value : 0;
            double hourlyRate = (double)selectHourlyRateComboBox.SelectedItem;

            double totalPay = (hoursWorked - overtimeHours) * hourlyRate + overtimeHours * hourlyRate * 2;

            MessageBox.Show($"Total pay is {totalPay:C}");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Reset all controls to their default state.
            noOfHoursWorkedNumericUpDown.Value = 8;
            overtimeCheckBox.Checked = false;
            selectOvertimeHoursNumericUpDown.Value = 0;
            selectHourlyRateComboBox.SelectedIndex = -1;
            DisableControls();
        }
    }
}