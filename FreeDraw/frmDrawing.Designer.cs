
namespace FreeDraw
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDraw = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFreehandLine = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEllipse = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColours = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYellow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRed = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSolid = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransparent = new System.Windows.Forms.ToolStripMenuItem();
            this.picDraw = new System.Windows.Forms.PictureBox();
            this.hsbPenWidth = new System.Windows.Forms.HScrollBar();
            this.hsbWidth = new System.Windows.Forms.HScrollBar();
            this.hsbHeight = new System.Windows.Forms.HScrollBar();
            this.lblPenWidth = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDraw,
            this.mnuColours,
            this.mnuStyle});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDraw
            // 
            this.mnuDraw.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRectangle,
            this.mnuFreehandLine,
            this.mnuCircle,
            this.mnuEllipse,
            this.mnuClear,
            this.mnuExit});
            this.mnuDraw.Name = "mnuDraw";
            this.mnuDraw.Size = new System.Drawing.Size(69, 29);
            this.mnuDraw.Text = "Draw";
            // 
            // mnuRectangle
            // 
            this.mnuRectangle.Name = "mnuRectangle";
            this.mnuRectangle.Size = new System.Drawing.Size(223, 34);
            this.mnuRectangle.Text = "Rectangle";
            this.mnuRectangle.Click += new System.EventHandler(this.mnuRectangle_Click);
            // 
            // mnuFreehandLine
            // 
            this.mnuFreehandLine.Name = "mnuFreehandLine";
            this.mnuFreehandLine.Size = new System.Drawing.Size(223, 34);
            this.mnuFreehandLine.Text = "Freehand Line";
            this.mnuFreehandLine.Click += new System.EventHandler(this.mnuFreehandLine_Click);
            // 
            // mnuCircle
            // 
            this.mnuCircle.Name = "mnuCircle";
            this.mnuCircle.Size = new System.Drawing.Size(223, 34);
            this.mnuCircle.Text = "Circle";
            this.mnuCircle.Click += new System.EventHandler(this.mnuCircle_Click);
            // 
            // mnuEllipse
            // 
            this.mnuEllipse.Name = "mnuEllipse";
            this.mnuEllipse.Size = new System.Drawing.Size(223, 34);
            this.mnuEllipse.Text = "Ellipse";
            this.mnuEllipse.Click += new System.EventHandler(this.mnuEllipse_Click);
            // 
            // mnuClear
            // 
            this.mnuClear.Name = "mnuClear";
            this.mnuClear.Size = new System.Drawing.Size(223, 34);
            this.mnuClear.Text = "Clear";
            this.mnuClear.Click += new System.EventHandler(this.mnuClear_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(223, 34);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuColours
            // 
            this.mnuColours.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYellow,
            this.mnuGreen,
            this.mnuBlue,
            this.mnuRed});
            this.mnuColours.Name = "mnuColours";
            this.mnuColours.Size = new System.Drawing.Size(89, 29);
            this.mnuColours.Text = "Colours";
            // 
            // mnuYellow
            // 
            this.mnuYellow.Name = "mnuYellow";
            this.mnuYellow.Size = new System.Drawing.Size(163, 34);
            this.mnuYellow.Text = "Yellow";
            this.mnuYellow.Click += new System.EventHandler(this.mnuYellow_Click);
            // 
            // mnuGreen
            // 
            this.mnuGreen.Name = "mnuGreen";
            this.mnuGreen.Size = new System.Drawing.Size(163, 34);
            this.mnuGreen.Text = "Green";
            this.mnuGreen.Click += new System.EventHandler(this.mnuGreen_Click);
            // 
            // mnuBlue
            // 
            this.mnuBlue.Name = "mnuBlue";
            this.mnuBlue.Size = new System.Drawing.Size(163, 34);
            this.mnuBlue.Text = "Blue";
            this.mnuBlue.Click += new System.EventHandler(this.mnuBlue_Click);
            // 
            // mnuRed
            // 
            this.mnuRed.Name = "mnuRed";
            this.mnuRed.Size = new System.Drawing.Size(163, 34);
            this.mnuRed.Text = "Red";
            this.mnuRed.Click += new System.EventHandler(this.mnuRed_Click);
            // 
            // mnuStyle
            // 
            this.mnuStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSolid,
            this.mnuTransparent});
            this.mnuStyle.Name = "mnuStyle";
            this.mnuStyle.Size = new System.Drawing.Size(91, 29);
            this.mnuStyle.Text = "Fill Style";
            // 
            // mnuSolid
            // 
            this.mnuSolid.Name = "mnuSolid";
            this.mnuSolid.Size = new System.Drawing.Size(205, 34);
            this.mnuSolid.Text = "Solid";
            this.mnuSolid.Click += new System.EventHandler(this.mnuSolid_Click);
            // 
            // mnuTransparent
            // 
            this.mnuTransparent.Name = "mnuTransparent";
            this.mnuTransparent.Size = new System.Drawing.Size(205, 34);
            this.mnuTransparent.Text = "Transparent";
            this.mnuTransparent.Click += new System.EventHandler(this.mnuTransparent_Click);
            // 
            // picDraw
            // 
            this.picDraw.BackColor = System.Drawing.Color.White;
            this.picDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDraw.Location = new System.Drawing.Point(12, 36);
            this.picDraw.Name = "picDraw";
            this.picDraw.Size = new System.Drawing.Size(776, 343);
            this.picDraw.TabIndex = 2;
            this.picDraw.TabStop = false;
            this.picDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picDraw_MouseDown);
            this.picDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDraw_MouseMove);
            this.picDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picDraw_MouseUp);
            // 
            // hsbPenWidth
            // 
            this.hsbPenWidth.Location = new System.Drawing.Point(12, 394);
            this.hsbPenWidth.Maximum = 10;
            this.hsbPenWidth.Name = "hsbPenWidth";
            this.hsbPenWidth.Size = new System.Drawing.Size(234, 39);
            this.hsbPenWidth.TabIndex = 3;
            this.hsbPenWidth.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbPenWidth_Scroll);
            // 
            // hsbWidth
            // 
            this.hsbWidth.Location = new System.Drawing.Point(12, 446);
            this.hsbWidth.Name = "hsbWidth";
            this.hsbWidth.Size = new System.Drawing.Size(323, 39);
            this.hsbWidth.TabIndex = 4;
            this.hsbWidth.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbWidth_Scroll);
            // 
            // hsbHeight
            // 
            this.hsbHeight.Location = new System.Drawing.Point(12, 497);
            this.hsbHeight.Name = "hsbHeight";
            this.hsbHeight.Size = new System.Drawing.Size(323, 39);
            this.hsbHeight.TabIndex = 5;
            this.hsbHeight.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbHeight_Scroll);
            // 
            // lblPenWidth
            // 
            this.lblPenWidth.AutoSize = true;
            this.lblPenWidth.Location = new System.Drawing.Point(276, 400);
            this.lblPenWidth.Name = "lblPenWidth";
            this.lblPenWidth.Size = new System.Drawing.Size(93, 25);
            this.lblPenWidth.TabIndex = 6;
            this.lblPenWidth.Text = "Pen Width";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(357, 451);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(60, 25);
            this.lblWidth.TabIndex = 7;
            this.lblWidth.Text = "Width";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(357, 501);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(65, 25);
            this.lblHeight.TabIndex = 8;
            this.lblHeight.Text = "Height";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblPenWidth);
            this.Controls.Add(this.hsbHeight);
            this.Controls.Add(this.hsbWidth);
            this.Controls.Add(this.hsbPenWidth);
            this.Controls.Add(this.picDraw);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDraw;
        private System.Windows.Forms.ToolStripMenuItem mnuRectangle;
        private System.Windows.Forms.ToolStripMenuItem mnuFreehandLine;
        private System.Windows.Forms.ToolStripMenuItem mnuCircle;
        private System.Windows.Forms.ToolStripMenuItem mnuEllipse;
        private System.Windows.Forms.ToolStripMenuItem mnuClear;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuColours;
        private System.Windows.Forms.ToolStripMenuItem mnuYellow;
        private System.Windows.Forms.ToolStripMenuItem mnuGreen;
        private System.Windows.Forms.ToolStripMenuItem mnuBlue;
        private System.Windows.Forms.ToolStripMenuItem mnuRed;
        private System.Windows.Forms.ToolStripMenuItem mnuStyle;
        private System.Windows.Forms.ToolStripMenuItem mnuSolid;
        private System.Windows.Forms.ToolStripMenuItem mnuTransparent;
        private System.Windows.Forms.PictureBox picDraw;
        private System.Windows.Forms.HScrollBar hsbPenWidth;
        private System.Windows.Forms.HScrollBar hsbWidth;
        private System.Windows.Forms.HScrollBar hsbHeight;
        private System.Windows.Forms.Label lblPenWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
    }
}

