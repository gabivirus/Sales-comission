using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sells_Comission
{
    public partial class comCalculator : Form
    {
        public comCalculator()
        {
            InitializeComponent();
        }

        private void comCalc_Click(object sender, EventArgs e)
        {
            comCalculation Calculation = new comCalculation();

            double first_Price = double.Parse(firstValueInput.Text);

            int product_Type = 0;

            if (radioA.Checked) product_Type = 1;
            else if (radioB.Checked) product_Type = 2;
            else product_Type = 3;

            double result = Calculation.FinalPriceCalc(first_Price, product_Type);

            comValue.Text = result.ToString();
        }
    }
}
