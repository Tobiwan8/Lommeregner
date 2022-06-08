using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lommeregner
{
    public partial class Lommeregner : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Lommeregner()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if((txt_tekst.Text == "0") || (isOperationPerformed))
            {
                txt_tekst.Clear();
            }
            isOperationPerformed = false;
            Button button = (Button)sender;

            /*if (button.Text == ".")
            {
                if(!txt_tekst.Text.Contains("."))
                {
                    txt_tekst.Text += button.Text;
                }
            }
            else*/
            txt_tekst.Text += button.Text;
        }

        private void Operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = double.Parse(txt_tekst.Text);
            lbl_currentOperation.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
        }

        private void ClearEverything(object sender, EventArgs e)
        {
            txt_tekst.Text = "0";
        }

        private void Clear(object sender, EventArgs e)
        {
            txt_tekst.Text = "0";
            resultValue = 0;
        }

        private void Operator_equals(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    txt_tekst.Text = (resultValue + Double.Parse(txt_tekst.Text)).ToString();
                    break;
                case "-":
                    txt_tekst.Text = (resultValue - Double.Parse(txt_tekst.Text)).ToString();
                    break;
                case "*":
                    txt_tekst.Text = (resultValue * Double.Parse(txt_tekst.Text)).ToString();
                    break;
                case "/":
                    txt_tekst.Text = (resultValue / Double.Parse(txt_tekst.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
