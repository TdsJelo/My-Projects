/*
 * Created by SharpDevelop.
 * User: JELO
 * Date: 22/09/2022
 * Time: 10:55 am
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Official_Login_Form
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Panel1Paint(object sender, PaintEventArgs e)
		{
			panel1.BackColor = Color.FromArgb(75, 0, 0,0);
		}
		void Button1Click(object sender, EventArgs e)
		{
			string a, b, user, pass;
			a = "Jelo";
			b = "TDS";
			user = Convert.ToString(textBox1.Text);
			pass = Convert.ToString(textBox2.Text);
			
			if (user==a && pass==b){
				MessageBox.Show("Login was successful");
				Welcome gi = new Welcome();
				gi.Show();
				this.Hide();
			}
			else if (user!=a && pass==b){
				MessageBox.Show("Your username was incorrect");
			}
			else if (user==a && pass!=b){
				MessageBox.Show("Your password was incorrect");
			}
			else if (user!=a && pass!=b){
				MessageBox.Show("Your account was not found");
				{
					
				}
				                
			}
				                
				}
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked==true)
			{
				textBox2.UseSystemPasswordChar=false;
			}
			else
			{
				textBox2.UseSystemPasswordChar=true;
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
			}
		}

