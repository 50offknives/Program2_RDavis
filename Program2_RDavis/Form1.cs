using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2_RDavis
{
    public partial class Form1 : Form
    {
        const double TAX_RATE = 0.05;

        double totalListPrice, totalDiscount, totalTax;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Accumulate Sales - Calculate Discounts - Add Taxes";

            totalClear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double listPrice, discount, discountPercent, tax;

            try
            {
                if ( double.TryParse(txtListPrice.Text, out listPrice) )
                {
                    if ( listPrice < 0 )
                    {
                        txtListPrice.Focus();
                        txtListPrice.SelectAll();
                        throw new FormatException("Negative values not allowed");
                    }
                }
                else
                {
                    throw new FormatException("Invalid Data");
                }

                if ( double.TryParse(txtDiscount.Text, out discountPercent) )
                {
                    if ( discountPercent < 0 )
                    {
                        txtDiscount.Focus();
                        txtDiscount.SelectAll();
                        throw new FormatException("Negative values not allowed");
                    }
                }
                else
                {
                    throw new FormatException("Invalid Data");
                }

                totalListPrice += listPrice;
                lblTotalListPrice.Text = totalListPrice.ToString("c");

                discountPercent /= 100;
                discount = listPrice * discountPercent;
                totalDiscount += discount;
                lblTotalDiscountAmount.Text = totalDiscount.ToString("c");

                tax = (listPrice - discount) * TAX_RATE;
                totalTax += tax;
                lblTotalTax.Text = totalTax.ToString("c");

                double totalNetPrice = totalListPrice - totalDiscount + totalTax;
                lblTotalNetPrice.Text = totalNetPrice.ToString("c");

                inputClear();
                txtListPrice.Focus();
            }
            catch (FormatException msg)
            {
                MessageBox.Show(msg.Message, "Data Format Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            inputClear();
            totalClear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program ended", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void inputClear()
        {
            txtListPrice.Clear();
            txtDiscount.Clear();
        }

        private void totalClear()
        {
            lblTotalListPrice.Text = "0.00";
            lblTotalDiscountAmount.Text = "0.00";
            lblTotalTax.Text = "0.00";
            lblTotalNetPrice.Text = "0.00";

            totalListPrice = 0;
            totalDiscount = 0;
            totalTax = 0;
        }
    }
}
