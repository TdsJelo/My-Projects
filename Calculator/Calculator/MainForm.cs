using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
	public partial class MainForm : Form
	{
		double res = 0;
		string ops = "";
		bool value = false;	
		
		public MainForm()
		{
			InitializeComponent();
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void number_enter(object sender, EventArgs e)
		{
			Button x = (Button) sender;
			
			if ((textBox1.Text == "0") || (value))
			{
				textBox1.Text = "";
			    value = false;
			}
			if (x.Text == ".")
			{
				if (!textBox1.Text.Contains("."))
					textBox1.Text = textBox1.Text + x.Text;
			}
			else
			{
				textBox1.Text = textBox1.Text + x.Text;
			}
			
		}
		void basic_math(object sender, EventArgs e)
		{
			Button x = (Button) sender;
			
			if (res != 0)
			{
				button12.PerformClick();
				value = true;
				ops = x.Text;
				label1.Text = Convert.ToString(res) + "   " + ops;
			}
			else
			{
			
			ops = x.Text;
			res = Double.Parse(textBox1.Text);
			textBox1.Text= "";
			label1.Text = Convert.ToString(res) + "   " + ops;
			}
	
		}
		void Button16Click(object sender, EventArgs e)
		{
			textBox1.Text = "0";
			label1.Text = "";
		}
		void Button17Click(object sender, EventArgs e)
		{
			if (textBox1.Text.Length > 0)
			{
				textBox1.Text= textBox1.Text.Remove(textBox1.Text.Length -1,1);
			}
			if (textBox1.Text == "")
			{
				textBox1.Text = "0";
			}
		}
		void Button12Click(object sender, EventArgs e)
		{
			label1.Text = "";
			switch (ops)
			{
				case "+":
					textBox1.Text = (res + Double.Parse(textBox1.Text)).ToString();
					break;
				case "-":
					textBox1.Text = (res - Double.Parse(textBox1.Text)).ToString();
					break;
				case "*":
					textBox1.Text = (res * Double.Parse(textBox1.Text)).ToString();
					break;
				case "/":
					textBox1.Text = (res / Double.Parse(textBox1.Text)).ToString();
					break;
				case "%":
					textBox1.Text = (res % Double.Parse(textBox1.Text)).ToString();
					break;
				default:
					break;	                 
					                 
			}
			res = Double.Parse(textBox1.Text);
			ops = "";
		
		}
	}
}
