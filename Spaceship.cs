using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace csharp2020
{
    class Spaceship
    {
        public int x, y, width, height;//variables for the rectangle
        public Image spaceship;//variable for the planet's image

        public Rectangle spaceRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Spaceship()
        {
            x = 200;
            y = 360;
            width = 40;
            height = 40;
            spaceship = Properties.Resources.alien1;
            spaceRec = new Rectangle(x, y, width, height);
        }
        public void DrawSpaceship(Graphics g)
        {

            g.DrawImage(spaceship, spaceRec);
        }

        public void MoveSpaceship(string move)
        {
            spaceRec.Location = new Point(x, y);

            if (move == "right")
            {
                if (spaceRec.Location.X > 550) // is spaceship within 50 of right side
                {

                    x = 550;
                    spaceRec.Location = new Point(x, y);
                }
                else
                {
                    x += 5;
                    spaceRec.Location = new Point(x, y);
                }

            }
            if (move == "left")
                {
                    if (spaceRec.Location.X < 10) // is spaceship within 10 of left side
                    {

                        x = 10;
                        spaceRec.Location = new Point(x, y);
                    }
                    else
                    {
                        x -= 5;
                        spaceRec.Location = new Point(x, y);
                    }
                }
            if (move == "down")
            {
                if (spaceRec.Location.Y > 490) // is spaceship within 10 of left side
                {

                    y = 490;
                    spaceRec.Location = new Point(x, y);
                }
                else
                {
                    y += 5;
                    spaceRec.Location = new Point(x, y);
                }
            }
            if (move == "up")
            {
                if (spaceRec.Location.Y < 10) // is spaceship within 10 of left side
                {

                    y = 10;
                    spaceRec.Location = new Point(x, y);
                }
                else
                {
                    y -= 5;
                    spaceRec.Location = new Point(x, y);
                }
            }
            spaceRec.Location = new Point(x, y);
        }

    }

}
