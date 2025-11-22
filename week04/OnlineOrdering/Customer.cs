namespace OnlineOrdering
{
    public class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        public bool IsInUSA()
        {
            return _address.IsUsaAddress();
        }

        public string GetName()
        {
            return _name;
        }

        public string GetFullAddress()
        {
            return _address.GetFullAddress();
        }

        public void DisplayCustomerInfo()
        {
            Console.WriteLine($"Customer Name: {_name}");
            Console.WriteLine("Customer Address:");
            Console.WriteLine(_address.GetFullAddress());
        }
    }
}