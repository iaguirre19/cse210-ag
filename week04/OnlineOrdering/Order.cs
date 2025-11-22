namespace OnlineOrdering
{
    public class Order
    {
        private Customer _customer;
        private List<Product> _products;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal GetOrderTotal()
        {
            decimal total = 0;
            foreach (var product in _products)
            {
                total += product.GetTotalPrice();
            }

            decimal shippingCost = 0;
            if (_customer.IsInUSA())
            {
                shippingCost = 5;
            }
            else
            {
                shippingCost = 35;
            }

            total += shippingCost;
            return total;
        }

        public void DisplayOrderDetails()
        {
            Console.WriteLine("Order Details:");
            _customer.DisplayCustomerInfo();
            Console.WriteLine("Products:");
            foreach (var product in _products)
            {
                product.DisplayProductInfo();
                Console.WriteLine();
            }
            Console.WriteLine($"Order Total: {GetOrderTotal():C}");
        }

        public string GetPackingLabel()
        {
            string packingLabel = "Packing Label:\n";
            foreach (var product in _products)
            {
                packingLabel += $"{product.GetName()} (ID: {product.GetProductId()})\n";
            }
            return packingLabel;
        }

        public string GetShippingLabel()
        {
            string shippingLabel = "Shipping Label:\n";
            shippingLabel += $"{_customer.GetName()}\n";
            shippingLabel += _customer.GetFullAddress();
            return shippingLabel;
        }
    }
}