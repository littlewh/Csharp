﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_1
{
    public partial class XButton : Button
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }

        enum model
        {
            hover,
            enter,
            press,
            enable
        }

        public Color HoverBackColor { get; set; }
        public Color EnterBackColor { get; set; }
        public Color PressBackColor { get; set; }
        public Color HoverForeColor { get; set; }
        public Color EnterForeColor { get; set; }
        public Color PressForeColor { get; set; }

        public int Radius { get; set; }

        model paintmodel = model.hover;
        public XButton()
        {
            InitializeComponent();
            //去黑边
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 5;
            FlatAppearance.BorderColor = Color.FromArgb(255, 255, 239);
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            //UseWaitCursor = true;
            SetDefaultColor();


        }
        public void SetDefaultColor()//初始值
        {
            HoverBackColor = Color.FromArgb(55, 199, 0);//静止颜色
            EnterBackColor = Color.FromArgb(77, 222, 0);//悬停颜色
            PressBackColor = Color.Green;//单击颜色
            HoverForeColor = Color.White;//静止字体颜色
            EnterForeColor = Color.White;//悬停字体颜色
            PressForeColor = Color.White;//单击字体颜色
            Radius = 10;

            Cursor = Cursors.Hand;//手势
            Font = new Font("黑体", 12);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var colorback = HoverBackColor;
            var colorfore = HoverForeColor;
            switch (paintmodel)
            {
                case model.hover:
                    colorback = HoverBackColor;
                    colorfore = HoverForeColor;
                    break;
                case model.enter:
                    colorback = EnterBackColor;
                    colorfore = EnterForeColor;
                    break;
                case model.press:
                    colorback = PressBackColor;
                    colorfore = PressForeColor;
                    break;
                case model.enable:
                    colorback = Color.LightGray;
                    break;
                default:
                    colorback = HoverBackColor;
                    colorfore = HoverForeColor;
                    break;
            }
            Draw(e.ClipRectangle, e.Graphics, false, colorback);
            DrawText(e.ClipRectangle, e.Graphics, colorfore);
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            UseWaitCursor = false;
            paintmodel = model.enter;
            base.OnMouseEnter(e);


        }
        protected override void OnMouseLeave(EventArgs e)
        {
            UseWaitCursor = false;
            paintmodel = model.hover;
            base.OnMouseLeave(e);

        }
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            UseWaitCursor = true;
            paintmodel = model.press;
            base.OnMouseDown(mevent);
        }
        protected override void OnEnabledChanged(EventArgs e)
        {
            paintmodel = Enabled ? model.hover : model.enable;
            Invalidate();//false turn true 强制刷新
            base.OnEnabledChanged(e);

        }
        void Draw(Rectangle rectangle, Graphics g, bool cusp, Color begin_color, Color? end_colorex = null)
        {
            Color end_color = end_colorex == null ? begin_color : (Color)end_colorex;
            int span = 2;
            //抗锯齿
            g.SmoothingMode = SmoothingMode.AntiAlias;
            //渐变填充
            LinearGradientBrush myLinearGradientBrush = new LinearGradientBrush(rectangle, begin_color, end_color, LinearGradientMode.Vertical);
            //画尖角
            if (cusp)
            {
                span = 10;
                PointF p1 = new PointF(rectangle.Width - 12, rectangle.Y + 10);
                PointF p2 = new PointF(rectangle.Width - 12, rectangle.Y + 30);
                PointF p3 = new PointF(rectangle.Width, rectangle.Y + 20);
                PointF[] ptsArray = { p1, p2, p3 };
                g.FillPolygon(myLinearGradientBrush, ptsArray);
            }
            //填充
            g.FillPath(myLinearGradientBrush, DrawRoundRect(rectangle.X, rectangle.Y, rectangle.Width - span, rectangle.Height - 1, Radius));

        }
        void DrawText(Rectangle rectangle, Graphics g, Color color)
        {
            SolidBrush sbr = new SolidBrush(color);
            var rect = new RectangleF();
            switch (TextAlign)
            {
                case ContentAlignment.MiddleCenter:
                    rect = getTextRec(rectangle, g);
                    break;
                default:
                    rect = getTextRec(rectangle, g);
                    break;
            }
            g.DrawString(Text, Font, sbr, rect);
        }
        RectangleF getTextRec(Rectangle rectangle, Graphics g)
        {
            var rect = new RectangleF();
            var size = g.MeasureString(Text, Font);
            if (size.Width > rectangle.Width || size.Height > rectangle.Height)
            {
                rect = rectangle;
            }
            else
            {
                rect.Size = size;
                rect.Location = new PointF(rectangle.X + (rectangle.Width - size.Width) / 2, rectangle.Y + (rectangle.Height - size.Height) / 2);
            }
            return rect;
        }
        GraphicsPath DrawRoundRect(int x, int y, int width, int height, int radius)
        {
            //四边圆角
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(x, y, radius, radius, 180, 90);
            gp.AddArc(width - radius, y, radius, radius, 270, 90);
            gp.AddArc(width - radius, height - radius, radius, radius, 0, 90);
            gp.AddArc(x, height - radius, radius, radius, 90, 90);
            gp.CloseAllFigures();
            return gp;
        }
    }
}