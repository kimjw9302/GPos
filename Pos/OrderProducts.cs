using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pos
{
    class OrderProducts
    {
        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        private int unitPrice;

        public int UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }
        private int costPrice;

        public int CostPrice
        {
            get { return costPrice; }
            set { costPrice = value; }
        }
        private string placeName;

        public string PlaceName
        {
            get { return placeName; }
            set { placeName = value; }
        }

    }
}
