using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        int numberOfInvoices = 0;
        decimal totalOfInvoices = 0m;
        decimal invoiceAverage = 0m;

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            decimal subtotal = Convert.ToDecimal(txtEnterSubtotal.Text);
            decimal discountPercent = .25m;
            decimal discountAmount = Math.Round(subtotal * discountPercent, 2);
            decimal invoiceTotal = subtotal - discountAmount;
            decimal lowestInvoiceTotal = Math.Min(invoiceTotal, 2);
            decimal largestInvoiceTotal = Math.Max(invoiceTotal, 2);

            txtSubtotal.Text = subtotal.ToString("c");
            txtDiscountPercent.Text = discountAmount.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");
            txtLowestInvoce.Text = lowestInvoiceTotal.ToString("c");
            txtLargestInvoice.Text = largestInvoiceTotal.ToString("c");

            numberOfInvoices++;
            totalOfInvoices += invoiceTotal;
            invoiceAverage = totalOfInvoices / numberOfInvoices;

            txtNumberOfInvoices.Text = numberOfInvoices.ToString();
            txtTotalOfInvoices.Text = totalOfInvoices.ToString("c");
            txtInvoicesAverage.Text = invoiceAverage.ToString("c");

            txtEnterSubtotal.Text = "";
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
    }
}
