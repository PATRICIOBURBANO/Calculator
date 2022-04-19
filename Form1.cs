using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string? Operand;
        double Outcome;
        double LastNumber;
        private double StoredNumber { get; set; }
      




        public Form1()
        {
            StoredNumber = 0;
            
            InitializeComponent();
        }


        private void n1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                // textBox2.Text += "1";
                textBox1.Text += "1";
            }

        }

        private void n2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }

        }
        private void n3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }

        }

        private void n4_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void n5_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void n6_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }

        }

        private void n7_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }

        }

        private void n8_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }

        }

        private void n9_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }


        private void n0_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void nPlus_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                textBox1.Text = StoredNumber.ToString();
            }
            else
            {
                Outcome = StoredNumber + Convert.ToDouble(textBox1.Text);
                textBox2.Text += textBox1.Text + "+";
                Operand = "+";
                StoredNumber = Outcome;
                textBox1.Text = "";
            }

        }

        private void nMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = StoredNumber.ToString();
            }
            else
            {
                Outcome = StoredNumber - (Convert.ToDouble(textBox1.Text)*-1);
                textBox2.Text += textBox1.Text + "-";
                Operand = "-";
                StoredNumber = Outcome;
                textBox1.Text = "";
            }



        }

        private void nFor_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = StoredNumber.ToString();
            }
            else
            {
                Outcome = Convert.ToDouble(textBox1.Text);
                textBox2.Text = textBox1.Text + "*";
                Operand = "*";
                StoredNumber = Outcome;
                textBox1.Text = "";

            }


        }
        private void nDiv_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = StoredNumber.ToString();
            }
            else
            {
                Outcome = Convert.ToDouble(textBox1.Text);
                textBox2.Text = textBox1.Text + "÷";
                Operand = "/";
                StoredNumber = Outcome;
                textBox1.Text = "";
            }


        }
        private void nDot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";

        }

        private void bc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            StoredNumber = 0;
            Outcome = 0;
        }


        private void nEqual_Click(object sender, EventArgs e)
        {


            if (Operand == "+")
            {
                LastNumber = Convert.ToDouble(textBox1.Text);
                StoredNumber = Outcome + Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Round(StoredNumber, 2).ToString("#.00"));


            }
            if (Operand == "-")
            {
                LastNumber = Convert.ToDouble(textBox1.Text);
                StoredNumber = Outcome - Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Round(StoredNumber, 2).ToString("#.00"));

            }
            if (Operand == "*")
            {
                LastNumber = Convert.ToDouble(textBox1.Text);
                StoredNumber = Outcome * Convert.ToDouble(LastNumber);
                textBox1.Text = Convert.ToString(Math.Round(StoredNumber, 2).ToString("#.00"));

            }
            if (Operand == "/")
            {
                if (Convert.ToDouble(textBox1.Text) == 0)
                {
                    textBox1.Text = "Err Div/Zero";

                }
                else
                {
                    LastNumber = Convert.ToDouble(textBox1.Text);
                    StoredNumber = Outcome / Convert.ToDouble(LastNumber);
                    textBox1.Text = Convert.ToString(Math.Round(StoredNumber, 2).ToString("#.00"));

                    ;
                }
            }
            textBox2.Text = textBox2.Text + LastNumber.ToString() + " = " + StoredNumber.ToString();
            Outcome = 0;


        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }



        private void btnLoc_Click(object sender, EventArgs e)
        {

        }

        private void btnBinary_Click(object sender, EventArgs e)
        {

            try
            {
                int number = int.Parse(textBox1.Text);
                if (number > Int32.MinValue && number < Int32.MaxValue)
                {
                    textBox1.Text = Convert.ToString(number, 2).ToString();
                }
            }
            catch (Exception)
            {

                textBox1.Text = "ERROR";

            }

        }

        private void btnDecimall_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Convert.ToInt32(textBox1.Text, 2).ToString();
            }
            catch (Exception )
            {
                textBox1.Text = "ERROR";

            }

        }


    }
    
}