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
    }  
    
}
