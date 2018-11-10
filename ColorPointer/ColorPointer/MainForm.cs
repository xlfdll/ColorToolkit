using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ColorPointer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void lockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshTimer.Enabled = !refreshTimer.Enabled;

            if (!refreshTimer.Enabled)
            {
                this.Text = Application.ProductName + " (Locked)";

                // Use Clipboard class to access clipboard anywhere.
                Clipboard.SetText(rgbHexLabel.Text, TextDataFormat.Text);
            }
        }

        private void fastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshTimer.Interval = 1;
        }

        private void slowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshTimer.Interval = 100;
        }

        private void minimizedToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            String modeString = item.Tag.ToString();

            if (!String.IsNullOrEmpty(modeString))
            {
                miniMode = (minimizedMode)Enum.Parse(typeof(minimizedMode), modeString);
            }
        }

        private void minimizedToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            ToolStripDropDownItem item = sender as ToolStripMenuItem;

            if (item != null)
            {
                String modeString = miniMode.ToString();

                foreach (ToolStripMenuItem menuitem in item.DropDownItems)
                {
                    menuitem.Checked = menuitem.Tag.Equals(modeString);
                }
            }
        }

        private void mainContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            switch (refreshTimer.Interval)
            {
                case 1: fastToolStripMenuItem.Checked = true;
                    break;
                case 100: fastToolStripMenuItem.Checked = false;
                    break;
            }

            slowToolStripMenuItem.Checked = !fastToolStripMenuItem.Checked;

            lockToolStripMenuItem.Checked = !refreshTimer.Enabled;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.L)
            {
                lockToolStripMenuItem.PerformClick();
            }
        }

        // Use Win32 function, with P/Invoke
        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            // Use GetDC & ReleaseDC function. If hwnd Handle is NULL(IntPtr.Zero), GetDC retrieves the DC for the entire screen.
            IntPtr hdc = GetDC(IntPtr.Zero);
            Color pointColor = ColorTranslator.FromWin32(Convert.ToInt32(GetPixel(hdc, Control.MousePosition.X, Control.MousePosition.Y)));
            Int32 result = ReleaseDC(IntPtr.Zero, hdc);

            Debug.Assert(result == 1, "ReleaseDC called failure.", "ReleaseDC result value is " + result.ToString());

            setPixelData(Control.MousePosition, pointColor);
        }

        private void setPixelData(Point position, Color color)
        {
            colorPictureBox.BackColor = color;

            // Use String.Format() function.
            pixelPointLabel.Text = String.Format("{0} x {1}", position.X, position.Y);
            rgbHexLabel.Text = String.Format("#{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B);
            rgbDecLabel.Text = String.Format("{0}, {1}, {2}", color.R, color.G, color.B);
            knownColorLabel.Text = color.ToKnownColor().ToString() != "0" ? color.ToKnownColor().ToString() : "(Unknown)";

            if (this.WindowState == FormWindowState.Minimized)
            {
                switch (miniMode)
                {
                    case minimizedMode.CurrentCursorPoint:
                        {
                            this.Text = String.Format("{0} x {1}", position.X, position.Y);

                            break;
                        }
                    case minimizedMode.DecRGBValue:
                        {
                            this.Text = String.Format("{0}, {1}, {2}", color.R, color.G, color.B);

                            break;
                        }
                    case minimizedMode.HexRGBValue:
                        {
                            this.Text = String.Format("#{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B);

                            break;
                        }
                    default:
                        break;
                }
            }
            else
            {
                this.Text = Application.ProductName;
            }
        }

        // Return value type could be customized if needed.
        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        private static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("gdi32.dll")]
        private static extern UInt32 GetPixel(IntPtr hdc, Int32 x, Int32 y);

        // Minimized Display Mode Definition.
        private enum minimizedMode { CurrentCursorPoint, DecRGBValue, HexRGBValue };
        private minimizedMode miniMode = minimizedMode.HexRGBValue;
    }
}