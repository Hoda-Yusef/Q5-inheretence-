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

        
        public static Boolean yyyyy(int x,int y,int thick)
        {
            if (x > 0 && y > 0 && thick >0)
                return true;
            else
                return false;
        }
        
        public Line(int Sx,int Sy,int Ex,int Ey ,int thick,string color)
        {
            this.start_point = new Point(Sx, Sy);
            this.end_point = new Point(Ex, Ey);
            this.thick = thick;
            this.color = color;
        }

        public Line()
        {
            this.start_point=new Point(0,0);
            this.end_point = new Point(0, 0);
            this.thick = 0;
            this.color = "black";
        }

        public float line_length()
        {
            return (float)Math.Sqrt((start_point.getX() - end_point.getX()) *(start_point.getX() - end_point.getX())+ (start_point.getY()-end_point.getY())* (start_point.getY() - end_point.getY()));
        }

        public void set_startX(int sx)
        {
            this.start_point.setX(sx);
        }

        public void set_startY(int sy)
        {
            this.start_point.setY(sy);
        }

        public void set_endX(int ex)
        {
            this.end_point.setX(ex);
        }

        public void set_endY(int ey)
        {
            this.end_point.setY(ey);
        }

        public int get_startX()
        {
            return this.start_point.getX();
        }

        public int get_startY()
        {
            return this.start_point.getY();
        }

        public int get_endX()
        {
            return this.end_point.getX();
        }

        public int get_endY()
        {
            return this.end_point.getY();
        }

        public void set_thick(int thick)
        {
            this.thick = thick;
        }

        public void set_color(string color)
        {
            this.color = color;
        }
    }
}
