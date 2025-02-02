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


    // Test Case 14: Check the stock amount increased by Zero
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


    // Test Case 15: Check the stock amount increased by negative value
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


    // Test Case 16: Check the stock amount decreased correctly
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


    // Test Case 17: Check the stock amount decreased by Zero
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
