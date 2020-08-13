using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceApp
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        // Initialize the variables for the array
        int totalIndex = 0;

        int numberOfInvoices = 0;
        decimal totalOfInvoices = 0m;
        decimal invoiceAverage = 0m;

        decimal[] invoiceTotalArray = new decimal[5];

        // Initalize the variable for the list
        List<decimal> invoiceTotalsList = new List<decimal>();

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEnterSubtotal.Text == "")
                {
                    MessageBox.Show("Subtotal is required field.", "Entry Error");
                }
                else
                {
                    decimal subtotal = Decimal.Parse(txtEnterSubtotal.Text);
                    if (subtotal > 0 && subtotal < 10000)
                    {
                        decimal discountPercent = 0m;
                        if (subtotal >= 500)
                        {
                            discountPercent = .2m;
                        }
                        else if (subtotal >= 250 & subtotal < 500)
                        {
                            discountPercent = .15m;
                        }
                        else if (subtotal >= 100 & subtotal < 250)
                            discountPercent = .1m;

                        decimal discountAmount = subtotal * discountPercent;
                        decimal invoiceTotal = subtotal - discountAmount;

                        discountAmount = Math.Round(discountAmount, 2);
                        invoiceTotal = Math.Round(invoiceTotal, 2);

                        decimal lowestInvoiceTotal = Math.Min(invoiceTotal, 2);
                        decimal largestInvoiceTotal = Math.Max(invoiceTotal, 2);

                        txtSubtotal.Text = subtotal.ToString("c");

                        txtDiscountPercent.Text = discountPercent.ToString("p1");
                        txtDiscountAmount.Text = discountAmount.ToString("c");
                        txtTotal.Text = invoiceTotal.ToString("c");

                        // Add total to array (and update index)
                        invoiceTotalArray[totalIndex] = invoiceTotal;
                        totalIndex++;

                        // Add total to list
                        invoiceTotalsList.Add(invoiceTotal);

                        txtLowestInvoce.Text = lowestInvoiceTotal.ToString("c");
                        txtLargestInvoice.Text = largestInvoiceTotal.ToString("c");

                        numberOfInvoices++;
                        totalOfInvoices += invoiceTotal;
                        invoiceAverage = totalOfInvoices / numberOfInvoices;

                        txtNumberOfInvoices.Text = numberOfInvoices.ToString();
                        txtTotalOfInvoices.Text = totalOfInvoices.ToString("c");
                        txtInvoicesAverage.Text = invoiceAverage.ToString("c");

                        txtEnterSubtotal.Text = "";
                        

                    }
                    else
                    {
                        MessageBox.Show("Subtotal must be greater than 0 and less than 10000.", "Entry Error");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for the subtotal field.", "Entry Error");

            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("The index is out of range. Please exit the application", "Entry Error");
            }
            txtEnterSubtotal.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            numberOfInvoices = 0;
            totalOfInvoices = 0m;
            invoiceAverage = 0m;
            txtNumberOfInvoices.Text = "";
            txtTotalOfInvoices.Text = "";
            txtInvoicesAverage.Text = "";

            txtEnterSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            // Display the message box for the array
            Array.Sort(invoiceTotalArray);
            string message = "";
            foreach (decimal total in invoiceTotalArray)
            {
                if (total != 0 )
                {
                    message += total.ToString("c") + "\n";
                }
            }

            MessageBox.Show(message, "Order total - Array");

            // Display the message box for the list
            invoiceTotalsList.Sort();
            message = "";
            foreach (decimal total in invoiceTotalsList)
            {
                message += total.ToString("c") + "\n";
            }

            MessageBox.Show(message, "Order total - List");
            this.Close();
        }
    }
}
