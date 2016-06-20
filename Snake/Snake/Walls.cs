using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls( int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            //Im creating the walls
            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, 'X');
            HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, 'X');
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, 'X');
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, 'X');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
            //upLine.Drow();
            //downLine.Drow();
            //leftLine.Drow();
            //rightLine.Drow();
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if(wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
