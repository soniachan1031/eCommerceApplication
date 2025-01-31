using PROG2070_Assignment2_Group4;

namespace ProductUnitTests
{
    public class ProductTest
    {
        private Product _product { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _product = new Product();
        }


        // Team Member 1: Disna Joy
        // Test Case 1: Check the product ID within valid range
        [TestCase(25000)]
        public void ProdIDWithinValidRange_Test(int validProdID)
        {
            // Arrange
            //int validProdID = 25000;

            // Act
            _product.ProdID = validProdID;

            // Assert
            Assert.AreEqual(validProdID, _product.ProdID);
        }


        // Test Case 2: Check the product ID exceeds the maximum value
        [Test]
        public void ProdIDMaximumValue_Test()
        {
            // Arrange
            // Act
            // Assert
        }


        // Test Case 3: Check the product ID below the minimum value
        [Test]
        public void ProdIDMinimumValue_Test()
        {
            // Arrange
            // Act
            // Assert
        }


        // Test Case 4: Check the product name is not empty
        [Test]
        public void ProdNameNotEmpty_Test()
        {
            // Arrange
            // Act
            // Assert

        }


        // Test Case 5: Check the product name is null
        [Test]
        public void ProdNameIsNull_Test()
        {
            // Arrange
            // Act
            // Assert
        }


        // Test Case 6: Check the product name is for Specai Characters
        [Test] 
        public void ProdNameSpecialCharacters_Test()
        {
            // Arrange
            // Act
            // Assert
        }

        /********************************************************************************************************************/
        // Team Member 2: Shong Chan    
        // Test Case 7: Check the item price within valid range
        [TestCase(2500.25)]
        public void ItemPriceWithinValidRange_Test(decimal validItemPrice)
        {
            // Arrange
            //decimal validItemPrice = 2500.25;

            // Act
            _product.ItemPrice = validItemPrice;

            // Assert
            Assert.AreEqual(validItemPrice, _product.ItemPrice);
        }


        // Test Case 8: Check the item price with Maximum value
        [TestCase(5000.00)]
        public void ItemPriceMaximumValue_Test(decimal maxItemPrice)
        {
            // Arrange
            //decimal maxItemPrice = 5000.00;

            // Act
            _product.ItemPrice = maxItemPrice;

            // Assert
            Assert.AreEqual(maxItemPrice, _product.ItemPrice);
        }


        // Test Case 9: Check the item price with Minimum value
        [TestCase(5.00)]
        public void ItemPriceMinimumValue_Test(decimal minItemPrice)
        {
            // Arrange
            // decimal minItemPrice = 5.00;

            // Act
            _product.ItemPrice = minItemPrice;

            // Assert
            Assert.AreEqual(minItemPrice, _product.ItemPrice);
        }


        // Test Case 10: Check the stock amount within valid range
        [TestCase(1000)]
        public void StockAmountWithinValidRange_Test(int validStockAmount)
        {
            // Arrange
            //int validStockAmount = 1000;

            // Act
            _product.StockAmount = validStockAmount;

            // Assert
            Assert.AreEqual(validStockAmount, _product.StockAmount);
        }


        // Test Case 11: Check the stock amount exceeds the maximum value
        [TestCase(500001)]
        public void StockAmountMaximumValue_Test(int invalidStockAmount)
        {
            // Arrange
            //int invalidStockAmount = 500001;

            // Act
            _product.StockAmount = invalidStockAmount;

            // Assert
            Assert.AreEqual(invalidStockAmount, _product.StockAmount);
        }


        // Test Case 12: Check the stock amount below the minimum value
        [TestCase(4)]
        public void StockAmountMinimumValue_Test(int invalidStockAmount)
        {
            // Arrange
            //int invalidStockAmount = 4;

            // Act
            _product.StockAmount = invalidStockAmount;

            // Assert
            Assert.AreEqual(invalidStockAmount, _product.StockAmount);
        }


        /********************************************************************************************************************/
        // Team Member 3: Amaninder Dhillon
        // Test Case 13: Check the stock amount increased correctly
        [Test]
        public void IncreaseStockAmount_Test()
        {
            // Arrange
            // Act
            // Assert
        }


        // Test Case 14: Check the stock amount increased by Zero
        [TestCase(0)]

        public void IncreaseStockAmountZero_Test(int amount)
        {
            // Arrange
            int initialStockAmount = _product.StockAmount;

            // Act
            _product.IncreaseStock(amount);

            // Assert
            Assert.AreEqual(initialStockAmount, _product.StockAmount);
        }


        // Test Case 15: Check the stock amount increased by negative value
        [Test]
        public void IncreaseStockAmountNegativeValue_Test()
        {
            // Arrange
            // Act
            // Assert
        }


        // Test Case 16: Check the stock amount decreased correctly
        [Test]
        public void DecreaseStockAmount_Test()
        {
            // Arrange
            // Act
            // Assert
        }


        // Test Case 17: Check the stock amount decreased by Zero
        [Test]
        public void DecreaseStockAmountZero_Test()
        {
            // Arrange
            // Act
            // Assert
        }


        // Test Case 18: Check the stock amount decreased by negative value
        [Test]
        public void DecreaseStockAmountNegativeValue_Test()
        {
            // Arrange
            // Act
            // Assert
        }
    }
}