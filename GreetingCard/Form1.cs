using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreetingCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen BlackPen = new Pen(Color.Black);
            Pen SilverPen = new Pen(Color.Silver, 11);
            Pen GreyPen = new Pen(Color.LightGray, 5);
            SolidBrush SilverBrush = new SolidBrush(Color.WhiteSmoke);
            SolidBrush GreyBrush = new SolidBrush(Color.LightGray);
            SolidBrush RedBrush = new SolidBrush(Color.Red);

            g.Clear(Color.LightPink);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen redPen = new Pen(Color.Red, 10); //colour, thickness (pixels)
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush brownBrush = new SolidBrush(Color.Sienna);

            g.Clear(Color.Navy);

            g.FillEllipse(brownBrush, 0, 0, 100, 100);
        }
    }
}
