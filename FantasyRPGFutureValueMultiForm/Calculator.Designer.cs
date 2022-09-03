﻿namespace FantasyRPGFutureValueMultiForm
{
    partial class frmFutureValue
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMonthlyGold = new System.Windows.Forms.TextBox();
            this.txtMonthlySilver = new System.Windows.Forms.TextBox();
            this.txtMonthlyCopper = new System.Windows.Forms.TextBox();
            this.txtValueGold = new System.Windows.Forms.TextBox();
            this.txtValueSilver = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValueCopper = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cboYears = new System.Windows.Forms.ComboBox();
            this.cboMonths = new System.Windows.Forms.ComboBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly Investment (Gold Pieces):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monthly Investment (Silver Piecesz):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Monthly Investment (Copper Pieces):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Annual Interest Rate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Number of Years:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Number of Months Per Year:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(32, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "1 gp = 10 sp && 1 sp = 10 cp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total Value Gold:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total Value Silver:";
            // 
            // txtMonthlyGold
            // 
            this.txtMonthlyGold.Location = new System.Drawing.Point(277, 36);
            this.txtMonthlyGold.Name = "txtMonthlyGold";
            this.txtMonthlyGold.Size = new System.Drawing.Size(100, 23);
            this.txtMonthlyGold.TabIndex = 1;
            this.txtMonthlyGold.Tag = "Monthly Gold";
            // 
            // txtMonthlySilver
            // 
            this.txtMonthlySilver.Location = new System.Drawing.Point(277, 73);
            this.txtMonthlySilver.Name = "txtMonthlySilver";
            this.txtMonthlySilver.Size = new System.Drawing.Size(100, 23);
            this.txtMonthlySilver.TabIndex = 2;
            this.txtMonthlySilver.Tag = "Monthly Silver";
            // 
            // txtMonthlyCopper
            // 
            this.txtMonthlyCopper.Location = new System.Drawing.Point(277, 109);
            this.txtMonthlyCopper.Name = "txtMonthlyCopper";
            this.txtMonthlyCopper.Size = new System.Drawing.Size(100, 23);
            this.txtMonthlyCopper.TabIndex = 3;
            this.txtMonthlyCopper.Tag = "Monthly Copper";
            // 
            // txtValueGold
            // 
            this.txtValueGold.Location = new System.Drawing.Point(277, 260);
            this.txtValueGold.Name = "txtValueGold";
            this.txtValueGold.ReadOnly = true;
            this.txtValueGold.Size = new System.Drawing.Size(100, 23);
            this.txtValueGold.TabIndex = 7;
            this.txtValueGold.Tag = "Total Gold";
            // 
            // txtValueSilver
            // 
            this.txtValueSilver.Location = new System.Drawing.Point(277, 296);
            this.txtValueSilver.Name = "txtValueSilver";
            this.txtValueSilver.ReadOnly = true;
            this.txtValueSilver.Size = new System.Drawing.Size(100, 23);
            this.txtValueSilver.TabIndex = 8;
            this.txtValueSilver.Tag = "Total Silver";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total Value Copper:";
            // 
            // txtValueCopper
            // 
            this.txtValueCopper.Location = new System.Drawing.Point(277, 331);
            this.txtValueCopper.Name = "txtValueCopper";
            this.txtValueCopper.ReadOnly = true;
            this.txtValueCopper.Size = new System.Drawing.Size(100, 23);
            this.txtValueCopper.TabIndex = 9;
            this.txtValueCopper.Tag = "Total Copper";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(113, 371);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(302, 371);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cboYears
            // 
            this.cboYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYears.FormattingEnabled = true;
            this.cboYears.Location = new System.Drawing.Point(277, 189);
            this.cboYears.Name = "cboYears";
            this.cboYears.Size = new System.Drawing.Size(100, 23);
            this.cboYears.TabIndex = 14;
            // 
            // cboMonths
            // 
            this.cboMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonths.FormattingEnabled = true;
            this.cboMonths.Location = new System.Drawing.Point(277, 225);
            this.cboMonths.Name = "cboMonths";
            this.cboMonths.Size = new System.Drawing.Size(100, 23);
            this.cboMonths.TabIndex = 15;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(277, 148);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 23);
            this.txtRate.TabIndex = 16;
            // 
            // frmFutureValue
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(408, 415);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.cboMonths);
            this.Controls.Add(this.cboYears);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtValueCopper);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtValueSilver);
            this.Controls.Add(this.txtValueGold);
            this.Controls.Add(this.txtMonthlyCopper);
            this.Controls.Add(this.txtMonthlySilver);
            this.Controls.Add(this.txtMonthlyGold);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFutureValue";
            this.Text = "Fantasy RPG Future Value Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtMonthlyGold;
        private TextBox txtMonthlySilver;
        private TextBox txtMonthlyCopper;
        private TextBox txtValueGold;
        private TextBox txtValueSilver;
        private Label label10;
        private TextBox txtValueCopper;
        private Button btnCalculate;
        private Button btnExit;
        private ComboBox cboYears;
        private ComboBox cboMonths;
        private TextBox txtRate;
    }
}