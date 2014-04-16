using System;
using System.Drawing;
using System.Collections;
using System.Diagnostics;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
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
        private System.Windows.Forms.RadioButton rdoBottom;
        private System.Windows.Forms.RadioButton rdoTop;
        private Button button1;
        private Button button2;
        public PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button3;
        private CheckBox checkBox1;
        public string position;

       
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
            this.rdoTop = new System.Windows.Forms.RadioButton();
            this.rdoBottom = new System.Windows.Forms.RadioButton();
            this.rdoLeft = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(3, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "Snip Screen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdoFloat
            // 
            this.rdoFloat.Location = new System.Drawing.Point(37, 120);
            this.rdoFloat.Name = "rdoFloat";
            this.rdoFloat.Size = new System.Drawing.Size(51, 17);
            this.rdoFloat.TabIndex = 9;
            this.rdoFloat.Text = "Float";
            this.rdoFloat.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoRight
            // 
            this.rdoRight.Location = new System.Drawing.Point(9, 96);
            this.rdoRight.Name = "rdoRight";
            this.rdoRight.Size = new System.Drawing.Size(52, 26);
            this.rdoRight.TabIndex = 8;
            this.rdoRight.Text = "Right";
            this.rdoRight.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoTop
            // 
            this.rdoTop.Location = new System.Drawing.Point(65, 76);
            this.rdoTop.Name = "rdoTop";
            this.rdoTop.Size = new System.Drawing.Size(50, 22);
            this.rdoTop.TabIndex = 7;
            this.rdoTop.Text = "Top";
            this.rdoTop.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoBottom
            // 
            this.rdoBottom.Location = new System.Drawing.Point(64, 98);
            this.rdoBottom.Name = "rdoBottom";
            this.rdoBottom.Size = new System.Drawing.Size(61, 22);
            this.rdoBottom.TabIndex = 11;
            this.rdoBottom.Text = "Bottom";
            this.rdoBottom.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoLeft
            // 
            this.rdoLeft.Location = new System.Drawing.Point(9, 76);
            this.rdoLeft.Name = "rdoLeft";
            this.rdoLeft.Size = new System.Drawing.Size(50, 22);
            this.rdoLeft.TabIndex = 7;
            this.rdoLeft.Text = "Left";
            this.rdoLeft.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(79, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 26);
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
            this.checkBox1.Location = new System.Drawing.Point(10, 58);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Snips go to Dock";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 5);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(10, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(60, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 24);
            this.button3.TabIndex = 21;
            this.button3.Text = "More";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(119, 459);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdoFloat);
            this.Controls.Add(this.rdoRight);
            this.Controls.Add(this.rdoTop);
            this.Controls.Add(this.rdoBottom);
            this.Controls.Add(this.rdoLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Text = "SnipDock";
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
            position = Properties.Settings.Default.position;
            //MessageBox.Show(position);
            switch (position)
            {
                case "Bottom":
                    this.Edge = AppBarEdges.Bottom;
                    this.rdoBottom.Checked = true;
                    move_items_top();

                    position = "Bottom";
                    
                    resize_window();
                    // MessageBox.Show(position);
                    break;

                case "Top":
                    this.Edge = AppBarEdges.Top;
                    this.rdoTop.Checked = true;
                    //this.Size = new System.Drawing.Size(141, 85);
                    move_items_top();
                    position = "Top";
                    resize_window();
                    // MessageBox.Show(position);
                    break;

                case "Left":
                    this.Edge = AppBarEdges.Left;
                    this.rdoLeft.Checked = true;
                    position = "Left";
                    move_items_side();
                    resize_window();
                    // MessageBox.Show(position);
                    break;

                case "Right":
                    this.Edge = AppBarEdges.Right;
                    this.rdoBottom.Checked = true;
                    move_items_side();

                    position = "Right";
                    resize_window();
                    // MessageBox.Show(position);
                    break;

                case "Float":
                    this.Edge = AppBarEdges.Float;
                    this.BringToFront();
                    move_items_side();
                    position = "Float";
                    resize_window();
                    this.TopMost = true;
                    // MessageBox.Show(position);
                    break;
            }
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
                        move_items_top();
                        position = "Bottom";

                        resize_window();
                       // MessageBox.Show(position);
                        break;

                    case "Top":
                        this.Edge = AppBarEdges.Top;
                        
                        //this.Size = new System.Drawing.Size(141, 85);
                        move_items_top();
                        position = "Top";
                        resize_window();
                       // MessageBox.Show(position);
                        break;

                    case "Left":
                        this.Edge = AppBarEdges.Left;
                        position = "Left";
                        move_items_side();
                        resize_window();
                       // MessageBox.Show(position);
                        break;

                    case "Right":
                        this.Edge = AppBarEdges.Right;
                        move_items_side();
                   
                        position = "Right";
                        resize_window();
                       // MessageBox.Show(position);
                        break;

                    case "Float":
                        this.Edge = AppBarEdges.Float;
                        this.BringToFront();
                        move_items_side();
                        position = "Float";
                        resize_window();
                        this.TopMost = true;
                       // MessageBox.Show(position);
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
                string path;
                if(Properties.Settings.Default.savepath=="")
                {
                    string pathPictures = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                    path = Path.Combine(pathPictures, "SnipDock");
                    Directory.CreateDirectory(path);
                }

                else 
                { 
                    path = Properties.Settings.Default.savepath;
                }
                bmp.Save(Path.Combine(path, DateTime.Now.ToString("yyyyMMddTHHmmss") + ".png"), ImageFormat.Png);


                if (docksnips)
                {

                    this.pictureBox1.Image = bmp;
                    this.pictureBox1.Size = new System.Drawing.Size(bmp.Width + 10, bmp.Height + 10);
                    this.pictureBox1.Image = bmp;
                    this.Size = new Size(bmp.Width, this.Height);

                    if (bmp.Width > 320)
                    {

                        move_items_top();
                    }

                }

            }
            snippingOn = false;
            this.Show();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!snippingOn) addImage();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clearsnip();
        }

        private void move_items_side()
        {
            this.button1.Location = new System.Drawing.Point(3, 140);
            this.rdoFloat.Location = new System.Drawing.Point(9, 117);
            this.rdoRight.Location = new System.Drawing.Point(9, 95);
            this.rdoTop.Location = new System.Drawing.Point(65, 76);
            this.rdoBottom.Location = new System.Drawing.Point(64, 97);
            this.rdoLeft.Location = new System.Drawing.Point(9, 76);
            this.button2.Location = new System.Drawing.Point(76, 140);
            this.checkBox1.Location = new System.Drawing.Point(10, 57);
           // this.label1.Location = new System.Drawing.Point(7, 348);
            this.pictureBox1.Location = new System.Drawing.Point(8, 200);
            this.pictureBox2.Location = new System.Drawing.Point(10, 6);
            this.button3.Location = new System.Drawing.Point(62, 6);
            //this.label3.Location = new System.Drawing.Point(5, 700);
        }

        private void move_items_top()
        {
            this.button1.Location = new System.Drawing.Point(309, 6);
            this.button2.Location = new System.Drawing.Point(309, 38);
            this.rdoFloat.Location = new System.Drawing.Point(238, 22);
            this.rdoRight.Location = new System.Drawing.Point(121, 28);
            this.rdoTop.Location = new System.Drawing.Point(174, 7);
            this.rdoBottom.Location = new System.Drawing.Point(174, 31);
            this.rdoLeft.Location = new System.Drawing.Point(121, 6);

            this.checkBox1.Location = new System.Drawing.Point(10, 60);
            //this.label1.Location = new System.Drawing.Point(591, -263);
            this.pictureBox1.Location = new System.Drawing.Point(10, 80);
            this.pictureBox2.Location = new System.Drawing.Point(10, 6);
            this.button3.Location = new System.Drawing.Point(62, 6);
        }
                        //this.label3.Location = new System.Drawing.Point(411, 6);}

        private void move_items_top_half()
        {
            this.rdoFloat.Location = new System.Drawing.Point(238, 22);
            this.rdoRight.Location = new System.Drawing.Point(121, 28);
            this.rdoTop.Location = new System.Drawing.Point(174, 7);
            this.rdoBottom.Location = new System.Drawing.Point(174, 31);
            this.rdoLeft.Location = new System.Drawing.Point(121, 6);
            this.button1.Location = new System.Drawing.Point(6, 80);
            this.button2.Location = new System.Drawing.Point(85, 80);
        }
        /*
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
        */
        private void clearSnipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearsnip();
        }

        private void clearsnip()
        {

            this.pictureBox1.Image = null;
            this.pictureBox1.Size = new Size(10, 5);
            //this.label1.Text = "";
            //this.label1.Visible = false;

            if (position == "Top" || position == "Bottom")
            {
                //this.TopMost = true;
                this.Size = new System.Drawing.Size(141, 100); 
            }
            if (position == "Left" || position == "Right")
            {
                move_items_side();
                this.Size = new System.Drawing.Size(119, 40); 
            }
            if (position == "Float")
            {
                this.Size = new System.Drawing.Size(119, 50); 
            }
        }

        private void resize_window()
        {
            Console.WriteLine("resizing");
            if (position == "Top" || position == "Bottom")
            {
               // Console.WriteLine("topbottom");
               // MessageBox.Show("topbottom");
                this.Size = new Size(pictureBox1.Width, pictureBox1.Height);
            }
            if (position == "Left" || position == "Right")
            {
               // MessageBox.Show("leftright");
                this.Size = new Size(pictureBox1.Width, pictureBox1.Height);
                move_items_side();
            }
            if (position == "Float")
            {
                this.Size = new Size(pictureBox1.Width, pictureBox1.Height);
            }

            Properties.Settings.Default["position"] = position;

            Properties.Settings.Default.Save();
            //MessageBox.Show(Properties.Settings.Default.position);
        }

        protected override void OnMouseWheel(MouseEventArgs mea)
        {
            // Override OnMouseWheel event, for zooming in/out with the scroll wheel
            if (pictureBox1.Image != null)
            {
                // If the mouse wheel is moved forward (Zoom in)
                if (mea.Delta > 0)
                {
                    // Check if the pictureBox dimensions are in range (15 is the minimum and maximum zoom level)
                    if ((pictureBox1.Width < (15 * this.Width)) && (pictureBox1.Height < (15 * this.Height)))
                    {
                        // Change the size of the picturebox, multiply it by the ZOOMFACTOR
                        pictureBox1.Width = (int)(pictureBox1.Width * 1.25);
                        pictureBox1.Height = (int)(pictureBox1.Height * 1.25);
                    }
                }
                else
                {
                    // Check if the pictureBox dimensions are in range (15 is the minimum and maximum zoom level)
                    if ((pictureBox1.Width > (this.Width / 15)) && (pictureBox1.Height > (this.Height / 15)))
                    {
                        // Change the size of the picturebox, divide it by the ZOOMFACTOR
                        pictureBox1.Width = (int)(pictureBox1.Width / 1.25);
                        pictureBox1.Height = (int)(pictureBox1.Height / 1.25);

                        resize_window();
                       // this.Size = new System.Drawing.Size(141, 65); 
                       //this.Size = new Size(pictureBox1.Width, pictureBox1.Height);


                    }
                }
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            MoreBox AboutForm = new MoreBox();
            AboutForm.Show();
        }

      

  
        

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

