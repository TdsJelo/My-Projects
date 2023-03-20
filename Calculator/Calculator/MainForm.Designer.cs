/*
 * Created by SharpDevelop.
 * User: JELO
 * Date: 27/09/2022
 * Time: 3:52 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Calculator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Button button19;
		private System.Windows.Forms.Label label1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.button16 = new System.Windows.Forms.Button();
			this.button17 = new System.Windows.Forms.Button();
			this.button18 = new System.Windows.Forms.Button();
			this.button19 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(24, 54);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(538, 91);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "0";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(162, 611);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(117, 73);
			this.button1.TabIndex = 1;
			this.button1.Text = "0";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.number_enter);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(24, 493);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(117, 73);
			this.button2.TabIndex = 2;
			this.button2.Text = "1";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.number_enter);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(162, 493);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(117, 73);
			this.button3.TabIndex = 3;
			this.button3.Text = "2";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.number_enter);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(302, 493);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(117, 73);
			this.button4.TabIndex = 4;
			this.button4.Text = "3";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.number_enter);
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(24, 376);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(117, 73);
			this.button5.TabIndex = 5;
			this.button5.Text = "4";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.number_enter);
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(162, 376);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(117, 73);
			this.button6.TabIndex = 6;
			this.button6.Text = "5";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.number_enter);
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.Location = new System.Drawing.Point(302, 376);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(117, 73);
			this.button7.TabIndex = 7;
			this.button7.Text = "6";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.number_enter);
			// 
			// button8
			// 
			this.button8.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.Location = new System.Drawing.Point(24, 268);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(117, 73);
			this.button8.TabIndex = 8;
			this.button8.Text = "7";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.number_enter);
			// 
			// button9
			// 
			this.button9.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button9.Location = new System.Drawing.Point(162, 268);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(117, 73);
			this.button9.TabIndex = 9;
			this.button9.Text = "8";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.number_enter);
			// 
			// button10
			// 
			this.button10.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button10.Location = new System.Drawing.Point(302, 268);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(117, 73);
			this.button10.TabIndex = 10;
			this.button10.Text = "9";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.number_enter);
			// 
			// button11
			// 
			this.button11.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button11.Location = new System.Drawing.Point(302, 611);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(117, 73);
			this.button11.TabIndex = 11;
			this.button11.Text = ".";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.number_enter);
			// 
			// button12
			// 
			this.button12.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button12.Location = new System.Drawing.Point(445, 611);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(117, 73);
			this.button12.TabIndex = 12;
			this.button12.Text = "=";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.Button12Click);
			// 
			// button13
			// 
			this.button13.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button13.Location = new System.Drawing.Point(445, 493);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(117, 73);
			this.button13.TabIndex = 13;
			this.button13.Text = "+";
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Click += new System.EventHandler(this.basic_math);
			// 
			// button14
			// 
			this.button14.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button14.Location = new System.Drawing.Point(445, 376);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(117, 73);
			this.button14.TabIndex = 14;
			this.button14.Text = "-";
			this.button14.UseVisualStyleBackColor = true;
			this.button14.Click += new System.EventHandler(this.basic_math);
			// 
			// button15
			// 
			this.button15.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button15.Location = new System.Drawing.Point(445, 268);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(117, 73);
			this.button15.TabIndex = 15;
			this.button15.Text = "*";
			this.button15.UseVisualStyleBackColor = true;
			this.button15.Click += new System.EventHandler(this.basic_math);
			// 
			// button16
			// 
			this.button16.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button16.Location = new System.Drawing.Point(24, 169);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(117, 73);
			this.button16.TabIndex = 16;
			this.button16.Text = "CE";
			this.button16.UseVisualStyleBackColor = true;
			this.button16.Click += new System.EventHandler(this.Button16Click);
			// 
			// button17
			// 
			this.button17.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button17.Location = new System.Drawing.Point(162, 169);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(117, 73);
			this.button17.TabIndex = 17;
			this.button17.Text = "⌫";
			this.button17.UseVisualStyleBackColor = true;
			this.button17.Click += new System.EventHandler(this.Button17Click);
			// 
			// button18
			// 
			this.button18.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button18.Location = new System.Drawing.Point(302, 169);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(117, 73);
			this.button18.TabIndex = 18;
			this.button18.Text = "%";
			this.button18.UseVisualStyleBackColor = true;
			this.button18.Click += new System.EventHandler(this.basic_math);
			// 
			// button19
			// 
			this.button19.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button19.Location = new System.Drawing.Point(445, 169);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(117, 73);
			this.button19.TabIndex = 19;
			this.button19.Text = "/";
			this.button19.UseVisualStyleBackColor = true;
			this.button19.Click += new System.EventHandler(this.basic_math);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(302, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(250, 29);
			this.label1.TabIndex = 20;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGray;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(584, 712);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button19);
			this.Controls.Add(this.button18);
			this.Controls.Add(this.button17);
			this.Controls.Add(this.button16);
			this.Controls.Add(this.button15);
			this.Controls.Add(this.button14);
			this.Controls.Add(this.button13);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm";
			this.Text = "Calculator";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
