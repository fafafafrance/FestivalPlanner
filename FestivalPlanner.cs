using System;
using System.Windows.Forms;

namespace GigPlanner
{
    public partial class FestivalPlanner : Form
    {
        public FestivalPlanner()
        {
            InitializeComponent();
        }

        // --- 1. Foundational Engines (Chapter 6 & 7) ---
        private bool IsValidData()
        {
            if (cboAttendance.SelectedItem == null)
            {
                MessageBox.Show("Please select an attendance number.", "Input Error");
                return false;
            }
            return true;
        }

        private decimal CalculateTotal(int attendance, bool isCamping)
        {
            decimal ticketPrice = 316m;
            decimal total = attendance * ticketPrice;

            if (isCamping)
            {
                total += 200m;
            }
            return total;
        }

        // --- 2. The Control Room ---
        private void PerformCalculation()
        {
            if (IsValidData())
            {
                int attendance = int.Parse(cboAttendance.SelectedItem?.ToString() ?? "0");
                bool isCamping = radCamping.Checked;

                // 1. Calculate Base
                decimal subtotal = attendance * 316m;

                // 2. Add Camping
                decimal campingFee = isCamping ? 200m : 0m;
                decimal total = subtotal + campingFee;

                // 3. Update TWO labels so you can see both values
                lblSubtotal.Text = $"Subtotal: {subtotal.ToString("c")}";
                lblResult.Text = $"Grand Total: {total.ToString("c")}";
            }
        }

        // --- 3. Event Handlers ---
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            PerformCalculation();
        }

        private void cboAttendance_SelectedIndexChanged(object sender, EventArgs e)
        {
            PerformCalculation();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboVenue.SelectedIndex = -1;
            cboAttendance.SelectedIndex = -1;
            radCamping.Checked = false;
            lblResult.Text = "$0.00";
        }
    } // This closes the class
} // This closes the namespace