using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pos
{
    class Sell
    {
        static private Sell sell = null;
        static private decimal cardmoeny;
        static private decimal cashmoney;
        static private decimal pointmoney;
        static private string clientID =null;
        static private int ages;
        static private decimal tot;
        static private int sale;
        static private decimal changemoney;
        private Sell()
        {

        }

        static public Sell Load()
        {
            if (sell == null)
            {
                sell = new Sell();
            }
            return sell;
        }

        public decimal Cardmoeny { get => cardmoeny; set => cardmoeny = value; }
        public decimal Cashmoney { get => cashmoney; set => cashmoney = value; }
        public decimal Pointmoney { get => pointmoney; set => pointmoney = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public int Ages { get => ages; set => ages = value; }
        public decimal Tot { get => tot; set => tot = value; }
        public int Sale { get => sale; set => sale = value; }
        public decimal Changemoney { get => changemoney; set => changemoney = value; }
    }
}
