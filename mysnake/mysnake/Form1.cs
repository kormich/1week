using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysnake
{
    public partial class Form1 : Form
    {
        private Label labelScore;
        private int width = 600;
        private int height = 600;
        private int sizesnake = 40;
        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            this.Width = width+60;
            this.Height = height+120;
            Map();
            labelScore = new Label();
            labelScore.Text = "Score: 0";
            labelScore.Location = new Point(this.Width/2-30, 40);
            this.Controls.Add(labelScore);
        }


        private void Map()
        {
            for (int i = 2; i <= width / sizesnake +1; i++)
            {
                PictureBox lines = new PictureBox();
                lines.BackColor = Color.Black;
                lines.Location = new Point(40, sizesnake * i);
                lines.Size = new Size(width-40, 1);
                this.Controls.Add(lines);
            }
            for (int i = 1; i <= height / sizesnake ; i++)
            {
                PictureBox lines = new PictureBox();
                lines.BackColor = Color.Black;
                lines.Location = new Point(sizesnake * i, 80);
                lines.Size = new Size(1, width-40);
                this.Controls.Add(lines);
            }
        }



    }   

        
    
}
