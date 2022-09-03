namespace FantasyRPGFutureValueMultiForm
{
    partial class frmValues
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.rxtValues = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 199);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(97, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "&Future Values";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // rxtValues
            // 
            this.rxtValues.Location = new System.Drawing.Point(9, 12);
            this.rxtValues.Name = "rxtValues";
            this.rxtValues.ReadOnly = true;
            this.rxtValues.Size = new System.Drawing.Size(1171, 181);
            this.rxtValues.TabIndex = 2;
            this.rxtValues.Text = "";
            this.rxtValues.WordWrap = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(133, 199);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmValues
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1192, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rxtValues);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmValues";
            this.Text = "frmValues";
            this.Load += new System.EventHandler(this.frmValues_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnCalculate;
        private RichTextBox rxtValues;
        private Button btnExit;
    }
}