using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q5__inheretence_
{
    public partial class calculator_display : Form
    {
        private Line p1 = new Line();
        private Circle c1 = new Circle();
        private Polygon poly1 = new Polygon();

        public calculator_display()
        {
            InitializeComponent();
        }

        

        private void accept_line_Click(object sender, EventArgs e)
        {
           
            if (sx.Value > 0 && sy.Value > 0 && ex.Value > 0 && ey.Value > 0 && thick.Value > 0)
            {
                panel1.Show();
                panel2.Show();
                panel3.Show();

                int Sx = Convert.ToInt32(sx.Value);
                int Sy = Convert.ToInt32(sy.Value);
                int Ex = Convert.ToInt32(ex.Value);
                int Ey = Convert.ToInt32(ey.Value);
                int Thick = Convert.ToInt32(thick.Value);

                p1.set_startX(Sx);
                p1.set_startY(Sy);
                p1.set_endX(Ex);
                p1.set_endY(Ey);
                p1.set_thick(Thick);
                p1.set_color(color_box.Text);


            }
            else
                MessageBox.Show(" ערכים שלילים או 0");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            line_length.Text = "Length :\n"+ p1.line_length();

        }

        private void move_Click(object sender, EventArgs e)
        {
            if (moveX.Value >= 0 && moveY.Value >= 0)
            {
                int mx = Convert.ToInt32(moveX.Value);
                int my = Convert.ToInt32(moveY.Value);

                p1.set_startX(mx + p1.get_startX());
                p1.set_startY(my + p1.get_startY());
                p1.set_endX(mx + p1.get_endX());
                p1.set_endY(my + p1.get_endY());
            }
            else
                MessageBox.Show("ערך שלילי");
        }

        private void display_Click(object sender, EventArgs e)
        {
            toString_display.Text = "Start (" + p1.get_startX() + "," + p1.get_startY() + ")\n End (" + p1.get_endX() + "," + p1.get_endY() + ")";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Show();
            panel5.Show();
            panel6.Show();

            if (centerX.Value > 0 && centerY.Value > 0 && thick_line.Value > 0 && raduis.Value > 0)
            {
                int x = Convert.ToInt32(centerX.Value);
                int y = Convert.ToInt32(centerY.Value);
                int thick = Convert.ToInt32(thick_line.Value);
                int Raduis = Convert.ToInt32(raduis.Value);

                c1.set_centerX(x);
                c1.set_centerY(y);
                c1.set_radius(Raduis);
                c1.set_thick(thick);
                c1.set_color(color.Text);

                scope_display.Text = "Result :\n" + c1.scope_calculator();
                area_display.Text = "Result :\n" + c1.area_calculator();

            }
            else
                MessageBox.Show("ערכים שליליים או 0");
        }

        private void move_center_Click(object sender, EventArgs e)
        {
            if (move_centerX.Value >= 0 && move_centerY.Value >= 0)
            {
                int mx = Convert.ToInt32(move_centerX.Value);
                int my = Convert.ToInt32(move_centerY.Value);

                c1.set_centerX(mx + c1.get_centerX());
                c1.set_centerY(my + c1.get_centerY());
            }
            else
                MessageBox.Show("ערכים שליליים");
        }

        private void check_point_Click(object sender, EventArgs e)
        {
            if (checkX.Value > 0 && checkY.Value > 0)
            {
                int cx = Convert.ToInt32(checkX.Value);
                int cy = Convert.ToInt32(checkY.Value);

                check_display.Text= ""+c1.check_point_on_line(cx, cy);
            }
            else
                MessageBox.Show("ערכים שליליים");
        }

        private void toString_Click(object sender, EventArgs e)
        {
            toString_dispaly.Text = "Center (" + c1.get_centerX() + "," + c1.get_centerY() + ")\nRadius : " + c1.get_radius();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void insert_point_Click(object sender, EventArgs e)
        {
            if (polygon_thick.Value > 0 && polygon_pointX.Value > 0 && polygon_pointY.Value > 0)
            {
                int px = Convert.ToInt32(polygon_pointX.Value);
                int py = Convert.ToInt32(polygon_pointY.Value);

                if(poly1.get_numOfPoints()==5)
                {
                    panel7.Show();
                    panel8.Show();
                    panel9.Show();
                    MessageBox.Show("מצולע הושלם ");
                }
                else
                {
                    poly1.set_polygonX(px);
                    poly1.set_polygonY(py);
                    poly1.set_numOfPoints(poly1.get_numOfPoints()+1);
                    points_amount_display.Text = "Point :" + poly1.get_numOfPoints();
                }

            }
            else
                MessageBox.Show("ערכים שליליים או 0");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            toString_polygon_dispaly.Text = ""+poly1.ToString_polygon();
        }
    }  
    
}
