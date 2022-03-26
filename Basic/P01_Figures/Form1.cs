using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01_Figures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Shape Area Calculator";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double area = 0;
            double perimeters=0;
            string shape = string.Empty;
            if (rbTriangle.Checked && radioButton2.Checked)
            {
                double a = double.Parse(tbFirstInput.Text);
                double ha = double.Parse(tbSecondInput.Text);
                area = a * ha / 2;
                shape = rbTriangle.Text;
            }
            else if (rbSquare.Checked && radioButton2.Checked)
            {
                double a = double.Parse(tbFirstInput.Text);
                area = a * a;
                shape = rbSquare.Text;
            }
            else if (rbRectangle.Checked && radioButton2.Checked)
            {
                double a = double.Parse(tbFirstInput.Text);
                double b = double.Parse(tbSecondInput.Text);
                area = a * b;
                shape = rbRectangle.Text;
            }
            else if(rbTriangle.Checked && radioButton1.Checked)
            {
                double a = double.Parse(tbFirstInput.Text);
                double b = double.Parse(tbSecondInput.Text);
                double c = double.Parse(tbThirdInput.Text);
                perimeters = a + b + c;
                shape=rbTriangle.Text;
            }
            else if (rbSquare.Checked && radioButton1.Checked)
            {
                double a = double.Parse(tbFirstInput.Text);
                perimeters = a + a + a + a;
                shape = rbSquare.Text;
            }
            else if(rbRectangle.Checked && radioButton1.Checked)
            {
                double a = double.Parse(tbFirstInput.Text);
                double b = double.Parse(tbSecondInput.Text);
                perimeters = (a + b) * 2;
                shape= rbRectangle.Text;
            }
            else if(rbCircle.Checked && radioButton2.Checked)
            {
                double r = double.Parse(tbFirstInput.Text);
                area = (22 / r) * r * r;
            }
            arealb.Text = $"{shape} area: {area:f3}";
            perimeter.Text = $"{shape} perimeter: {perimeters:f3}";
        }
        private void rbSquare_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        private void rbTriangle_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        private void rbRectangle_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
       

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            perimeterResult.Visible = false;
            perimeter.Visible = false;
            areaResult.Visible = true;
            arealb.Visible = true;
            tbThirdInput.Visible = false;
            labelThirdInput.Visible = false;
            if (rbCircle.Checked)
            {
                label1.Visible = true;
                tbFirstInput.Visible = true;
                label1.Text = "r=";
                labelSecondInput.Visible = false;
                tbSecondInput.Visible = false;
                tbThirdInput.Visible = false;
                labelThirdInput.Visible = false;
            }
            else if (rbTriangle.Checked)
            {
                labelSecondInput.Text = "ha=";
                label1.Text = "a=";
                labelThirdInput.Visible = false;
                tbThirdInput.Visible = false;
            }
            else if (rbRectangle.Checked)
            {
                label1.Text = "a=";
                labelSecondInput.Text = "b=";
                labelSecondInput.Visible = true;
                tbSecondInput.Visible = true;
                labelThirdInput.Visible = false;
                tbThirdInput.Visible = false;
            }
            else if (rbSquare.Checked)
            {
                labelSecondInput.Visible = false;
                tbSecondInput.Visible = false;
                labelThirdInput.Visible = false;
                tbThirdInput.Visible = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            areaResult.Visible = false;
            arealb.Visible=false;
            perimeterResult.Visible = true;
            perimeter.Visible = true;
            tbThirdInput.Visible = true;
            labelThirdInput.Visible = true;
            if (rbTriangle.Checked)
            {
                labelSecondInput.Text = "  b=";
                labelThirdInput.Visible = true;
                tbThirdInput.Visible = true;
            }
            else if (rbSquare.Checked)
            {
                labelSecondInput.Visible = false;
                tbSecondInput.Visible = false;
                labelThirdInput.Visible = false;
                tbThirdInput.Visible = false;
            }
            else if (rbCircle.Checked)
            {
                label1.Visible = false;
                labelSecondInput.Visible = false;
                labelThirdInput.Visible = false;
                tbFirstInput.Visible = false;
                tbSecondInput.Visible = false;
                tbThirdInput.Visible = false;
            }
            else if (rbRectangle.Checked)
            {
                labelSecondInput.Visible = true;
                tbSecondInput.Visible = true;
                labelThirdInput.Visible=false;
                tbThirdInput.Visible = false;
            }
        }

        private void rbCircle_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

       
    }
}
