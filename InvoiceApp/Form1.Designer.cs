namespace InvoiceApp
{
    partial class frmInvoiceTotal
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
            this.lbEnterSubtotal = new System.Windows.Forms.Label();
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.lbDiscountPercent = new System.Windows.Forms.Label();
            this.lbDiscountAmount = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbNumberOfInvoices = new System.Windows.Forms.Label();
            this.lbTotalOfInvoices = new System.Windows.Forms.Label();
            this.lbInvoiceAverage = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtEnterSubtotal = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtNumberOfInvoices = new System.Windows.Forms.TextBox();
            this.txtTotalOfInvoices = new System.Windows.Forms.TextBox();
            this.txtInvoicesAverage = new System.Windows.Forms.TextBox();
            this.lbLargestInvoice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLargestInvoice = new System.Windows.Forms.TextBox();
            this.txtLowestInvoce = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbEnterSubtotal
            // 
            this.lbEnterSubtotal.AutoSize = true;
            this.lbEnterSubtotal.Location = new System.Drawing.Point(80, 81);
            this.lbEnterSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEnterSubtotal.Name = "lbEnterSubtotal";
            this.lbEnterSubtotal.Size = new System.Drawing.Size(132, 24);
            this.lbEnterSubtotal.TabIndex = 0;
            this.lbEnterSubtotal.Text = "Enter Subtotal:";
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.AutoSize = true;
            this.lbSubtotal.Location = new System.Drawing.Point(80, 129);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(82, 24);
            this.lbSubtotal.TabIndex = 1;
            this.lbSubtotal.Text = "Subtotal:";
            // 
            // lbDiscountPercent
            // 
            this.lbDiscountPercent.AutoSize = true;
            this.lbDiscountPercent.Location = new System.Drawing.Point(80, 183);
            this.lbDiscountPercent.Name = "lbDiscountPercent";
            this.lbDiscountPercent.Size = new System.Drawing.Size(158, 24);
            this.lbDiscountPercent.TabIndex = 2;
            this.lbDiscountPercent.Text = "Discount Percent:";
            // 
            // lbDiscountAmount
            // 
            this.lbDiscountAmount.AutoSize = true;
            this.lbDiscountAmount.Location = new System.Drawing.Point(80, 235);
            this.lbDiscountAmount.Name = "lbDiscountAmount";
            this.lbDiscountAmount.Size = new System.Drawing.Size(159, 24);
            this.lbDiscountAmount.TabIndex = 3;
            this.lbDiscountAmount.Text = "Discount Amount:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(80, 284);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(56, 24);
            this.lbTotal.TabIndex = 4;
            this.lbTotal.Text = "Total:";
            // 
            // lbNumberOfInvoices
            // 
            this.lbNumberOfInvoices.AutoSize = true;
            this.lbNumberOfInvoices.Location = new System.Drawing.Point(466, 129);
            this.lbNumberOfInvoices.Name = "lbNumberOfInvoices";
            this.lbNumberOfInvoices.Size = new System.Drawing.Size(182, 24);
            this.lbNumberOfInvoices.TabIndex = 5;
            this.lbNumberOfInvoices.Text = "Number Of Invoices:";
            // 
            // lbTotalOfInvoices
            // 
            this.lbTotalOfInvoices.AutoSize = true;
            this.lbTotalOfInvoices.Location = new System.Drawing.Point(470, 183);
            this.lbTotalOfInvoices.Name = "lbTotalOfInvoices";
            this.lbTotalOfInvoices.Size = new System.Drawing.Size(154, 24);
            this.lbTotalOfInvoices.TabIndex = 6;
            this.lbTotalOfInvoices.Text = "Total Of Invoices:";
            // 
            // lbInvoiceAverage
            // 
            this.lbInvoiceAverage.AutoSize = true;
            this.lbInvoiceAverage.Location = new System.Drawing.Point(474, 235);
            this.lbInvoiceAverage.Name = "lbInvoiceAverage";
            this.lbInvoiceAverage.Size = new System.Drawing.Size(151, 24);
            this.lbInvoiceAverage.TabIndex = 7;
            this.lbInvoiceAverage.Text = "Invoice Average:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(73, 400);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(124, 51);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(272, 400);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 51);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear Total";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(474, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 51);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // txtEnterSubtotal
            // 
            this.txtEnterSubtotal.Location = new System.Drawing.Point(232, 82);
            this.txtEnterSubtotal.Name = "txtEnterSubtotal";
            this.txtEnterSubtotal.Size = new System.Drawing.Size(100, 28);
            this.txtEnterSubtotal.TabIndex = 11;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(168, 126);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 28);
            this.txtSubtotal.TabIndex = 12;
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Location = new System.Drawing.Point(244, 183);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.Size = new System.Drawing.Size(100, 28);
            this.txtDiscountPercent.TabIndex = 13;
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(272, 236);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.Size = new System.Drawing.Size(100, 28);
            this.txtDiscountAmount.TabIndex = 14;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(168, 285);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 28);
            this.txtTotal.TabIndex = 15;
            // 
            // txtNumberOfInvoices
            // 
            this.txtNumberOfInvoices.Location = new System.Drawing.Point(700, 131);
            this.txtNumberOfInvoices.Name = "txtNumberOfInvoices";
            this.txtNumberOfInvoices.Size = new System.Drawing.Size(100, 28);
            this.txtNumberOfInvoices.TabIndex = 16;
            // 
            // txtTotalOfInvoices
            // 
            this.txtTotalOfInvoices.Location = new System.Drawing.Point(658, 183);
            this.txtTotalOfInvoices.Name = "txtTotalOfInvoices";
            this.txtTotalOfInvoices.Size = new System.Drawing.Size(100, 28);
            this.txtTotalOfInvoices.TabIndex = 17;
            // 
            // txtInvoicesAverage
            // 
            this.txtInvoicesAverage.Location = new System.Drawing.Point(658, 236);
            this.txtInvoicesAverage.Name = "txtInvoicesAverage";
            this.txtInvoicesAverage.Size = new System.Drawing.Size(100, 28);
            this.txtInvoicesAverage.TabIndex = 18;
            // 
            // lbLargestInvoice
            // 
            this.lbLargestInvoice.AutoSize = true;
            this.lbLargestInvoice.Location = new System.Drawing.Point(478, 284);
            this.lbLargestInvoice.Name = "lbLargestInvoice";
            this.lbLargestInvoice.Size = new System.Drawing.Size(136, 24);
            this.lbLargestInvoice.TabIndex = 19;
            this.lbLargestInvoice.Text = "Largest Invoice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Lowest Invoce";
            // 
            // txtLargestInvoice
            // 
            this.txtLargestInvoice.Location = new System.Drawing.Point(658, 284);
            this.txtLargestInvoice.Name = "txtLargestInvoice";
            this.txtLargestInvoice.Size = new System.Drawing.Size(100, 28);
            this.txtLargestInvoice.TabIndex = 21;
            // 
            // txtLowestInvoce
            // 
            this.txtLowestInvoce.Location = new System.Drawing.Point(658, 331);
            this.txtLowestInvoce.Name = "txtLowestInvoce";
            this.txtLowestInvoce.Size = new System.Drawing.Size(100, 28);
            this.txtLowestInvoce.TabIndex = 22;
            // 
            // frmInvoiceTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 859);
            this.Controls.Add(this.txtLowestInvoce);
            this.Controls.Add(this.txtLargestInvoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbLargestInvoice);
            this.Controls.Add(this.txtInvoicesAverage);
            this.Controls.Add(this.txtTotalOfInvoices);
            this.Controls.Add(this.txtNumberOfInvoices);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtEnterSubtotal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbInvoiceAverage);
            this.Controls.Add(this.lbTotalOfInvoices);
            this.Controls.Add(this.lbNumberOfInvoices);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbDiscountAmount);
            this.Controls.Add(this.lbDiscountPercent);
            this.Controls.Add(this.lbSubtotal);
            this.Controls.Add(this.lbEnterSubtotal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInvoiceTotal";
            this.Text = "Invoice Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEnterSubtotal;
        private System.Windows.Forms.Label lbSubtotal;
        private System.Windows.Forms.Label lbDiscountPercent;
        private System.Windows.Forms.Label lbDiscountAmount;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbNumberOfInvoices;
        private System.Windows.Forms.Label lbTotalOfInvoices;
        private System.Windows.Forms.Label lbInvoiceAverage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtEnterSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtNumberOfInvoices;
        private System.Windows.Forms.TextBox txtTotalOfInvoices;
        private System.Windows.Forms.TextBox txtInvoicesAverage;
        private System.Windows.Forms.Label lbLargestInvoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLargestInvoice;
        private System.Windows.Forms.TextBox txtLowestInvoce;
    }
}

