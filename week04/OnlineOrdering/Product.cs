namespace OnlineOrdering
{
    public class Product
    {
        private string _product;
        private decimal _priceUnit;
        private int _quantity;
        private string _productId;

        public Product(string productId, string product, decimal priceUnit, int quantity)
        {
            _productId = productId;
            _product = product;
            _priceUnit = priceUnit;
            _quantity = quantity;
        }

        public decimal GetTotalPrice()
        {
            return _priceUnit * _quantity;
        }

        public string GetName()
        {
            return _product;
        }

        public string GetProductId()
        {
            return _productId;
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product ID: {_productId}");
            Console.WriteLine($"Product Name: {_product}");
            Console.WriteLine($"Unit Price: {_priceUnit:C}");
            Console.WriteLine($"Quantity: {_quantity}");
            Console.WriteLine($"Total Price: {GetTotalPrice():C}");
        }
    }
}