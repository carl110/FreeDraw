using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeDraw
{
    public partial class Form1 : Form
    {
        int height;
        int penWidth;
        int mode;
        bool fillStyle;
        Graphics g;
        Pen p;
        SolidBrush penColour = new(Color.Red);

        bool isDrag = false;
        Rectangle theRectangle = new Rectangle(new Point(0, 0), new Size(0, 0));
        Point startPoint;


        private Point? StartLocation = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadSubProcedure()
        {
            penColour = new SolidBrush(Color.Red);
            penWidth = 2;
            mode = 0;
            fillStyle = false;
            Graphics g = picDraw.CreateGraphics();
            Pen p = new Pen(penColour, penWidth);
        }

        private void mnuYellow_Click(object sender, EventArgs e)
        {
            penColour = new SolidBrush(Color.Yellow);
        }
        private void mnuGreen_Click(object sender, EventArgs e)
        {
            penColour = new SolidBrush(Color.Green);
        }
        private void mnuBlue_Click(object sender, EventArgs e)
        {
            penColour = new SolidBrush(Color.Blue);
        }
        private void mnuRed_Click(object sender, EventArgs e)
        {
            penColour = new SolidBrush(Color.Red);
        }
        private void mnuSolid_Click(object sender, EventArgs e) => fillStyle = true;
        private void mnuTransparent_Click(object sender, EventArgs e) => fillStyle = false;
        private void mnuRectangle_Click(object sender, EventArgs e)
        {
            mode = 1;
            mnuStyle.Enabled = true;
        }
        private void mnuFreehandLine_Click(object sender, EventArgs e)
        {
            mode = 2;
            mnuStyle.Enabled = false;
        }
        private void mnuCircle_Click(object sender, EventArgs e)
        {
            mode = 3;
            mnuStyle.Enabled = true;
        }
        private void mnuEllipse_Click(object sender, EventArgs e)
        {
            mode = 4;
            mnuStyle.Enabled = true;
        }
        private void mnuClear_Click(object sender, EventArgs e) => picDraw.Invalidate();
        private void mnuExit_Click(object sender, EventArgs e) => Close();
        private void hsbWidth_Scroll(object sender, ScrollEventArgs e) => penWidth = (sender as ScrollBar).Value;
        private void hsbHeight_Scroll(object sender, ScrollEventArgs e) => height = (sender as ScrollBar).Value;

        private void hsbPenWidth_Scroll(object sender, ScrollEventArgs e) => penWidth = (sender as ScrollBar).Value;

        private void drawLine(MouseEventArgs e)
        {
            if (StartLocation != null)
            {
                Graphics g = picDraw.CreateGraphics();
                p = new Pen(penColour, penWidth);
                g.DrawLine(p, StartLocation.Value.X, StartLocation.Value.Y, e.Location.X, e.Location.Y);
                g.DrawRectangle(p, new Rectangle(StartLocation.Value.X, StartLocation.Value.Y, (StartLocation.Value.X - e.Location.X), (StartLocation.Value.Y - e.Location.Y)));
                StartLocation = e.Location;
            }
        }
        private void drawRect(int width, int height)
        {
            Graphics g = picDraw.CreateGraphics();
            Pen p = new Pen(penColour, penWidth);
            g.DrawRectangle(p, StartLocation.Value.X, StartLocation.Value.Y, width, height);
            
            if (fillStyle)
            {
                g.FillRectangle(penColour, StartLocation.Value.X, StartLocation.Value.Y, width, height);
            }
        }
        private void drawEllipse(int width, int height)
        {
            Graphics g = picDraw.CreateGraphics();
            Pen p = new Pen(penColour, penWidth);
            g.DrawEllipse(p, StartLocation.Value.X, StartLocation.Value.Y, width, height);
            if (fillStyle)
                g.FillEllipse(penColour, StartLocation.Value.X, StartLocation.Value.Y, width, height);

        }

        private void drawCircle(int width, int height)
        {
            Graphics g = picDraw.CreateGraphics();
            Pen p = new Pen(penColour, penWidth);
            g.DrawEllipse(p, StartLocation.Value.X, StartLocation.Value.Y, Math.Min(width, height), Math.Min(width, height));
            if (fillStyle)
                g.FillEllipse(penColour, StartLocation.Value.X, StartLocation.Value.Y, Math.Min(width, height), Math.Min(width, height));
        }
        private void outlineOfRectangle(object sender, MouseEventArgs e)
        {
            if (isDrag)
            {
                ControlPaint.DrawReversibleFrame(theRectangle,
                    this.BackColor, FrameStyle.Dashed);
                Point endPoint = ((Control)sender).PointToScreen(new Point(e.X, e.Y));

                int width = endPoint.X - startPoint.X;
                int height = endPoint.Y - startPoint.Y;
                theRectangle = new Rectangle(startPoint.X,
                    startPoint.Y, width, height);
 
                ControlPaint.DrawReversibleFrame(theRectangle,
                    this.BackColor, FrameStyle.Dashed);
            }
        }
        private void picDraw_MouseUp(object sender, MouseEventArgs e)
        {
            Point endPoint = ((Control)sender).PointToScreen(new Point(e.X, e.Y));

            int width = endPoint.X - startPoint.X;
            int height = endPoint.Y - startPoint.Y;
            switch (mode)
            {
                case 1:
                    drawRect(width, height);
                    break;
                case 3:
                    drawCircle(width, height);
                    break;
                case 4:
                    drawEllipse(width, height);
                    break;
            }
            isDrag = false;
            theRectangle = new Rectangle(0, 0, 0, 0);
            StartLocation = null;
        }

        private void picDraw_MouseMove(object sender, MouseEventArgs e)
        {
            switch (mode)
            {
                case 1:
                    outlineOfRectangle(sender, e);
                    break;
                case 2:
                    drawLine(e);
                    break;
                case 3:
                    outlineOfRectangle(sender, e);
                    break;
                case 4:
                    outlineOfRectangle(sender, e);
                    break;
            }
        }

        private void picDraw_MouseDown(object sender, MouseEventArgs e)
        {
            StartLocation = e.Location;
            if (e.Button == MouseButtons.Left)
            {
                isDrag = true;
            }
            Control control = (Control)sender;
            startPoint = control.PointToScreen(new Point(e.X, e.Y));
        }
    }
}
