namespace ColorPointer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.colorPictureBox = new System.Windows.Forms.PictureBox();
            this.mainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainContextToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHexRGBColorValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDecRGBColorValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCurrentCursorPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.rgbHexLabel = new System.Windows.Forms.Label();
            this.pixelPointLabel = new System.Windows.Forms.Label();
            this.pixelPointHelpLabel = new System.Windows.Forms.Label();
            this.rgbHelpLabel = new System.Windows.Forms.Label();
            this.rgbDecLabel = new System.Windows.Forms.Label();
            this.knownColorLabel = new System.Windows.Forms.Label();
            this.colorToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).BeginInit();
            this.mainContextMenuStrip.SuspendLayout();
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
            this.colorPictureBox.ContextMenuStrip = this.mainContextMenuStrip;
            this.colorPictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            resources.ApplyResources(this.colorPictureBox, "colorPictureBox");
            this.colorPictureBox.Name = "colorPictureBox";
            this.colorPictureBox.TabStop = false;
            this.colorToolTip.SetToolTip(this.colorPictureBox, resources.GetString("colorPictureBox.ToolTip"));
            this.colorPictureBox.Click += new System.EventHandler(this.lockToolStripMenuItem_Click);
            // 
            // mainContextMenuStrip
            // 
            this.mainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockToolStripMenuItem,
            this.mainContextToolStripSeparator,
            this.refreshToolStripMenuItem,
            this.minimizedToolStripMenuItem});
            this.mainContextMenuStrip.Name = "speedContextMenuStrip";
            resources.ApplyResources(this.mainContextMenuStrip, "mainContextMenuStrip");
            this.mainContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.mainContextMenuStrip_Opening);
            // 
            // lockToolStripMenuItem
            // 
            this.lockToolStripMenuItem.Name = "lockToolStripMenuItem";
            resources.ApplyResources(this.lockToolStripMenuItem, "lockToolStripMenuItem");
            this.lockToolStripMenuItem.Click += new System.EventHandler(this.lockToolStripMenuItem_Click);
            // 
            // mainContextToolStripSeparator
            // 
            this.mainContextToolStripSeparator.Name = "mainContextToolStripSeparator";
            resources.ApplyResources(this.mainContextToolStripSeparator, "mainContextToolStripSeparator");
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fastToolStripMenuItem,
            this.slowToolStripMenuItem});
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            resources.ApplyResources(this.refreshToolStripMenuItem, "refreshToolStripMenuItem");
            // 
            // fastToolStripMenuItem
            // 
            this.fastToolStripMenuItem.Name = "fastToolStripMenuItem";
            resources.ApplyResources(this.fastToolStripMenuItem, "fastToolStripMenuItem");
            this.fastToolStripMenuItem.Click += new System.EventHandler(this.fastToolStripMenuItem_Click);
            // 
            // slowToolStripMenuItem
            // 
            this.slowToolStripMenuItem.Name = "slowToolStripMenuItem";
            resources.ApplyResources(this.slowToolStripMenuItem, "slowToolStripMenuItem");
            this.slowToolStripMenuItem.Click += new System.EventHandler(this.slowToolStripMenuItem_Click);
            // 
            // minimizedToolStripMenuItem
            // 
            this.minimizedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHexRGBColorValueToolStripMenuItem,
            this.showDecRGBColorValueToolStripMenuItem,
            this.showCurrentCursorPointToolStripMenuItem});
            this.minimizedToolStripMenuItem.Name = "minimizedToolStripMenuItem";
            resources.ApplyResources(this.minimizedToolStripMenuItem, "minimizedToolStripMenuItem");
            this.minimizedToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.minimizedToolStripMenuItem_DropDownItemClicked);
            this.minimizedToolStripMenuItem.DropDownOpening += new System.EventHandler(this.minimizedToolStripMenuItem_DropDownOpening);
            // 
            // showHexRGBColorValueToolStripMenuItem
            // 
            this.showHexRGBColorValueToolStripMenuItem.Name = "showHexRGBColorValueToolStripMenuItem";
            resources.ApplyResources(this.showHexRGBColorValueToolStripMenuItem, "showHexRGBColorValueToolStripMenuItem");
            this.showHexRGBColorValueToolStripMenuItem.Tag = "HexRGBValue";
            // 
            // showDecRGBColorValueToolStripMenuItem
            // 
            this.showDecRGBColorValueToolStripMenuItem.Name = "showDecRGBColorValueToolStripMenuItem";
            resources.ApplyResources(this.showDecRGBColorValueToolStripMenuItem, "showDecRGBColorValueToolStripMenuItem");
            this.showDecRGBColorValueToolStripMenuItem.Tag = "DecRGBValue";
            // 
            // showCurrentCursorPointToolStripMenuItem
            // 
            this.showCurrentCursorPointToolStripMenuItem.Name = "showCurrentCursorPointToolStripMenuItem";
            resources.ApplyResources(this.showCurrentCursorPointToolStripMenuItem, "showCurrentCursorPointToolStripMenuItem");
            this.showCurrentCursorPointToolStripMenuItem.Tag = "CurrentCursorPoint";
            // 
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // rgbHexLabel
            // 
            this.rgbHexLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.rgbHexLabel, "rgbHexLabel");
            this.rgbHexLabel.Name = "rgbHexLabel";
            // 
            // pixelPointLabel
            // 
            this.pixelPointLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.pixelPointLabel, "pixelPointLabel");
            this.pixelPointLabel.Name = "pixelPointLabel";
            // 
            // pixelPointHelpLabel
            // 
            resources.ApplyResources(this.pixelPointHelpLabel, "pixelPointHelpLabel");
            this.pixelPointHelpLabel.Name = "pixelPointHelpLabel";
            // 
            // rgbHelpLabel
            // 
            resources.ApplyResources(this.rgbHelpLabel, "rgbHelpLabel");
            this.rgbHelpLabel.Name = "rgbHelpLabel";
            // 
            // rgbDecLabel
            // 
            this.rgbDecLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.rgbDecLabel, "rgbDecLabel");
            this.rgbDecLabel.Name = "rgbDecLabel";
            // 
            // knownColorLabel
            // 
            this.knownColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.knownColorLabel, "knownColorLabel");
            this.knownColorLabel.Name = "knownColorLabel";
            // 
            // colorToolTip
            // 
            this.colorToolTip.IsBalloon = true;
            this.colorToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.colorToolTip.ToolTipTitle = "Tips";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pixelPointHelpLabel);
            this.Controls.Add(this.rgbHelpLabel);
            this.Controls.Add(this.pixelPointLabel);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.knownColorLabel);
            this.Controls.Add(this.rgbDecLabel);
            this.Controls.Add(this.rgbHexLabel);
            this.Controls.Add(this.colorPictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).EndInit();
            this.mainContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.PictureBox colorPictureBox;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.Label rgbHexLabel;
        private System.Windows.Forms.Label pixelPointLabel;
        private System.Windows.Forms.Label pixelPointHelpLabel;
        private System.Windows.Forms.Label rgbHelpLabel;
        private System.Windows.Forms.Label rgbDecLabel;
        private System.Windows.Forms.Label knownColorLabel;
        private System.Windows.Forms.ContextMenuStrip mainContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem lockToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator mainContextToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHexRGBColorValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDecRGBColorValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCurrentCursorPointToolStripMenuItem;
        private System.Windows.Forms.ToolTip colorToolTip;
    }
}

