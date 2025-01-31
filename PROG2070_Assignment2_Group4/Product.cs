using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PROG2070_Assignment2_Group4
{
    public class Product
    {
        private int _prodID;
        private string _prodName;
        private decimal _itemPrice;
        private int _stockAmount;

        public Product()
        {
            ProdID = 5; 
            ProdName = "Product Name"; 
            ItemPrice = 5m; 
            StockAmount = 5; 
        }


        public int ProdID
        {
            get { return _prodID; }
            set
            {
                if (value < 5 || value > 50000)
                {
                    throw new ArgumentOutOfRangeException("Product ID must be between 5 and 50000");
                }
                else
                {
                    _prodID = value;
                }
            }
        }

        public string ProdName
        {
            get { return _prodName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Product Name cannot be null or empty");
                }

                if (!Regex.IsMatch(value, @"^[a-zA-Z0-9\s]+$"))
                {
                    throw new ArgumentException("Product Name can only contain letters, numbers, and spaces.");

                }

                _prodName = value;
            }
        }

        public decimal ItemPrice
        {
            get { return _itemPrice; }
            set
            {
                if (value < 5m || value > 5000m)
                {
                    throw new ArgumentOutOfRangeException("Item Price must be between $5 and $5000");
                }
                else
                {
                    _itemPrice = value;
                }
            }
        }

        public int StockAmount
        {
            get { return _stockAmount; }
            set
            {
                if (value < 5 || value > 500000)
                {
                    throw new ArgumentOutOfRangeException("Stock Amount must be between 5 and 500000");
                }
                else
                {
                    _stockAmount = value;
                }
            }
        }


        public Product(int prodID, string prodName, decimal itemPrice, int stockAmount)
        {
            ProdID = prodID;
            ProdName = prodName;
            ItemPrice = itemPrice;
            StockAmount = stockAmount;
        }

        public void IncreaseStock(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Stock Increase Amount must be greater than 0");
            }

            if (amount == 0)
            {
                throw new ArgumentException("Stock Increase Amount cannot be 0");
            }

            StockAmount += amount;
        }


        public void DecreaseStock(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Stock Decrease Amount must be greater than 0");
            }
            
            if (amount == 0)
            {
                throw new ArgumentException("Stock Decrease Amount cannot be 0");
            }

            StockAmount -= amount;
        }
    }
}
