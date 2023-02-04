using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Earl
{
    public class DeskQuote
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Date { get; set; }
        public int RushOrder { get; set; }
        public Desk Desk { get; set; }

        public DeskQuote() 
        {
            Date = DateTime.Now;
        }

        public DeskQuote(string FirstName, string LastName, DateTime Date, int RushOrder, Desk Desk)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Date = Date;
            this.RushOrder = RushOrder;
            this.Desk = Desk;
        }
        public int getBasePrice()
        {
            return 200;
        }

        public int getSurfacePrice()
        {
            switch(Desk.SurfaceMaterial)
            {
                case Material.VENEER:

                    return 125;
                case Material.OAK:
                    return 200;
                case Material.ROSEWOOD:
                    return 300;
                case Material.LAMINATE:
                    return 100;
                case Material.PINE:
                    return 50;
                default:
                    return -1;
            }
        }
        public int getDrawerPrice()
        {
            return 50 * Desk.Drawers;
        }

        public int[,] getRushOrder()
        {
            const string FILENAME = @"..\..\..\rushOrderPrices.txt";
            int[,] rushOrderMatrix = new int[3, 3]; 
            try
            {
                string[] line = File.ReadAllLines(FILENAME);    
                for (int i = 0; i < 3; i++)
                {
                    for(int j = 0; j < 3; j++)
                    {
                        rushOrderMatrix[i, j] = Int32.Parse(line[i * 3 + j]);
                    }
                }
                
            }
            catch (IOException)
            {
                MessageBox.Show($"Error reading from file: {FILENAME}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rushOrderMatrix;
        }

        public int getRushOrderPrice()
        {
            if(RushOrder == 14)
            {
                return 0;
            }else if(RushOrder == 3)
            {
                int area = Desk.getArea();
                if(area < 1000)
                {
                    return getRushOrder()[0,0];
                }else if(area >=1000 && area < 2000)
                {
                    return getRushOrder()[0, 1];
                }
                else
                {
                    return getRushOrder()[0, 2];
                }
            }else if(RushOrder == 5)
            {
                int area = Desk.getArea();
                if (area < 1000)
                {
                    return getRushOrder()[1, 0];
                }
                else if (area >= 1000 && area < 2000)
                {
                    return getRushOrder()[1, 1];
                }
                else
                {
                    return getRushOrder()[1, 2];
                }
            }
            else
            {
                // rush order is 7
                int area = Desk.getArea();
                if (area < 1000)
                {
                    return getRushOrder()[2, 0];
                }
                else if (area >= 1000 && area < 2000)
                {
                    return getRushOrder()[2, 1];
                }
                else
                {
                    return getRushOrder()[2, 2];
                }
            }

        }

        public int getTotalPrice()
        {
            return Desk.getArea() +getBasePrice()+ getRushOrderPrice() + getDrawerPrice() + getSurfacePrice();
        }
    }
}
