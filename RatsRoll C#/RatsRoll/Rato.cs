using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatsRoll
{
    class Rato
    {
        public int X;
        public int Y;

        public Rato()
        {
    
        }

        public Rato(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public void desenharRato(Graphics g)
        {
            g.DrawImage(Properties.Resources.Rato_branco, new Point(X, Y));
        }
    }
}
