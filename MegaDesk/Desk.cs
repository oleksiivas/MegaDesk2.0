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


        private int width;
        private int depth;
        private Material surfaceMaterial;
        private int drawers;
        public Desk(int width, int depth, Material surfaceMaterial, int drawers)
        {
            this.width = width;
            this.depth = depth; 
            this.surfaceMaterial = surfaceMaterial;
            this.drawers = drawers;

        }

        public int getArea()
        {
            return width*depth;
        }
        public Material getSurfaceMaterial()
        {
            return surfaceMaterial;
        }
        public int getDrawers()
        {
            return drawers;
        }
    }
}
