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
        public int getRushOrder()
        {
            return rushOrder;
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
                    return 60;
                }else if(area >=1000 && area < 2000)
                {
                    return 70;
                }
                else
                {
                    return 80;
                }
            }else if(rushOrder == 5)
            {
                int area = desk.getArea();
                if (area < 1000)
                {
                    return 40;
                }
                else if (area >= 1000 && area < 2000)
                {
                    return 50;
                }
                else
                {
                    return 60;
                }
            }
            else
            {
                // rush order is 7
                int area = desk.getArea();
                if (area < 1000)
                {
                    return 30;
                }
                else if (area >= 1000 && area < 2000)
                {
                    return 35;
                }
                else
                {
                    return 40;
                }
            }

        }

        public int getTotalPrice()
        {
            return getAreaPrice() +getBasePrice()+ getRushOrderPrice() + getDrawerPrice() + getSurfacePrice();
        }
    }
}
