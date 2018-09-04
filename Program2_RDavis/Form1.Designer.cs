namespace Program2_RDavis
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
            this.lblListPrice = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtListPrice = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblTotalListPrice = new System.Windows.Forms.Label();
            this.lblTotalDiscountAmount = new System.Windows.Forms.Label();
            this.lblTotalTax = new System.Windows.Forms.Label();
            this.lblTotalNetPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblListPrice
            // 
            this.lblListPrice.AutoSize = true;
            this.lblListPrice.Location = new System.Drawing.Point(226, 47);
            this.lblListPrice.Name = "lblListPrice";
            this.lblListPrice.Size = new System.Drawing.Size(50, 13);
            this.lblListPrice.TabIndex = 0;
            this.lblListPrice.Text = "&List Price";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(447, 47);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(60, 13);
            this.lblDiscount.TabIndex = 2;
            this.lblDiscount.Text = "&Discount %";
            // 
            // txtListPrice
            // 
            this.txtListPrice.Location = new System.Drawing.Point(186, 73);
            this.txtListPrice.Name = "txtListPrice";
            this.txtListPrice.Size = new System.Drawing.Size(131, 20);
            this.txtListPrice.TabIndex = 1;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(412, 73);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(131, 20);
            this.txtDiscount.TabIndex = 3;
            // 
            // lblTotalListPrice
            // 
            this.lblTotalListPrice.Location = new System.Drawing.Point(80, 195);
            this.lblTotalListPrice.Name = "lblTotalListPrice";
            this.lblTotalListPrice.Size = new System.Drawing.Size(100, 23);
            this.lblTotalListPrice.TabIndex = 8;
            this.lblTotalListPrice.Text = "0.00";
            this.lblTotalListPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalDiscountAmount
            // 
            this.lblTotalDiscountAmount.Location = new System.Drawing.Point(250, 195);
            this.lblTotalDiscountAmount.Name = "lblTotalDiscountAmount";
            this.lblTotalDiscountAmount.Size = new System.Drawing.Size(100, 23);
            this.lblTotalDiscountAmount.TabIndex = 10;
            this.lblTotalDiscountAmount.Text = "0.00";
            this.lblTotalDiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalTax
            // 
            this.lblTotalTax.Location = new System.Drawing.Point(408, 195);
            this.lblTotalTax.Name = "lblTotalTax";
            this.lblTotalTax.Size = new System.Drawing.Size(100, 23);
            this.lblTotalTax.TabIndex = 12;
            this.lblTotalTax.Text = "0.00";
            this.lblTotalTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalNetPrice
            // 
            this.lblTotalNetPrice.Location = new System.Drawing.Point(547, 195);
            this.lblTotalNetPrice.Name = "lblTotalNetPrice";
            this.lblTotalNetPrice.Size = new System.Drawing.Size(100, 23);
            this.lblTotalNetPrice.TabIndex = 14;
            this.lblTotalNetPrice.Text = "0.00";
            this.lblTotalNetPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total List Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total Discount Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total Tax";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total Net Price";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(134, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 21);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Add to Totals";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(321, 299);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 21);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(508, 299);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 21);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalNetPrice);
            this.Controls.Add(this.lblTotalTax);
            this.Controls.Add(this.lblTotalDiscountAmount);
            this.Controls.Add(this.lblTotalListPrice);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtListPrice);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblListPrice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListPrice;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtListPrice;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblTotalListPrice;
        private System.Windows.Forms.Label lblTotalDiscountAmount;
        private System.Windows.Forms.Label lblTotalTax;
        private System.Windows.Forms.Label lblTotalNetPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

