/*
 * Created by SharpDevelop.
 * User: domokun
 * Date: 2018-09-14
 * Time: 3:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;


namespace HiWorld
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
			// /Version versionInfo = Assembly.GetExecutingAssembly().GetName().Version;
			
			//statusStrip1.Items[0].Alignment = Right;
			statusStrip1.Items[0].Text = "ver:"+Application.ProductVersion;
			statusStrip1.Items[2].Text = DateTime.Today.ToString();
			 
		}
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show(textBox1.Text,"hi",MessageBoxButtons.OK);
			label1.Text = textBox1.Text;
			Class1.createDB();
			Class1.barGen();
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void StatusStrip1ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
	
		}
		
		
		
	}
}
