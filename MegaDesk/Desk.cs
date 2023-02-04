using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Earl
{
    public class Desk
    {
        public static readonly int maxWidth = 96;
        public static readonly int minWidth = 26;
        public static readonly int maxDepth = 48;
        public static readonly int minDepth = 12;
        public static readonly int maxDrawers = 7;
        public static readonly int minDrawers = 0;


        public int Width { get; set; }
        public int Depth { get; set; }
        public Material SurfaceMaterial{get; set;}
        public int Drawers { get; set; }

        public Desk() { }
        public Desk(int width, int depth, Material surfaceMaterial, int drawers)
        {
            this.Width = width;
            this.Depth = depth; 
            this.SurfaceMaterial = surfaceMaterial;
            this.Drawers = drawers;
        }

        public int getArea()
        {
            return Width*Depth;
        }
    }
}
