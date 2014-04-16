using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.IO;
using System.Windows.Forms;

namespace SnipDock
{
    partial class MoreBox : Form
    {
        public MoreBox()
        {
            InitializeComponent();

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //
                // The user selected a folder and pressed the OK button.
                // We print the number of files found.
                //
                Properties.Settings.Default["savepath"] = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();
                
            }
        }

      
    }
}
