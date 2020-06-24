using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp2020
{
    public partial class Form1 : Form
    {

        Graphics g; //declare a graphics object called g
        Planet[] planet = new Planet[7];
        Random yspeed = new Random();


        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                int x = 10 + (i * 75);
                planet[i] = new Planet(x);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class's DrawPlanet method to draw the image planet1 
            for (int i = 0; i < 7; i++)
            {
                int rndmspeed = yspeed.Next(5, 20);
                planet[i].y += rndmspeed;

                //call the Planet class's drawPlanet method to draw the images
                planet[i].DrawPlanet(g);
            }


        }

        private void TmrPlanet_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                planet[i].MovePlanet();
                if (planet[i].y >= PnlGame.Height)
                {
                    planet[i].y = 30;
                }

            }
            PnlGame.Invalidate();
        }
    }
}
