using System;
using System.Collections.Generic;
using System.Text;


namespace Q5__inheretence_
{
    class Line
    {
        private string color;
        private int thick;
        private Point start_point;
        private Point end_point;

        public static Boolean check(int x,int y,int thick)
        {
            if (x > 0 && y > 0 && thick >0)
                return true;
            else
                return false;
        }

        public Line(int Sx,int Sy,int Ex,int Ey ,int thick,string color)
        {
            start_point.setX(Sx);
            start_point.setX(Sy);
            end_point.setX(Ex);
            end_point.setY(Ey);
            this.thick = thick;
            this.color = color;
        }

        public float line_length()
        {
            return (float)Math.Sqrt((start_point.getX() - end_point.getX()) *(start_point.getX() - end_point.getX())+ (start_point.getY()-end_point.getY())* (start_point.getY() - end_point.getY()));
        }


    }
}
