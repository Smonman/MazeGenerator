using System;
using System.Collections.Generic;
using System.Drawing;

namespace MazeGenerator1
{
    class Tile
    {
        Random r;
        public int x;
        public int y;
        public int xPos;
        public int yPos;
        int s;
        public bool visited;
        public bool[] walls;

        int cols;
        int rows;

        public Tile(int x, int y, int s, int cols, int rows, Random rand)
        {
            r = rand;
            this.x = x;
            this.y = y;
            this.s = s;
            xPos = this.x * this.s;
            yPos = this.y * this.s;
            visited = false;
            walls = new bool[] { true, true, true, true };
            this.cols = cols;
            this.rows = rows;
        }

        Tuple<int, int> GetIndex(int x, int y)
        {
            if (x < 0 || x > cols - 1 || y < 0 || y > rows - 1)
            {
                return null;
            }
            else
            {
                return new Tuple<int, int>(x, y);
            }
        }

        public Tile GetNextNeighbor(Tile[,] g)
        {
            List<Tile> neigbors = new List<Tile>();
            Tile top;
            Tile right;
            Tile bottom;
            Tile left;
            Tuple<int, int> coords;

            coords = GetIndex(x, y + 1);
            if (coords == null)
            {
                top = null;
            }
            else
            {
                top = g[coords.Item1, coords.Item2];
            }

            coords = GetIndex(x + 1, y);
            if (coords == null)
            {
                right = null;
            }
            else
            {
                right = g[coords.Item1, coords.Item2];
            }

            coords = GetIndex(x, y - 1);
            if (coords == null)
            {
                bottom = null;
            }
            else
            {
                bottom = g[coords.Item1, coords.Item2];
            }

            coords = GetIndex(x - 1, y);
            if (coords == null)
            {
                left = null;
            }
            else
            {
                left = g[coords.Item1, coords.Item2];
            }

            if (top != null && !top.visited)
            {
                neigbors.Add(top);
            }
            if (right != null && !right.visited)
            {
                neigbors.Add(right);
            }
            if (bottom != null && !bottom.visited)
            {
                neigbors.Add(bottom);
            }
            if (left != null && !left.visited)
            {
                neigbors.Add(left);
            }

            if (neigbors.Count > 0)
            {
                int n = r.Next(0, neigbors.Count);
                return neigbors[n];
            }
            else
            {
                return null;
            }
        }

        public int GetNeighborCount(Tile[,] g)
        {
            int count = 0;
            Tile top;
            Tile right;
            Tile bottom;
            Tile left;
            if (GetIndex(x, y + 1) == null)
            {
                top = null;
            }
            else
            {
                top = g[GetIndex(x, y + 1).Item1, GetIndex(x, y + 1).Item2];
            }
            if (GetIndex(x + 1, y) == null)
            {
                right = null;
            }
            else
            {
                right = g[GetIndex(x + 1, y).Item1, GetIndex(x + 1, y).Item2];
            }
            if (GetIndex(x, y - 1) == null)
            {
                bottom = null;
            }
            else
            {
                bottom = g[GetIndex(x, y - 1).Item1, GetIndex(x, y - 1).Item2];
            }
            if (GetIndex(x - 1, y) == null)
            {
                left = null;
            }
            else
            {
                left = g[GetIndex(x - 1, y).Item1, GetIndex(x - 1, y).Item2];
            }

            if (top != null && !top.visited)
            {
                count++;
            }
            if (right != null && !right.visited)
            {
                count++;
            }
            if (bottom != null && !bottom.visited)
            {
                count++;
            }
            if (left != null && !left.visited)
            {
                count++;
            }
            return count;
        }

        public void Show(ref Graphics g)
        {
            Pen p = new Pen(new SolidBrush(Color.Black));
            p.Width = 1;
            if (walls[0])
            {
                g.DrawLine(p, xPos, yPos, xPos + s, yPos);
            }
            if (walls[1])
            {
                g.DrawLine(p, xPos + s, yPos, xPos + s, yPos + s);
            }
            if (walls[2])
            {
                g.DrawLine(p, xPos + s, yPos + s, xPos, yPos + s);
            }
            if (walls[3])
            {
                g.DrawLine(p, xPos, yPos + s, xPos, yPos);
            }
        }
    }
}
