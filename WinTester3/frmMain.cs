using System;
using System.Drawing;
using System.Collections;
using System.Diagnostics;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;


namespace WinTester3
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmMain : ShellLib.ApplicationDesktopToolbar
    {
		private System.Windows.Forms.RadioButton rdoFloat;
		private System.Windows.Forms.RadioButton rdoRight;
		private System.Windows.Forms.RadioButton rdoLeft;
		private System.Windows.Forms.RadioButton rdoBottom;
		private System.Windows.Forms.RadioButton rdoTop;
        private Button button1;
        private PictureBox pictureBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
        /// 


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.button1 = new System.Windows.Forms.Button();
            this.rdoFloat = new System.Windows.Forms.RadioButton();
            this.rdoRight = new System.Windows.Forms.RadioButton();
            this.rdoLeft = new System.Windows.Forms.RadioButton();
            this.rdoBottom = new System.Windows.Forms.RadioButton();
            this.rdoTop = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(25, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "Snip Screen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdoFloat
            // 
            this.rdoFloat.Location = new System.Drawing.Point(36, 34);
            this.rdoFloat.Name = "rdoFloat";
            this.rdoFloat.Size = new System.Drawing.Size(60, 16);
            this.rdoFloat.TabIndex = 9;
            this.rdoFloat.Text = "Float";
            this.rdoFloat.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoRight
            // 
            this.rdoRight.Location = new System.Drawing.Point(57, 12);
            this.rdoRight.Name = "rdoRight";
            this.rdoRight.Size = new System.Drawing.Size(60, 16);
            this.rdoRight.TabIndex = 8;
            this.rdoRight.Text = "Right";
            this.rdoRight.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoLeft
            // 
            this.rdoLeft.Location = new System.Drawing.Point(8, 12);
            this.rdoLeft.Name = "rdoLeft";
            this.rdoLeft.Size = new System.Drawing.Size(60, 16);
            this.rdoLeft.TabIndex = 7;
            this.rdoLeft.Text = "Left";
            this.rdoLeft.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoBottom
            // 
            this.rdoBottom.Location = new System.Drawing.Point(60, -10);
            this.rdoBottom.Name = "rdoBottom";
            this.rdoBottom.Size = new System.Drawing.Size(60, 16);
            this.rdoBottom.TabIndex = 6;
            this.rdoBottom.Text = "Bottom";
            this.rdoBottom.Visible = false;
            this.rdoBottom.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoTop
            // 
            this.rdoTop.Location = new System.Drawing.Point(-6, -10);
            this.rdoTop.Name = "rdoTop";
            this.rdoTop.Size = new System.Drawing.Size(60, 16);
            this.rdoTop.TabIndex = 5;
            this.rdoTop.Text = "Top";
            this.rdoTop.Visible = false;
            this.rdoTop.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;

            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(125, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rdoFloat);
            this.Controls.Add(this.rdoRight);
            this.Controls.Add(this.rdoLeft);
            this.Controls.Add(this.rdoBottom);
            this.Controls.Add(this.rdoTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Text = "SnipSnap";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            frmMain mainform = new frmMain();
            Application.Run(mainform);
            
            
		}
				
		private void frmMain_Load(object sender, System.EventArgs e)
		{
			this.Edge = AppBarEdges.Left;
            //gkh.HookedKeys.Add(Keys.LShiftKey);
            //gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
            //gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);
            Console.WriteLine("Added");
           
 

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var bmp = SnippingTool.Snip();
            if (bmp != null)
            {
                /*
                        switch (extension)
                        {
                            case ".bmp":
                                bitmap.Save(FilePath, ImageFormat.Bmp);
                                break;
                            case ".jpg":
                                bitmap.Save(FilePath, ImageFormat.Jpeg);
                                break;
                            case ".gif":
                                bitmap.Save(FilePath, ImageFormat.Gif);
                                break;
                            case ".tiff":
                                bitmap.Save(FilePath, ImageFormat.Tiff);
                                break;
                            case ".png":
                                bitmap.Save(FilePath, ImageFormat.Png);
                                break;
                            default:
                                bitmap.Save(FilePath, ImageFormat.Jpeg);
                                break;
                        }
                 */
                bmp.Save("d:\\file.jpg", ImageFormat.Jpeg);
                this.pictureBox1.Size = new System.Drawing.Size(bmp.Height, bmp.Width);
                this.pictureBox1.Image = bmp;
                //this.Size = new Size(bmp.Width+20, this.Size.Height);
                
            }
            this.Show();
        }


        /*void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine("Keypressed");
            this.Hide();
            var bmp = SnippingTool.Snip();
            if (bmp != null)
            {
                Console.WriteLine("Image got");
                bmp.Save("d:\\file.jpg", ImageFormat.Jpeg);
                this.pictureBox1.Image = bmp;
            }
            this.Show();
        }
        */
      
	}

}

