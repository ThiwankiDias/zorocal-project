using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        string operation = "";
        double result_value = 0.0;
        bool is_operation_performed= false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if (result_textBox.Text == "0" || is_operation_performed ==true)
            {
                result_textBox.Clear();
            }
            Button btn = (Button)sender;
            if (btn.Text == ".")
            {
                if (!result_textBox.Text.Contains("."))
                {
                    result_textBox.Text = result_textBox.Text + btn.Text;
                }
                
            }
            else
            {
                result_textBox.Text = result_textBox.Text + btn.Text;
            }
           
            is_operation_performed = false;
        }

        private void operation_performed(object sender, EventArgs e)
        {
            if(result_value != 0)
            {
                btnEqual.PerformClick();
                Button btn = (Button)sender;
                operation = btn.Text;
                result_value = double.Parse(result_textBox.Text);
                label.Text = result_value + operation;
                is_operation_performed = true;
                result_textBox.Text = "0";
            }
            else
            {
                Button btn = (Button)sender;
                operation = btn.Text;
                result_value = double.Parse(result_textBox.Text);
                label.Text = result_value + operation;
                is_operation_performed = true;
                result_textBox.Text = "0";
            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            result_textBox.Text = "0";
            label.Text = "";
            result_value = 0;
        }

        private void clearEntry_Click(object sender, EventArgs e)
        {
            result_textBox.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    result_textBox.Text = (result_value + double.Parse(result_textBox.Text)).ToString();
                    break;
                case "-":
                    result_textBox.Text = (result_value - double.Parse(result_textBox.Text)).ToString();
                    break;
                case "*":
                    result_textBox.Text = (result_value * double.Parse(result_textBox.Text)).ToString();
                    break;
                case "/":
                    result_textBox.Text = (result_value / double.Parse(result_textBox.Text)).ToString();
                    break;

            }
        }
    }
}
