using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pos
{
    class Sell
    {
        static private Sell sell = null;
        static private decimal cardmoeny = 0;
        static private decimal cashmoney = 0;
        static private decimal pointmoney = 0;
        static private string clientID =null;
        static private int ages = 0;
        static private decimal tot = 0;
        static private int sale = 0;
        static private decimal changemoney = 0;
        static private int savePoint = 0;
        static private string cardNumber = "0";
        static private int empId = 0;
        static private string phone = null;
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
        static public void Clear()
        {
            cardmoeny=0;
            cashmoney = 0;
            pointmoney = 0;
            clientID = null;
             ages = 0;
            tot = 0;
             sale = 0;
            changemoney = 0;
             savePoint = 0;
            cardNumber = "0";
            empId = 0;
            phone = null;
        }

        public decimal Cardmoeny { get => cardmoeny; set => cardmoeny = value; }
        public decimal Cashmoney { get => cashmoney; set => cashmoney = value; }
        public decimal Pointmoney { get => pointmoney; set => pointmoney = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public int Ages { get => ages; set => ages = value; }
        public decimal Tot { get => tot; set => tot = value; }
        public int Sale { get => sale; set => sale = value; }
        public decimal Changemoney { get => changemoney; set => changemoney = value; }
        public int SavePoint { get => savePoint; set => savePoint = value; }
        public string CardNumber { get => cardNumber; set => cardNumber = value; }
        public  int EmpId { get => empId; set => empId = value; }
        public  string Phone { get => phone; set => phone = value; }
    }
}
