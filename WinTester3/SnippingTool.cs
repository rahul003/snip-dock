
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Drawing.Imaging;

namespace WinTester3 {
    public partial class SnippingTool : Form {
        public static Image Snip() {
            var rc = Screen.PrimaryScreen.Bounds;
            //MessageBox.Show(rc.ToString() );
            using (Bitmap bmp = new Bitmap(rc.Width, rc.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb)) {
                using (Graphics gr = Graphics.FromImage(bmp))
                    gr.CopyFromScreen(0, 0, 0, 0, bmp.Size);

                bmp.Save("d:\\file.jpg", ImageFormat.Jpeg);
                using (var snipper = new SnippingTool(bmp)) {
                    if (snipper.ShowDialog() == DialogResult.OK) {
                        return snipper.Image;
                    }
                }
                return null;
            }
        }

        public SnippingTool(Image screenShot) {
            InitializeComponent();
            this.BackgroundImage = screenShot;
            this.ShowInTaskbar = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Maximized;
            this.DoubleBuffered = true;
        }
        public Image Image { get; set; }

        private Rectangle rcSelect = new Rectangle();
        private Point pntStart;

        protected override void OnMouseDown(MouseEventArgs e) {
            // Start the snip on mouse down
            if (e.Button != MouseButtons.Left) return;
            pntStart = e.Location;
            rcSelect = new Rectangle(e.Location, new Size(0, 0));
            this.Invalidate();
        }
        protected override void OnMouseMove(MouseEventArgs e) {
            // Modify the selection on mouse move
            if (e.Button != MouseButtons.Left) return;
            int x1 = Math.Min(e.X, pntStart.X);
            int y1 = Math.Min(e.Y, pntStart.Y);
            int x2 = Math.Max(e.X, pntStart.X);
            int y2 = Math.Max(e.Y, pntStart.Y);
            rcSelect = new Rectangle(x1, y1, x2 - x1, y2 - y1);
            this.Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e) {
            // Complete the snip on mouse-up
            if (rcSelect.Width <= 0 || rcSelect.Height <= 0) return;
            Image = new Bitmap(rcSelect.Width, rcSelect.Height);
            using (Graphics gr = Graphics.FromImage(Image)) {
                gr.DrawImage(this.BackgroundImage, new Rectangle(0, 0, Image.Width, Image.Height),
                    rcSelect, GraphicsUnit.Pixel);
            }
            DialogResult = DialogResult.OK;
        }
        protected override void OnPaint(PaintEventArgs e) {
            // Draw the current selection
            using (Brush br = new SolidBrush(Color.FromArgb(120, Color.White))) {
                int x1 = rcSelect.X; int x2 = rcSelect.X + rcSelect.Width;
                int y1 = rcSelect.Y; int y2 = rcSelect.Y + rcSelect.Height;
                e.Graphics.FillRectangle(br, new Rectangle(0, 0, x1, this.Height));
                e.Graphics.FillRectangle(br, new Rectangle(x2, 0, this.Width - x2, this.Height));
                e.Graphics.FillRectangle(br, new Rectangle(x1, 0, x2 - x1, y1));
                e.Graphics.FillRectangle(br, new Rectangle(x1, y2, x2 - x1, this.Height - y2));
            }
            using (Pen pen = new Pen(Color.Blue, 3)) {
                e.Graphics.DrawRectangle(pen, rcSelect);
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            // Allow canceling the snip with the Escape key
            if (keyData == Keys.Escape) this.DialogResult = DialogResult.Cancel;
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}