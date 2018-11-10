namespace PickColor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.colorPictureBox = new System.Windows.Forms.PictureBox();
            this.hexRGBLabel = new System.Windows.Forms.Label();
            this.redValueLabel = new System.Windows.Forms.Label();
            this.greenValueLabel = new System.Windows.Forms.Label();
            this.blueValueLabel = new System.Windows.Forms.Label();
            this.redValueTextBox = new System.Windows.Forms.TextBox();
            this.greenValueTextBox = new System.Windows.Forms.TextBox();
            this.blueValueTextBox = new System.Windows.Forms.TextBox();
            this.advColorButton = new System.Windows.Forms.Button();
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.modeComboBox = new System.Windows.Forms.ComboBox();
            this.rgbMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).BeginInit();
            this.colorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // copyrightLabel
            // 
            resources.ApplyResources(this.copyrightLabel, "copyrightLabel");
            this.copyrightLabel.Name = "copyrightLabel";
            // 
            // colorPictureBox
            // 
            this.colorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorPictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            resources.ApplyResources(this.colorPictureBox, "colorPictureBox");
            this.colorPictureBox.Name = "colorPictureBox";
            this.colorPictureBox.TabStop = false;
            // 
            // hexRGBLabel
            // 
            resources.ApplyResources(this.hexRGBLabel, "hexRGBLabel");
            this.hexRGBLabel.Name = "hexRGBLabel";
            // 
            // redValueLabel
            // 
            resources.ApplyResources(this.redValueLabel, "redValueLabel");
            this.redValueLabel.Name = "redValueLabel";
            // 
            // greenValueLabel
            // 
            resources.ApplyResources(this.greenValueLabel, "greenValueLabel");
            this.greenValueLabel.Name = "greenValueLabel";
            // 
            // blueValueLabel
            // 
            resources.ApplyResources(this.blueValueLabel, "blueValueLabel");
            this.blueValueLabel.Name = "blueValueLabel";
            // 
            // redValueTextBox
            // 
            resources.ApplyResources(this.redValueTextBox, "redValueTextBox");
            this.redValueTextBox.Name = "redValueTextBox";
            this.redValueTextBox.ReadOnly = true;
            // 
            // greenValueTextBox
            // 
            resources.ApplyResources(this.greenValueTextBox, "greenValueTextBox");
            this.greenValueTextBox.Name = "greenValueTextBox";
            this.greenValueTextBox.ReadOnly = true;
            // 
            // blueValueTextBox
            // 
            resources.ApplyResources(this.blueValueTextBox, "blueValueTextBox");
            this.blueValueTextBox.Name = "blueValueTextBox";
            this.blueValueTextBox.ReadOnly = true;
            // 
            // advColorButton
            // 
            resources.ApplyResources(this.advColorButton, "advColorButton");
            this.advColorButton.Name = "advColorButton";
            this.advColorButton.UseVisualStyleBackColor = true;
            this.advColorButton.Click += new System.EventHandler(this.advColorButton_Click);
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.modeComboBox);
            this.colorGroupBox.Controls.Add(this.rgbMaskedTextBox);
            this.colorGroupBox.Controls.Add(this.colorPictureBox);
            this.colorGroupBox.Controls.Add(this.blueValueTextBox);
            this.colorGroupBox.Controls.Add(this.advColorButton);
            this.colorGroupBox.Controls.Add(this.hexRGBLabel);
            this.colorGroupBox.Controls.Add(this.greenValueTextBox);
            this.colorGroupBox.Controls.Add(this.redValueLabel);
            this.colorGroupBox.Controls.Add(this.redValueTextBox);
            this.colorGroupBox.Controls.Add(this.greenValueLabel);
            this.colorGroupBox.Controls.Add(this.blueValueLabel);
            resources.ApplyResources(this.colorGroupBox, "colorGroupBox");
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.TabStop = false;
            // 
            // modeComboBox
            // 
            this.modeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.Items.AddRange(new object[] {
            resources.GetString("modeComboBox.Items"),
            resources.GetString("modeComboBox.Items1"),
            resources.GetString("modeComboBox.Items2")});
            resources.ApplyResources(this.modeComboBox, "modeComboBox");
            this.modeComboBox.Name = "modeComboBox";
            this.modeComboBox.SelectedIndexChanged += new System.EventHandler(this.modeComboBox_SelectedIndexChanged);
            // 
            // rgbMaskedTextBox
            // 
            resources.ApplyResources(this.rgbMaskedTextBox, "rgbMaskedTextBox");
            this.rgbMaskedTextBox.Name = "rgbMaskedTextBox";
            this.rgbMaskedTextBox.TextChanged += new System.EventHandler(this.rgbMaskedTextBox_TextChanged);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.colorGroupBox);
            this.Controls.Add(this.copyrightLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).EndInit();
            this.colorGroupBox.ResumeLayout(false);
            this.colorGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.PictureBox colorPictureBox;
        private System.Windows.Forms.Label hexRGBLabel;
        private System.Windows.Forms.Label redValueLabel;
        private System.Windows.Forms.Label greenValueLabel;
        private System.Windows.Forms.Label blueValueLabel;
        private System.Windows.Forms.TextBox redValueTextBox;
        private System.Windows.Forms.TextBox greenValueTextBox;
        private System.Windows.Forms.TextBox blueValueTextBox;
        private System.Windows.Forms.Button advColorButton;
        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.MaskedTextBox rgbMaskedTextBox;
        private System.Windows.Forms.ComboBox modeComboBox;
    }
}

