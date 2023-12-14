using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.States;

namespace Calculator
{
    public partial class Form1 : Form
    {
        readonly CalculatorFunction CalculatorObject = new CalculatorFunction();

        public Form1()
        {
            InitializeComponent();
            OutputLabel.Text = Signs.ZERO;
        }

        public void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            CalculatorObject.Press(button.Tag.ToString(), button.Text);

            TopLabel.Text = CalculatorObject.GetToplabel();
            OutputLabel.Text = CalculatorObject.GetOutputlabel();
        }

    }
}
