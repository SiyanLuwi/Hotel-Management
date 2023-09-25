using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Management
{
    public partial class frmHotel : Form
    {
        int standard = 400;
        int economy = 300;
        int deluxe = 850;
        int exclusive = 1000;

        double silver = 0.05;
        double gold = 0.1;
        double plat = 0.2;
        double discount;
        int amount;
        int change;
        public frmHotel()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Age
            numAge.Minimum = 18;
            numAge.Maximum = 100;

            //Pax
            numPax.Minimum = 2;
            numPax.Maximum = 8;

        }
        //TEXTBOX NAME
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                gbAccommodation.Enabled = false; // Disable the group if txtName is empty
                btnCalculate.Enabled = false; // Disable the button if txtName is empty
                gbDiscount.Enabled = false; // Disable the group if txtName is empty
            }
            else
            {
                gbAccommodation.Enabled = true; // Enable the group if txtName is not empty
                btnCalculate.Enabled = true; //  Enable the button if txtName is not empty
               
            }
        }
        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Suppress the key press if it's not a digit or control key
            }
        }

        //CONTACT NUMBER
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Suppress the key press if it's a digit
            }
        }

        //GROUP BOX FOR ACCOMODATION
        private void gbAccommodation_Enter(object sender, EventArgs e)
        {

        }
        private void radStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (radStandard.Checked)
            {
                txtAmount.Text = "$400";
                gbDiscount.Enabled = true;
                UpdateDiscount(); // Call the function to update the discount.
                UpdateDue(); // Call a function to update the total due.
            }
        }
        private void radEconomy_CheckedChanged(object sender, EventArgs e)
        {
            if (radEconomy.Checked)
            {
                txtAmount.Text = "$300";
                gbDiscount.Enabled = true;
                UpdateDiscount(); // Call the function to update the discount.
                UpdateDue(); // Call a function to update the total due.
            }
        }
        private void radDeluxe_CheckedChanged(object sender, EventArgs e)
        {
            if (radDeluxe.Checked)
            {
                txtAmount.Text = "$850";
                gbDiscount.Enabled = true;
                UpdateDiscount(); // Call the function to update the discount.
                UpdateDue(); // Call a function to update the total due.
            }
        }
        private void radExclusive_CheckedChanged(object sender, EventArgs e)
        {

            if (radExclusive.Checked)
            {
                txtAmount.Text = "$1000";
                gbDiscount.Enabled = true;
                UpdateDiscount(); // Call the function to update the discount.
                UpdateDue(); // Call a function to update the total due.
            }
        }

        //GROUP BOX FOR DISCOUNT

        private void gbDiscount_Enter(object sender, EventArgs e)
        {

        }
        private void radRegular_CheckedChanged(object sender, EventArgs e)
        {
            txtDiscount.Text = "$0";

        }
        private void radSilver_CheckedChanged(object sender, EventArgs e)
        {
            if (radStandard.Checked)
            {
                discount = (standard * silver);
                txtDiscount.Clear();
                UpdateDiscount(); // Call the function to update the discount.
                UpdateDue(); // Call a function to update the total due.
            }
            else if (radEconomy.Checked)
            {
                discount = (economy * silver);
                txtDiscount.Clear();
                UpdateDiscount(); // Call the function to update the discount.
                UpdateDue(); // Call a function to update the total due.
            }
            else if (radDeluxe.Checked)
            {
                discount = (deluxe * silver);
                txtDiscount.Clear();
                UpdateDiscount(); // Call the function to update the discount.
                UpdateDue(); // Call a function to update the total due.
            }
            else if (radExclusive.Checked)
            {
                discount = (exclusive * silver);
                txtDiscount.Clear();
                UpdateDiscount(); // Call the function to update the discount.
                UpdateDue(); // Call a function to update the total due.
            }
            else
            {
                MessageBox.Show("Invalid Discount!. Please choose from the Discounts!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void radGold_CheckedChanged(object sender, EventArgs e)
        {
            if (radStandard.Checked)
            {
                discount = (economy * gold);
                txtDiscount.Clear();
                UpdateDiscount(); // Call the function to update the discount.
                UpdateDue(); // Call a function to update the total due.
            }
            else if (radEconomy.Checked)
            {
                discount = (economy * gold);
                txtDiscount.Clear();
                UpdateDiscount(); // Call the function to update the discount.
                UpdateDue(); // Call a function to update the total due.

            }
            else if (radDeluxe.Checked)
            {
                discount = (deluxe * gold);
                txtDiscount.Clear();
                UpdateDiscount(); // Call the function to update the discount.
                UpdateDue(); // Call a function to update the total due.
            }
            else if (radExclusive.Checked)
            {
                discount = (exclusive * gold);
                txtDiscount.Clear();
                UpdateDiscount(); // Call the function to update the discount.
                UpdateDue(); // Call a function to update the total due.
            }
            else
            {
                MessageBox.Show("Invalid Discount!. Please choose from the Discounts!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void radPlat_CheckedChanged(object sender, EventArgs e)
        {
            if (radStandard.Checked)
            {
                discount = (standard * plat);
                txtDiscount.Clear();
                UpdateDiscount(); // Call the function to update the discount.
                UpdateDue(); // Call a function to update the total due.

            }
            else if (radEconomy.Checked)
            {
                discount = (economy * plat);
                txtDiscount.Clear();
                UpdateDiscount(); // Call the function to update the discount.
                UpdateDue(); // Call a function to update the total due.

            }
            else if (radDeluxe.Checked)
            {
                discount = (deluxe * plat);
                txtDiscount.Clear();
                UpdateDiscount(); // Call the function to update the discount.
                UpdateDue(); // Call a function to update the total due.

            }
            else if (radExclusive.Checked)
            {
                discount = (exclusive * plat);
                txtDiscount.Clear();
                UpdateDiscount(); // Call the function to update the discount.
                UpdateDue(); // Call a function to update the total due.
            }
            else
            {
                MessageBox.Show("Invalid Discount!. Please choose from the Discounts!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Suppress the key press if it's not a digit or control key

            }
        }
        //textBox
        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            btnCalculate.Enabled = true;
        }
        //Button Function
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPayment.Text, out int payment))
            {
                // Remove the dollar sign and any other non-numeric characters from txtDue.Text
                string totalDueText = txtDue.Text.Replace("$", "").Trim();

                if (int.TryParse(totalDueText, out int totalDue))
                {
                    change = payment - totalDue;

                    string selectedRadioButtonText = GetSelectedRadioButtonText();

                    string reservationInfo = $"Hotel Reservation\n" +
                                             $"Name:\t\t\t {txtName.Text}\n" +
                                             $"Contact Number:\t\t {txtContact.Text}\n" +
                                             $"Age:\t\t\t {numAge.Value}\n" +
                                             $"Pax:\t\t\t {numPax.Value}\n\n" +
                                             $"====================================\n\n" +
                                             $"Room Accommodation:\t {selectedRadioButtonText}\n" +
                                             $"Total Due:\t\t ${totalDue}\n" +
                                             $"Payment:\t\t\t ${payment}\n\n" +
                                             $"====================================\n\n" +
                                             $"Change:\t\t\t ${change}\n\n" +
                                             $"\tThank You for Reserving!";

                    if (string.IsNullOrEmpty(txtContact.Text)) //if the txtContact.Text is empty
                    {
                        MessageBox.Show("Please put your contact details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                    else if (payment < totalDue) // if payment is less than the total Due
                    {
                        MessageBox.Show("Please pay the proper amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else // initialize the receipt
                    {
                        MessageBox.Show(reservationInfo, "Reservation Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetForm();
                    }

                }
                else
                {
                    // Handle the case where 'txtDue.Text' doesn't contain a valid integer.
                    MessageBox.Show("Invalid total due amount. Please enter a valid number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Handle the case where 'txtPayment.Text' doesn't contain a valid integer.
                MessageBox.Show("Invalid payment amount. Please enter a valid number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private string GetSelectedRadioButtonText()
        {
            if (radStandard.Checked)
            {
                return radStandard.Text;
            }
            else if (radEconomy.Checked)
            {
                return radEconomy.Text;
            }
            else if (radDeluxe.Checked)
            {
                return radDeluxe.Text;
            }
            else if (radExclusive.Checked)
            {
                return radExclusive.Text;
            }
            else
            {
                return "Unknown";
            }
        }

        private void UpdateDiscount()
        {
            if (radStandard.Checked)
            {
                discount = standard * GetDiscountRate();
            }
            else if (radEconomy.Checked)
            {
                discount = economy * GetDiscountRate();
            }
            else if (radDeluxe.Checked)
            {
                discount = deluxe * GetDiscountRate();
            }
            else if (radExclusive.Checked)
            {
                discount = exclusive * GetDiscountRate();
            }
            txtDiscount.Text = $"${discount}";
        }
        private double GetDiscountRate()
        {
            if (radSilver.Checked)
            {
                return silver;
            }
            else if (radGold.Checked)
            {
                return gold;
            }
            else if (radPlat.Checked)
            {
                return plat;
            }
            else
            {
                return 0; // Default to no discount if no radio button is selected.
            }
        }
        private void UpdateDue()
        {
            // Calculate the total due based on the selected accommodation and discount.
            amount = (int)(GetSelectedAccommodationPrice() - discount);
            txtDue.Text = $"${amount}";
        }

        private int GetSelectedAccommodationPrice()
        {
            if (radStandard.Checked)
            {
                return standard;
            }
            else if (radEconomy.Checked)
            {
                return economy;
            }
            else if (radDeluxe.Checked)
            {
                return deluxe;
            }
            else if (radExclusive.Checked)
            {
                return exclusive;
            }
            else
            {
                return 0; // Default to 0 if no radio button is selected.
            }
        }
        private void resetForm()
        {
            txtName.Text = string.Empty;
            txtContact.Text = string.Empty;
            numAge.Value = 18;
            numPax.Value = 2;
            gbAccommodation.Enabled = false;
            gbDiscount.Enabled = false;
            txtAmount.Text = string.Empty; 
            txtDue.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txtPayment.Text = string.Empty;
        }
    }
}