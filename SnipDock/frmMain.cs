using System;
using System.Drawing;
using System.Collections;
using System.Diagnostics;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using Utilities;
using System.Threading;
using System.IO;

namespace SnipDock
{
	public class frmMain : ShellLib.ApplicationDesktopToolbar
    {
        #region Code for Design
        /// Required designer variable.
		private System.Windows.Forms.RadioButton rdoFloat;
		private System.Windows.Forms.RadioButton rdoRight;
        private System.Windows.Forms.RadioButton rdoLeft;
        private Button button1;
        private Button button2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CheckBox checkBox1;
        //private System.ComponentModel.Container components = null;

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
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(6, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "Snip Screen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdoFloat
            // 
            this.rdoFloat.Location = new System.Drawing.Point(75, 63);
            this.rdoFloat.Name = "rdoFloat";
            this.rdoFloat.Size = new System.Drawing.Size(60, 16);
            this.rdoFloat.TabIndex = 9;
            this.rdoFloat.Text = "Float";
            this.rdoFloat.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoRight
            // 
            this.rdoRight.Location = new System.Drawing.Point(75, 40);
            this.rdoRight.Name = "rdoRight";
            this.rdoRight.Size = new System.Drawing.Size(60, 26);
            this.rdoRight.TabIndex = 8;
            this.rdoRight.Text = "Right";
            this.rdoRight.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoLeft
            // 
            this.rdoLeft.Location = new System.Drawing.Point(75, 23);
            this.rdoLeft.Name = "rdoLeft";
            this.rdoLeft.Size = new System.Drawing.Size(60, 22);
            this.rdoLeft.TabIndex = 7;
            this.rdoLeft.Text = "Left";
            this.rdoLeft.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 26);
            this.button2.TabIndex = 12;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(11, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Snips go to Dock";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(3, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(138, 362);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdoFloat);
            this.Controls.Add(this.rdoRight);
            this.Controls.Add(this.rdoLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Text = "SnipSnap";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #endregion Code for Design

        //to prevent multiple snips
        bool snippingOn = false;
        bool docksnips = true;
        /*
        //for keybindings
        bool ControlDown = false;
        bool ControlShiftDown = false;
        globalKeyboardHook gkh = new globalKeyboardHook();
        */
		public frmMain()
		{
            InitializeComponent();
            
           // gkh.hook();
		}

        /*
		/// Clean up any resources being used.
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{components.Dispose();}
			}
			//base.Dispose( disposing );
		}
        */

        private void frmMain_Load(object sender, System.EventArgs e)
        {
            this.Edge = AppBarEdges.Left;
            this.rdoLeft.Checked = true;
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
                        this.BringToFront();
                        this.TopMost = true;
						break;
				}
			}
		}

        private void addImage()
        {
            snippingOn = true;
            this.Hide();
            var bmp = SnippingTool.Snip();
            if (bmp != null)
            {
              
                string pathUser = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string pathPictures = Path.Combine(pathUser, "Pictures");
                string path = Path.Combine(pathPictures, "SnipDock");
                Directory.CreateDirectory(path);
                bmp.Save(Path.Combine(path,DateTime.Now.ToString("yyyyMMddTHHmmss")+".jpg"), ImageFormat.Jpeg);
                this.label1.Text = "Snip saved to /Pictures";
                this.label1.Visible = true;
                
                if (docksnips)
                {
                   
                    this.pictureBox1.Image = bmp;
                    this.pictureBox1.Size = new System.Drawing.Size(bmp.Width + 10, bmp.Height + 10);
                    this.pictureBox1.Image = bmp;
                    this.Size = new Size(bmp.Width, this.Height); 
                }

             }
            snippingOn = false; 
            this.Show();
           
        }
        /*
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg,
        System.Windows.Forms.Keys keyData)
        {
            if (tabControl1.SelectedTab == tabPageImageViewer)
            {
                Point AP = objImageViewer1.AutoScrollPosition;
                if (msg.WParam.ToInt32() == (int)Keys.Left) AP = new Point(-AP.X - oUserPrefs.horizontalOffset, -AP.Y);
                else if (msg.WParam.ToInt32() == (int)Keys.Right) AP = new Point(-AP.X + oUserPrefs.horizontalOffset, -AP.Y);
                else if (msg.WParam.ToInt32() == (int)Keys.Down) AP = new Point(-AP.X, -AP.Y + oUserPrefs.verticalOffset);
                else if (msg.WParam.ToInt32() == (int)Keys.Up) AP = new Point(-AP.X, -AP.Y - oUserPrefs.verticalOffset);
                else return base.ProcessCmdKey(ref msg, keyData);
                objImageViewer1.AutoScrollPosition = AP;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        */

        private void button1_Click(object sender, EventArgs e)
        {
            if (!snippingOn) addImage();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clearsnip();
            
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Edge = AppBarEdges.Left;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Edge = AppBarEdges.Right;
        }

        private void topToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Edge = AppBarEdges.Top;
        }

        private void downToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Edge = AppBarEdges.Bottom;
        }

        private void clearSnipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearsnip();
        }

        private void clearsnip()
        {
           
            /*this.objImageViewer1.AutoScrollMargin = new System.Drawing.Size(75, 23);
            this.objImageViewer1.Image = null;
            this.objImageViewer1.Size = new System.Drawing.Size(75, 23);
            this.objImageViewer1.Zoom = 1F;*/
            this.pictureBox1.Image = null;
            this.pictureBox1.Size = new Size(100, 50);
            this.label1.Text = "";
            this.label1.Visible = false;  
            this.Size = new System.Drawing.Size(141, this.Height);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                docksnips = true;
            }
            else
            {
                docksnips = false;
            }

        }
        /*
        private void button3_Click(object sender, EventArgs e)
        {
            
            this.objImageViewer1.Zoom -= 0.1F;
            if (this.objImageViewer1.Image != null)
            {
                int newwidth = this.objImageViewer1.Image.Width - (this.objImageViewer1.Image.Width / 10);
                int newheight = this.objImageViewer1.Image.Height - (this.objImageViewer1.Image.Height / 10);
                this.objImageViewer1.Size = new Size(newwidth, newheight);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.objImageViewer1.Zoom = 1F;
        }
        */
        
        
        

       
       
        


     
        #region tryingKeybinding
        /* gkh.HookedKeys.Add(Keys.LShiftKey);
           gkh.HookedKeys.Add(Keys.LControlKey);
           gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
           gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);
           Console.WriteLine("Added");
       }

       void gkh_KeyDown(object sender, KeyEventArgs e)
       {
            
           
           Console.WriteLine("keypressed");
           if ((e.KeyCode == System.Windows.Forms.Keys.LControlKey))
           {
               Console.WriteLine("control down");
               ControlDown = true;
           }
           else if ((ControlDown == true) && (e.KeyCode == System.Windows.Forms.Keys.LShiftKey))
           {
               Console.WriteLine("control shift down");
               ControlShiftDown = true;
               //toolStripStatusLabel1.Text = "Control-Z Pressed.";
           }

          // Thread.Sleep(1);
           e.Handled = true;
       }

       void gkh_KeyUp(object sender, KeyEventArgs e)
       {

           if (ControlShiftDown && !snippingOn)
           {
               Console.WriteLine("controlshift up, snipping");
               addImage();
               ControlDown = false;
               ControlShiftDown = false;
           }

           else
               Console.WriteLine("failed");
       }
           */
        #endregion tryingKeybinding
    }

}

