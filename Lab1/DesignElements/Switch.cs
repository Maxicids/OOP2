using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Lab1
{
    [ToolboxItem(true)]
    public class Switch : Control
    {
        private Rectangle rectangle;
        private int TogglePosX_ON;
        private int TogglePosX_OFF;
        private bool сhecked = false;
        public bool Checked
        {
            get => сhecked;
            set
            {
                сhecked = value;

                //SwitchToggle();

                //UpdateSize();
                //UpdateStructures();
            }
        }
        public Color BackColorOn { get; set; } = Color.Red;

        //public event OnCheckedChangedHandler CheckedChanged;
        //public delegate void OnCheckedChangedHandler(object sender);

        

        private StringFormat SF = new StringFormat();
        public Switch()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Cursor = Cursors.Hand;
            rectangle = new Rectangle(1, 1, Width - 3, Height - 4);
            Size = new Size(40, 15);
            Font = new Font("Verdana", 9F, FontStyle.Regular);
            BackColor = Color.White;

            TogglePosX_OFF = rectangle.X;
            TogglePosX_ON = rectangle.Width - rectangle.Height;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;
            graph.Clear(Parent.BackColor);
            
            Rectangle rectToggle = new Rectangle(rectangle.X, rectangle.Y, rectangle.Height - 1, Height - 4);

            GraphicsPath rectGP = RoundedRectangle(rectangle, rectangle.Height);

            Pen pen = new Pen(Color.DarkGray, 2);
            Pen penToggle = new Pen(Color.DarkGray, 3);

            if (Checked == true)
            {
                rectToggle.Location = new Point(TogglePosX_ON , rectangle.Y);
                graph.FillPath(new SolidBrush(BackColorOn), rectGP);
            }
            else
            {
                rectToggle.Location = new Point(TogglePosX_OFF, rectangle.Y);
                graph.FillPath(new SolidBrush(Color.DarkGray), rectGP);
            }
            graph.DrawPath(pen, rectGP);
            

            graph.DrawEllipse(penToggle, rectToggle);
            graph.FillEllipse(new SolidBrush(Color.White), rectToggle);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            SwitchToggle();
        }

        private void SwitchToggle()
        {
            Checked = !Checked;
            Invalidate();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            rectangle = new Rectangle(1, 1, Width - 3, Height - 4);

            TogglePosX_OFF = rectangle.X;
            TogglePosX_ON = rectangle.Width - rectangle.Height;
        }

        public static GraphicsPath RoundedRectangle(Rectangle rect, float RoundSize)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(rect.X, rect.Y, RoundSize, RoundSize, 180, 90);//лево верх
            gp.AddArc(rect.X + rect.Width - RoundSize, rect.Y, RoundSize, RoundSize, 270, 90);//право верх
            gp.AddArc(rect.X + rect.Width - RoundSize, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 0, 90);//право 
            gp.AddArc(rect.X, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 90, 90);//лево низ

            gp.CloseFigure();

            return gp;
        }
    }

}
