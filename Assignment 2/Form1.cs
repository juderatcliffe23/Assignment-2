﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // calculate the resistance of 2 resistors in series 
            try
            {
                double R1, R2, Resistance;
                R1 = Convert.ToDouble(textBox1.Text);
                R2 = Convert.ToDouble(textBox2.Text);
                Resistance = R1 + R2;
                label3.Text = "Resistance =" + Resistance;
            }
            catch
            {
                MessageBox.Show("Error. Use a number");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //calculate the resistance of 3 resistors in a series
            try
            {
                double R1, R2, R3, Resistance;
                R1 = Convert.ToDouble(textBox3.Text);
                R2 = Convert.ToDouble(textBox4.Text);
                R3 = Convert.ToDouble(textBox5.Text);
                Resistance = R1 + R2 + R3;
                label7.Text = "Resistance =" + Resistance;
            }
            catch
            {
                MessageBox.Show("Error. Use a number");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //calculate the resistance of 4 resistors in a series
            try
            {
                double R1, R2, R3, R4, Resistance;
                R1 = Convert.ToDouble(textBox6.Text);
                R2 = Convert.ToDouble(textBox7.Text);
                R3 = Convert.ToDouble(textBox8.Text);
                R4 = Convert.ToDouble(textBox9.Text);
                Resistance = R1 + R2 + R3 + R4;
                label12.Text = "Resistance =" + Resistance;
            }
            catch
            {
                MessageBox.Show("Error. Use a number");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //calculate the resistance of 5 resistors in a series
            try
            {
                double R1, R2, R3, R4, R5, Resistance;
                R1 = Convert.ToDouble(textBox10.Text);
                R2 = Convert.ToDouble(textBox11.Text);
                R3 = Convert.ToDouble(textBox12.Text);
                R4 = Convert.ToDouble(textBox13.Text);
                R5 = Convert.ToDouble(textBox14.Text);
                Resistance = R1 + R2 + R3 + R4 + R5;
                label18.Text = "Resistance =" + Resistance;
            }
            catch
            {
                MessageBox.Show("Error. Use a number");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //calculate the resistance of 2 resistors in parallel
            try
            {
                double R1, R2, Resistance;
                R1 = Convert.ToDouble(textBox15.Text);
                R2 = Convert.ToDouble(textBox16.Text);
                Resistance = 1 / (1 / R1 + 1 / R2);
                label21.Text = "Resistance =" + Resistance;
            }
            catch
            {
                MessageBox.Show("Error. Use a number");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //calculate the resistance of 3 resistors in parallel
            try
            {
                double R1, R2, R3, Resistance;
                R1 = Convert.ToDouble(textBox17.Text);
                R2 = Convert.ToDouble(textBox18.Text);
                R3 = Convert.ToDouble(textBox19.Text);
                Resistance = 1 / (1 / R1 + 1 / R2 + 1 / R3);
                label25.Text = "Resistance =" + Resistance;
            }
            catch
            {
                MessageBox.Show("Error. Use a number");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //calculate the resistance of 4 resistors in parallel
            try
            {
                double R1, R2, R3, R4, Resistance;
                R1 = Convert.ToDouble(textBox20.Text);
                R2 = Convert.ToDouble(textBox21.Text);
                R3 = Convert.ToDouble(textBox22.Text);
                R4 = Convert.ToDouble(textBox23.Text);
                Resistance = 1 / (1 / R1 + 1 / R2 + 1 / R3 + 1 / R4);
                label30.Text = "Resistance =" + Resistance;
            }
            catch
            {
                MessageBox.Show("Error. Use a number");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //calculate the resistance of 5 resistors in parallel
            try
            {
                double R1, R2, R3, R4, R5, Resistance;
                R1 = Convert.ToDouble(textBox24.Text);
                R2 = Convert.ToDouble(textBox25.Text);
                R3 = Convert.ToDouble(textBox26.Text);
                R4 = Convert.ToDouble(textBox27.Text);
                R5 = Convert.ToDouble(textBox28.Text);
                Resistance = 1 / (1 / R1 + 1 / R2 + 1 / R3 + 1 / R4 + 1 / R5);
                label36.Text = "Resistance =" + Resistance;
            }
            catch
            {
                MessageBox.Show("Error. Use a number");
            }
        }
    }
}
