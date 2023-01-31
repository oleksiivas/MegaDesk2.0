using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Earl
{
    public class DeskQuote
    {
        public string FirstName { get { return custFirstName; }  }
        public string LastName { get { return custFirstName; } }
        public DateTime Date { get { return date; } }
        public int RushOrder { get { return rushOrder; } }
        public int Total { get { return getTotalPrice(); } }
        public int Area { get { return this.desk.Area; } }
        public int Drawers { get { return this.desk.Drawers; } }
        public Material Material { get { return this.desk.Material; } }


        private Desk desk;
        private int rushOrder;
        private string custFirstName;
        private string custLastName;
        private DateTime date;
        public DeskQuote(Desk desk, int rushOrder, string custFirstName, string custLastName) {
            this.desk = desk;
            this.rushOrder = rushOrder;
            this.custFirstName = custFirstName;
            this.custLastName = custLastName;
            this.date = DateTime.Now;
        }
        public int getBasePrice()
        {
            return 200;
        }

        public DateTime getDate()
        {
            return date;
        }
        public int getAreaPrice()
        {
            return desk.getArea();
        }

        public int getSurfacePrice()
        {
            switch(desk.getSurfaceMaterial())
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
            return 50 * desk.getDrawers();
        }

        public string getCustFirstName()
        {
            return custFirstName;
        }
        public string getCustLastName() { 
            return custLastName;
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
            if(rushOrder == 14)
            {
                return 0;
            }else if(rushOrder == 3)
            {
                int area = desk.getArea();
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
            }else if(rushOrder == 5)
            {
                int area = desk.getArea();
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
                int area = desk.getArea();
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
            return getAreaPrice() +getBasePrice()+ getRushOrderPrice() + getDrawerPrice() + getSurfacePrice();
        }
    }
}
