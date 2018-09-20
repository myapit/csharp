/*
 * Created by SharpDevelop.
 * User: domokun
 * Date: 2018-09-19
 * Time: 1:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HiWorld
{
	/// <summary>
	/// Description of MDIForm.
	/// </summary>
	public partial class MDIForm : Form
	{
		public MDIForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			statusStrip1.Items[0].Text = "ver:"+Application.ProductVersion;
			statusStrip1.Items[2].Text = DateTime.Today.ToString();
			
		}
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			DialogResult confirm = MessageBox.Show("Are you sure to close this application ?","Exit App", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
			if (confirm == DialogResult.Yes)
			{
				System.Windows.Forms.Application.Exit();
			}
		}
		void OpenMainFormToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form MForm = new MainForm();
			MForm.MdiParent = this;
			MForm.Show();
		}
		void OpenForm2ToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form frm1 = new Form2();
			frm1.MdiParent = this;
			frm1.Show();
		}
	}
}
