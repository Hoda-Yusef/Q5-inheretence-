
namespace Q5__inheretence_
{
    partial class calculator_display
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Line = new System.Windows.Forms.TabPage();
            this.Circle = new System.Windows.Forms.TabPage();
            this.Polygon = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Line);
            this.tabControl1.Controls.Add(this.Circle);
            this.tabControl1.Controls.Add(this.Polygon);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(146, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1031, 652);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.Color.SkyBlue;
            this.Line.Location = new System.Drawing.Point(4, 37);
            this.Line.Name = "Line";
            this.Line.Padding = new System.Windows.Forms.Padding(3);
            this.Line.Size = new System.Drawing.Size(1040, 532);
            this.Line.TabIndex = 1;
            this.Line.Text = "Line";
            // 
            // Circle
            // 
            this.Circle.BackColor = System.Drawing.Color.SkyBlue;
            this.Circle.Location = new System.Drawing.Point(4, 37);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(1040, 532);
            this.Circle.TabIndex = 2;
            this.Circle.Text = "Circle";
            // 
            // Polygon
            // 
            this.Polygon.BackColor = System.Drawing.Color.SkyBlue;
            this.Polygon.Location = new System.Drawing.Point(4, 37);
            this.Polygon.Name = "Polygon";
            this.Polygon.Size = new System.Drawing.Size(1040, 532);
            this.Polygon.TabIndex = 3;
            this.Polygon.Text = "Polygon";
            // 
            // calculator_display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1306, 721);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "calculator_display";
            this.Text = "calculator_display";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Line;
        private System.Windows.Forms.TabPage Circle;
        private System.Windows.Forms.TabPage Polygon;
    }
}

