using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FantasyRPGFutureValueMultiForm
{
    public partial class frmValues : Form
    {
        public frmValues()
        {
            InitializeComponent();
        }

        private void frmValues_Load(object sender, EventArgs e)
        {
            rxtValues.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Form futureValuesForm = new frmFutureValue();
            DialogResult result = futureValuesForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                List<(string, string, string, string, string, string, string, string, string)> values = new();
                if (futureValuesForm.Tag != null && (futureValuesForm.Tag.ToString() != null && futureValuesForm.Tag.ToString() != ""))
                {
                    string[] temp = futureValuesForm.Tag.ToString().Split("\n");
                    for (int i = 0; i < temp.Length; i++)
                    {
                        if (temp[i] != "")
                        {
                            string[] temp2 = temp[i].Split("\t");
                            if (temp2[0] != "")
                            {
                                values.Add((temp2[0], temp2[1], temp2[2], temp2[3], temp2[4], temp2[5], temp2[6], temp2[7], temp2[8]));
                            }
                        }
                    }
                }

                string temp3 = "";
                for (int i = 0; i < values.Count; i++)
                {
                    if (i == 0 || (i % 2 == 0))
                    {
                        temp3 += "";
                        temp3 += values[i].Item1 + "\t" + values[i].Item2 + "\t" + values[i].Item3 + "\t" + values[i].Item4 + "\t\t" + values[i].Item5 + "\t" + values[i].Item6 + "\t" + values[i].Item7 + "\t\t" + values[i].Item8 + "\t\t" + values[i].Item9 + "\n";
                    }
                    else
                    {
                         temp3 += values[i].Item1 + "\t\t" + values[i].Item2 + "\t\t" + values[i].Item3 + "\t\t" + values[i].Item4 + "\t\t" + values[i].Item5 + "\t" + values[i].Item6 + "\t\t" + values[i].Item7 + "\t\t" + values[i].Item8 + "\t\t" + values[i].Item9 + "\n";
                    }
                }
                rxtValues.Text = temp3;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
