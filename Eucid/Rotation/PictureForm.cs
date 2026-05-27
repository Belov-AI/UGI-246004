using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eucid;

namespace Rotation
{
    public partial class PictureForm : Form
    {
        Eucid.Point rotationCenter;
        Triangle originalTriangle;
        Triangle rotatedTriangle;
        Graphics g;
        double scale;

        public PictureForm(
            Eucid.Point rotationCenter, 
            Triangle originalTriangle, 
            Triangle rotatedTriangle, 
            double scale)
        {
            InitializeComponent();

            this.rotationCenter = rotationCenter;
            this.originalTriangle = originalTriangle;
            this.rotatedTriangle = rotatedTriangle;
            this.scale = scale;

            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        System.Drawing.Point ConvertToScreen(Eucid.Point point) =>
            new System.Drawing.Point(
                (int)Math.Round(point.X * scale),
                (int)Math.Round(ClientSize.Height - point.Y * scale));

        private void PictureForm_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            DrawPoint(rotationCenter, Color.Red, 5);
        }

        void DrawPoint(Eucid.Point p, Color color, int radius)
        {
            using (var brush = new SolidBrush(color))
            {
                var pixel = ConvertToScreen(p);
                var size = 2 * radius;
                g.FillEllipse(brush, pixel.X - radius, pixel.Y - radius, size, size);
                DrawTriangle(originalTriangle, Color.Blue, 3, DashStyle.Solid);
                DrawTriangle(rotatedTriangle, Color.Green, 3, DashStyle.Dash);
            }
        }

        void DrawTriangle(Triangle t, Color color, int penWidth, DashStyle dash)
        {
            using(var pen = new Pen(color, penWidth))
            {
                pen.DashStyle = dash;

                g.DrawLines(pen, new[]
                    {ConvertToScreen(t.A),
                    ConvertToScreen(t.B),
                    ConvertToScreen(t.C),
                    ConvertToScreen(t.A)}
                );
            }
        }
    }
}
