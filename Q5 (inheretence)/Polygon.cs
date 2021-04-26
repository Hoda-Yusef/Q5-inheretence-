using System;
using System.Collections.Generic;
using System.Text;

namespace Q5__inheretence_
{
    class Polygon
    {
        private string color;
        private int thick;
        private Point[] polygon_points=new Point[5];
        private int numOfPoints;

        public Polygon(string color,int thick)
        {
            this.color = color;
            this.thick = thick;
            
        }

        public Polygon()
        {
            
            this.numOfPoints = 0;
            this.polygon_points[numOfPoints] = new Point(0, 0);

        }

        public string ToString_polygon()
        {
            string points="Point 0 ("+this.polygon_points[0].getX()+","+ this.polygon_points[0].getY()+")";

            
            for(int i=1;i<5;i++)
            {
                points = points+"\nPoint "+i+" (" + this.polygon_points[i].getX() + "," + this.polygon_points[i].getY() + ")";
            }
            
            return points;
        }

        public void set_polygonX(int x)
        {
            this.polygon_points[numOfPoints] = new Point(0, 0);
            this.polygon_points[numOfPoints].setX(x);
        }

        public int get_polygonX(int num)
        {
            return this.polygon_points[num].getX();
        }

        public void set_polygonY(int y)
        {
            this.polygon_points[numOfPoints].setY(y);
        }

        public int get_polygonY(int num)
        {
            return this.polygon_points[num].getY();
        }

        public void set_numOfPoints(int num)
        {
            this.numOfPoints = num;
        }

        public int get_numOfPoints()
        {
            return this.numOfPoints;
        }








    }

    


    



}
