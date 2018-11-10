using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PickColor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            modeComboBox.SelectedIndex = 0;
        }

        private void advColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                dlg.Color = colorPictureBox.BackColor;
                dlg.FullOpen = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    rgbMaskedTextBox.Text = String.Format("#{0:X2}{1:X2}{2:X2}", dlg.Color.R, dlg.Color.G, dlg.Color.B);
                }
            }
        }

        private void rgbMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(rgbMaskedTextBox.Text, colorPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase))
            {
                String red = rgbMaskedTextBox.Text.Substring(1, 2);
                String green = rgbMaskedTextBox.Text.Substring(3, 2);
                String blue = rgbMaskedTextBox.Text.Substring(5, 2);

                Int32 r = Convert.ToInt32(red, 16);
                Int32 g = Convert.ToInt32(green, 16);
                Int32 b = Convert.ToInt32(blue, 16);

                redValueTextBox.Text = r.ToString();
                greenValueTextBox.Text = g.ToString();
                blueValueTextBox.Text = b.ToString();

                colorPictureBox.BackColor = Color.FromArgb(r, g, b);
            }
            else
            {
                redValueTextBox.Clear();
                greenValueTextBox.Clear();
                blueValueTextBox.Clear();
            }
        }

        private void modeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (modeComboBox.SelectedItem.ToString())
            {
                case "Normal":
                    {
                        if (Regex.IsMatch(rgbMaskedTextBox.Text, colorPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase))
                        {
                            if (normalColor != Color.Empty)
                            {
                                rgbMaskedTextBox.Text = String.Format("#{0:X2}{1:X2}{2:X2}", normalColor.R, normalColor.G, normalColor.B);

                                normalColor = Color.Empty;
                            }
                        }

                        break;
                    }
                case "Invert":
                    {
                        if (Regex.IsMatch(rgbMaskedTextBox.Text, colorPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase))
                        {
                            if (normalColor == Color.Empty)
                            {
                                normalColor = colorPictureBox.BackColor;
                            }

                            Int32 r = 255 - normalColor.R;
                            Int32 g = 255 - normalColor.G;
                            Int32 b = 255 - normalColor.B;

                            rgbMaskedTextBox.Text = String.Format("#{0:X2}{1:X2}{2:X2}", r, g, b);
                        }

                        break;
                    }
                case "Complement":
                    {
                        if (Regex.IsMatch(rgbMaskedTextBox.Text, colorPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase))
                        {
                            if (normalColor == Color.Empty)
                            {
                                normalColor = colorPictureBox.BackColor;
                            }

                            Int32 r = normalColor.R;
                            Int32 g = normalColor.G;
                            Int32 b = normalColor.B;

                            Int32 rgbSub = Math.Max(Math.Max(r, g), b) + Math.Min(Math.Min(r, g), b);

                            r = rgbSub - r;
                            g = rgbSub - g;
                            b = rgbSub - b;

                            rgbMaskedTextBox.Text = String.Format("#{0:X2}{1:X2}{2:X2}", r, g, b);
                        }

                        break;
                    }
                default:
                    break;
            }
        }

        private Color normalColor = Color.Empty;
        private readonly String colorPattern = "^#[0-9A-Fa-f]{6}";
    }
}