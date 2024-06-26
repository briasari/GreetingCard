﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace GreetingCard
{
    public partial class Form1 : Form
    {
        int x;
        int y;
        int z;
        int w;
        SoundPlayer bark = new SoundPlayer(Properties.Resources.dogBark);

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            //frenchbulldog card (made of squares and lots of arcs

            Graphics g = this.CreateGraphics();
            Pen BlackPen = new Pen(Color.Black, 5);
            Pen ThickBlackPen = new Pen(Color.Black, 14);
            Pen WhitePen = new Pen(Color.White, 11);
            Pen SalmonPen = new Pen(Color.Salmon, 5);
            Pen LightPinkPen = new Pen(Color.LightPink, 5);
            Pen ThickDarkPinkPen = new Pen(Color.Brown, 14);
            SolidBrush BlackBrush = new SolidBrush(Color.Black);
            SolidBrush WhiteBrush = new SolidBrush(Color.White);
            SolidBrush SalmonBrush = new SolidBrush(Color.Salmon);
            SolidBrush LightPinkBrush = new SolidBrush(Color.LightPink);


            BorderDraw();

            DogDraw();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            bark.Play();

            Graphics g = this.CreateGraphics();
            Pen BlackPen = new Pen(Color.Black, 5);
            Pen ThickBlackPen = new Pen(Color.Black, 14);
            Pen WhitePen = new Pen(Color.White, 11);
            Pen SalmonPen = new Pen(Color.Salmon, 5);
            Pen LightPinkPen = new Pen(Color.LightPink, 5);
            Pen ThickDarkPinkPen = new Pen(Color.Brown, 14);
            SolidBrush BlackBrush = new SolidBrush(Color.Black);
            SolidBrush WhiteBrush = new SolidBrush(Color.White);
            SolidBrush SalmonBrush = new SolidBrush(Color.Salmon);
            SolidBrush LightPinkBrush = new SolidBrush(Color.LightPink);
            Font drawFont = new Font("Arial", 20, FontStyle.Bold);

            BorderDraw();
            DogDraw();

            for (int i = 0; i < 9; i++)
            {
                g.DrawArc(WhitePen, 165, 182, 35, 35, 90 - x, 65);
                g.DrawArc(WhitePen, 98, 182, 35, 35, 385 + y, 65);
                g.DrawArc(BlackPen, 165, 182, 35, 35, 90 - x, 65);
                g.DrawArc(BlackPen, 98, 182, 35, 35, 385 + y, 65);

                x = x + 2;
                y = y + 2;

                Thread.Sleep(100);
            }

            bark.Play();

            for (int j = 0; j < 4; j++)
            {
                z = 6;
                w = 10;

                g.RotateTransform(5 + w);
                g.FillEllipse(LightPinkBrush, 155, -20 + z, 225, 125);
                g.DrawString("      Sorry for\nchewing on your\n        shoes...", drawFont, WhiteBrush, 157, -0 + z);
                g.ResetTransform();

                Thread.Sleep(300);
                BorderDraw();
                DogDraw();
                g.DrawArc(BlackPen, 165, 182, 35, 35, 72, 83);
                g.DrawArc(BlackPen, 98, 182, 35, 35, 385, 83);

                g.RotateTransform(5 + z);
                g.FillEllipse(LightPinkBrush, 155, -20 + w, 225, 125);
                g.DrawString("      Sorry for\nchewing on your\n        shoes...", drawFont, WhiteBrush, 157, -0 + w);
                g.ResetTransform();

                Thread.Sleep(300);
                BorderDraw();
                DogDraw();
                g.DrawArc(BlackPen, 165, 182, 35, 35, 72, 83);
                g.DrawArc(BlackPen, 98, 182, 35, 35, 385, 83);

                w = w - 3;
                z = z - 5;
            }
            bark.Play();
        }

        public void BorderDraw()
        {
            Graphics g = this.CreateGraphics();
            Pen BlackPen = new Pen(Color.Black, 5);
            Pen ThickBlackPen = new Pen(Color.Black, 14);
            Pen WhitePen = new Pen(Color.White, 11);
            Pen SalmonPen = new Pen(Color.Salmon, 5);
            Pen LightPinkPen = new Pen(Color.LightPink, 5);
            Pen ThickDarkPinkPen = new Pen(Color.Brown, 14);
            SolidBrush BlackBrush = new SolidBrush(Color.Black);
            SolidBrush WhiteBrush = new SolidBrush(Color.White);
            SolidBrush SalmonBrush = new SolidBrush(Color.Salmon);
            SolidBrush LightPinkBrush = new SolidBrush(Color.LightPink);

            g.Clear(Color.LightCoral);

            //border
            g.FillRectangle(WhiteBrush, 0, 0, 20, 500);
            g.FillRectangle(WhiteBrush, 365, 0, 20, 500);
            g.FillRectangle(WhiteBrush, 0, 0, 500, 20);
            g.FillRectangle(WhiteBrush, 0, 443, 500, 20);

            //border corners
            g.DrawArc(WhitePen, 15, 15, 50, 50, 169, 111);
            g.DrawArc(WhitePen, 319, 15, 50, 50, 259, 111); //top two
            g.DrawArc(WhitePen, 15, 397, 50, 50, 78, 111);
            g.DrawArc(WhitePen, 319, 397, 50, 50, 351, 111); //bottom two
        }
        public void DogDraw()
        {
            Graphics g = this.CreateGraphics();
            Pen BlackPen = new Pen(Color.Black, 5);
            Pen ThickBlackPen = new Pen(Color.Black, 14);
            Pen WhitePen = new Pen(Color.White, 11);
            Pen SalmonPen = new Pen(Color.Salmon, 5);
            Pen LightPinkPen = new Pen(Color.LightPink, 5);
            Pen ThickDarkPinkPen = new Pen(Color.Brown, 14);
            SolidBrush BlackBrush = new SolidBrush(Color.Black);
            SolidBrush WhiteBrush = new SolidBrush(Color.White);
            SolidBrush SalmonBrush = new SolidBrush(Color.Salmon);
            SolidBrush LightPinkBrush = new SolidBrush(Color.LightPink);

            //dog shape
            g.FillEllipse(WhiteBrush, 94, 188, 35, 90);
            g.FillEllipse(WhiteBrush, 170, 188, 35, 90);
            g.FillEllipse(WhiteBrush, 106, 193, 85, 35);
            g.FillEllipse(WhiteBrush, 97, 165, 35, 80);
            g.FillEllipse(SalmonBrush, 101, 169, 27, 65);
            g.FillEllipse(WhiteBrush, 167, 165, 35, 80);
            g.FillEllipse(SalmonBrush, 171, 169, 27, 65);
            g.FillEllipse(WhiteBrush, 93, 258, 35, 95);
            g.FillEllipse(WhiteBrush, 170, 259, 35, 95);
            g.FillEllipse(WhiteBrush, 114, 350, 75, 30);
            g.FillRectangle(WhiteBrush, 100, 200, 100, 170);

            //left leg
            g.TranslateTransform(100, 200);
            g.RotateTransform(335);
            g.FillEllipse(WhiteBrush, -79, 86, 35, 72);
            g.ResetTransform();

            g.TranslateTransform(100, 200);
            g.RotateTransform(60);
            g.FillEllipse(WhiteBrush, 140, 10, 25, 100);
            g.ResetTransform();

            //right leg
            g.TranslateTransform(100, 200);
            g.RotateTransform(23);
            g.FillEllipse(WhiteBrush, 130, 50, 35, 72);
            g.ResetTransform();

            g.TranslateTransform(100, 200);
            g.RotateTransform(300);
            g.FillEllipse(WhiteBrush, -110, 100, 25, 100);
            g.ResetTransform();

            //front legs
            g.FillEllipse(WhiteBrush, 110, 333, 25, 60);
            g.FillEllipse(WhiteBrush, 168, 333, 25, 60);

            //dog collar
            g.DrawArc(ThickDarkPinkPen, 50, 180, 200, 100, 40, 101);
            g.FillEllipse(LightPinkBrush, 138, 280, 20, 20);

            //dog face
            //left eyeball
            g.TranslateTransform(100, 200);
            g.RotateTransform(345);
            g.FillEllipse(BlackBrush, 13, 25, 22, 15);
            g.FillEllipse(WhiteBrush, 19, 32, 3, 3);
            g.FillEllipse(WhiteBrush, 26, 30, 3, 3);
            g.ResetTransform();

            //left blush
            g.TranslateTransform(100, 200);
            g.RotateTransform(345);
            g.FillEllipse(LightPinkBrush, -9, 34, 17, 10);
            g.ResetTransform();

            //right eyeball
            g.TranslateTransform(100, 200);
            g.RotateTransform(15);
            g.FillEllipse(BlackBrush, 60, 0, 22, 15);
            g.FillEllipse(WhiteBrush, 66, 4, 3, 3);
            g.FillEllipse(WhiteBrush, 72, 7, 3, 3);
            g.ResetTransform();

            //left blush
            g.TranslateTransform(100, 200);
            g.RotateTransform(15);
            g.FillEllipse(LightPinkBrush, 86, 10, 17, 10);
            g.ResetTransform();

            //mouth
            g.FillPie(BlackBrush, 138, 240, 20, 10, 120, 315);
            g.DrawArc(BlackPen, 111, 230, 35, 35, 0, 170);
            g.DrawArc(BlackPen, 148, 230, 35, 35, 372, 170);
        }
    }
}