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


        // Team Member 1: Disna Joy Testing
        // Test Case 1: Check the product ID with the maximum value
        [TestCase(50000)]
        public void ProdIDMaximumValue_Test(int maxProdID)
        {
            // Arrange
            // int maxProdID = 50000;

            // Act
            _product.ProdID = maxProdID;

            // Assert
            Assert.That(_product.ProdID, Is.EqualTo(maxProdID));
        }


        // Test Case 2: Check the product ID with the minimum value
        [TestCase(5)]
        public void ProdIDMinimumValue_Test(int minProdID)
        {
            // Arrange
            // Act
            // Assert
        }


        // Test Case 3: Check the product ID out of range value
        [TestCase(4)]
        public void ProdIDOutOfRange_Test(int invalidProdID)
        {
            // Arrange
            // Act
            // Assert
        }


        // Test Case 4: Check the product name is not empty
        [TestCase("Test Product")]
        public void ProdNameNotEmpty_Test(string validProdName)
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


        // Test Case 6: Check the product name is for Special Characters
        [TestCase("Product#1")]
        public void ProdNameSpecialCharacters_Test(string invalidProdName)
        {
            // Arrange
            // Act
            // Assert
        }


        /********************************************************************************************************************/
        // Team Member 2: Shong Chan    
        // Test Case 7: Check the item price is out of range value
        [TestCase(5000.01)]
        public void ItemPriceOutOfRange_Test(decimal invalidItemPrice)
        {
            // Arrange
            //decimal validItemPrice = 5000.01;

            // Act & Assert
            try
            {
                _product.ItemPrice = invalidItemPrice;
                Assert.Fail("Expected ArgumentOutOfRangeException was not thrown.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.That(ex.Message, Does.Contain("Item Price must be between $5 and $5000"));
            }
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
            Assert.That(_product.ItemPrice, Is.EqualTo(maxItemPrice));
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
            Assert.That(_product.ItemPrice, Is.EqualTo(minItemPrice));
        }


        // Test Case 10: Check the stock amount is out of range value
        [TestCase(500001)]
        public void StockAmountOutOfRange_Test(int invalidStockAmount)
        {
            // Arrange
            //int validStockAmount = 1000;

            // Act & Assert
            try
            {
                _product.StockAmount = invalidStockAmount;
                Assert.Fail("Expected ArgumentOutOfRangeException was not thrown.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.That(ex.Message, Does.Contain("Stock Amount must be between 5 and 500000"));
            }
        }


        // Test Case 11: Check the stock amount is the maximum value
        [TestCase(500000)]
        public void StockAmountMaximumValue_Test(int validStockAmount)
        {
            // Arrange
            //int invalidStockAmount = 500000;

            // Act
            _product.StockAmount = validStockAmount;

            // Assert
            Assert.That(_product.StockAmount, Is.EqualTo(validStockAmount));
        }


        // Test Case 12: Check the stock amount is the minimum value
        [TestCase(5)]
        public void StockAmountMinimumValue_Test(int validStockAmount)
        {
            // Arrange
            //int invalidStockAmount = 5;

            // Act
            _product.StockAmount = validStockAmount;

            // Assert
            Assert.That(_product.StockAmount, Is.EqualTo(validStockAmount));
        }


        /*********************************************************************************************************************/
        // Team Member 3: Amaninder Dhillon
        // Test Case 13: Check the stock amount increasing by a valid amount 
        [Test]
        public void StockAmount_IncreasedBy20_StockAmountIncreasedBy20()
        {
            // Arrange
            int initialStock = 80;
            int amountToAdd = 20;
            int expectedStock = 100;

            _product.StockAmount = initialStock;

            // Act
            _product.IncreaseStock(amountToAdd);

            // Assert
            Assert.That(_product.StockAmount, Is.EqualTo(expectedStock));
        }


        // Test Case 14: Check the stock amount increasing beyond the maximum limit
        [Test]
        public void StockAmount_IncreasedAbove500000_ThrowsArgumentException_AndStockUnchanged()
        {
            // Arrange
            int initialStock = 450000;
            int amountToAdd = 60000;

            _product.StockAmount = initialStock;

            // Act
            try
            {
                _product.IncreaseStock(amountToAdd);
                Assert.Fail("Expected ArgumentException was not thrown.");
            }
            // Assert
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Does.Contain("Stock Amount must be between 5 and 500000"));
            }
        }


        // Test Case 15: Check the stock amount increasing by negative value
        [Test]
        public void StockAmount_IncreasedByNegative20_ThrowsArgumentException_AndStockUnchanged()
        {
            // Arrange
            int initialStock = 80;
            int amountToAdd = -20;

            _product.StockAmount = initialStock;

            // Act
            try
            {
                _product.IncreaseStock(amountToAdd);
                Assert.Fail("Expected ArgumentException was not thrown.");
            }
            // Assert
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Does.Contain("Stock Increase Amount must be greater than 0"));
            }
        }


        // Test Case 16: Check the stock amount decreasing by a valid amount 
        [Test]
        public void StockAmount_DecreasedBy20_StockAmountDecreasedBy20()
        {
            // Arrange
            int initialStock = 120;
            int amountToReduce = 20;
            int expectedStock = 100;

            _product.StockAmount = initialStock;

            // Act
            _product.DecreaseStock(amountToReduce);

            // Assert
            Assert.That(_product.StockAmount, Is.EqualTo(expectedStock));
        }


        // Test Case 17: Check the stock amount decreasing below the minimum limit
        [Test]
        public void StockAmount_DecreaseBelow5_ThrowsArgumentException_AndStockUnchanged()
        {
            // Arrange
            int initialStock = 10;
            int amountToReduce = 6;

            _product.StockAmount = initialStock;

            // Act
            try
            {
                _product.DecreaseStock(amountToReduce);
                Assert.Fail("Expected ArgumentException was not thrown.");
            }
            // Assert
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Does.Contain("Stock Amount must be between 5 and 500000"));
            }
        }


        // Test Case 18: Check the stock amount decreased by negative value
        [Test]
        public void StockAmount_DecreasedByNegative20_ThrowsArgumentException_AndStockUnchanged()
        {
            // Arrange
            int initialStock = 80;
            int amountToReduce = -20;

            _product.StockAmount = initialStock;

            // Act
            try
            {
                _product.DecreaseStock(amountToReduce);
                Assert.Fail("Expected ArgumentException was not thrown.");
            }
            // Assert
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Does.Contain("Stock Decrease Amount must be greater than 0"));
            }
        }
    }
}
