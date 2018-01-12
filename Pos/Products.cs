using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos
{
    class Products
    {
        private int barcode;

        public int Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        private double unitPrice;

        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        private double costPrice;

        public double CostPrice
        {
            get { return costPrice; }
            set { costPrice = value; }
        }

        private int actualInven;

        public int ActualInven
        {
            get { return actualInven; }
            set { actualInven = value; }
        }
        private int presentInven;

        public int PresentInven
        {
            get { return presentInven; }
            set { presentInven = value; }
        }
        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }


    }
}
