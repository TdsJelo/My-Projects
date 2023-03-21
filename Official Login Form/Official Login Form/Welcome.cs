/*
 * Created by SharpDevelop.
 * User: JELO
 * Date: 22/09/2022
 * Time: 11:33 am
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Official_Login_Form
{
	/// <summary>
	/// Description of Welcome.
	/// </summary>
	public partial class Welcome : Form
	{
		public Welcome()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label1Click(object sender, EventArgs e)
		{
			label1.BackColor = Color.FromArgb(100, 0, 0, 0);
		}
		void WelcomeLoad(object sender, EventArgs e)
		{
	
		}
	}
}
