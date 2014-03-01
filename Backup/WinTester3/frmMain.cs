using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace WinTester3
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmMain : ShellLib.ApplicationDesktopToolbar
	{
		private System.Windows.Forms.GroupBox grpEdge;
		private System.Windows.Forms.RadioButton rdoFloat;
		private System.Windows.Forms.RadioButton rdoRight;
		private System.Windows.Forms.RadioButton rdoLeft;
		private System.Windows.Forms.RadioButton rdoBottom;
		private System.Windows.Forms.RadioButton rdoTop;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.grpEdge = new System.Windows.Forms.GroupBox();
			this.rdoFloat = new System.Windows.Forms.RadioButton();
			this.rdoRight = new System.Windows.Forms.RadioButton();
			this.rdoLeft = new System.Windows.Forms.RadioButton();
			this.rdoBottom = new System.Windows.Forms.RadioButton();
			this.rdoTop = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// grpEdge
			// 
			this.grpEdge.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.grpEdge.Location = new System.Drawing.Point(8, 8);
			this.grpEdge.Name = "grpEdge";
			this.grpEdge.Size = new System.Drawing.Size(72, 104);
			this.grpEdge.TabIndex = 3;
			this.grpEdge.TabStop = false;
			this.grpEdge.Text = "Edge";
			// 
			// rdoFloat
			// 
			this.rdoFloat.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.rdoFloat.Location = new System.Drawing.Point(12, 88);
			this.rdoFloat.Name = "rdoFloat";
			this.rdoFloat.Size = new System.Drawing.Size(64, 16);
			this.rdoFloat.TabIndex = 9;
			this.rdoFloat.Text = "Float";
			this.rdoFloat.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
			// 
			// rdoRight
			// 
			this.rdoRight.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.rdoRight.Location = new System.Drawing.Point(12, 72);
			this.rdoRight.Name = "rdoRight";
			this.rdoRight.Size = new System.Drawing.Size(64, 16);
			this.rdoRight.TabIndex = 8;
			this.rdoRight.Text = "Right";
			this.rdoRight.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
			// 
			// rdoLeft
			// 
			this.rdoLeft.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.rdoLeft.Location = new System.Drawing.Point(12, 56);
			this.rdoLeft.Name = "rdoLeft";
			this.rdoLeft.Size = new System.Drawing.Size(64, 16);
			this.rdoLeft.TabIndex = 7;
			this.rdoLeft.Text = "Left";
			this.rdoLeft.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
			// 
			// rdoBottom
			// 
			this.rdoBottom.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.rdoBottom.Location = new System.Drawing.Point(12, 40);
			this.rdoBottom.Name = "rdoBottom";
			this.rdoBottom.Size = new System.Drawing.Size(64, 16);
			this.rdoBottom.TabIndex = 6;
			this.rdoBottom.Text = "Bottom";
			this.rdoBottom.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
			// 
			// rdoTop
			// 
			this.rdoTop.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.rdoTop.Location = new System.Drawing.Point(12, 24);
			this.rdoTop.Name = "rdoTop";
			this.rdoTop.Size = new System.Drawing.Size(64, 16);
			this.rdoTop.TabIndex = 5;
			this.rdoTop.Text = "Top";
			this.rdoTop.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
			// 
			// frmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(88, 120);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.rdoFloat,
																		  this.rdoRight,
																		  this.rdoLeft,
																		  this.rdoBottom,
																		  this.rdoTop,
																		  this.grpEdge});
			this.Name = "frmMain";
			this.Text = "WinTester for Part 3";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmMain());
		}
				
		private void frmMain_Load(object sender, System.EventArgs e)
		{
			this.Edge = AppBarEdges.Left;
		}
				
		private void rdo_CheckedChanged(object sender, System.EventArgs e)
		{
			RadioButton rdo = sender as RadioButton;
			if (rdo.Checked)
			{
				switch (rdo.Text)
				{
					case "Bottom":
						this.Edge = AppBarEdges.Bottom;
						break;

					case "Top":
						this.Edge = AppBarEdges.Top;
						break;
					
					case "Left":
						this.Edge = AppBarEdges.Left;
						break;

					case "Right":
						this.Edge = AppBarEdges.Right;
						break;

					case "Float":
						this.Edge = AppBarEdges.Float;
						break;

				}
			}
		}
	
		
	}
}
