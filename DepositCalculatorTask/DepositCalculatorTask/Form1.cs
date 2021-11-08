using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepositCalculatorTask
{
    public partial class Form1 : Form
    {

        string rbText;
        public Form1()
        {
            InitializeComponent();
            labelPercent.Text = "Deposit calculator with percent = 15%";
            labelResult.Visible = false;
        }

        private void buttonCalculateDeposit_Click(object sender, EventArgs e)
        {
            string sum = textBoxStartSum.Text;
            string period = comboBoxPeriod.Text;
            decimal resultSum;


            try
            {
                DepositCalculator depositCalculator = new DepositCalculator(sum, period);
                if (comboBoxMethod.Text == "Capitalization")
                {
                    resultSum = depositCalculator.CalculateDepositCapitalization();
                }
                else
                {
                    resultSum = depositCalculator.CalculateDepositMonthPayout();
                }
                labelResult.Text = "Result sum you will get is " + resultSum + rbText;
                labelResult.Visible = true;
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show("Incorrect startsum or period value, please check it");
            }
            
        
            

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            comboBoxPeriod.Text = String.Empty;
            textBoxStartSum.Text = String.Empty;
            labelPercent.Text = "Deposit calculator with percent = 15%";
            labelResult.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (RadioButton rb in this.Controls.OfType<RadioButton>())
                rb.CheckedChanged += new EventHandler(rb_CheckedChanged);
        }

         void rb_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                rbText = (sender as RadioButton).Text;
        }
    }
}
