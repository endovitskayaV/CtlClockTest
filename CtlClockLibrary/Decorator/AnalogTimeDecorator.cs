using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace WatchPatterns
{
    class AnologTimeDecorator : TimeDecorator
    {
        private Size bitmapSize;
        private Bitmap bitmap;

        public override void Draw(Size controlSize, Graphics graphicsTime)
        {
            SetBitmapSize(controlSize);
            if (bitmap==null)

            bitmap = 
                new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream
                                                          ("CtlClockLibrary.Decorator.clock.jpg"));
            //нарисовать циферблат размера bitmapSize:
            // graphicsTime.DrawImage(bitmap, 0, 0, bitmapSize.Width, bitmapSize.Height); 
            // bitmap = new Bitmap(bitmapSize.Width, bitmapSize.Height); // новый bitmap размера bitmapSize

            
            graphicsTime.DrawImage(bitmap, 0, 0, bitmapSize.Width, bitmapSize.Height);
            DrawArrows(graphicsTime);
        }

        private void SetBitmapSize(Size controlSize)
        {
            int maxLengthSide;
            if (controlSize.Height > controlSize.Width)
                maxLengthSide = controlSize.Height;
            else maxLengthSide = controlSize.Width;
            if (controlSize.Height.Equals(controlSize.Width)) maxLengthSide = controlSize.Height;//любое вообще, т к равны

            bitmapSize=new Size(maxLengthSide, maxLengthSide);
            //картинка будет максимального размера, равная размеру макс стороны
        }

        private void DrawArrows(Graphics graphics)
        {
            float clockCenterCoord = bitmapSize.Height / 2;
            double halfDialSize = bitmapSize.Width / 2;
            //sec
            double arrowLength = halfDialSize * 0.9;
            graphics.DrawLine(new Pen(Brushes.Black, 1),
                clockCenterCoord, clockCenterCoord, 
                X(SecRotationAngle(),arrowLength,clockCenterCoord), Y(SecRotationAngle(),arrowLength,clockCenterCoord));
            //min
            arrowLength = halfDialSize * 0.9 * 5 / 6;
            graphics.DrawLine(new Pen(Brushes.Black, 2), 
                clockCenterCoord, clockCenterCoord,
                X(MinRotationAngle(),arrowLength, clockCenterCoord), Y(MinRotationAngle(),arrowLength, clockCenterCoord));
            //hour
            double hour = ShortenHoursFormat();    
            arrowLength = halfDialSize * 0.9 * 0.5;

            int thickness;
            if (bitmapSize.Height < 150) thickness = 2;
            else thickness = 3;

            graphics.DrawLine(new Pen(Brushes.Black, thickness), 
                clockCenterCoord, clockCenterCoord, 
                X(HourRotationAngle(hour), arrowLength, clockCenterCoord), Y(HourRotationAngle(hour), arrowLength, clockCenterCoord));
        }

        private double SecRotationAngle()
        {
            return this.Time.Seconds * MathUtilsLib.MathUtils.GradToRadian(6); // 6 градусов поворота за 1 сек
        }

        private double MinRotationAngle()
        {
            return (this.Time.Minutes + this.Time.Seconds / 60.0) * MathUtilsLib.MathUtils.GradToRadian(6);
        }

        private double HourRotationAngle(double hour)
        {
            //30 градусов = 6 градусов* 5 делений в часе
            return (hour + this.Time.Minutes / 60.0) * MathUtilsLib.MathUtils.GradToRadian(30); 
        }

        private double ShortenHoursFormat()
        {
            double h = (this.Time.Hours);
            if (h > 12) h -= 12; //к 12 часовому формау времени
            return h;
        }

        private float X(double rotationAngle, double arrowLength, float clockCenterCoord)
        {
            return (float)(arrowLength * Math.Sin(rotationAngle) + clockCenterCoord);
        }

        private float Y(double rotationAngle, double arrowLength, float clockCenterCoord)
        {
            return (float)(arrowLength * Math.Cos(rotationAngle) * (-1) + clockCenterCoord);
        }
    }
}
